namespace Novelity.Pages.Admin
{
    partial class ManageBooks
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
            label14 = new Label();
            label1 = new Label();
            label2 = new Label();
            filterPanel = new Panel();
            clearFiltersBtn = new Button();
            archivedBox = new CheckBox();
            rentedBox = new CheckBox();
            overdueBox = new CheckBox();
            availableBox = new CheckBox();
            label7 = new Label();
            label11 = new Label();
            dateBox = new ComboBox();
            activeBox = new CheckBox();
            inactiveBox = new CheckBox();
            expiredBox = new CheckBox();
            label6 = new Label();
            label4 = new Label();
            createBookModalBtn = new Button();
            manageBooksPanel = new FlowLayoutPanel();
            prevBtn = new Button();
            nextBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            booksSearchbar = new TextBox();
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
            filterFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(960, -460);
            label14.Name = "label14";
            label14.Size = new Size(1, 1500);
            label14.TabIndex = 28;
            label14.Text = "OR";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(319, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 1500);
            label1.TabIndex = 29;
            label1.Text = "OR";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(1600, 0);
            label2.Name = "label2";
            label2.Size = new Size(1, 1500);
            label2.TabIndex = 30;
            label2.Text = "OR";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(127, 23, 52);
            filterPanel.Controls.Add(clearFiltersBtn);
            filterPanel.Controls.Add(archivedBox);
            filterPanel.Controls.Add(rentedBox);
            filterPanel.Controls.Add(overdueBox);
            filterPanel.Controls.Add(availableBox);
            filterPanel.Controls.Add(label7);
            filterPanel.Controls.Add(label11);
            filterPanel.Controls.Add(dateBox);
            filterPanel.Controls.Add(activeBox);
            filterPanel.Controls.Add(inactiveBox);
            filterPanel.Controls.Add(expiredBox);
            filterPanel.Controls.Add(label6);
            filterPanel.Controls.Add(label4);
            filterPanel.Location = new Point(319, 108);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(322, 377);
            filterPanel.TabIndex = 32;
            // 
            // clearFiltersBtn
            // 
            clearFiltersBtn.Location = new Point(217, 328);
            clearFiltersBtn.Name = "clearFiltersBtn";
            clearFiltersBtn.Size = new Size(84, 27);
            clearFiltersBtn.TabIndex = 61;
            clearFiltersBtn.Text = "Clear";
            clearFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // archivedBox
            // 
            archivedBox.AutoSize = true;
            archivedBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archivedBox.ForeColor = Color.Transparent;
            archivedBox.Location = new Point(21, 312);
            archivedBox.Name = "archivedBox";
            archivedBox.Size = new Size(97, 30);
            archivedBox.TabIndex = 60;
            archivedBox.Text = "Archived";
            archivedBox.UseVisualStyleBackColor = true;
            // 
            // rentedBox
            // 
            rentedBox.AutoSize = true;
            rentedBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentedBox.ForeColor = Color.Transparent;
            rentedBox.Location = new Point(21, 289);
            rentedBox.Name = "rentedBox";
            rentedBox.Size = new Size(83, 30);
            rentedBox.TabIndex = 59;
            rentedBox.Text = "Rented";
            rentedBox.UseVisualStyleBackColor = true;
            // 
            // overdueBox
            // 
            overdueBox.AutoSize = true;
            overdueBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            overdueBox.ForeColor = Color.Transparent;
            overdueBox.Location = new Point(21, 266);
            overdueBox.Name = "overdueBox";
            overdueBox.Size = new Size(95, 30);
            overdueBox.TabIndex = 58;
            overdueBox.Text = "Overdue";
            overdueBox.UseVisualStyleBackColor = true;
            // 
            // availableBox
            // 
            availableBox.AutoSize = true;
            availableBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availableBox.ForeColor = Color.Transparent;
            availableBox.Location = new Point(21, 243);
            availableBox.Name = "availableBox";
            availableBox.Size = new Size(100, 30);
            availableBox.TabIndex = 57;
            availableBox.Text = "Available";
            availableBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(15, 210);
            label7.Name = "label7";
            label7.Size = new Size(186, 33);
            label7.TabIndex = 56;
            label7.Text = "Availability Status";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Location = new Point(21, 74);
            label11.Name = "label11";
            label11.Size = new Size(280, 1);
            label11.TabIndex = 55;
            label11.Text = "OR";
            // 
            // dateBox
            // 
            dateBox.BackColor = Color.FromArgb(127, 23, 52);
            dateBox.FlatStyle = FlatStyle.Flat;
            dateBox.Font = new Font("Segoe UI", 11F);
            dateBox.ForeColor = Color.Transparent;
            dateBox.FormattingEnabled = true;
            dateBox.Items.AddRange(new object[] { "Newest to Oldest", "Oldest to Newest" });
            dateBox.Location = new Point(153, 24);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(145, 28);
            dateBox.TabIndex = 14;
            dateBox.Text = "Date";
            // 
            // activeBox
            // 
            activeBox.AutoSize = true;
            activeBox.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activeBox.ForeColor = Color.Transparent;
            activeBox.Location = new Point(21, 167);
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
            inactiveBox.Location = new Point(21, 144);
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
            expiredBox.Location = new Point(21, 121);
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
            label6.Location = new Point(16, 89);
            label6.Name = "label6";
            label6.Size = new Size(75, 33);
            label6.TabIndex = 6;
            label6.Text = "Status";
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
            // createBookModalBtn
            // 
            createBookModalBtn.BackColor = Color.FromArgb(127, 23, 52);
            createBookModalBtn.FlatStyle = FlatStyle.Flat;
            createBookModalBtn.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createBookModalBtn.ForeColor = Color.Transparent;
            createBookModalBtn.Location = new Point(1445, 35);
            createBookModalBtn.Name = "createBookModalBtn";
            createBookModalBtn.Size = new Size(156, 48);
            createBookModalBtn.TabIndex = 33;
            createBookModalBtn.Text = "Add Book";
            createBookModalBtn.UseVisualStyleBackColor = false;
            createBookModalBtn.Click += createBookModalBtn_Click;
            // 
            // manageBooksPanel
            // 
            manageBooksPanel.BackColor = SystemColors.Control;
            manageBooksPanel.FlowDirection = FlowDirection.TopDown;
            manageBooksPanel.Location = new Point(671, 108);
            manageBooksPanel.Name = "manageBooksPanel";
            manageBooksPanel.Size = new Size(935, 707);
            manageBooksPanel.TabIndex = 34;
            manageBooksPanel.Paint += manageBooksPanel_Paint;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.FromArgb(127, 23, 52);
            prevBtn.FlatStyle = FlatStyle.Flat;
            prevBtn.Font = new Font("Poppins", 11.25F);
            prevBtn.ForeColor = Color.White;
            prevBtn.Location = new Point(1050, 844);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(84, 39);
            prevBtn.TabIndex = 35;
            prevBtn.Text = "Prev";
            prevBtn.UseVisualStyleBackColor = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.FromArgb(127, 23, 52);
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Font = new Font("Poppins", 11.25F);
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(1195, 844);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(84, 39);
            nextBtn.TabIndex = 36;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(booksSearchbar);
            panel1.Location = new Point(671, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 48);
            panel1.TabIndex = 33;
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
            // label3
            // 
            label3.BackColor = Color.FromArgb(127, 23, 52);
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(2, 0);
            label3.Name = "label3";
            label3.Size = new Size(752, 2);
            label3.TabIndex = 35;
            label3.Text = "OR";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(127, 23, 52);
            label8.Dock = DockStyle.Bottom;
            label8.Location = new Point(2, 46);
            label8.Name = "label8";
            label8.Size = new Size(752, 2);
            label8.TabIndex = 36;
            label8.Text = "OR";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(127, 23, 52);
            label9.Dock = DockStyle.Right;
            label9.Location = new Point(754, 0);
            label9.Name = "label9";
            label9.Size = new Size(2, 48);
            label9.TabIndex = 35;
            label9.Text = "OR";
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
            // booksSearchbar
            // 
            booksSearchbar.BackColor = SystemColors.Control;
            booksSearchbar.BorderStyle = BorderStyle.None;
            booksSearchbar.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booksSearchbar.Location = new Point(52, 11);
            booksSearchbar.Multiline = true;
            booksSearchbar.Name = "booksSearchbar";
            booksSearchbar.PlaceholderText = "Enter book name...";
            booksSearchbar.Size = new Size(696, 26);
            booksSearchbar.TabIndex = 33;
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
            filterFlowLayout.Location = new Point(319, 506);
            filterFlowLayout.MaximumSize = new Size(322, 383);
            filterFlowLayout.MinimumSize = new Size(270, 42);
            filterFlowLayout.Name = "filterFlowLayout";
            filterFlowLayout.Size = new Size(322, 42);
            filterFlowLayout.TabIndex = 40;
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
            selectGenreBtn.Size = new Size(322, 42);
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
            memoirBtn.Size = new Size(322, 31);
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
            crimeFictionBtn.Size = new Size(322, 31);
            crimeFictionBtn.TabIndex = 3;
            crimeFictionBtn.Text = "CrimeFiction";
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
            romanceBtn.Size = new Size(322, 31);
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
            adventureBtn.Size = new Size(322, 31);
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
            classicsBtn.Size = new Size(322, 31);
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
            poetryBtn.Size = new Size(322, 31);
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
            dystopianBtn.Size = new Size(322, 31);
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
            contemporaryBtn.Size = new Size(322, 31);
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
            thrillerBtn.Size = new Size(322, 31);
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
            scifiBtn.Size = new Size(322, 31);
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
            youngAdultBtn.Size = new Size(322, 31);
            youngAdultBtn.TabIndex = 12;
            youngAdultBtn.Text = "Young Adult";
            youngAdultBtn.TextAlign = ContentAlignment.MiddleLeft;
            youngAdultBtn.UseVisualStyleBackColor = false;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(filterFlowLayout);
            Controls.Add(panel1);
            Controls.Add(nextBtn);
            Controls.Add(prevBtn);
            Controls.Add(manageBooksPanel);
            Controls.Add(createBookModalBtn);
            Controls.Add(filterPanel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageBooks";
            Text = "ManageBooks";
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            filterFlowLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label14;
        private Label label1;
        private Label label2;
        private Panel filterPanel;
        private CheckBox activeBox;
        private CheckBox inactiveBox;
        private CheckBox expiredBox;
        private Label label6;
        private Label label4;
        private Button createBookModalBtn;
        private FlowLayoutPanel manageBooksPanel;
        private Button prevBtn;
        private Button nextBtn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox booksSearchbar;
        private ComboBox dateBox;
        private Label label11;
        private CheckBox overdueBox;
        private CheckBox availableBox;
        private Label label7;
        private FlowLayoutPanel filterFlowLayout;
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
        private Button selectGenreBtn;
        private CheckBox archivedBox;
        private CheckBox rentedBox;
        private Button clearFiltersBtn;
        private System.Windows.Forms.Timer timer1;
    }
}