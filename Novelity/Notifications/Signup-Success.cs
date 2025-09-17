using System;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Signup_Success : Form
    {
        private readonly Form _previousForm;

        public Signup_Success(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            this.FormClosing += Signup_Success_FormClosing;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signup_Success_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form loginForm = _previousForm is Payment payment ? payment.GetLoginForm() : (_previousForm as Plan)?.GetLoginForm();
            if (loginForm != null)
                loginForm.Show();
        }
    }
}