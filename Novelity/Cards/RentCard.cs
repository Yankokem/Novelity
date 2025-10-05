using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Novelity.Cards
{
    public partial class RentCard : UserControl
    {
        private int _bookId;

        public RentCard(int bookId, string bookTitle, int availableCopies)
        {
            InitializeComponent();
            _bookId = bookId;

            // Populate fields
            usernameRent.Text = UserSession.Username;
            emailRent.Text = UserSession.Email;
            tierRent.Text = UserSession.PlanName ?? "Basic";
            bookTitleRent.Text = bookTitle;
            copiesRent.Text = availableCopies == 1 ? "1 copy" : $"{availableCopies} copies";

            // Rental duration & return date based on plan
            string query = "SELECT RentDurationDays FROM MembershipPlans WHERE PlanName = @PlanName";
            var param = new SqlParameter("@PlanName", UserSession.PlanName ?? "Basic");
            DataTable dt = DatabaseHelper.ExecuteQuery(query, new[] { param });

            int duration = 7; // default
            if (dt.Rows.Count > 0)
                duration = Convert.ToInt32(dt.Rows[0]["RentDurationDays"]);

            DurationRent.Text = $"{duration} days";
            dateRentedRent.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            returnDateRent.Text = DateTime.Now.AddDays(duration).ToString("MMMM dd, yyyy");

            agreementRent.Text = "I agree to return the book on or before the return date and to handle it with care.";
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void confirmRentBtn_Click(object sender, EventArgs e)
        {
            if (!agreementRent.Checked)
            {
                MessageBox.Show("You must agree to the terms before renting.", "Agreement Required");
                return;
            }

            // 🛑 Restrict admins
            if (UserSession.IsAdmin)
            {
                MessageBox.Show("Admins are not allowed to rent books.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🛑 Restrict Basic customers
            if (string.Equals(UserSession.PlanName, "Basic", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only Premium members can rent books. Please upgrade your plan.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Insert rental record
                string insertQuery = @"
                    INSERT INTO Rentals (UserID, BookID, DateRented, DateDue, RentalStatus)
                    VALUES (@UserID, @BookID, @DateRented, @DateDue, 'Pending');";

                var parameters = new[]
                {
                    new SqlParameter("@UserID", UserSession.UserID),
                    new SqlParameter("@BookID", _bookId),
                    new SqlParameter("@DateRented", DateTime.Now),
                    new SqlParameter("@DateDue", DateTime.Parse(returnDateRent.Text))
                };

                int rows = DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);

                if (rows > 0)
                {
                    // Decrease available quantity immediately since it's reserved
                    string updateQuery = "UPDATE Books SET AvailableQuantity = AvailableQuantity - 1 WHERE BookID = @BookID AND AvailableQuantity > 0";
                    DatabaseHelper.ExecuteNonQuery(updateQuery, new[] { new SqlParameter("@BookID", _bookId) });

                    MessageBox.Show("Your rental request is pending. Please pick up your book at the store.", "Success");

                    // Refresh BookInfo page
                    var parentForm = this.FindForm() as Novelity.Pages.Client.BookInfo;
                    parentForm?.GetType().GetMethod("LoadBookInfo", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.Invoke(parentForm, null);

                    // Hide rent card after success
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error renting book: " + ex.Message, "Error");
            }
        }
    }
}
