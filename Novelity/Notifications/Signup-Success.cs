using System;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Signup_Success : Form
    {
        private readonly Form _previousForm;

        public Signup_Success()
        {
            InitializeComponent();
        }

        public Signup_Success(Form previousForm) : this()
        {
            _previousForm = previousForm;
            this.FormClosing += Signup_Success_FormClosing;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signup_Success_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Simplified closing logic
            if (_previousForm != null)
            {
                if (_previousForm is Payment payment)
                {
                    payment.GetLoginForm()?.Show();
                }
                else if (_previousForm is Plan plan)
                {
                    plan.GetLoginForm()?.Show();
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}