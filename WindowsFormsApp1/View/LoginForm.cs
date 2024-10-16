using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_bankingEntities dbe = new db_bankingEntities();
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.username.Equals(txtUsername.Text)); // Thêm dấu chấm phẩy ở đây
                if (user1 != null)
                {
                    if (user1.password.Trim().Equals(txtPassword.Text.Trim()))
                    {
                        MenuBanking menu = new MenuBanking();
                        menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username: " + txtUsername.Text + ", Password Entered: " + txtPassword.Text + ", Password in DB: " + user1.password);
                        MessageBox.Show("Mật khẩu không chính xác");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập username và password"); // Sửa dấu nháy đơn thành nháy kép
            }
        }
    }
}
