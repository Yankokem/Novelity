using Microsoft.Data.SqlClient;
using Novelity.Cards;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Rentals : Form
    {
        public Rentals()
        {
            InitializeComponent();
            ConfigurePanel();
            LoadRentals();
        }

        private void ConfigurePanel()
        {
            // Match ManageBooks panel behavior
            rentalBooksPanel.AutoScroll = true;
            rentalBooksPanel.WrapContents = true;
            rentalBooksPanel.FlowDirection = FlowDirection.LeftToRight;
            rentalBooksPanel.Padding = new Padding(5);
        }

        private void LoadRentals()
        {
            try
            {
                rentalBooksPanel.Controls.Clear();

                string query = @"
                    SELECT r.RentalID, r.RentalStatus, r.ExtensionType,
                           b.Title, b.Author,
                           STRING_AGG(g.GenreName, ', ') AS Genres,
                           r.DateRented, r.DateDue, r.DateReturned
                    FROM Rentals r
                    INNER JOIN Books b ON r.BookID = b.BookID
                    LEFT JOIN BookGenres bg ON b.BookID = bg.BookID
                    LEFT JOIN Genres g ON bg.GenreID = g.GenreID
                    WHERE r.UserID = @UserID AND r.IsDeleted = 0
                    GROUP BY r.RentalID, r.RentalStatus, r.ExtensionType,
                             b.Title, b.Author, r.DateRented, r.DateDue, r.DateReturned
                    ORDER BY r.DateRented DESC;";

                SqlParameter[] parameters = {
                    new SqlParameter("@UserID", UserSession.UserID)
                };

                DataTable rentals = DatabaseHelper.ExecuteQuery(query, parameters);

                foreach (DataRow row in rentals.Rows)
                {
                    var card = new RentalCard
                    {
                        Title = row["Title"].ToString(),
                        Author = row["Author"].ToString(),
                        Genre = row["Genres"]?.ToString() ?? "N/A",
                        RentalID = Convert.ToInt32(row["RentalID"]),
                        RentedDateLabel = Convert.ToDateTime(row["DateRented"]).ToString("MMM dd, yyyy"),
                        DueDateLabel = Convert.ToDateTime(row["DateDue"]).ToString("MMM dd, yyyy")
                    };

                    int daysRemaining = (Convert.ToDateTime(row["DateDue"]) - DateTime.Now).Days;
                    card.DaysRemainingLabel = daysRemaining > 0
                        ? $"{daysRemaining} days left"
                        : "Overdue";

                    string status = row["RentalStatus"].ToString();
                    string extensionType = row["ExtensionType"].ToString();

                    if (status.Equals("Rented", StringComparison.OrdinalIgnoreCase) &&
                        extensionType.Equals("Extended", StringComparison.OrdinalIgnoreCase))
                    {
                        card.Status = "Extended";
                    }
                    else if (daysRemaining < 0 && status.Equals("Rented", StringComparison.OrdinalIgnoreCase))
                    {
                        card.Status = "Overdue";
                    }
                    else
                    {
                        card.Status = status;
                    }

                    rentalBooksPanel.Controls.Add(card);
                }

                if (rentals.Rows.Count == 0)
                {
                    Label noData = new Label
                    {
                        Text = "No rentals found.",
                        AutoSize = true,
                        Font = new System.Drawing.Font("Poppins", 12),
                        ForeColor = Color.Gray
                    };
                    rentalBooksPanel.Controls.Add(noData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rentals: " + ex.Message, "Error");
            }
        }
    }
}
