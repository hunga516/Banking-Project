using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View.Customer
{
    public partial class createCumtomer : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        db_bankingEntities BSE;
        MemoryStream ms;
      
        public createCumtomer()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            throw new NotImplementedException();
        }

        private void loadaccount()
        {
            BSE = new db_bankingEntities();
          //  var item  = BSE.User(
        }

        private void loaddate()
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
