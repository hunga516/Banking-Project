using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View.Customer;

namespace WindowsFormsApp1.View
{
    public partial class MenuBanking : Form
    {
        public MenuBanking()
        {
            InitializeComponent();

            // Thiết lập MDI container
            this.IsMdiContainer = true;
        }

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createCumtomer createCumtomer = new createCumtomer();
            createCumtomer.MdiParent = this;
            createCumtomer.Show();
        }
    }
}
