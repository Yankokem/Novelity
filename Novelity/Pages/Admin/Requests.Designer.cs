namespace Novelity.Pages.Admin
{
    partial class Requests
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label14 = new Label();
            label2 = new Label();
            label3 = new Label();
            requestsPanel = new FlowLayoutPanel();
            filterPanel = new Panel();
            returnedBox = new CheckBox();
            extendedBox = new CheckBox();
            overdueBox = new CheckBox();
            oldestToNewestBox = new CheckBox();
            newestToOldestBox = new CheckBox();
            label8 = new Label();
            rentedBox = new CheckBox();
            pendingBox = new CheckBox();
            claimedBox = new CheckBox();
            label9 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            requestSearchbar = new TextBox();
            nextBtn = new Button();
            prevBtn = new Button();
            filterPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(960, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 1080);
            label1.TabIndex = 31;
            label1.Text = "OR";
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(960, 0);
            label14.Name = "label14";
            label14.Size = new Size(1, 1080);
            label14.TabIndex = 30;
            label14.Text = "OR";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(319, 0);
            label2.Name = "label2";
            label2.Size = new Size(1, 1080);
            label2.TabIndex = 32;
            label2.Text = "OR";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(1600, 0);
            label3.Name = "label3";
            label3.Size = new Size(1, 1080);
            label3.TabIndex = 33;
            label3.Text = "OR";
            // 
            // requestsPanel
            // 
            requestsPanel.AutoSize = true;
            requestsPanel.BackColor = Color.Transparent;
            requestsPanel.FlowDirection = FlowDirection.TopDown;
            requestsPanel.Location = new Point(669, 99);
            requestsPanel.Margin = new Padding(0);
            requestsPanel.Name = "requestsPanel";
            requestsPanel.Size = new Size(935, 707);
            requestsPanel.TabIndex = 38;
            requestsPanel.WrapContents = false;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(127, 23, 52);
            filterPanel.Controls.Add(returnedBox);
            filterPanel.Controls.Add(extendedBox);
            filterPanel.Controls.Add(overdueBox);
            filterPanel.Controls.Add(oldestToNewestBox);
            filterPanel.Controls.Add(newestToOldestBox);
            filterPanel.Controls.Add(label8);
            filterPanel.Controls.Add(rentedBox);
            filterPanel.Controls.Add(pendingBox);
            filterPanel.Controls.Add(claimedBox);
            filterPanel.Controls.Add(label9);
            filterPanel.Controls.Add(label12);
            filterPanel.Location = new Point(317, 99);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(322, 465);
            filterPanel.TabIndex = 37;
            // 
            // returnedBox
            // 
            returnedBox.AutoSize = true;
            returnedBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnedBox.ForeColor = Color.Transparent;
            returnedBox.Location = new Point(16, 297);
            returnedBox.Name = "returnedBox";
            returnedBox.Size = new Size(99, 30);
            returnedBox.TabIndex = 15;
            returnedBox.Text = "Returned";
            returnedBox.UseVisualStyleBackColor = true;
            // 
            // extendedBox
            // 
            extendedBox.AutoSize = true;
            extendedBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            extendedBox.ForeColor = Color.Transparent;
            extendedBox.Location = new Point(16, 261);
            extendedBox.Name = "extendedBox";
            extendedBox.Size = new Size(99, 30);
            extendedBox.TabIndex = 14;
            extendedBox.Text = "Extended";
            extendedBox.UseVisualStyleBackColor = true;
            // 
            // overdueBox
            // 
            overdueBox.AutoSize = true;
            overdueBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            overdueBox.ForeColor = Color.Transparent;
            overdueBox.Location = new Point(16, 225);
            overdueBox.Name = "overdueBox";
            overdueBox.Size = new Size(95, 30);
            overdueBox.TabIndex = 13;
            overdueBox.Text = "Overdue";
            overdueBox.UseVisualStyleBackColor = true;
            // 
            // oldestToNewestBox
            // 
            oldestToNewestBox.AutoSize = true;
            oldestToNewestBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oldestToNewestBox.ForeColor = Color.Transparent;
            oldestToNewestBox.Location = new Point(21, 415);
            oldestToNewestBox.Name = "oldestToNewestBox";
            oldestToNewestBox.Size = new Size(156, 30);
            oldestToNewestBox.TabIndex = 12;
            oldestToNewestBox.Text = "Oldest to Newest";
            oldestToNewestBox.UseVisualStyleBackColor = true;
            // 
            // newestToOldestBox
            // 
            newestToOldestBox.AutoSize = true;
            newestToOldestBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newestToOldestBox.ForeColor = Color.Transparent;
            newestToOldestBox.Location = new Point(21, 379);
            newestToOldestBox.Name = "newestToOldestBox";
            newestToOldestBox.Size = new Size(156, 30);
            newestToOldestBox.TabIndex = 11;
            newestToOldestBox.Text = "Newest to Oldest";
            newestToOldestBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(16, 351);
            label8.Name = "label8";
            label8.Size = new Size(60, 33);
            label8.TabIndex = 10;
            label8.Text = "Date";
            // 
            // rentedBox
            // 
            rentedBox.AutoSize = true;
            rentedBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentedBox.ForeColor = Color.Transparent;
            rentedBox.Location = new Point(16, 189);
            rentedBox.Name = "rentedBox";
            rentedBox.Size = new Size(83, 30);
            rentedBox.TabIndex = 9;
            rentedBox.Text = "Rented";
            rentedBox.TextAlign = ContentAlignment.MiddleCenter;
            rentedBox.UseVisualStyleBackColor = true;
            // 
            // pendingBox
            // 
            pendingBox.AutoSize = true;
            pendingBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingBox.ForeColor = Color.Transparent;
            pendingBox.Location = new Point(16, 153);
            pendingBox.Name = "pendingBox";
            pendingBox.Size = new Size(93, 30);
            pendingBox.TabIndex = 8;
            pendingBox.Text = "Pending";
            pendingBox.UseVisualStyleBackColor = true;
            // 
            // claimedBox
            // 
            claimedBox.AutoSize = true;
            claimedBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            claimedBox.ForeColor = Color.Transparent;
            claimedBox.Location = new Point(16, 117);
            claimedBox.Name = "claimedBox";
            claimedBox.Size = new Size(95, 30);
            claimedBox.TabIndex = 7;
            claimedBox.Text = "Claimed";
            claimedBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(16, 81);
            label9.Name = "label9";
            label9.Size = new Size(75, 33);
            label9.TabIndex = 6;
            label9.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(16, 17);
            label12.Name = "label12";
            label12.Size = new Size(85, 48);
            label12.TabIndex = 0;
            label12.Text = "Filter";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(requestSearchbar);
            panel1.Location = new Point(669, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 48);
            panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(8, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(127, 23, 52);
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(2, 0);
            label4.Name = "label4";
            label4.Size = new Size(752, 2);
            label4.TabIndex = 35;
            label4.Text = "OR";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(127, 23, 52);
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(2, 46);
            label5.Name = "label5";
            label5.Size = new Size(752, 2);
            label5.TabIndex = 36;
            label5.Text = "OR";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(127, 23, 52);
            label6.Dock = DockStyle.Right;
            label6.Location = new Point(754, 0);
            label6.Name = "label6";
            label6.Size = new Size(2, 48);
            label6.TabIndex = 35;
            label6.Text = "OR";
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(127, 23, 52);
            label10.Dock = DockStyle.Left;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(2, 48);
            label10.TabIndex = 34;
            label10.Text = "OR";
            // 
            // requestSearchbar
            // 
            requestSearchbar.BackColor = SystemColors.Control;
            requestSearchbar.BorderStyle = BorderStyle.None;
            requestSearchbar.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestSearchbar.Location = new Point(52, 11);
            requestSearchbar.Multiline = true;
            requestSearchbar.Name = "requestSearchbar";
            requestSearchbar.PlaceholderText = "Enter book name...";
            requestSearchbar.Size = new Size(696, 26);
            requestSearchbar.TabIndex = 33;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.FromArgb(127, 23, 52);
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Font = new Font("Poppins", 11.25F);
            nextBtn.ForeColor = Color.Transparent;
            nextBtn.Location = new Point(1153, 829);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(84, 39);
            nextBtn.TabIndex = 40;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.FromArgb(127, 23, 52);
            prevBtn.FlatStyle = FlatStyle.Flat;
            prevBtn.Font = new Font("Poppins", 11.25F);
            prevBtn.ForeColor = Color.Transparent;
            prevBtn.Location = new Point(1036, 829);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(84, 39);
            prevBtn.TabIndex = 39;
            prevBtn.Text = "Prev";
            prevBtn.UseVisualStyleBackColor = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(nextBtn);
            Controls.Add(prevBtn);
            Controls.Add(panel1);
            Controls.Add(requestsPanel);
            Controls.Add(filterPanel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Requests";
            Text = "Reqeusts";
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label14;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel requestsPanel;
        private Panel filterPanel;
        private CheckBox oldestToNewestBox;
        private CheckBox newestToOldestBox;
        private Label label8;
        private CheckBox rentedBox;
        private CheckBox pendingBox;
        private CheckBox claimedBox;
        private Label label9;
        private Label label12;
        private CheckBox returnedBox;
        private CheckBox extendedBox;
        private CheckBox overdueBox;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label10;
        private TextBox requestSearchbar;
        private Button nextBtn;
        private Button prevBtn;
    }
}