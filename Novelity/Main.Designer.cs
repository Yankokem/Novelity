namespace Novelity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Navbar = new Panel();
            accountGroupBtn = new FlowLayoutPanel();
            profileBtn = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            usernameLabel = new Label();
            roleLabel = new Label();
            myRentalBtn = new Label();
            bookBtn = new Label();
            homeBtn = new Label();
            pictureBox5 = new PictureBox();
            logoutBtn = new PictureBox();
            minimizeBtn = new PictureBox();
            closeBtn = new PictureBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            manageAccountsBtn = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            adminNavbar = new Panel();
            panel1 = new Panel();
            flowy = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            dashboardBtn = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            reportsBtn = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            manageBooksBtn = new Label();
            panelContent = new Panel();
            label1 = new Label();
            Navbar.SuspendLayout();
            accountGroupBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileBtn).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            adminNavbar.SuspendLayout();
            panel1.SuspendLayout();
            flowy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // Navbar
            // 
            Navbar.BackColor = Color.FromArgb(127, 23, 52);
            Navbar.Controls.Add(accountGroupBtn);
            Navbar.Controls.Add(myRentalBtn);
            Navbar.Controls.Add(bookBtn);
            Navbar.Controls.Add(homeBtn);
            Navbar.Controls.Add(pictureBox5);
            Navbar.Controls.Add(logoutBtn);
            Navbar.Controls.Add(minimizeBtn);
            Navbar.Controls.Add(closeBtn);
            Navbar.Dock = DockStyle.Top;
            Navbar.Location = new Point(0, 0);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(1920, 86);
            Navbar.TabIndex = 0;
            // 
            // accountGroupBtn
            // 
            accountGroupBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            accountGroupBtn.Controls.Add(profileBtn);
            accountGroupBtn.Controls.Add(flowLayoutPanel2);
            accountGroupBtn.Location = new Point(1647, 16);
            accountGroupBtn.Name = "accountGroupBtn";
            accountGroupBtn.Size = new Size(195, 55);
            accountGroupBtn.TabIndex = 8;
            // 
            // profileBtn
            // 
            profileBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            profileBtn.Image = Properties.Resources.pfp;
            profileBtn.Location = new Point(3, 3);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(50, 50);
            profileBtn.SizeMode = PictureBoxSizeMode.Zoom;
            profileBtn.TabIndex = 3;
            profileBtn.TabStop = false;
            profileBtn.Click += profileBtn_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(usernameLabel);
            flowLayoutPanel2.Controls.Add(roleLabel);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(59, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(133, 50);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // usernameLabel
            // 
            usernameLabel.AllowDrop = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.Transparent;
            usernameLabel.Location = new Point(3, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(130, 23);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // roleLabel
            // 
            roleLabel.AllowDrop = true;
            roleLabel.BackColor = Color.Transparent;
            roleLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLabel.ForeColor = Color.Transparent;
            roleLabel.Location = new Point(3, 30);
            roleLabel.Margin = new Padding(3, 7, 3, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(130, 19);
            roleLabel.TabIndex = 4;
            roleLabel.Text = "role";
            // 
            // myRentalBtn
            // 
            myRentalBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            myRentalBtn.AutoSize = true;
            myRentalBtn.Font = new Font("Poppins", 18F);
            myRentalBtn.ForeColor = Color.Transparent;
            myRentalBtn.Location = new Point(1115, 24);
            myRentalBtn.Name = "myRentalBtn";
            myRentalBtn.Size = new Size(148, 42);
            myRentalBtn.TabIndex = 7;
            myRentalBtn.Text = "My Rentals";
            myRentalBtn.Click += myRentalBtn_Click;
            // 
            // bookBtn
            // 
            bookBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bookBtn.AutoSize = true;
            bookBtn.Font = new Font("Poppins", 18F);
            bookBtn.ForeColor = Color.Transparent;
            bookBtn.Location = new Point(925, 24);
            bookBtn.Name = "bookBtn";
            bookBtn.Size = new Size(88, 42);
            bookBtn.TabIndex = 6;
            bookBtn.Text = "Books";
            bookBtn.Click += bookBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            homeBtn.AutoSize = true;
            homeBtn.Font = new Font("Poppins", 18F);
            homeBtn.ForeColor = Color.Transparent;
            homeBtn.Location = new Point(731, 24);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(90, 42);
            homeBtn.TabIndex = 5;
            homeBtn.Text = "Home";
            homeBtn.Click += homeBtn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.logo;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(206, 86);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutBtn.Image = Properties.Resources.logout;
            logoutBtn.Location = new Point(1868, 39);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(40, 40);
            logoutBtn.SizeMode = PictureBoxSizeMode.Zoom;
            logoutBtn.TabIndex = 2;
            logoutBtn.TabStop = false;
            logoutBtn.Click += logoutBtn_Click_1;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeBtn.Image = Properties.Resources._;
            minimizeBtn.Location = new Point(1862, 8);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(20, 20);
            minimizeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeBtn.TabIndex = 1;
            minimizeBtn.TabStop = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.Image = Properties.Resources.x;
            closeBtn.Location = new Point(1888, 8);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(20, 20);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 0;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(pictureBox3);
            flowLayoutPanel4.Controls.Add(manageAccountsBtn);
            flowLayoutPanel4.Location = new Point(584, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(230, 35);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.accounts;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += manageAccountsBtn_Click;
            // 
            // manageAccountsBtn
            // 
            manageAccountsBtn.AutoSize = true;
            manageAccountsBtn.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageAccountsBtn.ForeColor = Color.Transparent;
            manageAccountsBtn.Location = new Point(38, 2);
            manageAccountsBtn.Margin = new Padding(3, 2, 3, 0);
            manageAccountsBtn.Name = "manageAccountsBtn";
            manageAccountsBtn.Size = new Size(189, 33);
            manageAccountsBtn.TabIndex = 1;
            manageAccountsBtn.Text = "Manage Accounts";
            manageAccountsBtn.Click += manageAccountsBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(adminNavbar);
            flowLayoutPanel1.Controls.Add(panelContent);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 86);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1920, 994);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // adminNavbar
            // 
            adminNavbar.BackColor = Color.FromArgb(188, 67, 100);
            adminNavbar.Controls.Add(panel1);
            adminNavbar.Location = new Point(0, 0);
            adminNavbar.Margin = new Padding(0);
            adminNavbar.Name = "adminNavbar";
            adminNavbar.Size = new Size(1920, 63);
            adminNavbar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowy);
            panel1.Controls.Add(flowLayoutPanel4);
            panel1.Controls.Add(flowLayoutPanel5);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Location = new Point(441, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 35);
            panel1.TabIndex = 0;
            // 
            // flowy
            // 
            flowy.AutoSize = true;
            flowy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowy.Controls.Add(pictureBox1);
            flowy.Controls.Add(dashboardBtn);
            flowy.Location = new Point(0, 0);
            flowy.Name = "flowy";
            flowy.Size = new Size(162, 35);
            flowy.TabIndex = 0;
            flowy.Click += dashboardBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += dashboardBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.AutoSize = true;
            dashboardBtn.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.Transparent;
            dashboardBtn.Location = new Point(38, 2);
            dashboardBtn.Margin = new Padding(3, 2, 3, 0);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(121, 33);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(pictureBox4);
            flowLayoutPanel5.Controls.Add(reportsBtn);
            flowLayoutPanel5.Location = new Point(923, 0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(129, 35);
            flowLayoutPanel5.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.reports;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // reportsBtn
            // 
            reportsBtn.AutoSize = true;
            reportsBtn.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportsBtn.ForeColor = Color.Transparent;
            reportsBtn.Location = new Point(38, 2);
            reportsBtn.Margin = new Padding(3, 2, 3, 0);
            reportsBtn.Name = "reportsBtn";
            reportsBtn.Size = new Size(88, 33);
            reportsBtn.TabIndex = 1;
            reportsBtn.Text = "Reports";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(pictureBox2);
            flowLayoutPanel3.Controls.Add(manageBooksBtn);
            flowLayoutPanel3.Location = new Point(271, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(196, 35);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.managebooks;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // manageBooksBtn
            // 
            manageBooksBtn.AutoSize = true;
            manageBooksBtn.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageBooksBtn.ForeColor = Color.Transparent;
            manageBooksBtn.Location = new Point(38, 2);
            manageBooksBtn.Margin = new Padding(3, 2, 3, 0);
            manageBooksBtn.Name = "manageBooksBtn";
            manageBooksBtn.Size = new Size(155, 33);
            manageBooksBtn.TabIndex = 1;
            manageBooksBtn.Text = "Manage Books";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(label1);
            panelContent.Location = new Point(0, 63);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1920, 922);
            panelContent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(671, 342);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Navbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "    Novelity";
            Navbar.ResumeLayout(false);
            Navbar.PerformLayout();
            accountGroupBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileBtn).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            adminNavbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowy.ResumeLayout(false);
            flowy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Navbar;
        private PictureBox logoutBtn;
        private PictureBox minimizeBtn;
        private PictureBox closeBtn;
        private Label myRentalBtn;
        private Label bookBtn;
        private Label homeBtn;
        private PictureBox pictureBox5;
        private PictureBox profileBtn;
        private FlowLayoutPanel accountGroupBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label usernameLabel;
        private Label roleLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel adminNavbar;
        private Panel panelContent;
        private FlowLayoutPanel flowy;
        private PictureBox pictureBox1;
        private Label dashboardBtn;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox pictureBox2;
        private Label manageBooksBtn;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox pictureBox3;
        private Label manageAccountsBtn;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel5;
        private PictureBox pictureBox4;
        private Label reportsBtn;
        private Label label1;
    }
}
