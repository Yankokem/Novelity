using System;
using System.Windows.Forms;
using Novelity.Modals;

namespace Novelity.Pages.Admin
{
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void createAccountModalBtn_Click(object sender, EventArgs e)
        {
            // Open the create account modal
            CreateAccount modal = new CreateAccount();
            modal.ShowDialog();
        }
    }
}