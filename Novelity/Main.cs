namespace Novelity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelContent.AutoScroll = false; // Disable scrolling on panelContent
            this.Load += Form1_Load; // Attach Load event handler
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm(new Home()); // Load Home form on startup
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.Size = panelContent.Size; // Match panel size
            panelContent.Controls.Clear(); // Clear previous content
            panelContent.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Home());
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Books());
        }

        private void myRentalBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new MyRentals());
        }
    }
}