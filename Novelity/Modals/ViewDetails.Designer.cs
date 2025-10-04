namespace Novelity.Modals
{
    partial class View_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Details));
            label3 = new Label();
            closeBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            createFnField = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            AddBookBtn = new Button();
            ActiveIcon = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActiveIcon).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(127, 23, 52);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(183, 48);
            label3.TabIndex = 71;
            label3.Text = "View Details";
            // 
            // closeBtn
            // 
            closeBtn.Image = Properties.Resources.x_red;
            closeBtn.Location = new Point(368, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(20, 20);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 72;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(127, 23, 52);
            label7.Location = new Point(12, 57);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 74;
            label7.Text = "Rental ID";
            label7.Click += label7_Click;
            // 
            // createFnField
            // 
            createFnField.Location = new Point(12, 83);
            createFnField.Name = "createFnField";
            createFnField.ReadOnly = true;
            createFnField.Size = new Size(222, 23);
            createFnField.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(127, 23, 52);
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 76;
            label1.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 145);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 77;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(127, 23, 52);
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 78;
            label2.Text = "Author";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 209);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(127, 23, 52);
            label4.Location = new Point(12, 247);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 80;
            label4.Text = "Date Rented";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 273);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(222, 23);
            textBox3.TabIndex = 81;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(127, 23, 52);
            label5.Location = new Point(12, 370);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 82;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(127, 23, 52);
            label6.Location = new Point(12, 309);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 83;
            label6.Text = "Due Date";
            // 
            // AddBookBtn
            // 
            AddBookBtn.BackColor = Color.FromArgb(127, 23, 52);
            AddBookBtn.FlatStyle = FlatStyle.Flat;
            AddBookBtn.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBookBtn.ForeColor = Color.Transparent;
            AddBookBtn.Location = new Point(279, 448);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(109, 40);
            AddBookBtn.TabIndex = 86;
            AddBookBtn.Text = "Close";
            AddBookBtn.UseVisualStyleBackColor = false;
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // ActiveIcon
            // 
            ActiveIcon.BackColor = Color.Transparent;
            ActiveIcon.Image = Properties.Resources.active;
            ActiveIcon.Location = new Point(12, 396);
            ActiveIcon.Name = "ActiveIcon";
            ActiveIcon.Size = new Size(92, 31);
            ActiveIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ActiveIcon.TabIndex = 87;
            ActiveIcon.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 335);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 23);
            dateTimePicker1.TabIndex = 88;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(127, 23, 52);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(400, 3);
            label9.TabIndex = 96;
            label9.Text = "OR";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(127, 23, 52);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(3, 500);
            label8.TabIndex = 97;
            label8.Text = "OR";
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(127, 23, 52);
            label10.Location = new Point(397, 0);
            label10.Name = "label10";
            label10.Size = new Size(3, 500);
            label10.TabIndex = 98;
            label10.Text = "OR";
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(127, 23, 52);
            label11.Location = new Point(0, 497);
            label11.Name = "label11";
            label11.Size = new Size(400, 3);
            label11.TabIndex = 99;
            label11.Text = "OR";
            // 
            // View_Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 500);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(ActiveIcon);
            Controls.Add(AddBookBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(createFnField);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(closeBtn);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Details";
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActiveIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox closeBtn;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox createFnField;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Button AddBookBtn;
        private PictureBox ActiveIcon;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
    }
}