using Novelity.Cards;
using Novelity.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Novelity.Pages.Admin
{
    public partial class ManageBooks : Form
    {
        private int currentPage = 1;
        private int pageSize = 4;
        private int totalPages = 1;
        private DataTable cachedBooks = null;
        private HashSet<string> selectedGenres = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // appearance for toggled genre buttons
        private readonly Color genreSelectedBackColor = SystemColors.Highlight;
        private readonly Color genreSelectedForeColor = Color.White;
        private readonly Color genreDefaultBackColor = SystemColors.Control;
        private readonly Color genreDefaultForeColor = SystemColors.ControlText;

        bool expand = false;

        public ManageBooks()
        {
            InitializeComponent();
            booksSearchbar.TextChanged += booksSearchbar_TextChanged;

            // Hook up filter events
            dateBox.SelectedIndexChanged += (s, e) => LoadBooks();
            expiredBox.CheckedChanged += (s, e) => LoadBooks();
            inactiveBox.CheckedChanged += (s, e) => LoadBooks();
            activeBox.CheckedChanged += (s, e) => LoadBooks();

            availableBox.CheckedChanged += (s, e) => LoadBooks();
            overdueBox.CheckedChanged += (s, e) => LoadBooks();
            rentedBox.CheckedChanged += (s, e) => LoadBooks();
            archivedBox.CheckedChanged += (s, e) => LoadBooks();

            clearFiltersBtn.Click += ClearFiltersBtn_Click;

            // Genres: buttons act as toggles (Click toggles selection)
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

        private void createBookModalBtn_Click(object sender, EventArgs e)
        {
            CreateBook modal = new CreateBook();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                currentPage = 1;
                cachedBooks = null;
                LoadBooks();
            }
        }

        public void RefreshBooks()
        {
            currentPage = 1;
            cachedBooks = null;
            LoadBooks();
        }

        private void booksSearchbar_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
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
                            b.Description,
                            b.TotalQuantity,
                            b.AvailableQuantity,
                            b.CoverImageFileName,
                            b.CreatedAt,
                            STRING_AGG(g.GenreName, ', ') AS Genres,
                            u.UserStatus,
                            rt.RentalStatus
                        FROM Books b
                        LEFT JOIN BookGenres bg ON b.BookID = bg.BookID
                        LEFT JOIN Genres g ON bg.GenreID = g.GenreID
                        LEFT JOIN Rentals rt ON b.BookID = rt.BookID
                        LEFT JOIN Users u ON rt.UserID = u.UserID
                        WHERE b.IsDeleted = 0
                        GROUP BY b.BookID, b.Title, b.Author, b.Publisher, b.ReleaseDate, 
                                 b.Description, b.TotalQuantity, b.AvailableQuantity, 
                                 b.CoverImageFileName, b.CreatedAt,
                                 u.UserStatus, rt.RentalStatus
                        ORDER BY b.BookID DESC;";

                    cachedBooks = DatabaseHelper.ExecuteQuery(query);
                }

                DataTable filteredTable = cachedBooks.Copy();
                ApplyFilters(ref filteredTable);

                manageBooksPanel.Controls.Clear();

                if (filteredTable.Rows.Count == 0)
                {
                    totalPages = 1;
                    prevBtn.Enabled = false;
                    nextBtn.Enabled = false;
                    return;
                }

                totalPages = (int)Math.Ceiling(filteredTable.Rows.Count / (double)pageSize);
                if (currentPage > totalPages) currentPage = totalPages;

                int startIndex = (currentPage - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, filteredTable.Rows.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    DataRow row = filteredTable.Rows[i];
                    ManageBooksCard card = new ManageBooksCard
                    {
                        BookID = Convert.ToInt32(row["BookID"]),
                        Title = row["Title"].ToString(),
                        Author = row["Author"].ToString(),
                        Publisher = row["Publisher"].ToString(),
                        ReleaseDate = row["ReleaseDate"] == DBNull.Value ? "" : Convert.ToDateTime(row["ReleaseDate"]).ToString("MMMM dd, yyyy"),
                        Genres = row["Genres"]?.ToString(),
                        Quantity = $"{row["AvailableQuantity"]}/{row["TotalQuantity"]}",
                        Status = (Convert.ToInt32(row["AvailableQuantity"]) > 0) ? "Available" : "Out of Stock",
                        DateAdded = Convert.ToDateTime(row["CreatedAt"]).ToString("MMMM dd, yyyy"),
                        CoverFileName = row["CoverImageFileName"] == DBNull.Value ? null : row["CoverImageFileName"].ToString()
                    };

                    manageBooksPanel.Controls.Add(card);
                }

                prevBtn.Enabled = currentPage > 1;
                nextBtn.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error");
            }
        }

        private void ApplyFilters(ref DataTable filteredTable)
        {
            var rows = filteredTable.AsEnumerable();

            // 🔍 Search
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

            // 📅 Date sort
            var dateSelection = dateBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(dateSelection))
            {
                if (dateSelection.Equals("Newest to Oldest", StringComparison.OrdinalIgnoreCase))
                    rows = rows.OrderByDescending(r => Convert.ToDateTime(r["CreatedAt"]));
                else if (dateSelection.Equals("Oldest to Newest", StringComparison.OrdinalIgnoreCase))
                    rows = rows.OrderBy(r => Convert.ToDateTime(r["CreatedAt"]));
            }

            // ✅ User Status
            if (expiredBox.Checked)
                rows = rows.Where(r => (r["UserStatus"]?.ToString() ?? "").Equals("Expired", StringComparison.OrdinalIgnoreCase));
            if (activeBox.Checked)
                rows = rows.Where(r => (r["UserStatus"]?.ToString() ?? "").Equals("Active", StringComparison.OrdinalIgnoreCase));
            if (inactiveBox.Checked)
                rows = rows.Where(r => (r["UserStatus"]?.ToString() ?? "").Equals("Inactive", StringComparison.OrdinalIgnoreCase));

            // 📖 Availability
            if (availableBox.Checked)
                rows = rows.Where(r => (r["RentalStatus"]?.ToString() ?? "").Equals("Available", StringComparison.OrdinalIgnoreCase));
            if (rentedBox.Checked)
                rows = rows.Where(r => (r["RentalStatus"]?.ToString() ?? "").Equals("Rented", StringComparison.OrdinalIgnoreCase));
            if (overdueBox.Checked)
                rows = rows.Where(r => (r["RentalStatus"]?.ToString() ?? "").Equals("Overdue", StringComparison.OrdinalIgnoreCase));
            if (archivedBox.Checked)
                rows = rows.Where(r => (r["RentalStatus"]?.ToString() ?? "").Equals("Archived", StringComparison.OrdinalIgnoreCase));

            // 🎭 Genres
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
            {
                selectedGenres.Remove(genre);
                SetGenreButtonUnselectedAppearance(btn);
            }
            else
            {
                selectedGenres.Add(genre);
                SetGenreButtonSelectedAppearance(btn);
            }

            currentPage = 1;
            LoadBooks();
        }

        private void SetGenreButtonSelectedAppearance(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = genreSelectedBackColor;
            btn.ForeColor = genreSelectedForeColor;
        }

        private void SetGenreButtonUnselectedAppearance(Button btn)
        {
            btn.FlatStyle = FlatStyle.Standard;
            btn.BackColor = genreDefaultBackColor;
            btn.ForeColor = genreDefaultForeColor;
        }

        private void ClearFiltersBtn_Click(object sender, EventArgs e)
        {
            booksSearchbar.Text = "";
            dateBox.SelectedIndex = -1;

            expiredBox.Checked = false;
            inactiveBox.Checked = false;
            activeBox.Checked = false;

            availableBox.Checked = false;
            overdueBox.Checked = false;
            rentedBox.Checked = false;
            archivedBox.Checked = false;

            selectedGenres.Clear();
            ResetAllGenreButtonsAppearance();

            currentPage = 1;
            LoadBooks();
        }

        private void ResetAllGenreButtonsAppearance()
        {
            var genreButtons = new Button[]
            {
                memoirBtn, crimeFictionBtn, romanceBtn, adventureBtn, classicsBtn,
                poetryBtn, dystopianBtn, contemporaryBtn, thrillerBtn, scifiBtn, youngAdultBtn
            };

            foreach (var b in genreButtons)
            {
                if (b != null) SetGenreButtonUnselectedAppearance(b);
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

        private void manageBooksPanel_Paint(object sender, PaintEventArgs e)
        {
        }

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
