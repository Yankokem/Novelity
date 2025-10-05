namespace Novelity.Cards
{
    partial class ManageBooksCard
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
            accountProfile = new Panel();
            bookIdLabel = new Label();
            dateAddedLabel = new Label();
            panel2 = new Panel();
            quantityLabel = new Label();
            label8 = new Label();
            releaseDateLabel = new Label();
            bookCoverImg = new PictureBox();
            publisherLabel = new Label();
            panel1 = new Panel();
            conditionLabel = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            archiveBookBtn = new Button();
            editBookBtn = new Button();
            panel5 = new Panel();
            statusPanel = new Panel();
            overdueIcon = new PictureBox();
            label16 = new Label();
            archivedIcon = new PictureBox();
            availableIcon = new PictureBox();
            rentedIcon = new PictureBox();
            borrowersPanel = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            closeBtn = new PictureBox();
            dateBarrowedLabel = new Label();
            usernameLabel = new Label();
            pictureBox1 = new PictureBox();
            genreLabel = new Label();
            authorLabel = new Label();
            titleLabel = new Label();
            accountProfile.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookCoverImg).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overdueIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)archivedIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availableIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentedIcon).BeginInit();
            borrowersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // accountProfile
            // 
            accountProfile.Controls.Add(bookIdLabel);
            accountProfile.Controls.Add(dateAddedLabel);
            accountProfile.Controls.Add(panel2);
            accountProfile.Controls.Add(releaseDateLabel);
            accountProfile.Controls.Add(bookCoverImg);
            accountProfile.Controls.Add(publisherLabel);
            accountProfile.Controls.Add(panel1);
            accountProfile.Controls.Add(label4);
            accountProfile.Controls.Add(label3);
            accountProfile.Controls.Add(label2);
            accountProfile.Controls.Add(label1);
            accountProfile.Controls.Add(archiveBookBtn);
            accountProfile.Controls.Add(editBookBtn);
            accountProfile.Controls.Add(panel5);
            accountProfile.Controls.Add(genreLabel);
            accountProfile.Controls.Add(authorLabel);
            accountProfile.Controls.Add(titleLabel);
            accountProfile.Dock = DockStyle.Fill;
            accountProfile.Location = new Point(0, 0);
            accountProfile.Name = "accountProfile";
            accountProfile.Size = new Size(929, 160);
            accountProfile.TabIndex = 35;
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookIdLabel.Location = new Point(892, 16);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new Size(21, 21);
            bookIdLabel.TabIndex = 45;
            bookIdLabel.Text = "ID";
            bookIdLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // dateAddedLabel
            // 
            dateAddedLabel.AutoSize = true;
            dateAddedLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateAddedLabel.Location = new Point(834, 124);
            dateAddedLabel.Name = "dateAddedLabel";
            dateAddedLabel.Size = new Size(79, 21);
            dateAddedLabel.TabIndex = 44;
            dateAddedLabel.Text = "date added";
            dateAddedLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(quantityLabel);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(470, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 66);
            panel2.TabIndex = 7;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(27, 34);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(64, 23);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "quantity";
            quantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(127, 23, 52);
            label8.Location = new Point(20, 2);
            label8.Name = "label8";
            label8.Size = new Size(81, 28);
            label8.TabIndex = 4;
            label8.Text = "Quantity";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            releaseDateLabel.Location = new Point(131, 98);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(85, 21);
            releaseDateLabel.TabIndex = 41;
            releaseDateLabel.Text = "Release Date";
            // 
            // bookCoverImg
            // 
            bookCoverImg.Image = Properties.Resources._1;
            bookCoverImg.Location = new Point(17, 16);
            bookCoverImg.Name = "bookCoverImg";
            bookCoverImg.Size = new Size(108, 129);
            bookCoverImg.SizeMode = PictureBoxSizeMode.Zoom;
            bookCoverImg.TabIndex = 40;
            bookCoverImg.TabStop = false;
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publisherLabel.Location = new Point(131, 71);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(64, 21);
            publisherLabel.TabIndex = 39;
            publisherLabel.Text = "Publisher";
            // 
            // panel1
            // 
            panel1.Controls.Add(conditionLabel);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(323, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(122, 66);
            panel1.TabIndex = 6;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conditionLabel.Location = new Point(33, 34);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(49, 23);
            conditionLabel.TabIndex = 5;
            conditionLabel.Text = "rating";
            conditionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(127, 23, 52);
            label6.Location = new Point(25, 3);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 4;
            label6.Text = "Rating";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(127, 23, 52);
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(2, 158);
            label4.Name = "label4";
            label4.Size = new Size(925, 2);
            label4.TabIndex = 38;
            label4.Text = "OR";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(127, 23, 52);
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(2, 0);
            label3.Name = "label3";
            label3.Size = new Size(925, 2);
            label3.TabIndex = 37;
            label3.Text = "OR";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(127, 23, 52);
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(2, 160);
            label2.TabIndex = 36;
            label2.Text = "OR";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(127, 23, 52);
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(927, 0);
            label1.Name = "label1";
            label1.Size = new Size(2, 160);
            label1.TabIndex = 35;
            label1.Text = "OR";
            // 
            // archiveBookBtn
            // 
            archiveBookBtn.BackColor = Color.FromArgb(127, 23, 52);
            archiveBookBtn.FlatStyle = FlatStyle.Flat;
            archiveBookBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archiveBookBtn.ForeColor = Color.Transparent;
            archiveBookBtn.Location = new Point(808, 84);
            archiveBookBtn.Name = "archiveBookBtn";
            archiveBookBtn.Size = new Size(105, 35);
            archiveBookBtn.TabIndex = 10;
            archiveBookBtn.Text = "Archive";
            archiveBookBtn.UseVisualStyleBackColor = false;
            archiveBookBtn.Click += archiveBookBtn_Click;
            // 
            // editBookBtn
            // 
            editBookBtn.BackColor = Color.FromArgb(127, 23, 52);
            editBookBtn.FlatStyle = FlatStyle.Flat;
            editBookBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBookBtn.ForeColor = Color.Transparent;
            editBookBtn.Location = new Point(808, 40);
            editBookBtn.Name = "editBookBtn";
            editBookBtn.Size = new Size(105, 35);
            editBookBtn.TabIndex = 9;
            editBookBtn.Text = "Edit";
            editBookBtn.UseVisualStyleBackColor = false;
            editBookBtn.Click += editBookBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(statusPanel);
            panel5.Controls.Add(borrowersPanel);
            panel5.Location = new Point(614, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(171, 148);
            panel5.TabIndex = 7;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(overdueIcon);
            statusPanel.Controls.Add(label16);
            statusPanel.Controls.Add(archivedIcon);
            statusPanel.Controls.Add(availableIcon);
            statusPanel.Controls.Add(rentedIcon);
            statusPanel.Location = new Point(9, 6);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(154, 63);
            statusPanel.TabIndex = 48;
            // 
            // overdueIcon
            // 
            overdueIcon.BackColor = Color.Transparent;
            overdueIcon.Image = Properties.Resources.overdue;
            overdueIcon.Location = new Point(29, 25);
            overdueIcon.Name = "overdueIcon";
            overdueIcon.Size = new Size(92, 31);
            overdueIcon.SizeMode = PictureBoxSizeMode.Zoom;
            overdueIcon.TabIndex = 49;
            overdueIcon.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(127, 23, 52);
            label16.Location = new Point(42, -3);
            label16.Name = "label16";
            label16.Size = new Size(62, 28);
            label16.TabIndex = 4;
            label16.Text = "Status";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // archivedIcon
            // 
            archivedIcon.BackColor = Color.Transparent;
            archivedIcon.Image = Properties.Resources.archive;
            archivedIcon.Location = new Point(29, 25);
            archivedIcon.Name = "archivedIcon";
            archivedIcon.Size = new Size(92, 31);
            archivedIcon.SizeMode = PictureBoxSizeMode.Zoom;
            archivedIcon.TabIndex = 47;
            archivedIcon.TabStop = false;
            // 
            // availableIcon
            // 
            availableIcon.BackColor = Color.Transparent;
            availableIcon.Image = Properties.Resources.available;
            availableIcon.Location = new Point(29, 25);
            availableIcon.Name = "availableIcon";
            availableIcon.Size = new Size(92, 31);
            availableIcon.SizeMode = PictureBoxSizeMode.Zoom;
            availableIcon.TabIndex = 48;
            availableIcon.TabStop = false;
            // 
            // rentedIcon
            // 
            rentedIcon.BackColor = Color.Transparent;
            rentedIcon.Image = Properties.Resources.rented;
            rentedIcon.Location = new Point(29, 25);
            rentedIcon.Name = "rentedIcon";
            rentedIcon.Size = new Size(92, 31);
            rentedIcon.SizeMode = PictureBoxSizeMode.Zoom;
            rentedIcon.TabIndex = 48;
            rentedIcon.TabStop = false;
            // 
            // borrowersPanel
            // 
            borrowersPanel.Controls.Add(label5);
            borrowersPanel.Controls.Add(pictureBox2);
            borrowersPanel.Controls.Add(closeBtn);
            borrowersPanel.Controls.Add(dateBarrowedLabel);
            borrowersPanel.Controls.Add(usernameLabel);
            borrowersPanel.Controls.Add(pictureBox1);
            borrowersPanel.Location = new Point(9, 65);
            borrowersPanel.Name = "borrowersPanel";
            borrowersPanel.Size = new Size(154, 77);
            borrowersPanel.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 55);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 49;
            label5.Text = "return date";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.calendar___red;
            pictureBox2.Location = new Point(6, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.Image = Properties.Resources.pfp_v1___red;
            closeBtn.Location = new Point(6, 5);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(20, 20);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 42;
            closeBtn.TabStop = false;
            // 
            // dateBarrowedLabel
            // 
            dateBarrowedLabel.AutoSize = true;
            dateBarrowedLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBarrowedLabel.Location = new Point(32, 30);
            dateBarrowedLabel.Name = "dateBarrowedLabel";
            dateBarrowedLabel.Size = new Size(97, 21);
            dateBarrowedLabel.TabIndex = 47;
            dateBarrowedLabel.Text = "date borrowed";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(32, 6);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(70, 21);
            usernameLabel.TabIndex = 46;
            usernameLabel.Text = "username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.calendar___red;
            pictureBox1.Location = new Point(6, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genreLabel.Location = new Point(131, 124);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(45, 21);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "Genre";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorLabel.Location = new Point(131, 44);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(53, 23);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Author";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(131, 16);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(45, 28);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // ManageBooksCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(accountProfile);
            Name = "ManageBooksCard";
            Size = new Size(929, 160);
            accountProfile.ResumeLayout(false);
            accountProfile.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookCoverImg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)overdueIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)archivedIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)availableIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentedIcon).EndInit();
            borrowersPanel.ResumeLayout(false);
            borrowersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel accountProfile;
        private Label publisherLabel;
        private Panel panel1;
        private Label conditionLabel;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button archiveBookBtn;
        private Button editBookBtn;
        private Panel panel5;
        private Label label16;
        private Label genreLabel;
        private Label authorLabel;
        private Label titleLabel;
        private PictureBox bookCoverImg;
        private Label releaseDateLabel;
        private Panel panel2;
        private Label quantityLabel;
        private Label label8;
        private PictureBox closeBtn;
        private PictureBox pictureBox1;
        private Label dateAddedLabel;
        private Label dateBarrowedLabel;
        private Label usernameLabel;
        private Label bookIdLabel;
        private Panel borrowersPanel;
        private Panel statusPanel;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox archivedIcon;
        private PictureBox rentedIcon;
        private PictureBox overdueIcon;
        private PictureBox availableIcon;
    }
}
