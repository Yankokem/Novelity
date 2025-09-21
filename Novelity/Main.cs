using System;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelContent.AutoScroll = false;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set admin navbar visibility based on user role
            SetAdminNavbarVisibility();

            LoadForm(new Home());
            DisplayUserInfo();
        }

        private void SetAdminNavbarVisibility()
        {
            if (UserSession.IsLoggedIn && UserSession.IsAdmin)
            {
                // Admin is logged in - show the admin navbar
                adminNavbar.Visible = true;

                // Adjust panelContent position and size to account for admin navbar
                panelContent.Top = adminNavbar.Bottom;
                panelContent.Height = this.ClientSize.Height - panelContent.Top;
            }
            else
            {
                // Customer or not logged in - hide the admin navbar
                adminNavbar.Visible = false;

                // Adjust panelContent to take the full space
                panelContent.Top = 0;
                panelContent.Height = this.ClientSize.Height;
            }
        }

        private void DisplayUserInfo()
        {
            if (UserSession.IsLoggedIn)
            {
                usernameLabel.Text = UserSession.Username;
                roleLabel.Text = UserSession.GetDisplayRole();
            }
            else
            {
                // This should not happen if Program.cs is working correctly
                usernameLabel.Text = "Not Logged In";
                roleLabel.Text = "Please Login";
            }
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.Size = panelContent.Size;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            UserSession.ClearSession();

            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Home());
        }

        //client pages
        private void bookBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Books());
        }

        private void myRentalBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new MyRentals());
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Profile());
        }

        //admin pages
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        // Handle form resize to maintain proper layout
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Re-adjust panelContent when form is resized
            if (adminNavbar.Visible)
            {
                panelContent.Top = adminNavbar.Bottom;
                panelContent.Height = this.ClientSize.Height - panelContent.Top;
            }
            else
            {
                panelContent.Top = 0;
                panelContent.Height = this.ClientSize.Height;
            }

            // Resize any loaded form to match panelContent size
            if (panelContent.Controls.Count > 0 && panelContent.Controls[0] is Form loadedForm)
            {
                loadedForm.Size = panelContent.Size;
            }
        }
    }
}