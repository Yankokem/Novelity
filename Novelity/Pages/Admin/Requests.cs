using Novelity.Cards;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Novelity.Pages.Admin
{
    public partial class Requests : Form
    {
        private DataTable cachedRequests;
        private int currentPage = 1;
        private int pageSize = 4;
        private int totalPages = 1;

        public Requests()
        {
            InitializeComponent();

            // Hook up checkbox events
            claimedBox.CheckedChanged += (s, e) => { currentPage = 1; LoadRequests(); };
            pendingBox.CheckedChanged += (s, e) => { currentPage = 1; LoadRequests(); };
            rentedBox.CheckedChanged += (s, e) => { currentPage = 1; LoadRequests(); };
            overdueBox.CheckedChanged += (s, e) => { currentPage = 1; LoadRequests(); };
            extendedBox.CheckedChanged += (s, e) => { currentPage = 1; LoadRequests(); };
            returnedBox.CheckedChanged += (s, e) => { currentPage = 1; LoadRequests(); };
            newestToOldestBox.CheckedChanged += (s, e) => { currentPage = 1; LoadRequests(); };
            oldestToNewestBox.CheckedChanged += (s, e) => { currentPage = 1; LoadRequests(); };

            LoadRequests();
        }

        public void RefreshRequests()
        {
            currentPage = 1;
            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                requestsPanel.Controls.Clear();

                if (cachedRequests == null)
                {
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
                        WHERE r.RentalStatus IN ('Pending','Rented','Extended','Overdue','Returned')
                        ORDER BY r.DateRented DESC;";

                    cachedRequests = DatabaseHelper.ExecuteQuery(query);
                }

                if (cachedRequests.Rows.Count == 0)
                {
                    totalPages = 1;
                    prevBtn.Enabled = false;
                    nextBtn.Enabled = false;
                    return;
                }

                var rows = cachedRequests.AsEnumerable();

                // filter
                var selectedStatuses = new System.Collections.Generic.List<string>();
                if (claimedBox.Checked) selectedStatuses.Add("Claimed");
                if (pendingBox.Checked) selectedStatuses.Add("Pending");
                if (rentedBox.Checked) selectedStatuses.Add("Rented");
                if (overdueBox.Checked) selectedStatuses.Add("Overdue");
                if (extendedBox.Checked) selectedStatuses.Add("Extended");
                if (returnedBox.Checked) selectedStatuses.Add("Returned");

                if (selectedStatuses.Any())
                    rows = rows.Where(r => selectedStatuses.Contains(r["RentalStatus"].ToString(), StringComparer.OrdinalIgnoreCase));

                // sorting
                if (newestToOldestBox.Checked && !oldestToNewestBox.Checked)
                    rows = rows.OrderByDescending(r => Convert.ToDateTime(r["DateRented"]));
                else if (oldestToNewestBox.Checked && !newestToOldestBox.Checked)
                    rows = rows.OrderBy(r => Convert.ToDateTime(r["DateRented"]));
                else
                    rows = rows.OrderByDescending(r => Convert.ToDateTime(r["DateRented"]));

                var filteredTable = rows.Any() ? rows.CopyToDataTable() : cachedRequests.Clone();

                totalPages = (int)Math.Ceiling(filteredTable.Rows.Count / (double)pageSize);
                if (currentPage > totalPages) currentPage = totalPages;

                int startIndex = (currentPage - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, filteredTable.Rows.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    DataRow row = filteredTable.Rows[i];
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

                    card.Margin = new Padding(0, 0, 0, 10);
                    requestsPanel.Controls.Add(card);
                }

                prevBtn.Enabled = currentPage > 1;
                nextBtn.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadRequests();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadRequests();
            }
        }
    }
}
