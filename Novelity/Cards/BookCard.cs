using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Novelity; // for Form1

namespace Novelity.Cards
{
    public partial class BookCard : UserControl
    {
        private string _coverFileName;

        public BookCard()
        {
            InitializeComponent();

            // Attach click events to everything inside the card so clicking anywhere opens details
            this.Click += Book_Click;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += Book_Click;
            }

            // If there are nested child controls inside panels/containers, wire those too
            WireChildControlClicks(this);
        }

        // Recursively wire click on nested children (helps if your design nests controls)
        private void WireChildControlClicks(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += Book_Click;
                if (c.HasChildren)
                    WireChildControlClicks(c);
            }
        }

        // Properties
        public int BookID { get; set; }

        public string Title
        {
            get => bookTitleLabel.Text;
            set => bookTitleLabel.Text = value;
        }

        public string Author
        {
            get => bookAuthorLabel.Text;
            set => bookAuthorLabel.Text = value;
        }

        public string Genres
        {
            get => bookGenreLabel.Text;
            set => bookGenreLabel.Text = value;
        }

        public string CoverFileName
        {
            get => _coverFileName;
            set
            {
                _coverFileName = value;
                LoadCoverImage();
            }
        }

        private void LoadCoverImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(_coverFileName))
                {
                    string coversPath = ConfigurationManager.AppSettings["BookCoversPath"];
                    string fullPath = Path.Combine(coversPath, _coverFileName);

                    if (File.Exists(fullPath))
                    {
                        bookPictureBox.Image = Image.FromFile(fullPath);
                        bookPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        bookPictureBox.Image = null;
                    }
                }
                else
                {
                    bookPictureBox.Image = null;
                }
            }
            catch
            {
                bookPictureBox.Image = null;
            }
        }

        private void Book_Click(object sender, EventArgs e)
        {
            try
            {
                // Find the live Form1 instance in the application (works even when Books is hosted inside panelContent)
                var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.LoadForm(new Novelity.Pages.Client.BookInfo(BookID));
                }
                else
                {
                    // fallback: try TopLevelControl (rare cases)
                    var top = this.TopLevelControl as Form1;
                    if (top != null)
                        top.LoadForm(new Novelity.Pages.Client.BookInfo(BookID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open book details: " + ex.Message, "Error");
            }
        }

        // If designer wired a separate BookCard_Click event, keep it empty to avoid duplicates
        private void BookCard_Click(object sender, EventArgs e)
        {
            // intentionally left blank - all clicks handled by Book_Click
        }
    }
}
