using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace Novelity.Cards
{
    public partial class ManageBooksCard : UserControl
    {
        public ManageBooksCard()
        {
            InitializeComponent();
            this.Margin = new Padding(0, 0, 0, 10); // bottom margin
        }

        // Public setters for the card fields
        public int BookID
        {
            set => bookIdLabel.Text = value.ToString();
        }

        public string Title
        {
            set => titleLabel.Text = value;
        }

        public string Author
        {
            set => authorLabel.Text = value;
        }

        public string Publisher
        {
            set => publisherLabel.Text = value;
        }

        public string ReleaseDate
        {
            set => releaseDateLabel.Text = value;
        }

        public string Genres
        {
            set => genreLabel.Text = value;
        }

        public string Quantity
        {
            set => quantityLabel.Text = value;
        }

        public string Status
        {
            set => statusLabel.Text = value;
        }

        public string DateAdded
        {
            set => dateAddedLabel.Text = value;
        }

        public string CoverFileName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string coversPath = ConfigurationManager.AppSettings["BookCoversPath"];
                    string fullPath = Path.Combine(coversPath, value);

                    if (File.Exists(fullPath))
                    {
                        bookCoverImg.Image = Image.FromFile(fullPath);
                        bookCoverImg.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            // skip for now
        }

        private void archiveBookBtn_Click(object sender, EventArgs e)
        {
            // skip for now
        }
    }
}
