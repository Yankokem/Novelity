using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Novelity.Modals
{
    public partial class EditBook : Form
    {
        private int _bookId;
        private string _existingCoverFileName = null;
        private string _selectedCoverFileName = null;
        private int _originalTotalQuantity = 0;
        private int _originalAvailableQuantity = 0;

        public EditBook(int bookId)
        {
            InitializeComponent();
            _bookId = bookId;

            // ensure click is wired up
            editImageBtn.Click += editImageBtn_Click;

            LoadBookData();
        }

        private void LoadBookData()
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
                        STRING_AGG(g.GenreName, ',') AS Genres
                    FROM Books b
                    LEFT JOIN BookGenres bg ON b.BookID = bg.BookID AND bg.IsDeleted = 0
                    LEFT JOIN Genres g ON bg.GenreID = g.GenreID AND g.IsDeleted = 0
                    WHERE b.BookID = @BookID
                    GROUP BY b.BookID, b.Title, b.Author, b.Publisher, 
                             b.ReleaseDate, b.Description, b.TotalQuantity, b.AvailableQuantity, b.CoverImageFileName;";

                SqlParameter[] parameters = { new SqlParameter("@BookID", _bookId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Book not found.", "Error");
                    this.Close();
                    return;
                }

                DataRow row = dt.Rows[0];

                editTitleField.Text = row["Title"]?.ToString() ?? "";
                editAuthorField.Text = row["Author"]?.ToString() ?? "";
                editPublisherField.Text = row["Publisher"]?.ToString() ?? "";
                editCopiesField.Text = row["TotalQuantity"]?.ToString() ?? "1";
                editDescriptionField.Text = row["Description"]?.ToString() ?? "";
                editReleaseDate.Value = row["ReleaseDate"] != DBNull.Value ? Convert.ToDateTime(row["ReleaseDate"]) : DateTime.Today;

                _originalTotalQuantity = row["TotalQuantity"] != DBNull.Value ? Convert.ToInt32(row["TotalQuantity"]) : 0;
                _originalAvailableQuantity = row["AvailableQuantity"] != DBNull.Value ? Convert.ToInt32(row["AvailableQuantity"]) : 0;

                if (row["CoverImageFileName"] != DBNull.Value)
                {
                    _existingCoverFileName = row["CoverImageFileName"].ToString();
                    editImageNameLabel.Text = _existingCoverFileName;
                }

                if (row["Genres"] != DBNull.Value)
                {
                    string[] genres = row["Genres"].ToString()
                        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(g => g.Trim()).ToArray();
                    ApplyGenres(genres);
                }
                else
                {
                    ClearAllGenreCheckboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book data: " + ex.Message, "Error");
                this.Close();
            }
        }

        private void ClearAllGenreCheckboxes()
        {
            checkFantasy.Checked = false;
            checkSF.Checked = false;
            checkMystery.Checked = false;
            checkThriller.Checked = false;
            checkHorror.Checked = false;
            checkRomance.Checked = false;
            checkHF.Checked = false;
            checkAdventure.Checked = false;
            checkYA.Checked = false;
            checkCL.Checked = false;
            checkNF.Checked = false;
            checkBiography.Checked = false;
            checkSH.Checked = false;
            checkPoetry.Checked = false;
            checkClassics.Checked = false;
            checkDystopian.Checked = false;
            checkComics.Checked = false;
            checkContempFiction.Checked = false;
            checkCrimeFiction.Checked = false;
            checkMemoir.Checked = false;
        }

        private void ApplyGenres(string[] genres)
        {
            ClearAllGenreCheckboxes();

            foreach (string g in genres)
            {
                string norm = g.Trim().ToLower();
                if (norm.Contains("fantasy")) checkFantasy.Checked = true;
                else if (norm.Contains("science fiction") || norm.Contains("sci-fi") || norm == "sf") checkSF.Checked = true;
                else if (norm.Contains("mystery")) checkMystery.Checked = true;
                else if (norm.Contains("thriller")) checkThriller.Checked = true;
                else if (norm.Contains("horror")) checkHorror.Checked = true;
                else if (norm.Contains("romance")) checkRomance.Checked = true;
                else if (norm.Contains("historical fiction") || norm == "hf") checkHF.Checked = true;
                else if (norm.Contains("adventure")) checkAdventure.Checked = true;
                else if (norm.Contains("young adult") || norm == "ya") checkYA.Checked = true;
                else if (norm.Contains("children")) checkCL.Checked = true;
                else if (norm.Contains("non-fiction") || norm == "nf") checkNF.Checked = true;
                else if (norm.Contains("biograph")) checkBiography.Checked = true;
                else if (norm.Contains("self-help") || norm == "sh") checkSH.Checked = true;
                else if (norm.Contains("poetry")) checkPoetry.Checked = true;
                else if (norm.Contains("classics")) checkClassics.Checked = true;
                else if (norm.Contains("dystopian")) checkDystopian.Checked = true;
                else if (norm.Contains("comic") || norm.Contains("graphic")) checkComics.Checked = true;
                else if (norm.Contains("contemporary")) checkContempFiction.Checked = true;
                else if (norm.Contains("crime")) checkCrimeFiction.Checked = true;
                else if (norm.Contains("memoir")) checkMemoir.Checked = true;
            }
        }

        private void editImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Title = "Select Book Cover";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = ofd.FileName;
                    string fileName = Path.GetFileName(sourcePath);

                    string targetFolder = ConfigurationManager.AppSettings["BookCoversPath"];
                    if (string.IsNullOrEmpty(targetFolder))
                    {
                        MessageBox.Show("Book covers path not configured in App.config.", "Error");
                        return;
                    }

                    if (!Directory.Exists(targetFolder))
                        Directory.CreateDirectory(targetFolder);

                    string destPath = Path.Combine(targetFolder, fileName);
                    File.Copy(sourcePath, destPath, true);

                    _selectedCoverFileName = fileName;
                    editImageNameLabel.Text = fileName;
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(editTitleField.Text) ||
                string.IsNullOrWhiteSpace(editAuthorField.Text) ||
                string.IsNullOrWhiteSpace(editCopiesField.Text))
            {
                MessageBox.Show("Please fill in title, author and copies.", "Error");
                return false;
            }

            if (!int.TryParse(editCopiesField.Text.Trim(), out int copies) || copies <= 0)
            {
                MessageBox.Show("Copies must be a positive number.", "Error");
                return false;
            }

            if (editReleaseDate.Value > DateTime.Today)
            {
                MessageBox.Show("Release date cannot be in the future.", "Error");
                return false;
            }

            return true;
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string title = editTitleField.Text.Trim();
                string author = editAuthorField.Text.Trim();
                string publisher = editPublisherField.Text.Trim();
                DateTime releaseDate = editReleaseDate.Value.Date;
                string description = editDescriptionField.Text.Trim();
                int newTotal = int.Parse(editCopiesField.Text.Trim());

                int delta = newTotal - _originalTotalQuantity;
                int newAvailable = _originalAvailableQuantity + delta;
                if (newAvailable < 0) newAvailable = 0;
                if (newAvailable > newTotal) newAvailable = newTotal;

                string finalCoverFileName = _selectedCoverFileName ?? _existingCoverFileName ?? null;

                string updateQuery = @"
                    UPDATE Books
                    SET Title = @Title,
                        Author = @Author,
                        Publisher = @Publisher,
                        ReleaseDate = @ReleaseDate,
                        Description = @Description,
                        TotalQuantity = @TotalQuantity,
                        AvailableQuantity = @AvailableQuantity,
                        CoverImageFileName = @CoverImageFileName
                    WHERE BookID = @BookID;";

                SqlParameter[] updateParams = {
                    new SqlParameter("@Title", title),
                    new SqlParameter("@Author", author),
                    new SqlParameter("@Publisher", string.IsNullOrWhiteSpace(publisher) ? (object)DBNull.Value : publisher),
                    new SqlParameter("@ReleaseDate", releaseDate),
                    new SqlParameter("@Description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description),
                    new SqlParameter("@TotalQuantity", newTotal),
                    new SqlParameter("@AvailableQuantity", newAvailable),
                    new SqlParameter("@CoverImageFileName", string.IsNullOrEmpty(finalCoverFileName) ? (object)DBNull.Value : finalCoverFileName),
                    new SqlParameter("@BookID", _bookId)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                if (rows > 0)
                {
                    MessageBox.Show("Book updated successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update book.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message, "Error");
            }
        }
    }
}
