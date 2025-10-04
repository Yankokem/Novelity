using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novelity.Modals
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
