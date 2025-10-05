using Microsoft.Data.SqlClient;
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
        SELECT u.UserID, u.Username, u.PasswordHash, u.PasswordSalt, u.RoleID, r.RoleName, u.Email, u.FirstName, u.LastName, p.PlanName
        FROM Users u
        INNER JOIN Roles r ON u.RoleID = r.RoleID
        LEFT JOIN MembershipPlans p ON u.PlanID = p.PlanID
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
                    string email = result.Rows[0]["Email"].ToString();
                    string firstName = result.Rows[0]["FirstName"].ToString();
                    string lastName = result.Rows[0]["LastName"].ToString();

                    // PlanName may be NULL if user hasn’t subscribed yet
                    string planName = result.Rows[0]["PlanName"] == DBNull.Value
                        ? "Free"
                        : result.Rows[0]["PlanName"].ToString();

                    // Create session
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

        

    }
}