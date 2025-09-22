using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Novelity.Modals
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            LoadRoles();
            roleBox.SelectedIndexChanged += roleBox_SelectedIndexChanged;
        }

        private void LoadRoles()
        {
            roleBox.Items.Add("Customer");
            roleBox.Items.Add("Admin");
            roleBox.SelectedIndex = 0;
        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCustomer = roleBox.SelectedItem?.ToString() == "Customer";
            planGroup.Visible = isCustomer;

            if (isCustomer)
            {
                planBox.Items.Clear();
                planBox.Items.Add("Basic");
                planBox.Items.Add("Premium");
                planBox.SelectedIndex = 0;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                CreateNewAccount();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(createFnField.Text) ||
                string.IsNullOrEmpty(createUsernameField.Text) ||
                string.IsNullOrEmpty(createEmailField.Text) ||
                string.IsNullOrEmpty(createPasswordField.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return false;
            }

            if (createPasswordField.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error");
                return false;
            }

            if (!IsValidEmail(createEmailField.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error");
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
            catch
            {
                return false;
            }
        }

        private void CreateNewAccount()
        {
            try
            {
                string fullName = createFnField.Text.Trim();
                string username = createUsernameField.Text.Trim();
                string email = createEmailField.Text.Trim();
                string password = createPasswordField.Text;
                string role = roleBox.SelectedItem.ToString();
                string planName = role == "Customer" ? planBox.SelectedItem.ToString() : null;

                // Check if username already exists
                if (UsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Error");
                    return;
                }

                // Check if email already exists
                if (EmailExists(email))
                {
                    MessageBox.Show("Email already exists. Please use a different one.", "Error");
                    return;
                }

                // Split name into first and last name
                string[] nameParts = fullName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts.Length > 1 ? nameParts[1] : "";

                // Generate password hash and salt
                using (var hmac = new HMACSHA512())
                {
                    byte[] passwordSalt = hmac.Key;
                    byte[] passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                    // Get role ID
                    int roleId = GetRoleId(role);
                    int? planId = role == "Customer" ? GetPlanId(planName) : null;

                    // Insert user into database
                    string query = @"
                        INSERT INTO Users (Username, Email, PasswordHash, PasswordSalt, FirstName, LastName, RoleID, PlanID, IsActiveMembership)
                        VALUES (@Username, @Email, @PasswordHash, @PasswordSalt, @FirstName, @LastName, @RoleID, @PlanID, @IsActiveMembership)";

                    SqlParameter[] parameters = {
                        new SqlParameter("@Username", username),
                        new SqlParameter("@Email", email),
                        new SqlParameter("@PasswordHash", passwordHash),
                        new SqlParameter("@PasswordSalt", passwordSalt),
                        new SqlParameter("@FirstName", firstName),
                        new SqlParameter("@LastName", lastName),
                        new SqlParameter("@RoleID", roleId),
                        new SqlParameter("@PlanID", planId ?? (object)DBNull.Value),
                        new SqlParameter("@IsActiveMembership", role == "Customer" ? 1 : 0)
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account created successfully!", "Success");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create account. Please try again.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message, "Error");
            }
        }

        private bool UsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND IsDeleted = 0";
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0;
        }

        private bool EmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND IsDeleted = 0";
            SqlParameter[] parameters = { new SqlParameter("@Email", email) };
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

        private void label4_Click(object sender, EventArgs e)
        {
            //ignore this!
        }
    }
}