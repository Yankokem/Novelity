using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Novelity.Helpers;

namespace Novelity
{
    public partial class Plan : Form
    {
        private readonly Signup _signupForm;

        public Plan(Signup signupForm)
        {
            InitializeComponent();
            _signupForm = signupForm;
            this.FormClosing += Plan_FormClosing;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Plan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                _signupForm.GetLoginForm().Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _signupForm.Show();
            this.Close();
        }

        private void basicBtn_Click(object sender, EventArgs e)
        {
            // Store selected plan in session
            SessionHelper.SelectedPlanID = 1;

            // Complete registration with basic plan (no payment needed)
            CompleteRegistration();
        }

        private void premiumBtn_Click(object sender, EventArgs e)
        {
            // Store selected plan in session
            SessionHelper.SelectedPlanID = 2;

            Payment paymentForm = new Payment(this);
            paymentForm.Show();
            this.Hide();
        }

        private void CompleteRegistration()
        {
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
                using (var hmac = new HMACSHA512())
                {
                    byte[] passwordSalt = hmac.Key;
                    byte[] passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                    // Get Customer role ID (assuming it's 2)
                    int roleId = 2;

                    string query;
                    SqlParameter[] parameters;

                    if (planId == 1) // Free plan
                    {
                        query = @"
                    INSERT INTO Users
                    (Username, Email, PasswordHash, PasswordSalt, FirstName, LastName, RoleID, PlanID, UserStatus)
                    VALUES
                    (@Username, @Email, @PasswordHash, @PasswordSalt, @FirstName, @LastName, @RoleID, @PlanID, 'Active');
                    SELECT SCOPE_IDENTITY();";

                        parameters = new SqlParameter[]
                        {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@PasswordHash", passwordHash),
                    new SqlParameter("@PasswordSalt", passwordSalt),
                    new SqlParameter("@FirstName", firstName),
                    new SqlParameter("@LastName", lastName),
                    new SqlParameter("@RoleID", roleId),
                    new SqlParameter("@PlanID", planId)
                        };
                    }
                    else // Premium plan
                    {
                        query = @"
                    INSERT INTO Users
                    (Username, Email, PasswordHash, PasswordSalt, FirstName, LastName, RoleID, PlanID,
                     AutoRenewal, MembershipStartDate, MembershipEndDate, UserStatus)
                    VALUES
                    (@Username, @Email, @PasswordHash, @PasswordSalt, @FirstName, @LastName, @RoleID, @PlanID,
                     1, GETDATE(), DATEADD(DAY, 30, GETDATE()), 'Active');
                    SELECT SCOPE_IDENTITY();";

                        parameters = new SqlParameter[]
                        {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@PasswordHash", passwordHash),
                    new SqlParameter("@PasswordSalt", passwordSalt),
                    new SqlParameter("@FirstName", firstName),
                    new SqlParameter("@LastName", lastName),
                    new SqlParameter("@RoleID", roleId),
                    new SqlParameter("@PlanID", planId)
                        };
                    }

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


        public Form GetPreviousForm() => _signupForm;
        public Form GetLoginForm() => _signupForm.GetLoginForm();
    }
}