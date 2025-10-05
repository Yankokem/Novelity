using Novelity; // for Form1
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

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
            WireChildControlClicks(this);
        }

        private void WireChildControlClicks(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += Book_Click;
                if (c.HasChildren)
                    WireChildControlClicks(c);
            }
        }

        public int BookID { get; set; }
        public string Title { get => bookTitleLabel.Text; set => bookTitleLabel.Text = value; }
        public string Author { get => bookAuthorLabel.Text; set => bookAuthorLabel.Text = value; }
        public string Genres { get => bookGenreLabel.Text; set => bookGenreLabel.Text = value; }

        public string CoverFileName
        {
            get => _coverFileName;
            set { _coverFileName = value; LoadCoverImage(); }
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
                    else bookPictureBox.Image = null;
                }
                else bookPictureBox.Image = null;
            }
            catch { bookPictureBox.Image = null; }
        }

        // 🔴 NEW: status-driven panel color
        public string Status
        {
            set
            {
                Color defaultColor = Color.FromArgb(127, 23, 52);
                Color rentedColor = Color.FromArgb(245, 156, 13);

                Color finalColor = defaultColor;
                if (!string.IsNullOrEmpty(value) &&
                    value.Trim().Equals("Rented", StringComparison.OrdinalIgnoreCase))
                {
                    finalColor = rentedColor;
                }

                // assume you have panels named leftPanel, rightPanel, topPanel, bottomPanel
                left.BackColor = finalColor;
                right.BackColor = finalColor;
                top.BackColor = finalColor;
                bottom.BackColor = finalColor;
            }
        }

        private void Book_Click(object sender, EventArgs e)
        {
            try
            {
                var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (mainForm != null)
                    mainForm.LoadForm(new Novelity.Pages.Client.BookInfo(BookID));
                else
                {
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

        private void BookCard_Click(object sender, EventArgs e) { }
    }
}
