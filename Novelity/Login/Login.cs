using Microsoft.Data.SqlClient;
using Novelity.Helpers;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup(this);
            signupForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text.Trim();
            string password = passwordField.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get user data from database
                string query = @"
            SELECT u.UserID, u.Username, u.PasswordHash, u.PasswordSalt, u.RoleID, r.RoleName 
            FROM Users u 
            INNER JOIN Roles r ON u.RoleID = r.RoleID 
            WHERE u.Username = @Username AND u.IsDeleted = 0";

                SqlParameter[] parameters = {
            new SqlParameter("@Username", username)
        };

                DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verify password
                byte[] storedHash = (byte[])result.Rows[0]["PasswordHash"];
                byte[] storedSalt = (byte[])result.Rows[0]["PasswordSalt"];

                if (VerifyPassword(password, storedHash, storedSalt))
                {
                    // Login successful
                    int userId = Convert.ToInt32(result.Rows[0]["UserID"]);
                    string roleName = result.Rows[0]["RoleName"].ToString();

                    // Get additional user info for session
                    string queryUserInfo = "SELECT Email, FirstName, LastName, PlanID FROM Users WHERE UserID = @UserID";
                    SqlParameter[] userInfoParams = { new SqlParameter("@UserID", userId) };
                    DataTable userInfo = DatabaseHelper.ExecuteQuery(queryUserInfo, userInfoParams);

                    string email = userInfo.Rows[0]["Email"].ToString();
                    string firstName = userInfo.Rows[0]["FirstName"].ToString();
                    string lastName = userInfo.Rows[0]["LastName"].ToString();
                    object planIdObj = userInfo.Rows[0]["PlanID"];

                    string planName = null;
                    if (planIdObj != DBNull.Value)
                    {
                        int planId = Convert.ToInt32(planIdObj);
                        string queryPlan = "SELECT PlanName FROM MembershipPlans WHERE PlanID = @PlanID";
                        SqlParameter[] planParams = { new SqlParameter("@PlanID", planId) };
                        DataTable planInfo = DatabaseHelper.ExecuteQuery(queryPlan, planParams);

                        if (planInfo.Rows.Count > 0)
                        {
                            planName = planInfo.Rows[0]["PlanName"].ToString();
                        }
                    }

                    // Create user session (this will automatically save it)
                    UserSession.CreateSession(userId, username, email, firstName, lastName, roleName, planName);

                    // Open main form
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }
            return true;
        }

        public Form GetLoginForm() => this;

        // Demo login buttons (optional - you can add these as hidden buttons for testing)
        private void demoAdminBtn_Click(object sender, EventArgs e)
        {
            DemoLogin("Admin");
        }

        private void demoCustomerBtn_Click(object sender, EventArgs e)
        {
            DemoLogin("Customer");
        }

        private void DemoLogin(string role = "Customer")
        {
            string planName = role == "Customer" ? "Premium" : null;
            UserSession.CreateSession(999, "demo", "demo@example.com", "Demo", "User", role, planName);

            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }
}