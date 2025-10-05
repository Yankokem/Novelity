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
            top = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bookTitleLabel = new Label();
            bookAuthorLabel = new Label();
            bookGenreLabel = new Label();
            bottom = new Label();
            left = new Label();
            right = new Label();
            bookPictureBox = new PictureBox();
            Book.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Book
            // 
            Book.Controls.Add(top);
            Book.Controls.Add(flowLayoutPanel1);
            Book.Controls.Add(bottom);
            Book.Controls.Add(left);
            Book.Controls.Add(right);
            Book.Controls.Add(bookPictureBox);
            Book.Location = new Point(0, 0);
            Book.Margin = new Padding(0);
            Book.Name = "Book";
            Book.Size = new Size(315, 220);
            Book.TabIndex = 4;
            Book.Click += Book_Click;
            // 
            // top
            // 
            top.BackColor = Color.FromArgb(127, 23, 52);
            top.Dock = DockStyle.Top;
            top.Location = new Point(2, 0);
            top.Name = "top";
            top.Size = new Size(311, 2);
            top.TabIndex = 40;
            top.Text = "OR";
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
            // bottom
            // 
            bottom.BackColor = Color.FromArgb(127, 23, 52);
            bottom.Dock = DockStyle.Bottom;
            bottom.Location = new Point(2, 218);
            bottom.Name = "bottom";
            bottom.Size = new Size(311, 2);
            bottom.TabIndex = 39;
            bottom.Text = "OR";
            // 
            // left
            // 
            left.BackColor = Color.FromArgb(127, 23, 52);
            left.Dock = DockStyle.Left;
            left.Location = new Point(0, 0);
            left.Name = "left";
            left.Size = new Size(2, 220);
            left.TabIndex = 37;
            left.Text = "OR";
            // 
            // right
            // 
            right.AccessibleDescription = "right";
            right.BackColor = Color.FromArgb(127, 23, 52);
            right.Dock = DockStyle.Right;
            right.Location = new Point(313, 0);
            right.Name = "right";
            right.Size = new Size(2, 220);
            right.TabIndex = 36;
            right.Text = "OR";
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
        private Label top;
        private Label bottom;
        private Label left;
        private Label right;
        private PictureBox bookPictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label bookTitleLabel;
        private Label bookAuthorLabel;
        private Label bookGenreLabel;
    }
}
