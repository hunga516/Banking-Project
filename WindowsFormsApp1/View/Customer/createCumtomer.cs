using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            loaddata();
        }

        private void loaddata()
        {
          //  dataGridView1.AutoGenerateColumns = false;
            db_bankingEntities bs = new db_bankingEntities();
            var item = bs.Customer_Table.ToList();
            dataGridView1.DataSource = item;
        }

        private void loadstate()
        {
            // throw new NotImplementedException();

        }

        private void loadaccount()
        {
            BSE = new db_bankingEntities();
            var item = BSE.Customer_Table.ToArray();
            no = item.LastOrDefault().CustomerNo + 1;
            txtCustomerNo.Text = Convert.ToString(no);

        }

        private void loaddate()
        {
            txtDateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtDateLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioMale.Checked)
            {
                gender = "Male";

            } else if(radioFemale.Checked)
            {
                gender = "Female";
            }
            BSE = new db_bankingEntities();
            Customer_Table customer = new Customer_Table();
            customer.CustomerNo = Convert.ToDecimal(txtCustomerNo.Text);
            customer.Name = txtName.Text;
            customer.Birth = dateTimePicker1.Value.ToString();
            customer.PhoneNo = txtPhone.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.Gender = gender;
            customer.Balance = Convert.ToDecimal(txtBalance.Text);
            customer.Date = txtDateLabel.Text;
            customer.Picture = ms.ToArray();
            BSE.Customer_Table.Add(customer);
            BSE.SaveChanges();
            MessageBox.Show("New customer created !"); 
        }

        private void createCumtomer_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
