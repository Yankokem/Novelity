namespace Novelity
{
    partial class Books
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            filterPanel = new Panel();
            rentedBox = new CheckBox();
            clearFiltersBtn = new Button();
            availableBox = new CheckBox();
            dateBox = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            booksPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            booksSearchbar = new TextBox();
            panel2 = new Panel();
            label16 = new Label();
            label14 = new Label();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            filterFlowLayout = new FlowLayoutPanel();
            selectGenreBtn = new Button();
            memoirBtn = new Button();
            crimeFictionBtn = new Button();
            romanceBtn = new Button();
            adventureBtn = new Button();
            classicsBtn = new Button();
            poetryBtn = new Button();
            dystopianBtn = new Button();
            contemporaryBtn = new Button();
            thrillerBtn = new Button();
            scifiBtn = new Button();
            youngAdultBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            filterPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            filterFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(960, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 1500);
            label1.TabIndex = 30;
            label1.Text = "OR";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(1600, 0);
            label2.Name = "label2";
            label2.Size = new Size(1, 1500);
            label2.TabIndex = 31;
            label2.Text = "OR";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(319, 0);
            label3.Name = "label3";
            label3.Size = new Size(1, 1500);
            label3.TabIndex = 32;
            label3.Text = "OR";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(127, 23, 52);
            filterPanel.Controls.Add(rentedBox);
            filterPanel.Controls.Add(clearFiltersBtn);
            filterPanel.Controls.Add(availableBox);
            filterPanel.Controls.Add(dateBox);
            filterPanel.Controls.Add(label7);
            filterPanel.Controls.Add(label4);
            filterPanel.Location = new Point(319, 108);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(270, 213);
            filterPanel.TabIndex = 33;
            // 
            // rentedBox
            // 
            rentedBox.AutoSize = true;
            rentedBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentedBox.ForeColor = Color.Transparent;
            rentedBox.Location = new Point(16, 129);
            rentedBox.Name = "rentedBox";
            rentedBox.Size = new Size(83, 30);
            rentedBox.TabIndex = 61;
            rentedBox.Text = "Rented";
            rentedBox.UseVisualStyleBackColor = true;
            // 
            // clearFiltersBtn
            // 
            clearFiltersBtn.Location = new Point(168, 167);
            clearFiltersBtn.Name = "clearFiltersBtn";
            clearFiltersBtn.Size = new Size(84, 27);
            clearFiltersBtn.TabIndex = 55;
            clearFiltersBtn.Text = "Clear";
            clearFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // availableBox
            // 
            availableBox.AutoSize = true;
            availableBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availableBox.ForeColor = Color.Transparent;
            availableBox.Location = new Point(16, 108);
            availableBox.Name = "availableBox";
            availableBox.Size = new Size(100, 30);
            availableBox.TabIndex = 60;
            availableBox.Text = "Available";
            availableBox.UseVisualStyleBackColor = true;
            // 
            // dateBox
            // 
            dateBox.BackColor = Color.FromArgb(127, 23, 52);
            dateBox.FlatStyle = FlatStyle.Flat;
            dateBox.Font = new Font("Segoe UI", 11F);
            dateBox.ForeColor = Color.Transparent;
            dateBox.FormattingEnabled = true;
            dateBox.Items.AddRange(new object[] { "Newest to Oldest", "Oldest to Newest" });
            dateBox.Location = new Point(107, 27);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(145, 28);
            dateBox.TabIndex = 13;
            dateBox.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(16, 75);
            label7.Name = "label7";
            label7.Size = new Size(186, 34);
            label7.TabIndex = 59;
            label7.Text = "Availability Status";
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
            // booksPanel
            // 
            booksPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            booksPanel.BackColor = SystemColors.Control;
            booksPanel.Location = new Point(614, 108);
            booksPanel.Margin = new Padding(0);
            booksPanel.Name = "booksPanel";
            booksPanel.Size = new Size(1018, 14138);
            booksPanel.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(booksSearchbar);
            panel1.Location = new Point(614, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 48);
            panel1.TabIndex = 36;
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
            // label8
            // 
            label8.BackColor = Color.FromArgb(127, 23, 52);
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(2, 0);
            label8.Name = "label8";
            label8.Size = new Size(700, 2);
            label8.TabIndex = 35;
            label8.Text = "OR";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(127, 23, 52);
            label9.Dock = DockStyle.Bottom;
            label9.Location = new Point(2, 46);
            label9.Name = "label9";
            label9.Size = new Size(700, 2);
            label9.TabIndex = 36;
            label9.Text = "OR";
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(127, 23, 52);
            label10.Dock = DockStyle.Right;
            label10.Location = new Point(702, 0);
            label10.Name = "label10";
            label10.Size = new Size(2, 48);
            label10.TabIndex = 35;
            label10.Text = "OR";
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(127, 23, 52);
            label11.Dock = DockStyle.Left;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(2, 48);
            label11.TabIndex = 34;
            label11.Text = "OR";
            // 
            // booksSearchbar
            // 
            booksSearchbar.BackColor = SystemColors.Control;
            booksSearchbar.BorderStyle = BorderStyle.None;
            booksSearchbar.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booksSearchbar.Location = new Point(52, 11);
            booksSearchbar.Multiline = true;
            booksSearchbar.Name = "booksSearchbar";
            booksSearchbar.PlaceholderText = "Enter book name...";
            booksSearchbar.Size = new Size(644, 26);
            booksSearchbar.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(127, 23, 52);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(1335, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 48);
            panel2.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Poppins", 12F);
            label16.ForeColor = Color.Transparent;
            label16.Location = new Point(8, 11);
            label16.Name = "label16";
            label16.Size = new Size(190, 28);
            label16.TabIndex = 13;
            label16.Text = "Total Books on Record:";
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(127, 23, 52);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(2, 48);
            label14.TabIndex = 43;
            label14.Text = "OR";
            // 
            // label15
            // 
            label15.BackColor = Color.FromArgb(127, 23, 52);
            label15.Location = new Point(234, 2);
            label15.Name = "label15";
            label15.Size = new Size(2, 48);
            label15.TabIndex = 44;
            label15.Text = "OR";
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(127, 23, 52);
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(236, 2);
            label13.TabIndex = 55;
            label13.Text = "OR";
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(127, 23, 52);
            label12.Location = new Point(0, 46);
            label12.Name = "label12";
            label12.Size = new Size(236, 2);
            label12.TabIndex = 54;
            label12.Text = "OR";
            // 
            // filterFlowLayout
            // 
            filterFlowLayout.BackColor = Color.FromArgb(255, 192, 192);
            filterFlowLayout.Controls.Add(selectGenreBtn);
            filterFlowLayout.Controls.Add(memoirBtn);
            filterFlowLayout.Controls.Add(crimeFictionBtn);
            filterFlowLayout.Controls.Add(romanceBtn);
            filterFlowLayout.Controls.Add(adventureBtn);
            filterFlowLayout.Controls.Add(classicsBtn);
            filterFlowLayout.Controls.Add(poetryBtn);
            filterFlowLayout.Controls.Add(dystopianBtn);
            filterFlowLayout.Controls.Add(contemporaryBtn);
            filterFlowLayout.Controls.Add(thrillerBtn);
            filterFlowLayout.Controls.Add(scifiBtn);
            filterFlowLayout.Controls.Add(youngAdultBtn);
            filterFlowLayout.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterFlowLayout.Location = new Point(319, 340);
            filterFlowLayout.MaximumSize = new Size(270, 383);
            filterFlowLayout.MinimumSize = new Size(270, 42);
            filterFlowLayout.Name = "filterFlowLayout";
            filterFlowLayout.Size = new Size(270, 42);
            filterFlowLayout.TabIndex = 39;
            // 
            // selectGenreBtn
            // 
            selectGenreBtn.BackColor = Color.FromArgb(127, 23, 52);
            selectGenreBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectGenreBtn.ForeColor = Color.Transparent;
            selectGenreBtn.ImageAlign = ContentAlignment.MiddleRight;
            selectGenreBtn.Location = new Point(0, 0);
            selectGenreBtn.Margin = new Padding(0);
            selectGenreBtn.Name = "selectGenreBtn";
            selectGenreBtn.Padding = new Padding(10, 0, 10, 0);
            selectGenreBtn.Size = new Size(270, 42);
            selectGenreBtn.TabIndex = 1;
            selectGenreBtn.Text = "Select Genre";
            selectGenreBtn.TextAlign = ContentAlignment.MiddleLeft;
            selectGenreBtn.UseVisualStyleBackColor = false;
            selectGenreBtn.Click += button2_Click;
            // 
            // memoirBtn
            // 
            memoirBtn.BackColor = Color.FromArgb(255, 192, 192);
            memoirBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memoirBtn.ForeColor = Color.Black;
            memoirBtn.ImageAlign = ContentAlignment.MiddleRight;
            memoirBtn.Location = new Point(0, 42);
            memoirBtn.Margin = new Padding(0);
            memoirBtn.Name = "memoirBtn";
            memoirBtn.Padding = new Padding(10, 0, 10, 0);
            memoirBtn.Size = new Size(270, 31);
            memoirBtn.TabIndex = 2;
            memoirBtn.Text = "Memoir";
            memoirBtn.TextAlign = ContentAlignment.MiddleLeft;
            memoirBtn.UseVisualStyleBackColor = false;
            // 
            // crimeFictionBtn
            // 
            crimeFictionBtn.BackColor = Color.FromArgb(255, 192, 192);
            crimeFictionBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crimeFictionBtn.ForeColor = Color.Black;
            crimeFictionBtn.ImageAlign = ContentAlignment.MiddleRight;
            crimeFictionBtn.Location = new Point(0, 73);
            crimeFictionBtn.Margin = new Padding(0);
            crimeFictionBtn.Name = "crimeFictionBtn";
            crimeFictionBtn.Padding = new Padding(10, 0, 10, 0);
            crimeFictionBtn.Size = new Size(270, 31);
            crimeFictionBtn.TabIndex = 3;
            crimeFictionBtn.Text = "Crime Fiction";
            crimeFictionBtn.TextAlign = ContentAlignment.MiddleLeft;
            crimeFictionBtn.UseVisualStyleBackColor = false;
            // 
            // romanceBtn
            // 
            romanceBtn.BackColor = Color.FromArgb(255, 192, 192);
            romanceBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            romanceBtn.ForeColor = Color.Black;
            romanceBtn.ImageAlign = ContentAlignment.MiddleRight;
            romanceBtn.Location = new Point(0, 104);
            romanceBtn.Margin = new Padding(0);
            romanceBtn.Name = "romanceBtn";
            romanceBtn.Padding = new Padding(10, 0, 10, 0);
            romanceBtn.Size = new Size(270, 31);
            romanceBtn.TabIndex = 4;
            romanceBtn.Text = "Romance";
            romanceBtn.TextAlign = ContentAlignment.MiddleLeft;
            romanceBtn.UseVisualStyleBackColor = false;
            // 
            // adventureBtn
            // 
            adventureBtn.BackColor = Color.FromArgb(255, 192, 192);
            adventureBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adventureBtn.ForeColor = Color.Black;
            adventureBtn.ImageAlign = ContentAlignment.MiddleRight;
            adventureBtn.Location = new Point(0, 135);
            adventureBtn.Margin = new Padding(0);
            adventureBtn.Name = "adventureBtn";
            adventureBtn.Padding = new Padding(10, 0, 10, 0);
            adventureBtn.Size = new Size(270, 31);
            adventureBtn.TabIndex = 5;
            adventureBtn.Text = "Adventure";
            adventureBtn.TextAlign = ContentAlignment.MiddleLeft;
            adventureBtn.UseVisualStyleBackColor = false;
            // 
            // classicsBtn
            // 
            classicsBtn.BackColor = Color.FromArgb(255, 192, 192);
            classicsBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classicsBtn.ForeColor = Color.Black;
            classicsBtn.ImageAlign = ContentAlignment.MiddleRight;
            classicsBtn.Location = new Point(0, 166);
            classicsBtn.Margin = new Padding(0);
            classicsBtn.Name = "classicsBtn";
            classicsBtn.Padding = new Padding(10, 0, 10, 0);
            classicsBtn.Size = new Size(270, 31);
            classicsBtn.TabIndex = 6;
            classicsBtn.Text = "Classics";
            classicsBtn.TextAlign = ContentAlignment.MiddleLeft;
            classicsBtn.UseVisualStyleBackColor = false;
            // 
            // poetryBtn
            // 
            poetryBtn.BackColor = Color.FromArgb(255, 192, 192);
            poetryBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            poetryBtn.ForeColor = Color.Black;
            poetryBtn.ImageAlign = ContentAlignment.MiddleRight;
            poetryBtn.Location = new Point(0, 197);
            poetryBtn.Margin = new Padding(0);
            poetryBtn.Name = "poetryBtn";
            poetryBtn.Padding = new Padding(10, 0, 10, 0);
            poetryBtn.Size = new Size(270, 31);
            poetryBtn.TabIndex = 7;
            poetryBtn.Text = "Poetry";
            poetryBtn.TextAlign = ContentAlignment.MiddleLeft;
            poetryBtn.UseVisualStyleBackColor = false;
            // 
            // dystopianBtn
            // 
            dystopianBtn.BackColor = Color.FromArgb(255, 192, 192);
            dystopianBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dystopianBtn.ForeColor = Color.Black;
            dystopianBtn.ImageAlign = ContentAlignment.MiddleRight;
            dystopianBtn.Location = new Point(0, 228);
            dystopianBtn.Margin = new Padding(0);
            dystopianBtn.Name = "dystopianBtn";
            dystopianBtn.Padding = new Padding(10, 0, 10, 0);
            dystopianBtn.Size = new Size(270, 31);
            dystopianBtn.TabIndex = 8;
            dystopianBtn.Text = "Dystopian";
            dystopianBtn.TextAlign = ContentAlignment.MiddleLeft;
            dystopianBtn.UseVisualStyleBackColor = false;
            // 
            // contemporaryBtn
            // 
            contemporaryBtn.BackColor = Color.FromArgb(255, 192, 192);
            contemporaryBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contemporaryBtn.ForeColor = Color.Black;
            contemporaryBtn.ImageAlign = ContentAlignment.MiddleRight;
            contemporaryBtn.Location = new Point(0, 259);
            contemporaryBtn.Margin = new Padding(0);
            contemporaryBtn.Name = "contemporaryBtn";
            contemporaryBtn.Padding = new Padding(10, 0, 10, 0);
            contemporaryBtn.Size = new Size(270, 31);
            contemporaryBtn.TabIndex = 9;
            contemporaryBtn.Text = "Contemporary Fiction";
            contemporaryBtn.TextAlign = ContentAlignment.MiddleLeft;
            contemporaryBtn.UseVisualStyleBackColor = false;
            // 
            // thrillerBtn
            // 
            thrillerBtn.BackColor = Color.FromArgb(255, 192, 192);
            thrillerBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thrillerBtn.ForeColor = Color.Black;
            thrillerBtn.ImageAlign = ContentAlignment.MiddleRight;
            thrillerBtn.Location = new Point(0, 290);
            thrillerBtn.Margin = new Padding(0);
            thrillerBtn.Name = "thrillerBtn";
            thrillerBtn.Padding = new Padding(10, 0, 10, 0);
            thrillerBtn.Size = new Size(270, 31);
            thrillerBtn.TabIndex = 10;
            thrillerBtn.Text = "Thriller";
            thrillerBtn.TextAlign = ContentAlignment.MiddleLeft;
            thrillerBtn.UseVisualStyleBackColor = false;
            // 
            // scifiBtn
            // 
            scifiBtn.BackColor = Color.FromArgb(255, 192, 192);
            scifiBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scifiBtn.ForeColor = Color.Black;
            scifiBtn.ImageAlign = ContentAlignment.MiddleRight;
            scifiBtn.Location = new Point(0, 321);
            scifiBtn.Margin = new Padding(0);
            scifiBtn.Name = "scifiBtn";
            scifiBtn.Padding = new Padding(10, 0, 10, 0);
            scifiBtn.Size = new Size(270, 31);
            scifiBtn.TabIndex = 11;
            scifiBtn.Text = "Science Fiction";
            scifiBtn.TextAlign = ContentAlignment.MiddleLeft;
            scifiBtn.UseVisualStyleBackColor = false;
            // 
            // youngAdultBtn
            // 
            youngAdultBtn.BackColor = Color.FromArgb(255, 192, 192);
            youngAdultBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            youngAdultBtn.ForeColor = Color.Black;
            youngAdultBtn.ImageAlign = ContentAlignment.MiddleRight;
            youngAdultBtn.Location = new Point(0, 352);
            youngAdultBtn.Margin = new Padding(0);
            youngAdultBtn.Name = "youngAdultBtn";
            youngAdultBtn.Padding = new Padding(10, 0, 10, 0);
            youngAdultBtn.Size = new Size(270, 31);
            youngAdultBtn.TabIndex = 12;
            youngAdultBtn.Text = "Young Adult";
            youngAdultBtn.TextAlign = ContentAlignment.MiddleLeft;
            youngAdultBtn.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(filterFlowLayout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(booksPanel);
            Controls.Add(filterPanel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Books";
            Text = "Books";
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            filterFlowLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel filterPanel;
        private Label label4;
        private FlowLayoutPanel booksPanel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox booksSearchbar;
        private Panel panel2;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label16;
        private Label label15;
        private ComboBox dateBox;
        private FlowLayoutPanel filterFlowLayout;
        private Button selectGenreBtn;
        private System.Windows.Forms.Timer timer1;
        private Button memoirBtn;
        private Button crimeFictionBtn;
        private Button romanceBtn;
        private Button adventureBtn;
        private Button classicsBtn;
        private Button poetryBtn;
        private Button dystopianBtn;
        private Button contemporaryBtn;
        private Button thrillerBtn;
        private Button scifiBtn;
        private Button youngAdultBtn;
        private Button clearFiltersBtn;
        private CheckBox rentedBox;
        private CheckBox availableBox;
        private Label label7;
    }
}