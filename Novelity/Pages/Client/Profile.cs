using Microsoft.Data.SqlClient;
using Novelity.Modals;
using Novelity.Pages.Admin;
using System;
using System.Windows.Forms;

namespace Novelity
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                // Show basic profile info (left section)
                lblName.Text = $"{UserSession.FirstName} {UserSession.LastName}";
                lblUsername.Text = UserSession.Username;
                lblEmail.Text = UserSession.Email;

                // By default, hide all panels
                panelAdmin.Visible = false;
                panelPremium.Visible = false;
                panelFree.Visible = false;

                // Determine which panel to show
                if (UserSession.IsAdmin)
                {
                    panelAdmin.Visible = true;
                }
                else if (UserSession.IsCustomer)
                {
                    if (string.Equals(UserSession.PlanName, "Premium", StringComparison.OrdinalIgnoreCase))
                    {
                        panelPremium.Visible = true;
                    }
                    else
                    {
                        // Assume free plan if not premium
                        panelFree.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            EditProfile form = new EditProfile();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            ManageBooks form = new ManageBooks();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ManageAccounts form = new ManageAccounts();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rentals form = new Rentals();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            Reports form = new Reports();
            form.Show();
        }
    }
}
