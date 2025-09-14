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
            this.Close();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup(this); // Pass the current Login form
            signupForm.Show();
            this.Hide(); // Hide the Login form
        }
    }
}