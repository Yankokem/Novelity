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
        private int currentPage = 1;
        private int pageSize = 4;
        private int totalPages = 1;
        private DataTable cachedAccounts = null;

        public ManageAccounts()
        {
            InitializeComponent();
            SetDefaultFilters();
            this.Load += ManageAccounts_Load;
            SubscribeToFilterEvents();
        }

        private void SetDefaultFilters()
        {
            adminBox.Checked = true;
            customerBox.Checked = true;
            basicBox.Checked = false;
            premiumBox.Checked = false;
            expiredBox.Checked = false;
            inactiveBox.Checked = false;
            activeBox.Checked = true;
            suspendedBox.Checked = false;
            bannedBox.Checked = false;
            newestToOldestBox.Checked = true;
            oldestToNewestBox.Checked = false;
        }

        private void SubscribeToFilterEvents()
        {
            adminBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            customerBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            basicBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            premiumBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            expiredBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            inactiveBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            activeBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            suspendedBox.CheckedChanged += FilterCheckbox_CheckedChanged;
            bannedBox.CheckedChanged += FilterCheckbox_CheckedChanged;
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
                this.Invoke(new Action(() =>
                {
                    cachedAccounts = null;
                    currentPage = 1;
                    LoadAccountCards();
                }));
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
                if (cachedAccounts == null)
                {
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
                            u.MembershipEndDate as RawEndDate,
                            ISNULL(u.UserStatus, 'Active') as UserStatus,
                            u.AutoRenewal
                        FROM Users u
                        INNER JOIN Roles r ON u.RoleID = r.RoleID
                        LEFT JOIN MembershipPlans mp ON u.PlanID = mp.PlanID
                        WHERE 1=1";

                    string whereConditions = BuildWhereConditions();
                    string orderBy = BuildOrderByClause();

                    string finalQuery = baseQuery + whereConditions + orderBy;

                    cachedAccounts = DatabaseHelper.ExecuteQuery(finalQuery);
                }

                accountsPanel.Controls.Clear();

                if (cachedAccounts.Rows.Count == 0)
                {
                    UpdateResultsCount(0);
                    return;
                }

                totalPages = (int)Math.Ceiling(cachedAccounts.Rows.Count / (double)pageSize);
                if (currentPage > totalPages) currentPage = totalPages;

                int startIndex = (currentPage - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, cachedAccounts.Rows.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    DataRow row = cachedAccounts.Rows[i];
                    AccountCard card = new AccountCard();

                    card.UserID = Convert.ToInt32(row["UserID"]);
                    card.FullName = row["FullName"].ToString();
                    card.Username = row["Username"].ToString();
                    card.Email = row["Email"].ToString();
                    card.Tier = row["PlanName"].ToString();
                    card.SubscriptionDate = row["SubscriptionDate"].ToString();
                    card.RenewalDate = row["RenewalDate"].ToString();
                    card.Role = row["RoleName"].ToString();
                    card.AutoRenewal = Convert.ToBoolean(row["AutoRenewal"]);

                    bool isDeleted = Convert.ToBoolean(row["IsDeleted"]);
                    string userStatus = row["UserStatus"].ToString();
                    card.UserStatus = isDeleted ? "Inactive" : DetermineDisplayStatus(userStatus, row);

                    card.SetConditionalDisplay(row["RoleName"].ToString(), row["PlanName"].ToString());
                    card.DisplayUserID();
                    card.Margin = new Padding(0, 0, 0, 10);

                    card.EditClicked += (s, args) => EditAccount(card.UserID);
                    card.DeleteClicked += (s, args) => DeleteAccount(card.UserID);

                    card.SetDeleteButtonText(isDeleted);

                    accountsPanel.Controls.Add(card);
                }

                prevBtn.Enabled = currentPage > 1;
                nextBtn.Enabled = currentPage < totalPages;

                UpdateResultsCount(cachedAccounts.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message, "Error");
            }
        }

        private string DetermineDisplayStatus(string userStatus, DataRow row)
        {
            bool isDeleted = Convert.ToBoolean(row["IsDeleted"]);
            if (isDeleted)
                return "Inactive";

            if (!string.IsNullOrEmpty(userStatus))
                return userStatus;

            string roleName = row["RoleName"].ToString();
            if (roleName == "Customer" && row["RawEndDate"] != DBNull.Value)
            {
                DateTime membershipEndDate = Convert.ToDateTime(row["RawEndDate"]);
                if (membershipEndDate < DateTime.Now)
                    return "Expired";
            }

            return "Active";
        }

        private string BuildWhereConditions()
        {
            string conditions = "";

            if (adminBox.Checked && !customerBox.Checked)
                conditions += " AND r.RoleName = 'Admin'";
            else if (!adminBox.Checked && customerBox.Checked)
                conditions += " AND r.RoleName = 'Customer'";
            else if (!adminBox.Checked && !customerBox.Checked)
                conditions += " AND 1=0";

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

            bool expiredSelected = expiredBox.Checked;
            bool inactiveSelected = inactiveBox.Checked;
            bool activeSelected = activeBox.Checked;
            bool suspendedSelected = suspendedBox.Checked;
            bool bannedSelected = bannedBox.Checked;

            if (expiredSelected || inactiveSelected || activeSelected || suspendedSelected || bannedSelected)
            {
                conditions += " AND (";
                List<string> statusConditions = new List<string>();

                if (expiredSelected)
                    statusConditions.Add("(u.UserStatus = 'Expired')");
                if (inactiveSelected)
                    statusConditions.Add("(u.IsDeleted = 1)");
                if (activeSelected)
                    statusConditions.Add("(u.IsDeleted = 0 AND ISNULL(u.UserStatus, 'Active') = 'Active')");
                if (suspendedSelected)
                    statusConditions.Add("(u.UserStatus = 'Suspended')");
                if (bannedSelected)
                    statusConditions.Add("(u.UserStatus = 'Banned')");

                conditions += string.Join(" OR ", statusConditions);
                conditions += ")";
            }
            else
            {
                conditions += " AND (u.IsDeleted = 0 AND ISNULL(u.UserStatus, 'Active') = 'Active')";
            }

            return conditions;
        }

        private string BuildOrderByClause()
        {
            if (oldestToNewestBox.Checked)
                return " ORDER BY u.CreatedAt ASC";
            else
                return " ORDER BY u.CreatedAt DESC";
        }

        private void UpdateResultsCount(int count)
        {
            // optional
        }

        private void EditAccount(int userId)
        {
            EditAccount modal = new EditAccount(userId);
            if (modal.ShowDialog() == DialogResult.OK)
            {
                cachedAccounts = null;
                LoadAccountCards();
            }
        }

        private void DeleteAccount(int userId)
        {
            try
            {
                string checkQuery = "SELECT IsDeleted FROM Users WHERE UserID = @UserID";
                SqlParameter[] checkParams = { new SqlParameter("@UserID", userId) };
                bool isDeleted = Convert.ToBoolean(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                string action = isDeleted ? "unarchive" : "archive";
                string confirmMsg = isDeleted
                    ? "Are you sure you want to unarchive this account?"
                    : "Are you sure you want to archive this account?";

                if (MessageBox.Show(confirmMsg, "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE Users SET IsDeleted = @NewStatus WHERE UserID = @UserID";
                    SqlParameter[] updateParams = {
                        new SqlParameter("@NewStatus", isDeleted ? 0 : 1),
                        new SqlParameter("@UserID", userId)
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Account {action}d successfully!", "Success");
                        cachedAccounts = null;
                        LoadAccountCards();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to {action} account.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating account: " + ex.Message, "Error");
            }
        }

        private void createAccountModalBtn_Click(object sender, EventArgs e)
        {
            CreateAccount modal = new CreateAccount();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                cachedAccounts = null;
                LoadAccountCards();
                accountsPanel.VerticalScroll.Value = 0;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            SetDefaultFilters();
            cachedAccounts = null;
            currentPage = 1;
            LoadAccountCards();
        }

        private void clearFiltersBtn_Click(object sender, EventArgs e)
        {
            basicBox.Checked = false;
            premiumBox.Checked = false;
            expiredBox.Checked = false;
            inactiveBox.Checked = false;
            activeBox.Checked = false;
            suspendedBox.Checked = false;
            bannedBox.Checked = false;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadAccountCards();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadAccountCards();
            }
        }
    }
}
