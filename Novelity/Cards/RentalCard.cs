using System;
using System.Windows.Forms;

namespace Novelity.Cards
{
    public partial class RentalCard : UserControl
    {
        public RentalCard()
        {
            InitializeComponent();
            this.Margin = new Padding(0, 0, 0, 10); // spacing between cards
        }

        // Public setters
        public string Title { set => titleRental.Text = value; }
        public string Author { set => authorRental.Text = value; }
        public string Genre { set => genreRental.Text = value; }
        public int RentalID { set => rentalIdRental.Text = value.ToString(); }

        public string RentedDateLabel { set => rentedDateLabel.Text = value; }
        public string DueDateLabel { set => dueDateLabel.Text = value; }
        public string DaysRemainingLabel { set => daysRemainingLabel.Text = value; }

        private string _status;
        public string Status
        {
            get => _status;
            set
            {
                _status = value?.Trim();

                // Hide all icons first
                rentingIcon.Visible = false;
                claimBookIcon.Visible = false;
                extendedIcon.Visible = false;
                returnedIcon.Visible = false;
                overdueIcon.Visible = false;

                // Show based on status
                switch (_status?.ToLower())
                {
                    case "rented":
                        rentingIcon.Visible = true;
                        break;
                    case "pending":
                        claimBookIcon.Visible = true;
                        break;
                    case "extended":
                        extendedIcon.Visible = true;
                        break;
                    case "returned":
                        returnedIcon.Visible = true;
                        break;
                    case "overdue":
                        overdueIcon.Visible = true;
                        break;
                    default:
                        claimBookIcon.Visible = true; // fallback
                        break;
                }
            }
        }

        private void extendRentalBtn_Click(object sender, EventArgs e) { /* skip */ }
        private void returnNowBtn_Click(object sender, EventArgs e) { /* skip */ }
        private void viewDetailsBtn_Click(object sender, EventArgs e) { /* skip */ }
    }
}
