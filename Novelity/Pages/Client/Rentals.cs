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
        private DataTable cachedRentals;
        private int currentPage = 1;
        private int pageSize = 4;
        private int totalPages = 1;

        public Rentals()
        {
            InitializeComponent();
            ConfigurePanel();
            LoadRentals();
        }

        private void ConfigurePanel()
        {
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

                if (cachedRentals == null)
                {
                    string query = @"
                        SELECT r.RentalID, r.RentalStatus, r.ExtensionType,
                               b.Title, b.Author, b.CoverImageFileName,
                               STRING_AGG(g.GenreName, ', ') AS Genres,
                               r.DateRented, r.DateDue, r.DateReturned
                        FROM Rentals r
                        INNER JOIN Books b ON r.BookID = b.BookID
                        LEFT JOIN BookGenres bg ON b.BookID = bg.BookID
                        LEFT JOIN Genres g ON bg.GenreID = g.GenreID
                        WHERE r.UserID = @UserID AND r.IsDeleted = 0
                        GROUP BY r.RentalID, r.RentalStatus, r.ExtensionType,
                                 b.Title, b.Author, b.CoverImageFileName,
                                 r.DateRented, r.DateDue, r.DateReturned
                        ORDER BY r.DateRented DESC;";

                    SqlParameter[] parameters = {
                        new SqlParameter("@UserID", UserSession.UserID)
                    };

                    cachedRentals = DatabaseHelper.ExecuteQuery(query, parameters);
                }

                if (cachedRentals.Rows.Count == 0)
                {
                    totalPages = 1;
                    prevBtn.Enabled = false;
                    nextBtn.Enabled = false;
                    Label noData = new Label
                    {
                        Text = "No rentals found.",
                        AutoSize = true,
                        Font = new System.Drawing.Font("Poppins", 12),
                        ForeColor = Color.Gray
                    };
                    rentalBooksPanel.Controls.Add(noData);
                    return;
                }

                totalPages = (int)Math.Ceiling(cachedRentals.Rows.Count / (double)pageSize);
                if (currentPage > totalPages) currentPage = totalPages;

                int startIndex = (currentPage - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, cachedRentals.Rows.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    DataRow row = cachedRentals.Rows[i];

                    var card = new RentalCard
                    {
                        Title = row["Title"].ToString(),
                        Author = row["Author"].ToString(),
                        Genre = row["Genres"]?.ToString() ?? "N/A",
                        RentalID = Convert.ToInt32(row["RentalID"]),
                        RentedDateLabel = Convert.ToDateTime(row["DateRented"]).ToString("MMM dd, yyyy"),
                        DueDateLabel = Convert.ToDateTime(row["DateDue"]).ToString("MMM dd, yyyy"),
                        BookCoverFileName = row["CoverImageFileName"] == DBNull.Value ? null : row["CoverImageFileName"].ToString()
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

                prevBtn.Enabled = currentPage > 1;
                nextBtn.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rentals: " + ex.Message, "Error");
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadRentals();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadRentals();
            }
        }
    }
}
