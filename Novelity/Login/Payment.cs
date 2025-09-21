using Microsoft.Data.SqlClient;
using Novelity.Helpers;
using System;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Payment : Form
    {
        private readonly Plan _planForm;

        public Payment(Plan planForm)
        {
            InitializeComponent();
            _planForm = planForm;
            this.FormClosing += Payment_FormClosing;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                _planForm.GetLoginForm().Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _planForm.Show();
            this.Close();
        }

        private void completeSignupBtn_Click(object sender, EventArgs e)
        {
            // For now, we'll just complete the registration without actual payment processing
            // In a real application, you would integrate with a payment gateway here

            try
            {
                // Get stored user data from session
                string name = SessionHelper.SignupName;
                string username = SessionHelper.SignupUsername;
                string email = SessionHelper.SignupEmail;
                string password = SessionHelper.SignupPassword;
                int planId = SessionHelper.SelectedPlanID;

                // Split name into first and last name
                string[] nameParts = name.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts.Length > 1 ? nameParts[1] : "";

                // Generate password hash and salt
                using (var hmac = new System.Security.Cryptography.HMACSHA512())
                {
                    byte[] passwordSalt = hmac.Key;
                    byte[] passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                    // Get Customer role ID (assuming it's 2)
                    int roleId = 2;

                    // Insert user into database
                    string query = @"
                        INSERT INTO Users (Username, Email, PasswordHash, PasswordSalt, FirstName, LastName, RoleID, PlanID, IsActiveMembership, MembershipStartDate, MembershipEndDate)
                        VALUES (@Username, @Email, @PasswordHash, @PasswordSalt, @FirstName, @LastName, @RoleID, @PlanID, 1, GETDATE(), DATEADD(DAY, 30, GETDATE()));
                        SELECT SCOPE_IDENTITY();";

                    SqlParameter[] parameters = {
                        new SqlParameter("@Username", username),
                        new SqlParameter("@Email", email),
                        new SqlParameter("@PasswordHash", passwordHash),
                        new SqlParameter("@PasswordSalt", passwordSalt),
                        new SqlParameter("@FirstName", firstName),
                        new SqlParameter("@LastName", lastName),
                        new SqlParameter("@RoleID", roleId),
                        new SqlParameter("@PlanID", planId)
                    };

                    int userId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));

                    // Show success message
                    Signup_Success successForm = new Signup_Success(this);
                    successForm.ShowDialog();

                    // Return to login form
                    Form loginForm = GetLoginForm();
                    loginForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error completing registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form GetLoginForm() => _planForm.GetLoginForm();

        private void Payment_Load(object sender, EventArgs e)
        {
            // Payment form load logic if needed
        }
    }
}