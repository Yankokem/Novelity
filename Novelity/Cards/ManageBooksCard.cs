using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Novelity.Cards
{
    public partial class ManageBooksCard : UserControl
    {
        public ManageBooksCard()
        {
            InitializeComponent();
            this.Margin = new Padding(0, 0, 0, 10); // bottom margin
        }

        private int _bookId;
        public int BookID
        {
            get => _bookId;
            set
            {
                _bookId = value;
                bookIdLabel.Text = value.ToString();
            }
        }

        // Public setters for the card fields
        public string Title { set => titleLabel.Text = value; }
        public string Author { set => authorLabel.Text = value; }
        public string Publisher { set => publisherLabel.Text = value; }
        public string ReleaseDate { set => releaseDateLabel.Text = value; }
        public string Genres { set => genreLabel.Text = value; }
        public string Quantity { set => quantityLabel.Text = value; }
        public string DateAdded { set => dateAddedLabel.Text = value; }

        public string CoverFileName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string coversPath = ConfigurationManager.AppSettings["BookCoversPath"] ?? "";
                    string fullPath = Path.Combine(coversPath, value);
                    if (File.Exists(fullPath))
                    {
                        try
                        {
                            bookCoverImg.Image = Image.FromFile(fullPath);
                            bookCoverImg.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch { bookCoverImg.Image = null; }
                    }
                    else
                    {
                        bookCoverImg.Image = null;
                    }
                }
                else
                {
                    bookCoverImg.Image = null;
                }
            }
        }

        // status icons & panels behavior (kept as you had it before)
        public string Status
        {
            set
            {
                // hide all icons first
                availableIcon.Visible = rentedIcon.Visible = archivedIcon.Visible = overdueIcon.Visible = false;
                borrowersPanel.Visible = true;
                statusPanel.Visible = true;
                statusPanel.Location = new Point(9, 6);

                if (string.IsNullOrEmpty(value))
                {
                    availableIcon.Visible = true;
                    borrowersPanel.Visible = false;
                    statusPanel.Location = new Point(9, 44);
                    return;
                }

                switch (value.Trim().ToLower())
                {
                    case "available":
                        availableIcon.Visible = true;
                        borrowersPanel.Visible = false;
                        statusPanel.Location = new Point(9, 44);
                        break;
                    case "rented":
                        rentedIcon.Visible = true;
                        break;
                    case "pending":
                        // pending == there are reservations — treat visually similar to rented
                        rentedIcon.Visible = true;
                        break;
                    case "out of stock":
                        // no available copies - show archived-style (grayed) icon
                        archivedIcon.Visible = true;
                        borrowersPanel.Visible = false;
                        statusPanel.Location = new Point(9, 44);
                        break;
                    case "overdue":
                        overdueIcon.Visible = true;
                        break;
                    case "archived":
                    case "inactive":
                        archivedIcon.Visible = true;
                        borrowersPanel.Visible = false;
                        statusPanel.Location = new Point(9, 44);
                        break;
                    default:
                        availableIcon.Visible = true;
                        borrowersPanel.Visible = false;
                        statusPanel.Location = new Point(9, 44);
                        break;
                }
            }
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var modal = new Novelity.Modals.EditBook(this.BookID))
                {
                    var form = this.FindForm() as Novelity.Pages.Admin.ManageBooks;
                    if (modal.ShowDialog() == DialogResult.OK)
                    {
                        // ask parent to reload books
                        form?.RefreshBooks();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening edit modal: " + ex.Message, "Error");
            }
        }

        private void archiveBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string checkQuery = "SELECT IsDeleted FROM Books WHERE BookID = @BookID";
                SqlParameter[] checkParams = { new SqlParameter("@BookID", _bookId) };
                object sc = DatabaseHelper.ExecuteScalar(checkQuery, checkParams);
                bool isDeleted = sc != null && sc != DBNull.Value && Convert.ToBoolean(sc);

                string action = isDeleted ? "unarchive" : "archive";
                string confirmMsg = isDeleted ? "Are you sure you want to unarchive this book?" : "Are you sure you want to archive this book?";

                if (MessageBox.Show(confirmMsg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE Books SET IsDeleted = @NewStatus WHERE BookID = @BookID";
                    SqlParameter[] updateParams = {
                        new SqlParameter("@NewStatus", isDeleted ? 0 : 1),
                        new SqlParameter("@BookID", _bookId)
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Book {action}d successfully!", "Success");
                        var form = this.FindForm() as Novelity.Pages.Admin.ManageBooks;
                        form?.RefreshBooks();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to {action} book.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message, "Error");
            }
        }
    }
}
