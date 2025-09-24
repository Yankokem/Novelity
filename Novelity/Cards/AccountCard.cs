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

        public string Email
        {
            set { emailLabel.Text = value; }
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

        // Method to set conditional display based on role and plan
        public void SetConditionalDisplay(string role, string tier)
        {
            if (role == "Admin" || tier == "Basic" || tier == "No Plan")
            {
                tierLabel.Text = "N/A";
                subDateLabel.Text = "N/A";
                renewalDateLabel.Text = "N/A";
            }
        }

        // You can add click events for buttons if you have edit/delete buttons
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}