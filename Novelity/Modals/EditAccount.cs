using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Novelity.Modals
{
    public partial class EditAccount : Form
    {
        private int _userId;
        private string _currentRole;
        private string _currentPlan;
        private DateTime? _originalMembershipStartDate;
        private DateTime? _originalMembershipEndDate;

        public EditAccount(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadUserData();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            editroleBox.SelectedIndexChanged += EditroleBox_SelectedIndexChanged;
            editplanBox.SelectedIndexChanged += EditplanBox_SelectedIndexChanged;
        }

        private void LoadUserData()
        {
            try
            {
                string query = @"
                    SELECT 
                        u.UserID,
                        u.Username,
                        u.Email,
                        u.FirstName,
                        u.LastName,
                        r.RoleName,
                        ISNULL(mp.PlanName, 'No Plan') as PlanName,
                        u.MembershipStartDate,
                        u.MembershipEndDate,
                        u.UserStatus
                    FROM Users u
                    INNER JOIN Roles r ON u.RoleID = r.RoleID
                    LEFT JOIN MembershipPlans mp ON u.PlanID = mp.PlanID
                    WHERE u.UserID = @UserID";

                SqlParameter[] parameters = { new SqlParameter("@UserID", _userId) };
                DataTable userData = DatabaseHelper.ExecuteQuery(query, parameters);

                if (userData.Rows.Count > 0)
                {
                    DataRow row = userData.Rows[0];

                    // Populate fields
                    editFnField.Text = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                    editUsernameField.Text = row["Username"].ToString();
                    editEmailField.Text = row["Email"].ToString();

                    _currentRole = row["RoleName"].ToString();
                    _currentPlan = row["PlanName"].ToString();

                    // Store original dates
                    _originalMembershipStartDate = row["MembershipStartDate"] != DBNull.Value ?
                        Convert.ToDateTime(row["MembershipStartDate"]) : (DateTime?)null;
                    _originalMembershipEndDate = row["MembershipEndDate"] != DBNull.Value ?
                        Convert.ToDateTime(row["MembershipEndDate"]) : (DateTime?)null;

                    // Load roles
                    editroleBox.Items.Add("Customer");
                    editroleBox.Items.Add("Admin");
                    editroleBox.SelectedItem = _currentRole;

                    // Load plans
                    editplanBox.Items.Add("Basic");
                    editplanBox.Items.Add("Premium");
                    if (_currentRole == "Customer" && _currentPlan != "No Plan")
                    {
                        editplanBox.SelectedItem = _currentPlan;
                    }

                    // Load statuses
                    editStatusBox.Items.Add("Active");
                    editStatusBox.Items.Add("Expired");
                    editStatusBox.Items.Add("Suspended");
                    editStatusBox.Items.Add("Banned");
                    editStatusBox.SelectedItem = row["UserStatus"].ToString();

                    // Set calendar
                    if (_originalMembershipEndDate.HasValue)
                    {
                        editMonthCalendar.SetDate(_originalMembershipEndDate.Value);
                    }

                    ApplyUIStateBasedOnRoleAndPlan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error");
                this.Close();
            }
        }

        private void EditroleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = editroleBox.SelectedItem?.ToString();

            if (selectedRole == "Admin")
            {
                this.Height = 500;
                editAccountBtn.Location = new System.Drawing.Point(279, 448);
                panelLineBottom.Location = new System.Drawing.Point(0, 497);

                planGroup.Visible = false;
                calenderLabel.Visible = false;
                editMonthCalendar.Visible = false;
            }
            else if (selectedRole == "Customer")
            {
                planGroup.Visible = true;
                ApplyPlanSpecificUI();
            }
        }

        private void EditplanBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyPlanSpecificUI();
        }

        private void ApplyPlanSpecificUI()
        {
            string selectedPlan = editplanBox.SelectedItem?.ToString();

            if (selectedPlan == "Basic")
            {
                this.Height = 450;
                editAccountBtn.Location = new System.Drawing.Point(279, 398);
                panelLineBottom.Location = new System.Drawing.Point(0, 447);

                calenderLabel.Visible = false;
                editMonthCalendar.Visible = false;
            }
            else if (selectedPlan == "Premium")
            {
                this.Height = 600;
                editAccountBtn.Location = new System.Drawing.Point(279, 548);
                panelLineBottom.Location = new System.Drawing.Point(0, 597);

                calenderLabel.Visible = true;
                editMonthCalendar.Visible = true;
            }
        }

        private void ApplyUIStateBasedOnRoleAndPlan()
        {
            if (_currentRole == "Admin")
            {
                EditroleBox_SelectedIndexChanged(null, EventArgs.Empty);
            }
            else if (_currentRole == "Customer")
            {
                planGroup.Visible = true;
                if (_currentPlan == "Basic")
                {
                    ApplyPlanSpecificUI();
                }
                else
                {
                    this.Height = 600;
                    editAccountBtn.Location = new System.Drawing.Point(279, 548);
                    panelLineBottom.Location = new System.Drawing.Point(0, 597);
                    calenderLabel.Visible = true;
                    editMonthCalendar.Visible = true;
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void editAccountBtn_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                UpdateAccount();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(editFnField.Text) ||
                string.IsNullOrEmpty(editUsernameField.Text) ||
                string.IsNullOrEmpty(editEmailField.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error");
                return false;
            }

            if (!IsValidEmail(editEmailField.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error");
                return false;
            }

            if (UsernameExists(editUsernameField.Text, _userId))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Error");
                return false;
            }

            if (EmailExists(editEmailField.Text, _userId))
            {
                MessageBox.Show("Email already exists. Please use a different one.", "Error");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch { return false; }
        }

        private void UpdateAccount()
        {
            try
            {
                string fullName = editFnField.Text.Trim();
                string username = editUsernameField.Text.Trim();
                string email = editEmailField.Text.Trim();
                string password = editPasswordField.Text;
                string role = editroleBox.SelectedItem.ToString();
                string planName = role == "Customer" ? editplanBox.SelectedItem?.ToString() : null;
                string userStatus = editStatusBox.SelectedItem?.ToString() ?? "Active";

                string[] nameParts = fullName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts.Length > 1 ? nameParts[1] : "";

                int roleId = GetRoleId(role);
                int? planId = (role == "Customer" && planName != null) ? GetPlanId(planName) : null;

                DateTime? newMembershipStartDate = _originalMembershipStartDate;
                DateTime? newMembershipEndDate = _originalMembershipEndDate;

                if (role == "Customer" && planName == "Premium" && editMonthCalendar.Visible)
                {
                    newMembershipEndDate = editMonthCalendar.SelectionStart;
                    if (!_originalMembershipStartDate.HasValue)
                        newMembershipStartDate = DateTime.Today;
                }
                else if (role == "Customer" && planName == "Basic")
                {
                    DateTime startDate = _originalMembershipStartDate ?? DateTime.Today;
                    newMembershipStartDate = startDate;
                    newMembershipEndDate = startDate.AddDays(30);
                }
                else if (role == "Admin")
                {
                    newMembershipStartDate = null;
                    newMembershipEndDate = null;
                }

                string query = @"
                    UPDATE Users 
                    SET Username = @Username, 
                        Email = @Email, 
                        FirstName = @FirstName, 
                        LastName = @LastName, 
                        RoleID = @RoleID, 
                        PlanID = @PlanID,
                        MembershipStartDate = @MembershipStartDate,
                        MembershipEndDate = @MembershipEndDate,
                        UserStatus = @UserStatus";

                if (!string.IsNullOrEmpty(password))
                {
                    if (password.Length < 6)
                    {
                        MessageBox.Show("Password must be at least 6 characters long.", "Error");
                        return;
                    }

                    using (var hmac = new HMACSHA512())
                    {
                        byte[] passwordSalt = hmac.Key;
                        byte[] passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                        query += ", PasswordHash = @PasswordHash, PasswordSalt = @PasswordSalt";

                        // Add password params after building base param list
                    }
                }

                query += " WHERE UserID = @UserID";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@FirstName", firstName),
                    new SqlParameter("@LastName", lastName),
                    new SqlParameter("@RoleID", roleId),
                    new SqlParameter("@PlanID", planId ?? (object)DBNull.Value),
                    new SqlParameter("@MembershipStartDate", newMembershipStartDate ?? (object)DBNull.Value),
                    new SqlParameter("@MembershipEndDate", newMembershipEndDate ?? (object)DBNull.Value),
                    new SqlParameter("@UserStatus", userStatus),
                    new SqlParameter("@UserID", _userId)
                };

                if (!string.IsNullOrEmpty(password))
                {
                    using (var hmac = new HMACSHA512())
                    {
                        byte[] passwordSalt = hmac.Key;
                        byte[] passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                        parameters.Add(new SqlParameter("@PasswordHash", passwordHash));
                        parameters.Add(new SqlParameter("@PasswordSalt", passwordSalt));
                    }
                }

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters.ToArray());

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account updated successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update account. Please try again.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating account: " + ex.Message, "Error");
            }
        }

        private bool UsernameExists(string username, int excludeUserId)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND UserID != @UserID AND IsDeleted = 0";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@UserID", excludeUserId)
            };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0;
        }

        private bool EmailExists(string email, int excludeUserId)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND UserID != @UserID AND IsDeleted = 0";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", email),
                new SqlParameter("@UserID", excludeUserId)
            };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0;
        }

        private int GetRoleId(string roleName)
        {
            string query = "SELECT RoleID FROM Roles WHERE RoleName = @RoleName AND IsDeleted = 0";
            SqlParameter[] parameters = { new SqlParameter("@RoleName", roleName) };
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
        }

        private int GetPlanId(string planName)
        {
            string query = "SELECT PlanID FROM MembershipPlans WHERE PlanName = @PlanName AND IsDeleted = 0";
            SqlParameter[] parameters = { new SqlParameter("@PlanName", planName) };
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
        }
    }
}
