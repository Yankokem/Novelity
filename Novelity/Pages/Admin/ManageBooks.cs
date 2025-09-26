using Novelity.Cards;
using Novelity.Modals;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Novelity.Pages.Admin
{
    public partial class ManageBooks : Form
    {
        private int currentPage = 1;
        private int pageSize = 4;
        private int totalPages = 1;

        public ManageBooks()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void createBookModalBtn_Click(object sender, EventArgs e)
        {
            CreateBook modal = new CreateBook();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                currentPage = 1;
                LoadBooks();
            }
        }

        private void LoadBooks()
        {
            try
            {
                string query = @"
                    SELECT 
                        b.BookID,
                        b.Title,
                        b.Author,
                        b.Publisher,
                        b.ReleaseDate,
                        b.Description,
                        b.TotalQuantity,
                        b.AvailableQuantity,
                        b.CoverImageFileName,
                        b.CreatedAt,
                        STRING_AGG(g.GenreName, ', ') AS Genres
                    FROM Books b
                    LEFT JOIN BookGenres bg ON b.BookID = bg.BookID
                    LEFT JOIN Genres g ON bg.GenreID = g.GenreID
                    WHERE b.IsDeleted = 0
                    GROUP BY b.BookID, b.Title, b.Author, b.Publisher, b.ReleaseDate, 
                             b.Description, b.TotalQuantity, b.AvailableQuantity, 
                             b.CoverImageFileName, b.CreatedAt
                    ORDER BY b.BookID DESC;";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No books found in database yet.", "Info");
                    manageBooksPanel.Controls.Clear();
                    return;
                }

                // Pagination math
                totalPages = (int)Math.Ceiling(dt.Rows.Count / (double)pageSize);
                if (currentPage > totalPages) currentPage = totalPages;

                int startIndex = (currentPage - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, dt.Rows.Count);

                manageBooksPanel.Controls.Clear();

                for (int i = startIndex; i < endIndex; i++)
                {
                    DataRow row = dt.Rows[i];
                    ManageBooksCard card = new ManageBooksCard
                    {
                        BookID = Convert.ToInt32(row["BookID"]),
                        Title = row["Title"].ToString(),
                        Author = row["Author"].ToString(),
                        Publisher = row["Publisher"].ToString(),
                        ReleaseDate = Convert.ToDateTime(row["ReleaseDate"]).ToString("MMMM dd, yyyy"),
                        Genres = row["Genres"]?.ToString(),
                        Quantity = $"{row["AvailableQuantity"]}/{row["TotalQuantity"]}",
                        Status = (Convert.ToInt32(row["AvailableQuantity"]) > 0) ? "Available" : "Out of Stock",
                        DateAdded = Convert.ToDateTime(row["CreatedAt"]).ToString("MMMM dd, yyyy"),
                        CoverFileName = row["CoverImageFileName"] == DBNull.Value ? null : row["CoverImageFileName"].ToString()
                    };

                    manageBooksPanel.Controls.Add(card);
                }

                // Enable/disable navigation
                prevBtn.Enabled = currentPage > 1;
                nextBtn.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error");
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadBooks();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadBooks();
            }
        }
    }
}
