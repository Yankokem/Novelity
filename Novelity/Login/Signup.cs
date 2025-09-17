using System;
using System.Windows.Forms;

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
            Form loginForm = GetLoginForm();
            loginForm.Show();
            this.Close();
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form loginForm = GetLoginForm();
            loginForm.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }

        private void signupBtn_Click_1(object sender, EventArgs e)
        {
            Plan planForm = new Plan(this);
            planForm.Show();
            this.Hide();
        }

        public Form GetPreviousForm() => _loginForm;

        public Form GetLoginForm() => _loginForm.GetLoginForm();

        
    }
}