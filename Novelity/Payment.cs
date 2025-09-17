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
            Form loginForm = GetLoginForm();
            loginForm.Show();
            this.Close();
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form loginForm = GetLoginForm();
            loginForm.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _planForm.Show();
            this.Close();
        }

        private void completeSignupBtn_Click(object sender, EventArgs e)
        {
            Signup_Success successForm = new Signup_Success(this);
            successForm.ShowDialog();
            Form loginForm = GetLoginForm();
            loginForm.Show();
            this.Close();
        }

        public Form GetLoginForm() => _planForm.GetLoginForm();
    }
}