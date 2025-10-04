using Novelity.Cards;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Books : Form
    {
        private DataTable cachedBooks = null;
        private HashSet<string> selectedGenres = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        private int gap = 20; // gap between cards
        bool expand = false;

        public Books()
        {
            InitializeComponent();

            booksPanel.AutoScroll = true;
            booksPanel.WrapContents = true;
            booksPanel.FlowDirection = FlowDirection.LeftToRight;

            // hook events
            booksSearchbar.TextChanged += (s, e) => LoadBooks();
            dateBox.SelectedIndexChanged += (s, e) => LoadBooks();
            availableBox.CheckedChanged += (s, e) => LoadBooks();
            rentedBox.CheckedChanged += (s, e) => LoadBooks();

            // clear button
            clearFiltersBtn.Click += ClearFiltersBtn_Click;

            // genre buttons
            memoirBtn.Click += GenreBtn_Click;
            crimeFictionBtn.Click += GenreBtn_Click;
            romanceBtn.Click += GenreBtn_Click;
            adventureBtn.Click += GenreBtn_Click;
            classicsBtn.Click += GenreBtn_Click;
            poetryBtn.Click += GenreBtn_Click;
            dystopianBtn.Click += GenreBtn_Click;
            contemporaryBtn.Click += GenreBtn_Click;
            thrillerBtn.Click += GenreBtn_Click;
            scifiBtn.Click += GenreBtn_Click;
            youngAdultBtn.Click += GenreBtn_Click;

            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                if (cachedBooks == null)
                {
                    string query = @"
                        SELECT 
                            b.BookID,
                            b.Title,
                            b.Author,
                            b.Publisher,
                            b.ReleaseDate,
                            b.TotalQuantity,
                            b.AvailableQuantity,
                            b.CoverImageFileName,
                            STRING_AGG(g.GenreName, ', ') AS Genres
                        FROM Books b
                        LEFT JOIN BookGenres bg ON b.BookID = bg.BookID
                        LEFT JOIN Genres g ON bg.GenreID = g.GenreID
                        WHERE b.IsDeleted = 0
                        GROUP BY b.BookID, b.Title, b.Author, b.Publisher, b.ReleaseDate, 
                                 b.TotalQuantity, b.AvailableQuantity, b.CoverImageFileName
                        ORDER BY b.BookID DESC;";

                    cachedBooks = DatabaseHelper.ExecuteQuery(query);
                }

                DataTable filteredTable = cachedBooks.Copy();
                ApplyFilters(ref filteredTable);

                booksPanel.SuspendLayout();
                booksPanel.Controls.Clear();

                foreach (DataRow row in filteredTable.Rows)
                {
                    BookCard card = new BookCard
                    {
                        BookID = Convert.ToInt32(row["BookID"]),
                        Title = row["Title"].ToString(),
                        Author = row["Author"].ToString(),
                        Genres = row["Genres"]?.ToString(),
                        CoverFileName = row["CoverImageFileName"] == DBNull.Value ? null : row["CoverImageFileName"].ToString()
                    };

                    card.Margin = new Padding(0, 0, gap, gap);
                    booksPanel.Controls.Add(card);
                }

                booksPanel.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error");
            }
        }

        private void ApplyFilters(ref DataTable filteredTable)
        {
            var rows = filteredTable.AsEnumerable();

            // 🔍 search
            string searchText = booksSearchbar.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
            {
                rows = rows.Where(r =>
                {
                    string title = r["Title"]?.ToString().ToLower() ?? "";
                    string author = r["Author"]?.ToString().ToLower() ?? "";
                    string publisher = r["Publisher"]?.ToString().ToLower() ?? "";
                    string genres = r["Genres"]?.ToString().ToLower() ?? "";
                    return title.Contains(searchText) || author.Contains(searchText) ||
                           publisher.Contains(searchText) || genres.Contains(searchText);
                });
            }

            // 📦 availability
            if (availableBox.Checked)
                rows = rows.Where(r => Convert.ToInt32(r["AvailableQuantity"]) > 0);

            if (rentedBox.Checked)
                rows = rows.Where(r => Convert.ToInt32(r["AvailableQuantity"]) < Convert.ToInt32(r["TotalQuantity"]));

            // 📅 date sort
            var dateSelection = dateBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(dateSelection))
            {
                if (dateSelection.Equals("Newest to Oldest", StringComparison.OrdinalIgnoreCase))
                    rows = rows.OrderByDescending(r => r["ReleaseDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(r["ReleaseDate"]));
                else if (dateSelection.Equals("Oldest to Newest", StringComparison.OrdinalIgnoreCase))
                    rows = rows.OrderBy(r => r["ReleaseDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(r["ReleaseDate"]));
            }

            // 🎭 genres
            if (selectedGenres.Any())
            {
                rows = rows.Where(r =>
                {
                    var genresCell = (r["Genres"]?.ToString() ?? "");
                    return selectedGenres.Any(g => genresCell.IndexOf(g, StringComparison.OrdinalIgnoreCase) >= 0);
                });
            }

            filteredTable = rows.Any() ? rows.CopyToDataTable() : filteredTable.Clone();
        }

        private void GenreBtn_Click(object sender, EventArgs e)
        {
            if (!(sender is Button btn)) return;
            string genre = btn.Text?.Trim();
            if (string.IsNullOrEmpty(genre)) return;

            if (selectedGenres.Contains(genre))
                selectedGenres.Remove(genre);
            else
                selectedGenres.Add(genre);

            LoadBooks();
        }

        // 🧹 Clear button function
        private void ClearFiltersBtn_Click(object sender, EventArgs e)
        {
            booksSearchbar.Text = "";
            dateBox.SelectedIndex = -1;

            availableBox.Checked = false;
            rentedBox.Checked = false;

            selectedGenres.Clear();
            LoadBooks();
        }

        // filterFlowLayout expand/collapse
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                filterFlowLayout.Height += 10;
                if (filterFlowLayout.Height >= filterFlowLayout.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                filterFlowLayout.Height -= 10;
                if (filterFlowLayout.Height <= filterFlowLayout.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
