using Novelity.Cards;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Novelity.Pages.Admin
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
            // Load requests when form is created
            LoadRequests();
        }

        /// <summary>
        /// Public method that RequestCard will call after an update so
        /// the Requests page can refresh itself.
        /// </summary>
        public void RefreshRequests()
        {
            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                // Clear panel first
                requestsPanel.Controls.Clear();

                // Query rentals we care about (Pending, Rented, Extended, Overdue)
                string query = @"
                    SELECT 
                        r.RentalID,
                        r.BookID,
                        r.UserID,
                        r.RentalStatus,
                        r.DateRented,
                        r.DateDue,
                        b.Title,
                        b.Author,
                        b.CoverImageFileName,
                        u.Username
                    FROM Rentals r
                    INNER JOIN Books b ON r.BookID = b.BookID
                    INNER JOIN Users u ON r.UserID = u.UserID
                    WHERE r.RentalStatus IN ('Pending','Rented','Extended','Overdue')
                    ORDER BY r.DateRented DESC;
                ";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count == 0)
                {
                    // optional small debug: show that there are no requests
                    // MessageBox.Show("No pending rental requests found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create a RequestCard for each row
                foreach (DataRow row in dt.Rows)
                {
                    int rentalId = Convert.ToInt32(row["RentalID"]);
                    int bookId = Convert.ToInt32(row["BookID"]);
                    string title = row["Title"]?.ToString() ?? "";
                    string author = row["Author"]?.ToString() ?? "";
                    string username = row["Username"]?.ToString() ?? "";
                    string status = row["RentalStatus"]?.ToString() ?? "Pending";
                    string cover = row["CoverImageFileName"] == DBNull.Value ? null : row["CoverImageFileName"].ToString();

                    DateTime dateRented = row["DateRented"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["DateRented"]);
                    DateTime dateDue = row["DateDue"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["DateDue"]);

                    RequestCard card = new RequestCard();
                    card.Bind(rentalId, bookId, title, author, username, dateRented, dateDue, status, cover);

                    // small spacing so cards aren't glued
                    card.Margin = new Padding(0, 0, 0, 10);

                    requestsPanel.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
