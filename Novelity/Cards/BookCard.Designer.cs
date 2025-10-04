namespace Novelity.Cards
{
    partial class BookCard
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
            Book = new Panel();
            label12 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bookTitleLabel = new Label();
            bookAuthorLabel = new Label();
            bookGenreLabel = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            bookPictureBox = new PictureBox();
            Book.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Book
            // 
            Book.Controls.Add(label12);
            Book.Controls.Add(flowLayoutPanel1);
            Book.Controls.Add(label13);
            Book.Controls.Add(label11);
            Book.Controls.Add(label9);
            Book.Controls.Add(bookPictureBox);
            Book.Dock = DockStyle.Fill;
            Book.Location = new Point(0, 0);
            Book.Margin = new Padding(0);
            Book.Name = "Book";
            Book.Size = new Size(315, 220);
            Book.TabIndex = 4;
            Book.Click += Book_Click;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(127, 23, 52);
            label12.Dock = DockStyle.Top;
            label12.Location = new Point(2, 0);
            label12.Name = "label12";
            label12.Size = new Size(311, 2);
            label12.TabIndex = 40;
            label12.Text = "OR";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(bookTitleLabel);
            flowLayoutPanel1.Controls.Add(bookAuthorLabel);
            flowLayoutPanel1.Controls.Add(bookGenreLabel);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(141, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(166, 195);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTitleLabel.Location = new Point(0, 0);
            bookTitleLabel.Margin = new Padding(0);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(45, 28);
            bookTitleLabel.TabIndex = 14;
            bookTitleLabel.Text = "Title";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Poppins", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bookAuthorLabel.ForeColor = SystemColors.ControlText;
            bookAuthorLabel.Location = new Point(3, 28);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(53, 23);
            bookAuthorLabel.TabIndex = 13;
            bookAuthorLabel.Text = "Author";
            // 
            // bookGenreLabel
            // 
            bookGenreLabel.AutoSize = true;
            bookGenreLabel.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookGenreLabel.ForeColor = SystemColors.GrayText;
            bookGenreLabel.Location = new Point(3, 51);
            bookGenreLabel.Name = "bookGenreLabel";
            bookGenreLabel.Size = new Size(43, 19);
            bookGenreLabel.TabIndex = 13;
            bookGenreLabel.Text = "Genre";
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(127, 23, 52);
            label13.Dock = DockStyle.Bottom;
            label13.Location = new Point(2, 218);
            label13.Name = "label13";
            label13.Size = new Size(311, 2);
            label13.TabIndex = 39;
            label13.Text = "OR";
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(127, 23, 52);
            label11.Dock = DockStyle.Left;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(2, 220);
            label11.TabIndex = 37;
            label11.Text = "OR";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(127, 23, 52);
            label9.Dock = DockStyle.Right;
            label9.Location = new Point(313, 0);
            label9.Name = "label9";
            label9.Size = new Size(2, 220);
            label9.TabIndex = 36;
            label9.Text = "OR";
            // 
            // bookPictureBox
            // 
            bookPictureBox.Image = Properties.Resources.the_monkey_s_paw;
            bookPictureBox.Location = new Point(12, 14);
            bookPictureBox.Name = "bookPictureBox";
            bookPictureBox.Size = new Size(123, 194);
            bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            bookPictureBox.TabIndex = 10;
            bookPictureBox.TabStop = false;
            // 
            // BookCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Book);
            Margin = new Padding(0);
            Name = "BookCard";
            Size = new Size(315, 220);
            Click += BookCard_Click;
            Book.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Book;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label9;
        private PictureBox bookPictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label bookTitleLabel;
        private Label bookAuthorLabel;
        private Label bookGenreLabel;
    }
}
