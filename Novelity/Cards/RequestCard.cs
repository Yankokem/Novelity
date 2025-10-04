using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Novelity.Cards
{
    public partial class RequestCard : UserControl
    {
        // internal fields for DB operations — must be set when creating the card
        private int _rentalId;
        private int _bookId;

        public RequestCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bind the card with data coming from the DB / parent loader.
        /// MUST be called after creating the card.
        /// </summary>
        public void Bind(int rentalId, int bookId, string title, string author, string username,
                         DateTime dateRented, DateTime dateDue, string status, string coverFileName = null)
        {
            _rentalId = rentalId;
            _bookId = bookId;

            titleReq.Text = title;
            authorReq.Text = author;
            rentersUsernameReq.Text = username;
            rentedDateReq.Text = dateRented.ToString("MMMM dd, yyyy");
            returnDateReq.Text = dateDue.ToString("MMMM dd, yyyy");

            // days remaining (or overdue)
            try
            {
                var days = (dateDue.Date - DateTime.Now.Date).Days;
                daysRemainingReq.Text = days >= 0 ? $"{days} days" : $"{Math.Abs(days)} days overdue";
            }
            catch
            {
                daysRemainingReq.Text = "-";
            }

            // book id and cover
            bookIDReq.Text = bookId.ToString();
            if (!string.IsNullOrEmpty(coverFileName))
            {
                try
                {
                    string coversPath = System.Configuration.ConfigurationManager.AppSettings["BookCoversPath"] ?? "";
                    string fullPath = System.IO.Path.Combine(coversPath, coverFileName);
                    if (System.IO.File.Exists(fullPath))
                    {
                        bookPictureBox.Image = Image.FromFile(fullPath);
                        bookPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch { /* ignore image load errors */ }
            }

            SetStatusIcons(status);

            // Adjust buttons initial state based on status
            claimedBtn.Enabled = !string.Equals(status, "rented", StringComparison.OrdinalIgnoreCase)
                                 && !string.Equals(status, "returned", StringComparison.OrdinalIgnoreCase);
            returnedBtn.Enabled = string.Equals(status, "rented", StringComparison.OrdinalIgnoreCase)
                                  || string.Equals(status, "extended", StringComparison.OrdinalIgnoreCase)
                                  || string.Equals(status, "overdue", StringComparison.OrdinalIgnoreCase);
        }

        private void SetStatusIcons(string status)
        {
            // hide all first
            pendingIcon.Visible = claimBookIcon.Visible = rentingIcon.Visible =
                overdueIcon.Visible = extendedIcon.Visible = returnedIcon.Visible = false;

            status = status?.Trim()?.ToLower();

            switch (status)
            {
                case "pending":
                    pendingIcon.Visible = true;
                    break;
                case "rented":
                    rentingIcon.Visible = true;
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
                    pendingIcon.Visible = true;
                    break;
            }
        }

        private void claimedBtn_Click(object sender, EventArgs e)
        {
            // basic safety checks
            if (_rentalId <= 0 || _bookId <= 0)
            {
                MessageBox.Show("Error marking as claimed: missing rental/book id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Update rental status to Rented. DO NOT decrement available copies here:
                // available quantity is already decreased when the user created the rental (reserve).
                string updateQuery = @"
                    UPDATE Rentals
                    SET RentalStatus = 'Rented', DateClaimed = GETDATE()
                    WHERE RentalID = @RentalID;
                ";

                var parameters = new[]
                {
                    new SqlParameter("@RentalID", _rentalId)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Book marked as claimed (Rented).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update UI icons and button states WITHOUT removing the control
                    SetStatusIcons("rented");
                    claimedBtn.Enabled = false;
                    returnedBtn.Enabled = true;

                    // Ask parent form to refresh list gracefully (if available)
                    var parentForm = this.FindForm() as Novelity.Pages.Admin.Requests;
                    parentForm?.RefreshRequests(); // safe-call, implemented in Requests.cs
                }
                else
                {
                    MessageBox.Show("Failed to mark as claimed. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking as claimed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnedBtn_Click(object sender, EventArgs e)
        {
            if (_rentalId <= 0 || _bookId <= 0)
            {
                MessageBox.Show("Error marking as returned: missing rental/book id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Mark rental returned and increase book available quantity
                string updateQuery = @"
                    UPDATE Rentals
                    SET RentalStatus = 'Returned', DateReturned = GETDATE()
                    WHERE RentalID = @RentalID;

                    UPDATE Books
                    SET AvailableQuantity = AvailableQuantity + 1
                    WHERE BookID = @BookID;
                ";

                var parameters = new[]
                {
                    new SqlParameter("@RentalID", _rentalId),
                    new SqlParameter("@BookID", _bookId)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Book marked as returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SetStatusIcons("returned");
                    claimedBtn.Enabled = false;
                    returnedBtn.Enabled = false;

                    var parentForm = this.FindForm() as Novelity.Pages.Admin.Requests;
                    parentForm?.RefreshRequests();
                }
                else
                {
                    MessageBox.Show("Failed to mark as returned. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking as returned: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
