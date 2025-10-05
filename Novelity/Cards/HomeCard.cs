using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Novelity.Cards
{
    public partial class HomeCard : UserControl
    {
        private string _coverFileName;

        public HomeCard()
        {
            InitializeComponent();
        }

        // Properties
        public string Title
        {
            set => titleLabel.Text = value;
        }

        public string Author
        {
            set => authorLabel.Text = value;
        }

        public string CoverFileName
        {
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
                        bookCover.Image = Image.FromFile(fullPath);
                        bookCover.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        bookCover.Image = null;
                    }
                }
                else
                {
                    bookCover.Image = null;
                }
            }
            catch
            {
                bookCover.Image = null;
            }
        }
    }
}
