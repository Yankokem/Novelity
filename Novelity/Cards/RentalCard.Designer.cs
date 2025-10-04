namespace Novelity.Cards
{
    partial class RentalCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalCard));
            Rent_Card = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            titleRental = new Label();
            authorRental = new Label();
            genreRental = new Label();
            label2 = new Label();
            label1 = new Label();
            rentalIdRental = new Label();
            borrowersPanel = new Panel();
            daysRemainingLabel = new Label();
            check = new PictureBox();
            closeBtn = new PictureBox();
            dueDateLabel = new Label();
            rentedDateLabel = new Label();
            pictureBox1 = new PictureBox();
            statusPanel = new Panel();
            returnedIcon = new PictureBox();
            claimBookIcon = new PictureBox();
            rentingIcon = new PictureBox();
            overdueIcon = new PictureBox();
            extendedIcon = new PictureBox();
            label16 = new Label();
            extendRentalBtn = new Button();
            viewDetailsBtn = new Button();
            returnNowBtn = new Button();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            bookPictureBox = new PictureBox();
            Rent_Card.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            borrowersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)check).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnedIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claimBookIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentingIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)overdueIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)extendedIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Rent_Card
            // 
            Rent_Card.Controls.Add(flowLayoutPanel1);
            Rent_Card.Controls.Add(label2);
            Rent_Card.Controls.Add(label1);
            Rent_Card.Controls.Add(rentalIdRental);
            Rent_Card.Controls.Add(borrowersPanel);
            Rent_Card.Controls.Add(statusPanel);
            Rent_Card.Controls.Add(extendRentalBtn);
            Rent_Card.Controls.Add(viewDetailsBtn);
            Rent_Card.Controls.Add(returnNowBtn);
            Rent_Card.Controls.Add(label12);
            Rent_Card.Controls.Add(label13);
            Rent_Card.Controls.Add(label11);
            Rent_Card.Controls.Add(label9);
            Rent_Card.Controls.Add(bookPictureBox);
            Rent_Card.Location = new Point(0, 0);
            Rent_Card.Name = "Rent_Card";
            Rent_Card.Size = new Size(929, 160);
            Rent_Card.TabIndex = 36;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(titleRental);
            flowLayoutPanel1.Controls.Add(authorRental);
            flowLayoutPanel1.Controls.Add(genreRental);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(122, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 117);
            flowLayoutPanel1.TabIndex = 55;
            // 
            // titleRental
            // 
            titleRental.AutoSize = true;
            titleRental.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleRental.Location = new Point(3, 0);
            titleRental.Name = "titleRental";
            titleRental.Size = new Size(45, 28);
            titleRental.TabIndex = 49;
            titleRental.Text = "Title";
            // 
            // authorRental
            // 
            authorRental.AutoSize = true;
            authorRental.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorRental.Location = new Point(3, 28);
            authorRental.Name = "authorRental";
            authorRental.Size = new Size(53, 23);
            authorRental.TabIndex = 50;
            authorRental.Text = "Author";
            // 
            // genreRental
            // 
            genreRental.AutoSize = true;
            genreRental.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genreRental.Location = new Point(3, 51);
            genreRental.Name = "genreRental";
            genreRental.Size = new Size(45, 21);
            genreRental.TabIndex = 51;
            genreRental.Text = "Genre";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(127, 23, 52);
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(927, 2);
            label2.Name = "label2";
            label2.Size = new Size(2, 156);
            label2.TabIndex = 54;
            label2.Text = "OR";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(127, 23, 52);
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(2, 158);
            label1.Name = "label1";
            label1.Size = new Size(927, 2);
            label1.TabIndex = 53;
            label1.Text = "OR";
            // 
            // rentalIdRental
            // 
            rentalIdRental.AutoSize = true;
            rentalIdRental.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentalIdRental.Location = new Point(127, 126);
            rentalIdRental.Name = "rentalIdRental";
            rentalIdRental.Size = new Size(64, 21);
            rentalIdRental.TabIndex = 52;
            rentalIdRental.Text = "Rental ID:";
            // 
            // borrowersPanel
            // 
            borrowersPanel.Controls.Add(daysRemainingLabel);
            borrowersPanel.Controls.Add(check);
            borrowersPanel.Controls.Add(closeBtn);
            borrowersPanel.Controls.Add(dueDateLabel);
            borrowersPanel.Controls.Add(rentedDateLabel);
            borrowersPanel.Controls.Add(pictureBox1);
            borrowersPanel.Location = new Point(533, 35);
            borrowersPanel.Name = "borrowersPanel";
            borrowersPanel.Size = new Size(191, 94);
            borrowersPanel.TabIndex = 8;
            // 
            // daysRemainingLabel
            // 
            daysRemainingLabel.AutoSize = true;
            daysRemainingLabel.Font = new Font("Poppins", 9.75F);
            daysRemainingLabel.Location = new Point(32, 67);
            daysRemainingLabel.Name = "daysRemainingLabel";
            daysRemainingLabel.Size = new Size(124, 23);
            daysRemainingLabel.TabIndex = 49;
            daysRemainingLabel.Text = "7 Days Remaining";
            // 
            // check
            // 
            check.BackColor = Color.Transparent;
            check.Image = Properties.Resources.check_red;
            check.Location = new Point(6, 67);
            check.Name = "check";
            check.Size = new Size(25, 25);
            check.SizeMode = PictureBoxSizeMode.Zoom;
            check.TabIndex = 48;
            check.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.Image = Properties.Resources.calendar___red;
            closeBtn.Location = new Point(6, -1);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(25, 25);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 42;
            closeBtn.TabStop = false;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Font = new Font("Poppins", 9.75F);
            dueDateLabel.Location = new Point(32, 33);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(110, 23);
            dueDateLabel.TabIndex = 47;
            dueDateLabel.Text = "October 5, 2025";
            // 
            // rentedDateLabel
            // 
            rentedDateLabel.AutoSize = true;
            rentedDateLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentedDateLabel.Location = new Point(32, 0);
            rentedDateLabel.Name = "rentedDateLabel";
            rentedDateLabel.Size = new Size(137, 23);
            rentedDateLabel.TabIndex = 46;
            rentedDateLabel.Text = "September 29, 2025";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.back_red;
            pictureBox1.Location = new Point(6, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(returnedIcon);
            statusPanel.Controls.Add(claimBookIcon);
            statusPanel.Controls.Add(rentingIcon);
            statusPanel.Controls.Add(overdueIcon);
            statusPanel.Controls.Add(extendedIcon);
            statusPanel.Controls.Add(label16);
            statusPanel.Location = new Point(357, 48);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(139, 63);
            statusPanel.TabIndex = 48;
            // 
            // returnedIcon
            // 
            returnedIcon.BackColor = Color.Transparent;
            returnedIcon.Image = Properties.Resources.Returned;
            returnedIcon.Location = new Point(20, 25);
            returnedIcon.Name = "returnedIcon";
            returnedIcon.Size = new Size(92, 31);
            returnedIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnedIcon.TabIndex = 51;
            returnedIcon.TabStop = false;
            // 
            // claimBookIcon
            // 
            claimBookIcon.BackColor = Color.Transparent;
            claimBookIcon.Image = Properties.Resources.Claim_Book;
            claimBookIcon.Location = new Point(20, 25);
            claimBookIcon.Name = "claimBookIcon";
            claimBookIcon.Size = new Size(92, 31);
            claimBookIcon.SizeMode = PictureBoxSizeMode.Zoom;
            claimBookIcon.TabIndex = 53;
            claimBookIcon.TabStop = false;
            // 
            // rentingIcon
            // 
            rentingIcon.BackColor = Color.Transparent;
            rentingIcon.Image = Properties.Resources.Renting1;
            rentingIcon.Location = new Point(20, 25);
            rentingIcon.Name = "rentingIcon";
            rentingIcon.Size = new Size(92, 31);
            rentingIcon.SizeMode = PictureBoxSizeMode.Zoom;
            rentingIcon.TabIndex = 50;
            rentingIcon.TabStop = false;
            // 
            // overdueIcon
            // 
            overdueIcon.BackColor = Color.Transparent;
            overdueIcon.Image = Properties.Resources.overdue;
            overdueIcon.Location = new Point(20, 26);
            overdueIcon.Name = "overdueIcon";
            overdueIcon.Size = new Size(92, 31);
            overdueIcon.SizeMode = PictureBoxSizeMode.Zoom;
            overdueIcon.TabIndex = 49;
            overdueIcon.TabStop = false;
            // 
            // extendedIcon
            // 
            extendedIcon.BackColor = Color.Transparent;
            extendedIcon.Image = Properties.Resources.Extended__1_;
            extendedIcon.Location = new Point(20, 25);
            extendedIcon.Name = "extendedIcon";
            extendedIcon.Size = new Size(92, 31);
            extendedIcon.SizeMode = PictureBoxSizeMode.Zoom;
            extendedIcon.TabIndex = 54;
            extendedIcon.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(127, 23, 52);
            label16.Location = new Point(35, -3);
            label16.Name = "label16";
            label16.Size = new Size(62, 28);
            label16.TabIndex = 4;
            label16.Text = "Status";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // extendRentalBtn
            // 
            extendRentalBtn.BackColor = Color.FromArgb(127, 23, 52);
            extendRentalBtn.FlatStyle = FlatStyle.Flat;
            extendRentalBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            extendRentalBtn.ForeColor = Color.Transparent;
            extendRentalBtn.Location = new Point(764, 24);
            extendRentalBtn.Name = "extendRentalBtn";
            extendRentalBtn.Size = new Size(150, 35);
            extendRentalBtn.TabIndex = 45;
            extendRentalBtn.Text = "Extend Rental";
            extendRentalBtn.UseVisualStyleBackColor = false;
            // 
            // viewDetailsBtn
            // 
            viewDetailsBtn.BackColor = Color.FromArgb(127, 23, 52);
            viewDetailsBtn.FlatStyle = FlatStyle.Flat;
            viewDetailsBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewDetailsBtn.ForeColor = Color.Transparent;
            viewDetailsBtn.Location = new Point(764, 106);
            viewDetailsBtn.Name = "viewDetailsBtn";
            viewDetailsBtn.Size = new Size(150, 35);
            viewDetailsBtn.TabIndex = 44;
            viewDetailsBtn.Text = "View Details";
            viewDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // returnNowBtn
            // 
            returnNowBtn.BackColor = Color.FromArgb(127, 23, 52);
            returnNowBtn.FlatStyle = FlatStyle.Flat;
            returnNowBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnNowBtn.ForeColor = Color.Transparent;
            returnNowBtn.Location = new Point(764, 65);
            returnNowBtn.Name = "returnNowBtn";
            returnNowBtn.Size = new Size(150, 35);
            returnNowBtn.TabIndex = 43;
            returnNowBtn.Text = "Return Now";
            returnNowBtn.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(127, 23, 52);
            label12.Location = new Point(1280, 2);
            label12.Name = "label12";
            label12.Size = new Size(2, 209);
            label12.TabIndex = 41;
            label12.Text = "OR";
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(127, 23, 52);
            label13.Dock = DockStyle.Left;
            label13.Location = new Point(0, 2);
            label13.Name = "label13";
            label13.Size = new Size(2, 158);
            label13.TabIndex = 42;
            label13.Text = "OR";
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(127, 23, 52);
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(929, 2);
            label11.TabIndex = 40;
            label11.Text = "OR";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(127, 23, 52);
            label9.Location = new Point(0, 207);
            label9.Name = "label9";
            label9.Size = new Size(1282, 2);
            label9.TabIndex = 39;
            label9.Text = "OR";
            // 
            // bookPictureBox
            // 
            bookPictureBox.Image = (Image)resources.GetObject("bookPictureBox.Image");
            bookPictureBox.Location = new Point(12, 11);
            bookPictureBox.Name = "bookPictureBox";
            bookPictureBox.Size = new Size(109, 137);
            bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            bookPictureBox.TabIndex = 5;
            bookPictureBox.TabStop = false;
            // 
            // RentalCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Rent_Card);
            Margin = new Padding(0, 0, 0, 20);
            Name = "RentalCard";
            Size = new Size(929, 160);
            Rent_Card.ResumeLayout(false);
            Rent_Card.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            borrowersPanel.ResumeLayout(false);
            borrowersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)check).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnedIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)claimBookIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentingIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)overdueIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)extendedIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Rent_Card;
        private PictureBox bookPictureBox;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button extendRentalBtn;
        private Button viewDetailsBtn;
        private Button returnNowBtn;
        private Panel statusPanel;
        private PictureBox overdueIcon;
        private Label label16;
        private Panel borrowersPanel;
        private Label daysRemainingLabel;
        private PictureBox check;
        private PictureBox closeBtn;
        private Label dueDateLabel;
        private Label rentedDateLabel;
        private PictureBox pictureBox1;
        private Label rentalIdRental;
        private Label genreRental;
        private Label authorRental;
        private Label titleRental;
        private PictureBox claimBookIcon;
        private PictureBox returnedIcon;
        private PictureBox rentingIcon;
        private PictureBox extendedIcon;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
