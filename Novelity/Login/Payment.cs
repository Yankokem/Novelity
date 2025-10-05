using Microsoft.Data.SqlClient;
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
            try
            {
                string name = SessionHelper.SignupName;
                string username = SessionHelper.SignupUsername;
                string email = SessionHelper.SignupEmail;
                string password = SessionHelper.SignupPassword;
                int planId = SessionHelper.SelectedPlanID;

                string[] nameParts = name.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts.Length > 1 ? nameParts[1] : "";

                using (var hmac = new System.Security.Cryptography.HMACSHA512())
                {
                    byte[] passwordSalt = hmac.Key;
                    byte[] passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                    int roleId = 2; // Customer
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

                    Signup_Success successForm = new Signup_Success(this);
                    successForm.ShowDialog();

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
