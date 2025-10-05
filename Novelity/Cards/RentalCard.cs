using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Novelity.Cards
{
    public partial class RentalCard : UserControl
    {
        private string _coverFileName;

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

        // 🔴 New: cover file property
        public string BookCoverFileName
        {
            get => _coverFileName;
            set
            {
                _coverFileName = value;
                LoadCoverImage();
            }
        }

        private void LoadCoverImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(_coverFileName))
                {
                    string coversPath = ConfigurationManager.AppSettings["BookCoversPath"] ?? "";
                    string fullPath = Path.Combine(coversPath, _coverFileName);

                    if (File.Exists(fullPath))
                    {
                        bookPictureBox.Image = Image.FromFile(fullPath);
                        bookPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        bookPictureBox.Image = null;
                    }
                }
                else
                {
                    bookPictureBox.Image = null;
                }
            }
            catch
            {
                bookPictureBox.Image = null;
            }
        }

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
