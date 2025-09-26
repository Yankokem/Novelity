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
        public int UserID { get; set; }

        public string FullName
        {
            get => fullNameLabel.Text;
            set => fullNameLabel.Text = value;
        }

        public string Username
        {
            get => usernameLabel.Text;
            set => usernameLabel.Text = value;
        }

        public string Email
        {
            get => emailLabel.Text;
            set => emailLabel.Text = value;
        }

        public string Tier
        {
            get => tierLabel.Text;
            set => tierLabel.Text = value;
        }

        public string SubscriptionDate
        {
            get => subDateLabel.Text;
            set => subDateLabel.Text = value;
        }

        public string RenewalDate
        {
            get => renewalDateLabel.Text;
            set => renewalDateLabel.Text = value;
        }

        public string Role
        {
            get => roleLabel.Text;
            set => roleLabel.Text = value;
        }

        public bool AutoRenewal { get; set; }

        private string _status;
        public string UserStatus
        {
            get => _status;
            set
            {
                _status = value;
                SetStatusIcon(value);
            }
        }

        public void DisplayUserID()
        {
            userIdLabel.Text = $"ID: {UserID}";

            // Show auto-renewal status
            if (Role == "Customer" && Tier != "No Plan")
            {
                string renewalStatus = AutoRenewal ? "Auto" : "Manual";
                userIdLabel.Text += $" | Renewal: {renewalStatus}";
            }
        }

        public void SetConditionalDisplay(string role, string tier)
        {
            if (role == "Admin")
            {
                tierLabel.Text = "N/A";
                subDateLabel.Text = "N/A";
                renewalDateLabel.Text = "N/A";
            }
            else if (tier == "No Plan")
            {
                tierLabel.Text = "N/A";
                subDateLabel.Text = "N/A";
                renewalDateLabel.Text = "N/A";
            }
            else if (tier == "Basic")
            {
                subDateLabel.Text = "N/A";
                renewalDateLabel.Text = "N/A";
            }
        }

        private void SetStatusIcon(string status)
        {
            // Hide all icons first
            ActiveIcon.Visible = false;
            ExpiredIcon.Visible = false;
            InactiveIcon.Visible = false;
            SuspendedIcon.Visible = false;
            BannedIcon.Visible = false;

            // Show the appropriate icon based on status
            switch (status?.ToLower())
            {
                case "active":
                    ActiveIcon.Visible = true;
                    break;
                case "expired":
                    ExpiredIcon.Visible = true;
                    break;
                case "banned":
                    BannedIcon.Visible = true;
                    break;
                case "suspended":
                    SuspendedIcon.Visible = true;
                    break;
                case "inactive":
                    InactiveIcon.Visible = true;
                    break;
                default:
                    InactiveIcon.Visible = true;
                    break;
            }
        }

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

        public void SetDeleteButtonText(bool isDeleted)
        {
            deleteBtn.Text = isDeleted ? "Unarchive" : "Archive";
        }
    }
}
