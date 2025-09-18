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
            panel1 = new Panel();
            myRentalBtn = new Label();
            bookBtn = new Label();
            homeBtn = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            minimizeBtn = new PictureBox();
            closeBtn = new PictureBox();
            panelContent = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(127, 23, 52);
            panel1.Controls.Add(myRentalBtn);
            panel1.Controls.Add(bookBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(minimizeBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 86);
            panel1.TabIndex = 0;
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
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.pfp;
            pictureBox4.Location = new Point(1813, 39);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.logout;
            pictureBox3.Location = new Point(1868, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
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
            // panelContent
            // 
            panelContent.Controls.Add(panel2);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 86);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1920, 994);
            panelContent.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 0);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "    Novelity";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox minimizeBtn;
        private PictureBox closeBtn;
        private Label myRentalBtn;
        private Label bookBtn;
        private Label homeBtn;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private FlowLayoutPanel panelContent;
        private Panel panel2;
    }
}
