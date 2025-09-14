namespace Novelity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelContent.AutoScroll = false; // Disable scrolling on panelContent
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
            Home HomePage = new Home();
            HomePage.TopLevel = false;
            HomePage.Size = panelContent.Size; // Match panel size
            panelContent.Controls.Clear(); // Clear previous content
            panelContent.Controls.Add(HomePage);
            HomePage.BringToFront();
            HomePage.Show();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            Books BookPage = new Books();
            BookPage.TopLevel = false;
            BookPage.Size = panelContent.Size; // Match panel size
            panelContent.Controls.Clear(); // Clear previous content
            panelContent.Controls.Add(BookPage);
            BookPage.BringToFront();
            BookPage.Show();
        }

        private void myRentalBtn_Click(object sender, EventArgs e)
        {
            MyRentals MyRentalsPage = new MyRentals();
            MyRentalsPage.TopLevel = false;
            MyRentalsPage.Size = panelContent.Size; // Match panel size
            panelContent.Controls.Clear(); // Clear previous content
            panelContent.Controls.Add(MyRentalsPage);
            MyRentalsPage.BringToFront();
            MyRentalsPage.Show();
        }
    }
}