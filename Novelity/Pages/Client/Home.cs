using Novelity.Cards;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoadRecentlyAdded();
            LoadCustomersChoice();
        }

        private void LoadRecentlyAdded()
        {
            try
            {
                recentlyAddedPanel.Controls.Clear();

                string query = @"
                    SELECT TOP 6 
                        BookID,
                        Title,
                        Author,
                        CoverImageFileName
                    FROM Books
                    WHERE IsDeleted = 0
                    ORDER BY CreatedAt DESC;";

                DataTable books = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in books.Rows)
                {
                    HomeCard card = new HomeCard
                    {
                        Title = row["Title"].ToString(),
                        Author = row["Author"].ToString(),
                        CoverFileName = row["CoverImageFileName"] == DBNull.Value ? null : row["CoverImageFileName"].ToString()
                    };

                    // Add right padding
                    card.Margin = new Padding(0, 0, 31, 0);
                    recentlyAddedPanel.Controls.Add(card);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recently added books: " + ex.Message, "Error");
            }
        }

        private void LoadCustomersChoice()
        {
            try
            {
                customersChoicePanel.Controls.Clear();

                string query = @"
                    SELECT TOP 6 
                        b.BookID,
                        b.Title,
                        b.Author,
                        b.CoverImageFileName,
                        COUNT(r.RentalID) AS RentalCount
                    FROM Rentals r
                    INNER JOIN Books b ON r.BookID = b.BookID
                    WHERE b.IsDeleted = 0
                    GROUP BY b.BookID, b.Title, b.Author, b.CoverImageFileName
                    ORDER BY RentalCount DESC;";

                DataTable books = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in books.Rows)
                {
                    HomeCard card = new HomeCard
                    {
                        Title = row["Title"].ToString(),
                        Author = row["Author"].ToString(),
                        CoverFileName = row["CoverImageFileName"] == DBNull.Value ? null : row["CoverImageFileName"].ToString()
                    };

                    // Right padding for spacing
                    card.Margin = new Padding(0, 0, 31, 0);
                    customersChoicePanel.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers' choice books: " + ex.Message, "Error");
            }
        }
    }
}
