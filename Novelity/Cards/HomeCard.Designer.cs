namespace Novelity.Cards
{
    partial class HomeCard
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
            bookCover = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            authorLabel = new Label();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)bookCover).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bookCover
            // 
            bookCover.Dock = DockStyle.Top;
            bookCover.Image = Properties.Resources.the_monkey_s_paw;
            bookCover.Location = new Point(0, 0);
            bookCover.Name = "bookCover";
            bookCover.Size = new Size(187, 291);
            bookCover.SizeMode = PictureBoxSizeMode.Zoom;
            bookCover.TabIndex = 0;
            bookCover.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(titleLabel);
            flowLayoutPanel1.Controls.Add(authorLabel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 297);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(187, 136);
            flowLayoutPanel1.TabIndex = 27;
            // 
            // authorLabel
            // 
            authorLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            authorLabel.AutoSize = true;
            authorLabel.BackColor = Color.Transparent;
            authorLabel.Font = new Font("Poppins", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            authorLabel.ForeColor = Color.FromArgb(64, 64, 64);
            authorLabel.Location = new Point(3, 63);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(140, 26);
            authorLabel.TabIndex = 26;
            authorLabel.Text = "Haruki Murakami";
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(64, 64, 64);
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(158, 63);
            titleLabel.TabIndex = 25;
            titleLabel.Text = "Les Amants du Spoutnik";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // HomeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(bookCover);
            Margin = new Padding(0);
            Name = "HomeCard";
            Size = new Size(187, 433);
            ((System.ComponentModel.ISupportInitialize)bookCover).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bookCover;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label titleLabel;
        private Label authorLabel;
    }
}
