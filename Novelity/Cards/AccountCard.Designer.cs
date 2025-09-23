namespace Novelity.Cards
{
    partial class AccountCard
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
            pictureBox1 = new PictureBox();
            fullNameLabel = new Label();
            usernameLabel = new Label();
            userIdLabel = new Label();
            panel3 = new Panel();
            tierLabel = new Label();
            label10 = new Label();
            panel4 = new Panel();
            subDateLabel = new Label();
            label13 = new Label();
            panel5 = new Panel();
            renewalDateLabel = new Label();
            label16 = new Label();
            historyBtn = new Button();
            EditBtn = new Button();
            deleteBtn = new Button();
            accountProfile = new Panel();
            panel1 = new Panel();
            roleLabel = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            accountProfile.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pfp___red;
            pictureBox1.Location = new Point(19, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(140, 17);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(85, 28);
            fullNameLabel.TabIndex = 1;
            fullNameLabel.Text = "Fullname";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(140, 45);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(77, 23);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userIdLabel.Location = new Point(140, 109);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(21, 21);
            userIdLabel.TabIndex = 3;
            userIdLabel.Text = "id";
            // 
            // panel3
            // 
            panel3.Controls.Add(tierLabel);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(363, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 66);
            panel3.TabIndex = 5;
            // 
            // tierLabel
            // 
            tierLabel.AutoSize = true;
            tierLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tierLabel.Location = new Point(19, 34);
            tierLabel.Name = "tierLabel";
            tierLabel.Size = new Size(33, 23);
            tierLabel.TabIndex = 5;
            tierLabel.Text = "Tier";
            tierLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(127, 23, 52);
            label10.Location = new Point(31, 2);
            label10.Name = "label10";
            label10.Size = new Size(41, 28);
            label10.TabIndex = 4;
            label10.Text = "Tier";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(subDateLabel);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(480, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 66);
            panel4.TabIndex = 6;
            // 
            // subDateLabel
            // 
            subDateLabel.AutoSize = true;
            subDateLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subDateLabel.Location = new Point(38, 34);
            subDateLabel.Name = "subDateLabel";
            subDateLabel.Size = new Size(41, 23);
            subDateLabel.TabIndex = 5;
            subDateLabel.Text = "date";
            subDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(127, 23, 52);
            label13.Location = new Point(4, 2);
            label13.Name = "label13";
            label13.Size = new Size(153, 28);
            label13.TabIndex = 4;
            label13.Text = "Subscription Date";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(renewalDateLabel);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(649, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(142, 66);
            panel5.TabIndex = 7;
            // 
            // renewalDateLabel
            // 
            renewalDateLabel.AutoSize = true;
            renewalDateLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            renewalDateLabel.Location = new Point(25, 34);
            renewalDateLabel.Name = "renewalDateLabel";
            renewalDateLabel.Size = new Size(41, 23);
            renewalDateLabel.TabIndex = 5;
            renewalDateLabel.Text = "date";
            renewalDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(127, 23, 52);
            label16.Location = new Point(10, 2);
            label16.Name = "label16";
            label16.Size = new Size(122, 28);
            label16.TabIndex = 4;
            label16.Text = "Renewal Date";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // historyBtn
            // 
            historyBtn.BackColor = Color.FromArgb(127, 23, 52);
            historyBtn.FlatStyle = FlatStyle.Flat;
            historyBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historyBtn.ForeColor = Color.Transparent;
            historyBtn.Location = new Point(808, 16);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new Size(105, 35);
            historyBtn.TabIndex = 8;
            historyBtn.Text = "History";
            historyBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(127, 23, 52);
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.Transparent;
            EditBtn.Location = new Point(808, 57);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(105, 35);
            EditBtn.TabIndex = 9;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(127, 23, 52);
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.Transparent;
            deleteBtn.Location = new Point(808, 98);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(105, 35);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // accountProfile
            // 
            accountProfile.Controls.Add(panel1);
            accountProfile.Controls.Add(label4);
            accountProfile.Controls.Add(label3);
            accountProfile.Controls.Add(label2);
            accountProfile.Controls.Add(label1);
            accountProfile.Controls.Add(deleteBtn);
            accountProfile.Controls.Add(EditBtn);
            accountProfile.Controls.Add(historyBtn);
            accountProfile.Controls.Add(panel5);
            accountProfile.Controls.Add(panel4);
            accountProfile.Controls.Add(panel3);
            accountProfile.Controls.Add(userIdLabel);
            accountProfile.Controls.Add(usernameLabel);
            accountProfile.Controls.Add(fullNameLabel);
            accountProfile.Controls.Add(pictureBox1);
            accountProfile.Location = new Point(0, 0);
            accountProfile.Name = "accountProfile";
            accountProfile.Size = new Size(929, 150);
            accountProfile.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.Controls.Add(roleLabel);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(243, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 66);
            panel1.TabIndex = 6;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(23, 34);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(34, 23);
            roleLabel.TabIndex = 5;
            roleLabel.Text = "role";
            roleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(127, 23, 52);
            label6.Location = new Point(32, 1);
            label6.Name = "label6";
            label6.Size = new Size(46, 28);
            label6.TabIndex = 4;
            label6.Text = "Role";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(127, 23, 52);
            label4.Location = new Point(1, 147);
            label4.Name = "label4";
            label4.Size = new Size(927, 2);
            label4.TabIndex = 38;
            label4.Text = "OR";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(127, 23, 52);
            label3.Location = new Point(1, 1);
            label3.Name = "label3";
            label3.Size = new Size(927, 2);
            label3.TabIndex = 37;
            label3.Text = "OR";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(127, 23, 52);
            label2.Location = new Point(1, 1);
            label2.Name = "label2";
            label2.Size = new Size(2, 148);
            label2.TabIndex = 36;
            label2.Text = "OR";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(127, 23, 52);
            label1.Location = new Point(926, 1);
            label1.Name = "label1";
            label1.Size = new Size(2, 148);
            label1.TabIndex = 35;
            label1.Text = "OR";
            // 
            // AccountCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(accountProfile);
            Name = "AccountCard";
            Size = new Size(929, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            accountProfile.ResumeLayout(false);
            accountProfile.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label fullNameLabel;
        private Label usernameLabel;
        private Label userIdLabel;
        private Panel panel3;
        private Label tierLabel;
        private Label label10;
        private Panel panel4;
        private Label subDateLabel;
        private Label label13;
        private Panel panel5;
        private Label renewalDateLabel;
        private Label label16;
        private Button historyBtn;
        private Button EditBtn;
        private Button deleteBtn;
        private Panel accountProfile;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label roleLabel;
        private Label label6;
    }
}
