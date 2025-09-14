using System;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Signup : Form
    {
        private readonly Login _loginForm; // Store the Login form reference

        public Signup(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm; // Initialize the reference
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _loginForm.Show(); // Show the original Login form
            this.Close(); // Close the Signup form
        }
    }
}