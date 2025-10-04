using Novelity.Cards;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Novelity.Pages.Client
{
    public partial class BookInfo : Form
    {
        private int _bookId;

        public BookInfo(int bookId)
        {
            InitializeComponent();
            _bookId = bookId;
            LoadBookInfo();
        }

        private void LoadBookInfo()
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
                        STRING_AGG(g.GenreName, ', ') AS Genres
                    FROM Books b
                    LEFT JOIN BookGenres bg ON b.BookID = bg.BookID
                    LEFT JOIN Genres g ON bg.GenreID = g.GenreID
                    WHERE b.BookID = @BookID AND b.IsDeleted = 0
                    GROUP BY b.BookID, b.Title, b.Author, b.Publisher, b.ReleaseDate,
                             b.Description, b.TotalQuantity, b.AvailableQuantity, b.CoverImageFileName";

                var param = new Microsoft.Data.SqlClient.SqlParameter("@BookID", _bookId);
                DataTable dt = DatabaseHelper.ExecuteQuery(query, new[] { param });

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Book not found.", "Error");
                    return;
                }

                DataRow row = dt.Rows[0];

                // Cover
                if (row["CoverImageFileName"] != DBNull.Value)
                {
                    string coversPath = ConfigurationManager.AppSettings["BookCoversPath"];
                    string fileName = row["CoverImageFileName"].ToString();
                    string fullPath = Path.Combine(coversPath, fileName);

                    if (File.Exists(fullPath))
                        bookCoverInfo.Image = Image.FromFile(fullPath);
                }

                // Text fields
                titleInfo.Text = row["Title"].ToString();
                authorInfo.Text = row["Author"].ToString();
                genreInfo.Text = row["Genres"]?.ToString();
                publisherInfo.Text = row["Publisher"].ToString();
                publishDateInfo.Text = Convert.ToDateTime(row["ReleaseDate"]).ToString("MMMM dd, yyyy");
                descriptionInfo.Text = row["Description"].ToString();

                int available = Convert.ToInt32(row["AvailableQuantity"]);
                int total = Convert.ToInt32(row["TotalQuantity"]);

                copiesInfo.Text = available == 1 ? "1 copy available" : $"{available} copies available";

                if (available > 0)
                {
                    availableInfo.Visible = true;
                    rentedInfo.Visible = false;
                }
                else
                {
                    availableInfo.Visible = false;
                    rentedInfo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book info: " + ex.Message, "Error");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LoadForm(new Books());
            }
        }


        private void rentBookBtn_Click(object sender, EventArgs e)
        {
            rentConfirmationPanel.Controls.Clear();

            // Create RentCard and add it to the panel
            RentCard rentCard = new RentCard(
                _bookId,
                titleInfo.Text,
                copiesInfo.Text.Contains("1") ? 1 : int.Parse(copiesInfo.Text.Split(' ')[0])
            );

            rentCard.Dock = DockStyle.Fill;
            rentConfirmationPanel.Controls.Add(rentCard);
            rentCard.BringToFront();
        }

    }
}
