using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace Novelity.Modals
{
    public partial class CreateBook : Form
    {
        private string selectedImageFileName = null; // store chosen file name

        public CreateBook()
        {
            InitializeComponent();
            LoadGenres();
            LoadPublishers();
        }

        // ----------------- Utilities -----------------
        private IEnumerable<T> GetAllControlsOfType<T>(Control parent) where T : Control
        {
            foreach (Control c in parent.Controls)
            {
                if (c is T t) yield return t;
                foreach (var child in GetAllControlsOfType<T>(c))
                    yield return child;
            }
        }

        private string NormalizeText(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            var chars = s.ToLower().Where(char.IsLetterOrDigit).ToArray();
            return new string(chars);
        }

        // ----------------- Load / map genres -----------------
        private void LoadGenres()
        {
            try
            {
                UncheckAllGenreCheckboxes();

                string query = "SELECT GenreID, GenreName FROM Genres WHERE IsDeleted = 0 ORDER BY GenreName";
                DataTable genres = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in genres.Rows)
                {
                    string genreName = row["GenreName"].ToString();
                    int genreId = Convert.ToInt32(row["GenreID"]);

                    // Try mapping by explicit function first
                    CheckBox correspondingCheckbox = GetCheckboxByGenreName(genreName);

                    // If not found, attempt robust fallback by matching checkbox Text/Name
                    if (correspondingCheckbox == null)
                    {
                        string normalizedGenre = NormalizeText(genreName);
                        correspondingCheckbox = GetAllControlsOfType<CheckBox>(this)
                            .FirstOrDefault(cb =>
                            {
                                string cbTextNorm = NormalizeText(cb.Text);
                                string cbNameNorm = NormalizeText(cb.Name);
                                return !string.IsNullOrEmpty(cbTextNorm) &&
                                       (cbTextNorm == normalizedGenre ||
                                        cbTextNorm.Contains(normalizedGenre) ||
                                        normalizedGenre.Contains(cbTextNorm) ||
                                        cbNameNorm == normalizedGenre ||
                                        cbNameNorm.Contains(normalizedGenre));
                            });
                    }

                    if (correspondingCheckbox != null)
                    {
                        correspondingCheckbox.Tag = genreId;         // store GenreID in Tag
                        correspondingCheckbox.Enabled = true;
                        correspondingCheckbox.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note: Using default genres. " + ex.Message, "Info");
                EnableAllGenreCheckboxes();
            }
        }

        private void UncheckAllGenreCheckboxes()
        {
            var genreCheckboxes = GetAllControlsOfType<CheckBox>(this)
                .Where(cb => cb.Name != null && cb.Name.ToLower().StartsWith("check"))
                .ToList();

            foreach (var checkbox in genreCheckboxes)
            {
                checkbox.Checked = false;
                checkbox.Enabled = false;
                checkbox.Visible = false;
                checkbox.Tag = null;
            }
        }

        private void EnableAllGenreCheckboxes()
        {
            var genreCheckboxes = GetAllControlsOfType<CheckBox>(this)
                .Where(cb => cb.Name != null && cb.Name.ToLower().StartsWith("check"))
                .ToList();

            foreach (var checkbox in genreCheckboxes)
            {
                checkbox.Enabled = true;
                checkbox.Visible = true;
            }
        }

        private CheckBox GetCheckboxByGenreName(string genreName)
        {
            // direct mapping from known names to designer checkbox fields (if you have them)
            // keep this as-is for faster mapping
            return genreName.ToLower() switch
            {
                "fantasy" => checkFantasy,
                "science fiction" => checkSF,
                "sf" => checkSF,
                "mystery" => checkMystery,
                "thriller" => checkThriller,
                "horror" => checkHorror,
                "romance" => checkRomance,
                "historical fiction" => checkHF,
                "hf" => checkHF,
                "adventure" => checkAdventure,
                "young adult" => checkYA,
                "ya" => checkYA,
                "children's literature" => checkCL,
                "childrens literature" => checkCL,
                "cl" => checkCL,
                "non-fiction" => checkNF,
                "non fiction" => checkNF,
                "nf" => checkNF,
                "biography" => checkBiography,
                "autobiography" => checkBiography,
                "self-help" => checkSH,
                "self help" => checkSH,
                "sh" => checkSH,
                "poetry" => checkPoetry,
                "classics" => checkClassics,
                "dystopian" => checkDystopian,
                "graphic novels" => checkComics,
                "comics" => checkComics,
                "contemporary fiction" => checkContempFiction,
                "crime fiction" => checkCrimeFiction,
                "memoir" => checkMemoir,
                _ => null
            };
        }

        // ----------------- Publishers / close -----------------
        private void LoadPublishers()
        {
            try
            {
                // If you have a Publishers table, use it to populate an autocomplete for the publisher textbox.
                string query = "SELECT PublisherName FROM Publishers WHERE IsDeleted = 0 ORDER BY PublisherName";
                DataTable publishers = DatabaseHelper.ExecuteQuery(query);

                if (publishers.Rows.Count > 0)
                {
                    AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
                    foreach (DataRow r in publishers.Rows)
                    {
                        string name = r["PublisherName"]?.ToString();
                        if (!string.IsNullOrWhiteSpace(name))
                            ac.Add(name);
                    }

                    // addPublisherField is a TextBox — set autocomplete
                    addPublisherField.AutoCompleteCustomSource = ac;
                    addPublisherField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    addPublisherField.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch
            {
                // Publishers table might not exist — that's OK, fallback to free-text publisher textbox
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ----------------- Add book flow -----------------
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                CreateNewBook();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(addTitleField.Text) ||
                string.IsNullOrEmpty(addAuthorField.Text) ||
                string.IsNullOrEmpty(addPublisherField.Text) ||
                string.IsNullOrEmpty(addCopiesField.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error");
                return false;
            }

            if (!int.TryParse(addCopiesField.Text, out int copies) || copies <= 0)
            {
                MessageBox.Show("Please enter a valid number of copies.", "Error");
                return false;
            }

            if (addReleaseDate.Value > DateTime.Today)
            {
                MessageBox.Show("Release date cannot be in the future.", "Error");
                return false;
            }

            if (GetSelectedGenreIDs().Count == 0)
            {
                MessageBox.Show("Please select at least one genre.", "Error");
                return false;
            }

            return true;
        }

        private List<int> GetSelectedGenreIDs()
        {
            var selected = new List<int>();

            var genreCheckboxes = GetAllControlsOfType<CheckBox>(this)
                .Where(cb => cb.Name != null && cb.Name.ToLower().StartsWith("check") && cb.Checked)
                .ToList();

            foreach (var checkbox in genreCheckboxes)
            {
                if (checkbox.Tag != null && int.TryParse(checkbox.Tag.ToString(), out int gid))
                {
                    selected.Add(gid);
                }
                else
                {
                    // Try to resolve genre id by matching checkbox text to Genres table as fallback
                    string cbText = checkbox.Text?.Trim();
                    if (!string.IsNullOrEmpty(cbText))
                    {
                        string q = "SELECT GenreID FROM Genres WHERE REPLACE(LOWER(GenreName), ' ', '') = @g OR LOWER(GenreName) = @gRaw";
                        SqlParameter[] p = {
                            new SqlParameter("@g", NormalizeText(cbText)),
                            new SqlParameter("@gRaw", cbText.ToLower())
                        };
                        object sc = DatabaseHelper.ExecuteScalar(q, p);
                        if (sc != null && sc != DBNull.Value)
                        {
                            selected.Add(Convert.ToInt32(Convert.ToDecimal(sc)));
                        }
                    }
                }
            }

            return selected.Distinct().ToList();
        }

        private void CreateNewBook()
        {
            try
            {
                string title = addTitleField.Text.Trim();
                string author = addAuthorField.Text.Trim();
                string publisher = addPublisherField.Text.Trim(); // TEXTBOX: use Text
                DateTime releaseDate = addReleaseDate.Value;
                string description = addDescriptionField.Text.Trim();
                int totalQuantity = int.Parse(addCopiesField.Text);
                var selectedGenreIDs = GetSelectedGenreIDs();

                if (BookExists(title, author))
                {
                    MessageBox.Show("A book with this title and author already exists.", "Error");
                    return;
                }

                string query = @"
                    INSERT INTO Books (Title, Author, Publisher, ReleaseDate, Description, TotalQuantity, AvailableQuantity, CoverImageFileName, IsDeleted)
                    VALUES (@Title, @Author, @Publisher, @ReleaseDate, @Description, @TotalQuantity, @AvailableQuantity, @CoverImageFileName, 0);
                    SELECT SCOPE_IDENTITY();";

                SqlParameter[] parameters = {
                    new SqlParameter("@Title", title),
                    new SqlParameter("@Author", author),
                    new SqlParameter("@Publisher", string.IsNullOrEmpty(publisher) ? (object)DBNull.Value : publisher),
                    new SqlParameter("@ReleaseDate", releaseDate),
                    new SqlParameter("@Description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description),
                    new SqlParameter("@TotalQuantity", totalQuantity),
                    new SqlParameter("@AvailableQuantity", totalQuantity),
                    new SqlParameter("@CoverImageFileName", string.IsNullOrEmpty(selectedImageFileName) ? (object)DBNull.Value : selectedImageFileName)
                };

                object result = DatabaseHelper.ExecuteScalar(query, parameters);
                if (result == null || result == DBNull.Value)
                {
                    MessageBox.Show("Failed to insert book (no ID returned).", "Error");
                    return;
                }

                int newBookId = Convert.ToInt32(Convert.ToDecimal(result));

                // Insert into BookGenres (use parameterized queries)
                foreach (int genreId in selectedGenreIDs)
                {
                    string genreQuery = "INSERT INTO BookGenres (BookID, GenreID) VALUES (@BookID, @GenreID)";
                    SqlParameter[] genreParams = {
                        new SqlParameter("@BookID", newBookId),
                        new SqlParameter("@GenreID", genreId)
                    };
                    DatabaseHelper.ExecuteNonQuery(genreQuery, genreParams);
                }

                MessageBox.Show("Book added successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message, "Error");
            }
        }

        private bool BookExists(string title, string author)
        {
            string query = "SELECT COUNT(*) FROM Books WHERE Title = @Title AND Author = @Author AND IsDeleted = 0";
            SqlParameter[] parameters = {
                new SqlParameter("@Title", title),
                new SqlParameter("@Author", author)
            };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0;
        }

        // --- Add Image button ---
        private void addImageBtn_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Book covers path not configured. Please check App.config.", "Error");
                        return;
                    }

                    if (!Directory.Exists(targetFolder))
                    {
                        // create folder automatically
                        Directory.CreateDirectory(targetFolder);
                    }

                    string destPath = Path.Combine(targetFolder, fileName);
                    File.Copy(sourcePath, destPath, true);

                    selectedImageFileName = fileName;
                    imageLabel.Text = $"Selected: {fileName}";
                }
            }
        }
    }
}
