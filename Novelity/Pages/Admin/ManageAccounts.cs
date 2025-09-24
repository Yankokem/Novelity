using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using Novelity.Modals;
using Novelity.Cards;
using Microsoft.Data.SqlClient;

namespace Novelity.Pages.Admin
{
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();

            // Set default filter states
            SetDefaultFilters();

            this.Load += ManageAccounts_Load;
            SubscribeToFilterEvents();
        }

        private void SetDefaultFilters()
        {
            // Set default states
            adminBox.Checked = true;
            customerBox.Checked = true;
            basicBox.Checked = false;
            premiumBox.Checked = false;
            expiredBox.Checked = false;
            inactiveBox.Checked = false;
            activeBox.Checked = true;
            newestToOldestBox.Checked = true; // Default sort
            oldestToNewestBox.Checked = false;
        }

        private void SubscribeToFilterEvents()
        {
            // Role filters
            adminBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            customerBox.CheckedChanged += FilterCheckbox_CheckedChanged;

            // Plan filters
            basicBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            premiumBox.CheckedChanged += FilterCheckbox_CheckedChanged;

            // Status filters
            expiredBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            inactiveBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            activeBox.CheckedChanged += FilterCheckbox_CheckedChanged;

            // Sort filters
            newestToOldestBox.CheckedChanged += SortCheckbox_CheckedChanged;
            oldestToNewestBox.CheckedChanged += SortCheckbox_CheckedChanged;
        }

        private void FilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            DebounceFilter();
        }

        private void SortCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = (CheckBox)sender;
            if (clickedCheckbox.Checked)
            {
                if (clickedCheckbox == newestToOldestBox)
                    oldestToNewestBox.Checked = false;
                else if (clickedCheckbox == oldestToNewestBox)
                    newestToOldestBox.Checked = false;
            }

            DebounceFilter();
        }

        private System.Threading.Timer _filterTimer;
        private void DebounceFilter()
        {
            _filterTimer?.Dispose();
            _filterTimer = new System.Threading.Timer(_ =>
            {
                this.Invoke(new Action(() => LoadAccountCards()));
            }, null, 300, System.Threading.Timeout.Infinite);
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            LoadAccountCards();
        }

        private void LoadAccountCards()
        {
            try
            {
                accountsPanel.Controls.Clear();

                string baseQuery = @"
            SELECT 
                u.UserID,
                u.Username,
                u.Email,
                u.FirstName + ' ' + u.LastName as FullName,
                r.RoleName,
                ISNULL(mp.PlanName, 'No Plan') as PlanName,
                CONVERT(VARCHAR, u.MembershipStartDate, 107) as SubscriptionDate,
                CONVERT(VARCHAR, u.MembershipEndDate, 107) as RenewalDate,
                u.IsDeleted,
                u.IsActiveMembership,
                u.MembershipEndDate as RawEndDate
            FROM Users u
            INNER JOIN Roles r ON u.RoleID = r.RoleID
            LEFT JOIN MembershipPlans mp ON u.PlanID = mp.PlanID
            WHERE 1=1";

                string whereConditions = BuildWhereConditions();
                string orderBy = BuildOrderByClause();

                string finalQuery = baseQuery + whereConditions + orderBy;

                DataTable accountsData = DatabaseHelper.ExecuteQuery(finalQuery);

                foreach (DataRow row in accountsData.Rows)
                {
                    AccountCard card = new AccountCard();

                    card.UserID = Convert.ToInt32(row["UserID"]);
                    card.FullName = row["FullName"].ToString();
                    card.Username = row["Username"].ToString();
                    card.Email = row["Email"].ToString(); // Set email
                    card.Tier = row["PlanName"].ToString();
                    card.SubscriptionDate = row["SubscriptionDate"].ToString();
                    card.RenewalDate = row["RenewalDate"].ToString();
                    card.Role = row["RoleName"].ToString();

                    // Apply conditional display
                    card.SetConditionalDisplay(row["RoleName"].ToString(), row["PlanName"].ToString());

                    card.DisplayUserID();
                    card.Margin = new Padding(0, 0, 0, 10);

                    card.EditClicked += (s, args) => EditAccount(card.UserID);
                    card.DeleteClicked += (s, args) => DeleteAccount(card.UserID);

                    accountsPanel.Controls.Add(card);
                }

                UpdateResultsCount(accountsData.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message, "Error");
            }
        }

        private string BuildWhereConditions()
        {
            string conditions = "";

            // Role filters
            if (adminBox.Checked && !customerBox.Checked)
                conditions += " AND r.RoleName = 'Admin'";
            else if (!adminBox.Checked && customerBox.Checked)
                conditions += " AND r.RoleName = 'Customer'";
            else if (adminBox.Checked && customerBox.Checked)
                conditions += " AND (r.RoleName = 'Admin' OR r.RoleName = 'Customer')";
            else if (!adminBox.Checked && !customerBox.Checked)
                conditions += " AND 1=0";

            // Plan filters
            bool basicSelected = basicBox.Checked;
            bool premiumSelected = premiumBox.Checked;

            if (basicSelected || premiumSelected)
            {
                conditions += " AND (";
                List<string> planConditions = new List<string>();

                if (basicSelected)
                    planConditions.Add("mp.PlanName = 'Basic'");
                if (premiumSelected)
                    planConditions.Add("mp.PlanName = 'Premium'");

                conditions += string.Join(" OR ", planConditions);
                conditions += ")";
            }

            // Status filters - FIXED BASED ON YOUR SPECIFICATIONS
            bool expiredSelected = expiredBox.Checked;
            bool inactiveSelected = inactiveBox.Checked;
            bool activeSelected = activeBox.Checked;

            if (expiredSelected || inactiveSelected || activeSelected)
            {
                conditions += " AND (";
                List<string> statusConditions = new List<string>();

                if (expiredSelected)
                {
                    // Only customers with expired membership (didn't pay)
                    statusConditions.Add("(r.RoleName = 'Customer' AND u.IsActiveMembership = 1 AND u.MembershipEndDate < GETDATE() AND u.IsDeleted = 0)");
                }

                if (inactiveSelected)
                {
                    // All archived/deleted accounts (both admins and customers)
                    statusConditions.Add("(u.IsDeleted = 1)");
                }

                if (activeSelected)
                {
                    // Admins (always active) + Active-paying customers
                    statusConditions.Add("(r.RoleName = 'Admin' AND u.IsDeleted = 0)"); // All non-deleted admins
                    statusConditions.Add("(r.RoleName = 'Customer' AND u.IsActiveMembership = 1 AND u.MembershipEndDate >= GETDATE() AND u.IsDeleted = 0)"); // Active customers
                }

                conditions += string.Join(" OR ", statusConditions);
                conditions += ")";
            }
            else
            {
                // Default: show non-deleted accounts
                conditions += " AND u.IsDeleted = 0";
            }

            return conditions;
        }

        private string BuildOrderByClause()
        {
            // FIXED: Default is newest to oldest even without checkbox checked
            if (oldestToNewestBox.Checked)
                return " ORDER BY u.CreatedAt ASC";
            else
                return " ORDER BY u.CreatedAt DESC"; // Default: newest to oldest
        }

        private void UpdateResultsCount(int count)
        {
            // Optional: Add a label to show count
            // resultsCountLabel.Text = $"Showing {count} accounts";
        }

        private void EditAccount(int userId)
        {
            EditAccount modal = new EditAccount(userId);
            if (modal.ShowDialog() == DialogResult.OK)
            {
                LoadAccountCards();
            }
        }

        private void DeleteAccount(int userId)
        {
            if (MessageBox.Show("Are you sure you want to archive this account? This action can be reversed later.", "Confirm Archive",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE Users SET IsDeleted = 1 WHERE UserID = @UserID";
                    SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account archived successfully!", "Success");
                        LoadAccountCards();
                    }
                    else
                    {
                        MessageBox.Show("Failed to archive account.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error archiving account: " + ex.Message, "Error");
                }
            }
        }

        private void createAccountModalBtn_Click(object sender, EventArgs e)
        {
            CreateAccount modal = new CreateAccount();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                LoadAccountCards();
                accountsPanel.VerticalScroll.Value = 0;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            // Reset to default filters
            SetDefaultFilters();
            LoadAccountCards();
        }

        private void clearFiltersBtn_Click(object sender, EventArgs e)
        {
            // Clear only plan and status filters, keep role and sort defaults
            basicBox.Checked = false;
            premiumBox.Checked = false;
            expiredBox.Checked = false;
            inactiveBox.Checked = false;
            activeBox.Checked = false;
        }
    }
}