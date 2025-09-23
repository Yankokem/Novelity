using System;
using System.Windows.Forms;

namespace Novelity.Cards
{
    public partial class AccountCard : UserControl
    {
        public AccountCard()
        {
            InitializeComponent();
        }

        // Public properties to set the card data
        public int UserID
        {
            get;
            set;
        }

        public string FullName
        {
            set { fullNameLabel.Text = value; }
        }
        public string Username
        {
            set { usernameLabel.Text = value; }
        }
        public string Tier
        {
            set { tierLabel.Text = value; }
        }
        public string SubscriptionDate
        {
            set { subDateLabel.Text = value; }
        }
        public string RenewalDate
        {
            set { renewalDateLabel.Text = value; }
        }
        public string Role
        {
            set { roleLabel.Text = value; }
        }

        // Add this method to display UserID
        public void DisplayUserID()
        {
            userIdLabel.Text = $"ID: {UserID}";
        }

        // You can add click events for buttons if you have edit/delete buttons
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;

        // Example method if you have edit/delete buttons
        private void editBtn_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}