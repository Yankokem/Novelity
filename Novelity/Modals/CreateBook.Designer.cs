namespace Novelity.Modals
{
    partial class CreateBook
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
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            addPublisherField = new TextBox();
            label8 = new Label();
            label9 = new Label();
            addAuthorField = new TextBox();
            label6 = new Label();
            label7 = new Label();
            addTitleField = new TextBox();
            addReleaseDate = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label5 = new Label();
            Copies = new Label();
            addCopiesField = new TextBox();
            checkFantasy = new CheckBox();
            checkSF = new CheckBox();
            checkMystery = new CheckBox();
            checkThriller = new CheckBox();
            checkHorror = new CheckBox();
            checkCL = new CheckBox();
            checkYA = new CheckBox();
            checkAdventure = new CheckBox();
            checkHF = new CheckBox();
            checkRomance = new CheckBox();
            checkClassics = new CheckBox();
            checkPoetry = new CheckBox();
            checkSH = new CheckBox();
            checkBiography = new CheckBox();
            checkNF = new CheckBox();
            checkMemoir = new CheckBox();
            checkCrimeFiction = new CheckBox();
            checkContempFiction = new CheckBox();
            checkComics = new CheckBox();
            checkDystopian = new CheckBox();
            addDescriptionField = new TextBox();
            AddBookBtn = new Button();
            closeBtn = new PictureBox();
            label1 = new Label();
            genrePanel = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            imageLabel = new Label();
            addImageBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            genrePanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(127, 23, 52);
            label13.Location = new Point(20, 295);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 37;
            label13.Text = "Release Date";
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(127, 23, 52);
            label10.Location = new Point(20, 219);
            label10.Name = "label10";
            label10.Size = new Size(230, 2);
            label10.TabIndex = 35;
            label10.Text = "OR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(127, 23, 52);
            label11.Location = new Point(19, 172);
            label11.Name = "label11";
            label11.Size = new Size(69, 23);
            label11.TabIndex = 34;
            label11.Text = "Publisher";
            // 
            // addPublisherField
            // 
            addPublisherField.Location = new Point(19, 198);
            addPublisherField.Name = "addPublisherField";
            addPublisherField.Size = new Size(233, 23);
            addPublisherField.TabIndex = 33;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(127, 23, 52);
            label8.Location = new Point(20, 159);
            label8.Name = "label8";
            label8.Size = new Size(230, 2);
            label8.TabIndex = 32;
            label8.Text = "OR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(127, 23, 52);
            label9.Location = new Point(19, 112);
            label9.Name = "label9";
            label9.Size = new Size(53, 23);
            label9.TabIndex = 31;
            label9.Text = "Author";
            // 
            // addAuthorField
            // 
            addAuthorField.Location = new Point(19, 138);
            addAuthorField.Name = "addAuthorField";
            addAuthorField.Size = new Size(233, 23);
            addAuthorField.TabIndex = 30;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(127, 23, 52);
            label6.Location = new Point(20, 103);
            label6.Name = "label6";
            label6.Size = new Size(230, 2);
            label6.TabIndex = 29;
            label6.Text = "OR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(127, 23, 52);
            label7.Location = new Point(19, 56);
            label7.Name = "label7";
            label7.Size = new Size(36, 23);
            label7.TabIndex = 28;
            label7.Text = "Title";
            // 
            // addTitleField
            // 
            addTitleField.Location = new Point(19, 82);
            addTitleField.Name = "addTitleField";
            addTitleField.Size = new Size(233, 23);
            addTitleField.TabIndex = 27;
            // 
            // addReleaseDate
            // 
            addReleaseDate.Location = new Point(19, 321);
            addReleaseDate.Name = "addReleaseDate";
            addReleaseDate.Size = new Size(200, 23);
            addReleaseDate.TabIndex = 38;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(127, 23, 52);
            label5.Location = new Point(21, 280);
            label5.Name = "label5";
            label5.Size = new Size(230, 2);
            label5.TabIndex = 41;
            label5.Text = "OR";
            // 
            // Copies
            // 
            Copies.AutoSize = true;
            Copies.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Copies.ForeColor = Color.FromArgb(127, 23, 52);
            Copies.Location = new Point(20, 233);
            Copies.Name = "Copies";
            Copies.Size = new Size(55, 23);
            Copies.TabIndex = 40;
            Copies.Text = "Copies";
            // 
            // addCopiesField
            // 
            addCopiesField.Location = new Point(20, 259);
            addCopiesField.Name = "addCopiesField";
            addCopiesField.Size = new Size(233, 23);
            addCopiesField.TabIndex = 39;
            // 
            // checkFantasy
            // 
            checkFantasy.AutoSize = true;
            checkFantasy.Location = new Point(16, 0);
            checkFantasy.Name = "checkFantasy";
            checkFantasy.Size = new Size(66, 19);
            checkFantasy.TabIndex = 43;
            checkFantasy.Text = "Fantasy";
            checkFantasy.UseVisualStyleBackColor = true;
            // 
            // checkSF
            // 
            checkSF.AutoSize = true;
            checkSF.Location = new Point(16, 25);
            checkSF.Name = "checkSF";
            checkSF.Size = new Size(105, 19);
            checkSF.TabIndex = 44;
            checkSF.Text = "Science Fiction";
            checkSF.UseVisualStyleBackColor = true;
            // 
            // checkMystery
            // 
            checkMystery.AutoSize = true;
            checkMystery.Location = new Point(16, 50);
            checkMystery.Name = "checkMystery";
            checkMystery.Size = new Size(68, 19);
            checkMystery.TabIndex = 45;
            checkMystery.Text = "Mystery";
            checkMystery.UseVisualStyleBackColor = true;
            // 
            // checkThriller
            // 
            checkThriller.AutoSize = true;
            checkThriller.Location = new Point(16, 75);
            checkThriller.Name = "checkThriller";
            checkThriller.Size = new Size(63, 19);
            checkThriller.TabIndex = 46;
            checkThriller.Text = "Thriller";
            checkThriller.UseVisualStyleBackColor = true;
            // 
            // checkHorror
            // 
            checkHorror.AutoSize = true;
            checkHorror.Location = new Point(16, 100);
            checkHorror.Name = "checkHorror";
            checkHorror.Size = new Size(61, 19);
            checkHorror.TabIndex = 47;
            checkHorror.Text = "Horror";
            checkHorror.UseVisualStyleBackColor = true;
            // 
            // checkCL
            // 
            checkCL.AutoSize = true;
            checkCL.Location = new Point(125, 100);
            checkCL.Name = "checkCL";
            checkCL.Size = new Size(132, 19);
            checkCL.TabIndex = 52;
            checkCL.Text = "Children’s Literature";
            checkCL.UseVisualStyleBackColor = true;
            // 
            // checkYA
            // 
            checkYA.AutoSize = true;
            checkYA.Location = new Point(125, 75);
            checkYA.Name = "checkYA";
            checkYA.Size = new Size(117, 19);
            checkYA.TabIndex = 51;
            checkYA.Text = "Young Adult (YA)";
            checkYA.UseVisualStyleBackColor = true;
            // 
            // checkAdventure
            // 
            checkAdventure.AutoSize = true;
            checkAdventure.Location = new Point(125, 50);
            checkAdventure.Name = "checkAdventure";
            checkAdventure.Size = new Size(81, 19);
            checkAdventure.TabIndex = 50;
            checkAdventure.Text = "Adventure";
            checkAdventure.UseVisualStyleBackColor = true;
            // 
            // checkHF
            // 
            checkHF.AutoSize = true;
            checkHF.Location = new Point(125, 25);
            checkHF.Name = "checkHF";
            checkHF.Size = new Size(115, 19);
            checkHF.TabIndex = 49;
            checkHF.Text = "Historical Fiction";
            checkHF.UseVisualStyleBackColor = true;
            // 
            // checkRomance
            // 
            checkRomance.AutoSize = true;
            checkRomance.Location = new Point(125, 0);
            checkRomance.Name = "checkRomance";
            checkRomance.Size = new Size(76, 19);
            checkRomance.TabIndex = 48;
            checkRomance.Text = "Romance";
            checkRomance.UseVisualStyleBackColor = true;
            // 
            // checkClassics
            // 
            checkClassics.AutoSize = true;
            checkClassics.Location = new Point(267, 100);
            checkClassics.Name = "checkClassics";
            checkClassics.Size = new Size(67, 19);
            checkClassics.TabIndex = 57;
            checkClassics.Text = "Classics";
            checkClassics.UseVisualStyleBackColor = true;
            // 
            // checkPoetry
            // 
            checkPoetry.AutoSize = true;
            checkPoetry.Location = new Point(267, 75);
            checkPoetry.Name = "checkPoetry";
            checkPoetry.Size = new Size(60, 19);
            checkPoetry.TabIndex = 56;
            checkPoetry.Text = "Poetry";
            checkPoetry.UseVisualStyleBackColor = true;
            // 
            // checkSH
            // 
            checkSH.AutoSize = true;
            checkSH.Location = new Point(267, 50);
            checkSH.Name = "checkSH";
            checkSH.Size = new Size(75, 19);
            checkSH.TabIndex = 55;
            checkSH.Text = "Self-Help";
            checkSH.UseVisualStyleBackColor = true;
            // 
            // checkBiography
            // 
            checkBiography.AutoSize = true;
            checkBiography.Location = new Point(267, 25);
            checkBiography.Name = "checkBiography";
            checkBiography.Size = new Size(80, 19);
            checkBiography.TabIndex = 54;
            checkBiography.Text = "Biography";
            checkBiography.UseVisualStyleBackColor = true;
            // 
            // checkNF
            // 
            checkNF.AutoSize = true;
            checkNF.Location = new Point(267, 0);
            checkNF.Name = "checkNF";
            checkNF.Size = new Size(90, 19);
            checkNF.TabIndex = 53;
            checkNF.Text = "Non-Fiction";
            checkNF.UseVisualStyleBackColor = true;
            // 
            // checkMemoir
            // 
            checkMemoir.AutoSize = true;
            checkMemoir.Location = new Point(370, 100);
            checkMemoir.Name = "checkMemoir";
            checkMemoir.Size = new Size(68, 19);
            checkMemoir.TabIndex = 62;
            checkMemoir.Text = "Memoir";
            checkMemoir.UseVisualStyleBackColor = true;
            // 
            // checkCrimeFiction
            // 
            checkCrimeFiction.AutoSize = true;
            checkCrimeFiction.Location = new Point(370, 75);
            checkCrimeFiction.Name = "checkCrimeFiction";
            checkCrimeFiction.Size = new Size(97, 19);
            checkCrimeFiction.TabIndex = 61;
            checkCrimeFiction.Text = "Crime Fiction";
            checkCrimeFiction.UseVisualStyleBackColor = true;
            // 
            // checkContempFiction
            // 
            checkContempFiction.AutoSize = true;
            checkContempFiction.Location = new Point(370, 50);
            checkContempFiction.Name = "checkContempFiction";
            checkContempFiction.Size = new Size(142, 19);
            checkContempFiction.TabIndex = 60;
            checkContempFiction.Text = "Contemporary Fiction";
            checkContempFiction.UseVisualStyleBackColor = true;
            // 
            // checkComics
            // 
            checkComics.AutoSize = true;
            checkComics.Location = new Point(370, 25);
            checkComics.Name = "checkComics";
            checkComics.Size = new Size(66, 19);
            checkComics.TabIndex = 59;
            checkComics.Text = "Comics";
            checkComics.UseVisualStyleBackColor = true;
            // 
            // checkDystopian
            // 
            checkDystopian.AutoSize = true;
            checkDystopian.Location = new Point(370, 0);
            checkDystopian.Name = "checkDystopian";
            checkDystopian.Size = new Size(79, 19);
            checkDystopian.TabIndex = 58;
            checkDystopian.Text = "Dystopian";
            checkDystopian.UseVisualStyleBackColor = true;
            // 
            // addDescriptionField
            // 
            addDescriptionField.Location = new Point(268, 82);
            addDescriptionField.Multiline = true;
            addDescriptionField.Name = "addDescriptionField";
            addDescriptionField.Size = new Size(412, 262);
            addDescriptionField.TabIndex = 63;
            // 
            // AddBookBtn
            // 
            AddBookBtn.BackColor = Color.FromArgb(127, 23, 52);
            AddBookBtn.FlatStyle = FlatStyle.Flat;
            AddBookBtn.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBookBtn.ForeColor = Color.Transparent;
            AddBookBtn.Location = new Point(579, 442);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(109, 40);
            AddBookBtn.TabIndex = 64;
            AddBookBtn.Text = "Add Book";
            AddBookBtn.UseVisualStyleBackColor = false;
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Image = Properties.Resources.x_red;
            closeBtn.Location = new Point(668, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(20, 20);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 65;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(127, 23, 52);
            label1.Location = new Point(268, 56);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 66;
            label1.Text = "Description";
            // 
            // genrePanel
            // 
            genrePanel.Controls.Add(checkSF);
            genrePanel.Controls.Add(checkFantasy);
            genrePanel.Controls.Add(checkMystery);
            genrePanel.Controls.Add(checkThriller);
            genrePanel.Controls.Add(checkHorror);
            genrePanel.Controls.Add(checkMemoir);
            genrePanel.Controls.Add(checkAdventure);
            genrePanel.Controls.Add(checkCrimeFiction);
            genrePanel.Controls.Add(checkRomance);
            genrePanel.Controls.Add(checkContempFiction);
            genrePanel.Controls.Add(checkHF);
            genrePanel.Controls.Add(checkComics);
            genrePanel.Controls.Add(checkDystopian);
            genrePanel.Controls.Add(checkYA);
            genrePanel.Controls.Add(checkCL);
            genrePanel.Controls.Add(checkClassics);
            genrePanel.Controls.Add(checkSH);
            genrePanel.Controls.Add(checkPoetry);
            genrePanel.Controls.Add(checkNF);
            genrePanel.Controls.Add(checkBiography);
            genrePanel.Location = new Point(19, 363);
            genrePanel.Name = "genrePanel";
            genrePanel.Size = new Size(516, 119);
            genrePanel.TabIndex = 67;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(127, 23, 52);
            label2.Location = new Point(268, 342);
            label2.Name = "label2";
            label2.Size = new Size(412, 2);
            label2.TabIndex = 68;
            label2.Text = "OR";
            // 
            // panel2
            // 
            panel2.Controls.Add(imageLabel);
            panel2.Controls.Add(addImageBtn);
            panel2.Location = new Point(337, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 47);
            panel2.TabIndex = 69;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(94, 15);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(83, 15);
            imageLabel.TabIndex = 1;
            imageLabel.Text = "Choose image";
            // 
            // addImageBtn
            // 
            addImageBtn.Location = new Point(13, 11);
            addImageBtn.Name = "addImageBtn";
            addImageBtn.Size = new Size(75, 23);
            addImageBtn.TabIndex = 0;
            addImageBtn.Text = "Add Image";
            addImageBtn.UseVisualStyleBackColor = true;
            addImageBtn.Click += addImageBtn_Click;
            // 
            // CreateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(genrePanel);
            Controls.Add(label1);
            Controls.Add(closeBtn);
            Controls.Add(AddBookBtn);
            Controls.Add(addDescriptionField);
            Controls.Add(label5);
            Controls.Add(Copies);
            Controls.Add(addCopiesField);
            Controls.Add(addReleaseDate);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(addPublisherField);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(addAuthorField);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(addTitleField);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateBook";
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            genrePanel.ResumeLayout(false);
            genrePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label10;
        private Label label11;
        private TextBox addPublisherField;
        private Label label8;
        private Label label9;
        private TextBox addAuthorField;
        private Label label6;
        private Label label7;
        private TextBox addTitleField;
        private DateTimePicker addReleaseDate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private Label Copies;
        private TextBox addCopiesField;
        private CheckBox checkFantasy;
        private CheckBox checkSF;
        private CheckBox checkMystery;
        private CheckBox checkThriller;
        private CheckBox checkHorror;
        private CheckBox checkCL;
        private CheckBox checkYA;
        private CheckBox checkAdventure;
        private CheckBox checkHF;
        private CheckBox checkRomance;
        private CheckBox checkClassics;
        private CheckBox checkPoetry;
        private CheckBox checkSH;
        private CheckBox checkBiography;
        private CheckBox checkNF;
        private CheckBox checkMemoir;
        private CheckBox checkCrimeFiction;
        private CheckBox checkContempFiction;
        private CheckBox checkComics;
        private CheckBox checkDystopian;
        private TextBox addDescriptionField;
        private Button AddBookBtn;
        private PictureBox closeBtn;
        private Label label1;
        private Panel genrePanel;
        private Label label2;
        private Panel panel2;
        private Label imageLabel;
        private Button addImageBtn;
    }
}