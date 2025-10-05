namespace Novelity.Cards
{
    partial class RequestCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestCard));
            flowLayoutPanel1 = new FlowLayoutPanel();
            titleReq = new Label();
            authorReq = new Label();
            overdueIcon = new PictureBox();
            bookIDReq = new Label();
            bookPictureBox = new PictureBox();
            panel1 = new Panel();
            extendedIcon = new PictureBox();
            rentingIcon = new PictureBox();
            returnedIcon = new PictureBox();
            claimBookIcon = new PictureBox();
            pendingIcon = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label11 = new Label();
            borrowersPanel = new Panel();
            pictureBox2 = new PictureBox();
            rentersUsernameReq = new Label();
            daysRemainingReq = new Label();
            check = new PictureBox();
            closeBtn = new PictureBox();
            returnDateReq = new Label();
            rentedDateReq = new Label();
            pictureBox1 = new PictureBox();
            returnedBtn = new Button();
            claimedBtn = new Button();
            statusPanel = new Panel();
            label16 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overdueIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)extendedIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentingIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnedIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claimBookIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendingIcon).BeginInit();
            borrowersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)check).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(titleReq);
            flowLayoutPanel1.Controls.Add(authorReq);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(117, 7);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 117);
            flowLayoutPanel1.TabIndex = 58;
            // 
            // titleReq
            // 
            titleReq.AutoSize = true;
            titleReq.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleReq.Location = new Point(3, 0);
            titleReq.Name = "titleReq";
            titleReq.Size = new Size(73, 28);
            titleReq.TabIndex = 49;
            titleReq.Text = "titleReq";
            // 
            // authorReq
            // 
            authorReq.AutoSize = true;
            authorReq.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorReq.Location = new Point(3, 28);
            authorReq.Name = "authorReq";
            authorReq.Size = new Size(78, 23);
            authorReq.TabIndex = 50;
            authorReq.Text = "authorReq";
            // 
            // overdueIcon
            // 
            overdueIcon.BackColor = Color.Transparent;
            overdueIcon.Image = Properties.Resources.overdue;
            overdueIcon.Location = new Point(21, 23);
            overdueIcon.Name = "overdueIcon";
            overdueIcon.Size = new Size(92, 31);
            overdueIcon.SizeMode = PictureBoxSizeMode.Zoom;
            overdueIcon.TabIndex = 49;
            overdueIcon.TabStop = false;
            // 
            // bookIDReq
            // 
            bookIDReq.AutoSize = true;
            bookIDReq.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookIDReq.Location = new Point(122, 127);
            bookIDReq.Name = "bookIDReq";
            bookIDReq.Size = new Size(73, 21);
            bookIDReq.TabIndex = 57;
            bookIDReq.Text = "bookIDReq";
            // 
            // bookPictureBox
            // 
            bookPictureBox.Image = (Image)resources.GetObject("bookPictureBox.Image");
            bookPictureBox.Location = new Point(7, 12);
            bookPictureBox.Name = "bookPictureBox";
            bookPictureBox.Size = new Size(109, 137);
            bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            bookPictureBox.TabIndex = 56;
            bookPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(borrowersPanel);
            panel1.Controls.Add(returnedBtn);
            panel1.Controls.Add(claimedBtn);
            panel1.Controls.Add(bookPictureBox);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(statusPanel);
            panel1.Controls.Add(bookIDReq);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 160);
            panel1.TabIndex = 59;
            // 
            // extendedIcon
            // 
            extendedIcon.BackColor = Color.Transparent;
            extendedIcon.Image = Properties.Resources.Extended__1_;
            extendedIcon.Location = new Point(21, 23);
            extendedIcon.Name = "extendedIcon";
            extendedIcon.Size = new Size(92, 31);
            extendedIcon.SizeMode = PictureBoxSizeMode.Zoom;
            extendedIcon.TabIndex = 54;
            extendedIcon.TabStop = false;
            // 
            // rentingIcon
            // 
            rentingIcon.BackColor = Color.Transparent;
            rentingIcon.Image = Properties.Resources.Renting1;
            rentingIcon.Location = new Point(21, 23);
            rentingIcon.Name = "rentingIcon";
            rentingIcon.Size = new Size(92, 31);
            rentingIcon.SizeMode = PictureBoxSizeMode.Zoom;
            rentingIcon.TabIndex = 50;
            rentingIcon.TabStop = false;
            // 
            // returnedIcon
            // 
            returnedIcon.BackColor = Color.Transparent;
            returnedIcon.Image = Properties.Resources.Returned;
            returnedIcon.Location = new Point(21, 23);
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
            claimBookIcon.Location = new Point(21, 23);
            claimBookIcon.Name = "claimBookIcon";
            claimBookIcon.Size = new Size(92, 31);
            claimBookIcon.SizeMode = PictureBoxSizeMode.Zoom;
            claimBookIcon.TabIndex = 53;
            claimBookIcon.TabStop = false;
            // 
            // pendingIcon
            // 
            pendingIcon.BackColor = Color.Transparent;
            pendingIcon.Image = Properties.Resources.Pending;
            pendingIcon.Location = new Point(21, 23);
            pendingIcon.Name = "pendingIcon";
            pendingIcon.Size = new Size(92, 31);
            pendingIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pendingIcon.TabIndex = 55;
            pendingIcon.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(127, 23, 52);
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(2, 158);
            label3.Name = "label3";
            label3.Size = new Size(925, 2);
            label3.TabIndex = 65;
            label3.Text = "OR";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(127, 23, 52);
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(2, 158);
            label1.TabIndex = 64;
            label1.Text = "OR";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(127, 23, 52);
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(927, 2);
            label2.Name = "label2";
            label2.Size = new Size(2, 158);
            label2.TabIndex = 63;
            label2.Text = "OR";
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(127, 23, 52);
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(929, 2);
            label11.TabIndex = 62;
            label11.Text = "OR";
            // 
            // borrowersPanel
            // 
            borrowersPanel.Controls.Add(pictureBox2);
            borrowersPanel.Controls.Add(rentersUsernameReq);
            borrowersPanel.Controls.Add(daysRemainingReq);
            borrowersPanel.Controls.Add(check);
            borrowersPanel.Controls.Add(closeBtn);
            borrowersPanel.Controls.Add(returnDateReq);
            borrowersPanel.Controls.Add(rentedDateReq);
            borrowersPanel.Controls.Add(pictureBox1);
            borrowersPanel.Location = new Point(537, 18);
            borrowersPanel.Name = "borrowersPanel";
            borrowersPanel.Size = new Size(191, 133);
            borrowersPanel.TabIndex = 59;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.pfp_v1___red;
            pictureBox2.Location = new Point(3, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // rentersUsernameReq
            // 
            rentersUsernameReq.AutoSize = true;
            rentersUsernameReq.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentersUsernameReq.Location = new Point(29, 0);
            rentersUsernameReq.Name = "rentersUsernameReq";
            rentersUsernameReq.Size = new Size(148, 23);
            rentersUsernameReq.TabIndex = 51;
            rentersUsernameReq.Text = "rentersUsernameReq";
            // 
            // daysRemainingReq
            // 
            daysRemainingReq.AutoSize = true;
            daysRemainingReq.Font = new Font("Poppins", 9.75F);
            daysRemainingReq.Location = new Point(29, 102);
            daysRemainingReq.Name = "daysRemainingReq";
            daysRemainingReq.Size = new Size(136, 23);
            daysRemainingReq.TabIndex = 49;
            daysRemainingReq.Text = "daysRemainingReq";
            // 
            // check
            // 
            check.BackColor = Color.Transparent;
            check.Image = Properties.Resources.check_red;
            check.Location = new Point(3, 102);
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
            closeBtn.Location = new Point(3, 34);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(25, 25);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 42;
            closeBtn.TabStop = false;
            // 
            // returnDateReq
            // 
            returnDateReq.AutoSize = true;
            returnDateReq.Font = new Font("Poppins", 9.75F);
            returnDateReq.Location = new Point(29, 68);
            returnDateReq.Name = "returnDateReq";
            returnDateReq.Size = new Size(105, 23);
            returnDateReq.TabIndex = 47;
            returnDateReq.Text = "returnDateReq";
            // 
            // rentedDateReq
            // 
            rentedDateReq.AutoSize = true;
            rentedDateReq.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentedDateReq.Location = new Point(29, 35);
            rentedDateReq.Name = "rentedDateReq";
            rentedDateReq.Size = new Size(109, 23);
            rentedDateReq.TabIndex = 46;
            rentedDateReq.Text = "rentedDateReq";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.back_red;
            pictureBox1.Location = new Point(3, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // returnedBtn
            // 
            returnedBtn.BackColor = Color.FromArgb(127, 23, 52);
            returnedBtn.FlatStyle = FlatStyle.Flat;
            returnedBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnedBtn.ForeColor = Color.Transparent;
            returnedBtn.Location = new Point(768, 83);
            returnedBtn.Name = "returnedBtn";
            returnedBtn.Size = new Size(150, 35);
            returnedBtn.TabIndex = 61;
            returnedBtn.Text = "Returned";
            returnedBtn.UseVisualStyleBackColor = false;
            returnedBtn.Click += returnedBtn_Click;
            // 
            // claimedBtn
            // 
            claimedBtn.BackColor = Color.FromArgb(127, 23, 52);
            claimedBtn.FlatStyle = FlatStyle.Flat;
            claimedBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            claimedBtn.ForeColor = Color.Transparent;
            claimedBtn.Location = new Point(768, 42);
            claimedBtn.Name = "claimedBtn";
            claimedBtn.Size = new Size(150, 35);
            claimedBtn.TabIndex = 60;
            claimedBtn.Text = "Claimed";
            claimedBtn.UseVisualStyleBackColor = false;
            claimedBtn.Click += claimedBtn_Click;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(pendingIcon);
            statusPanel.Controls.Add(returnedIcon);
            statusPanel.Controls.Add(rentingIcon);
            statusPanel.Controls.Add(claimBookIcon);
            statusPanel.Controls.Add(overdueIcon);
            statusPanel.Controls.Add(extendedIcon);
            statusPanel.Controls.Add(label16);
            statusPanel.Location = new Point(357, 48);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(139, 63);
            statusPanel.TabIndex = 51;
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
            // RequestCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(0, 0, 0, 20);
            Name = "RequestCard";
            Size = new Size(929, 160);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)overdueIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)extendedIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentingIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnedIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)claimBookIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendingIcon).EndInit();
            borrowersPanel.ResumeLayout(false);
            borrowersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)check).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label titleReq;
        private Label authorReq;
        private Label bookIDReq;
        private PictureBox bookPictureBox;
        private Panel panel1;
        private Panel statusPanel;
        private PictureBox returnedIcon;
        private PictureBox claimBookIcon;
        private PictureBox rentingIcon;
        private PictureBox overdueIcon;
        private PictureBox extendedIcon;
        private Label label16;
        private Panel borrowersPanel;
        private Label daysRemainingReq;
        private PictureBox check;
        private PictureBox closeBtn;
        private Label returnDateReq;
        private Label rentedDateReq;
        private PictureBox pictureBox1;
        private Button returnedBtn;
        private Button claimedBtn;
        private PictureBox pictureBox2;
        private Label rentersUsernameReq;
        private PictureBox pendingIcon;
        private Label label2;
        private Label label11;
        private Label label3;
        private Label label1;
    }
}
