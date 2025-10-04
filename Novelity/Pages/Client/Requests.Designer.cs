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
            oldestToNewestBox = new CheckBox();
            newestToOldestBox = new CheckBox();
            label8 = new Label();
            activeBox = new CheckBox();
            inactiveBox = new CheckBox();
            expiredBox = new CheckBox();
            label9 = new Label();
            premiumBox = new CheckBox();
            basicBox = new CheckBox();
            customerBox = new CheckBox();
            adminBox = new CheckBox();
            label11 = new Label();
            label12 = new Label();
            filterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(127, 23, 52);
            label1.Location = new Point(960, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 1080);
            label1.TabIndex = 31;
            label1.Text = "OR";
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(127, 23, 52);
            label14.Location = new Point(960, 0);
            label14.Name = "label14";
            label14.Size = new Size(1, 1080);
            label14.TabIndex = 30;
            label14.Text = "OR";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(127, 23, 52);
            label2.Location = new Point(319, 0);
            label2.Name = "label2";
            label2.Size = new Size(1, 1080);
            label2.TabIndex = 32;
            label2.Text = "OR";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(127, 23, 52);
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
            requestsPanel.Size = new Size(935, 883);
            requestsPanel.TabIndex = 38;
            requestsPanel.WrapContents = false;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(127, 23, 52);
            filterPanel.Controls.Add(oldestToNewestBox);
            filterPanel.Controls.Add(newestToOldestBox);
            filterPanel.Controls.Add(label8);
            filterPanel.Controls.Add(activeBox);
            filterPanel.Controls.Add(inactiveBox);
            filterPanel.Controls.Add(expiredBox);
            filterPanel.Controls.Add(label9);
            filterPanel.Controls.Add(premiumBox);
            filterPanel.Controls.Add(basicBox);
            filterPanel.Controls.Add(customerBox);
            filterPanel.Controls.Add(adminBox);
            filterPanel.Controls.Add(label11);
            filterPanel.Controls.Add(label12);
            filterPanel.Location = new Point(317, 99);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(322, 530);
            filterPanel.TabIndex = 37;
            // 
            // oldestToNewestBox
            // 
            oldestToNewestBox.AutoSize = true;
            oldestToNewestBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oldestToNewestBox.ForeColor = Color.Transparent;
            oldestToNewestBox.Location = new Point(21, 480);
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
            newestToOldestBox.Location = new Point(21, 444);
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
            label8.Location = new Point(16, 416);
            label8.Name = "label8";
            label8.Size = new Size(60, 33);
            label8.TabIndex = 10;
            label8.Text = "Date";
            // 
            // activeBox
            // 
            activeBox.AutoSize = true;
            activeBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activeBox.ForeColor = Color.Transparent;
            activeBox.Location = new Point(21, 351);
            activeBox.Name = "activeBox";
            activeBox.Size = new Size(76, 30);
            activeBox.TabIndex = 9;
            activeBox.Text = "Active";
            activeBox.UseVisualStyleBackColor = true;
            // 
            // inactiveBox
            // 
            inactiveBox.AutoSize = true;
            inactiveBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inactiveBox.ForeColor = Color.Transparent;
            inactiveBox.Location = new Point(21, 315);
            inactiveBox.Name = "inactiveBox";
            inactiveBox.Size = new Size(90, 30);
            inactiveBox.TabIndex = 8;
            inactiveBox.Text = "Inactive";
            inactiveBox.UseVisualStyleBackColor = true;
            // 
            // expiredBox
            // 
            expiredBox.AutoSize = true;
            expiredBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiredBox.ForeColor = Color.Transparent;
            expiredBox.Location = new Point(21, 279);
            expiredBox.Name = "expiredBox";
            expiredBox.Size = new Size(85, 30);
            expiredBox.TabIndex = 7;
            expiredBox.Text = "Expired";
            expiredBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(16, 249);
            label9.Name = "label9";
            label9.Size = new Size(75, 33);
            label9.TabIndex = 6;
            label9.Text = "Status";
            // 
            // premiumBox
            // 
            premiumBox.AutoSize = true;
            premiumBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            premiumBox.ForeColor = Color.Transparent;
            premiumBox.Location = new Point(21, 186);
            premiumBox.Name = "premiumBox";
            premiumBox.Size = new Size(99, 30);
            premiumBox.TabIndex = 5;
            premiumBox.Text = "Premium";
            premiumBox.UseVisualStyleBackColor = true;
            // 
            // basicBox
            // 
            basicBox.AutoSize = true;
            basicBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            basicBox.ForeColor = Color.Transparent;
            basicBox.Location = new Point(21, 150);
            basicBox.Name = "basicBox";
            basicBox.Size = new Size(71, 30);
            basicBox.TabIndex = 4;
            basicBox.Text = "Basic";
            basicBox.UseVisualStyleBackColor = true;
            // 
            // customerBox
            // 
            customerBox.AutoSize = true;
            customerBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerBox.ForeColor = Color.Transparent;
            customerBox.Location = new Point(107, 70);
            customerBox.Name = "customerBox";
            customerBox.Size = new Size(106, 30);
            customerBox.TabIndex = 3;
            customerBox.Text = "Customer";
            customerBox.UseVisualStyleBackColor = true;
            // 
            // adminBox
            // 
            adminBox.AutoSize = true;
            adminBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminBox.ForeColor = Color.Transparent;
            adminBox.Location = new Point(21, 70);
            adminBox.Name = "adminBox";
            adminBox.Size = new Size(80, 30);
            adminBox.TabIndex = 2;
            adminBox.Text = "Admin";
            adminBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(16, 118);
            label11.Name = "label11";
            label11.Size = new Size(181, 33);
            label11.TabIndex = 1;
            label11.Text = "Membership Plan";
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
            // Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
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
        private CheckBox activeBox;
        private CheckBox inactiveBox;
        private CheckBox expiredBox;
        private Label label9;
        private CheckBox premiumBox;
        private CheckBox basicBox;
        private CheckBox customerBox;
        private CheckBox adminBox;
        private Label label11;
        private Label label12;
    }
}