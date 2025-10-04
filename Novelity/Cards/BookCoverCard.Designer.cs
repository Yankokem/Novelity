namespace Novelity.Cards
{
    partial class BookCoverCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCoverCard));
            bookPictureBox = new PictureBox();
            bookTitleLbl = new Label();
            bookAuthor = new Label();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // bookPictureBox
            // 
            bookPictureBox.Image = (Image)resources.GetObject("bookPictureBox.Image");
            bookPictureBox.Location = new Point(0, 0);
            bookPictureBox.Name = "bookPictureBox";
            bookPictureBox.Size = new Size(249, 276);
            bookPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bookPictureBox.TabIndex = 0;
            bookPictureBox.TabStop = false;
            // 
            // bookTitleLbl
            // 
            bookTitleLbl.AutoSize = true;
            bookTitleLbl.BackColor = Color.Transparent;
            bookTitleLbl.Font = new Font("Poppins", 13F);
            bookTitleLbl.ForeColor = Color.Black;
            bookTitleLbl.Location = new Point(2, 279);
            bookTitleLbl.Name = "bookTitleLbl";
            bookTitleLbl.Size = new Size(231, 31);
            bookTitleLbl.TabIndex = 6;
            bookTitleLbl.Text = "Les amants du Spoutnik";
            bookTitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookAuthor
            // 
            bookAuthor.AutoSize = true;
            bookAuthor.BackColor = Color.Transparent;
            bookAuthor.Font = new Font("Poppins", 10F);
            bookAuthor.ForeColor = Color.Black;
            bookAuthor.Location = new Point(3, 300);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(127, 25);
            bookAuthor.TabIndex = 7;
            bookAuthor.Text = "Haruki Murakami";
            bookAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookCoverCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bookAuthor);
            Controls.Add(bookTitleLbl);
            Controls.Add(bookPictureBox);
            Name = "BookCoverCard";
            Size = new Size(245, 327);
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bookPictureBox;
        private Label bookTitleLbl;
        private Label bookAuthor;
    }
}
