using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Novelity
{
    public partial class Signup : Form
    {
        private readonly Login _loginForm;

        public Signup(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            this.FormClosing += Signup_FormClosing;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                _loginForm.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(signupNameField.Text) ||
                string.IsNullOrEmpty(signupUsernameField.Text) ||
                string.IsNullOrEmpty(signupEmailField.Text) ||
                string.IsNullOrEmpty(signupPasswordField.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!IsValidEmail(signupEmailField.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password strength
            if (signupPasswordField.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username already exists
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND IsDeleted = 0";
                SqlParameter[] checkParams = {
                    new SqlParameter("@Username", signupUsernameField.Text)
                };

                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));
                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if email already exists
                checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND IsDeleted = 0";
                SqlParameter[] emailParams = {
                    new SqlParameter("@Email", signupEmailField.Text)
                };

                count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, emailParams));
                if (count > 0)
                {
                    MessageBox.Show("Email already exists. Please use a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Store user data in session
                SessionHelper.SignupName = signupNameField.Text;
                SessionHelper.SignupUsername = signupUsernameField.Text;
                SessionHelper.SignupEmail = signupEmailField.Text;
                SessionHelper.SignupPassword = signupPasswordField.Text;

                // Proceed to plan selection
                Plan planForm = new Plan(this);
                planForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during signup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public Form GetPreviousForm() => _loginForm;
        public Form GetLoginForm() => _loginForm.GetLoginForm();
    }
}