using System;
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
            this.Close(); // Close the entire application
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup(this);
            signupForm.Show();
            this.Hide();
        }

        public Form GetLoginForm() => this; // Helper to identify Login form
    }
}