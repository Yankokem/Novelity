namespace Novelity.Pages.Admin
{
    partial class ManageAccounts
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
            filterPanel = new Panel();
            oldestToNewestBox = new CheckBox();
            newestToOldestBox = new CheckBox();
            label7 = new Label();
            activeBox = new CheckBox();
            inactiveBox = new CheckBox();
            expiredBox = new CheckBox();
            label6 = new Label();
            premiumBox = new CheckBox();
            basicBox = new CheckBox();
            customerBox = new CheckBox();
            adminBox = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            createAccountModalBtn = new Button();
            accountsPanel = new FlowLayoutPanel();
            label16 = new Label();
            filterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(127, 23, 52);
            filterPanel.Controls.Add(oldestToNewestBox);
            filterPanel.Controls.Add(newestToOldestBox);
            filterPanel.Controls.Add(label7);
            filterPanel.Controls.Add(activeBox);
            filterPanel.Controls.Add(inactiveBox);
            filterPanel.Controls.Add(expiredBox);
            filterPanel.Controls.Add(label6);
            filterPanel.Controls.Add(premiumBox);
            filterPanel.Controls.Add(basicBox);
            filterPanel.Controls.Add(customerBox);
            filterPanel.Controls.Add(adminBox);
            filterPanel.Controls.Add(label5);
            filterPanel.Controls.Add(label4);
            filterPanel.Location = new Point(319, 108);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(322, 530);
            filterPanel.TabIndex = 31;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(16, 416);
            label7.Name = "label7";
            label7.Size = new Size(60, 33);
            label7.TabIndex = 10;
            label7.Text = "Date";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(16, 249);
            label6.Name = "label6";
            label6.Size = new Size(75, 33);
            label6.TabIndex = 6;
            label6.Text = "Status";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(16, 118);
            label5.Name = "label5";
            label5.Size = new Size(181, 33);
            label5.TabIndex = 1;
            label5.Text = "Membership Plan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(16, 17);
            label4.Name = "label4";
            label4.Size = new Size(85, 48);
            label4.TabIndex = 0;
            label4.Text = "Filter";
            // 
            // createAccountModalBtn
            // 
            createAccountModalBtn.BackColor = Color.FromArgb(127, 23, 52);
            createAccountModalBtn.FlatStyle = FlatStyle.Flat;
            createAccountModalBtn.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccountModalBtn.ForeColor = Color.Transparent;
            createAccountModalBtn.Location = new Point(1445, 35);
            createAccountModalBtn.Name = "createAccountModalBtn";
            createAccountModalBtn.Size = new Size(156, 48);
            createAccountModalBtn.TabIndex = 32;
            createAccountModalBtn.Text = "Create Account";
            createAccountModalBtn.UseVisualStyleBackColor = false;
            createAccountModalBtn.Click += createAccountModalBtn_Click;
            // 
            // accountsPanel
            // 
            accountsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            accountsPanel.AutoSize = true;
            accountsPanel.FlowDirection = FlowDirection.TopDown;
            accountsPanel.Location = new Point(671, 108);
            accountsPanel.Name = "accountsPanel";
            accountsPanel.Size = new Size(935, 2567);
            accountsPanel.TabIndex = 33;
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Location = new Point(1600, 0);
            label16.Name = "label16";
            label16.Size = new Size(3, 1500);
            label16.TabIndex = 36;
            label16.Text = "OR";
            // 
            // ManageAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(accountsPanel);
            Controls.Add(createAccountModalBtn);
            Controls.Add(filterPanel);
            Controls.Add(label16);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAccounts";
            Text = "ManageAccounts";
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel filterPanel;
        private CheckBox adminBox;
        private Label label5;
        private Label label4;
        private CheckBox oldestToNewestBox;
        private CheckBox newestToOldestBox;
        private Label label7;
        private CheckBox activeBox;
        private CheckBox inactiveBox;
        private CheckBox expiredBox;
        private Label label6;
        private CheckBox premiumBox;
        private CheckBox basicBox;
        private CheckBox customerBox;
        private Button createAccountModalBtn;
        private FlowLayoutPanel accountsPanel;
        private Label label16;
    }
}