using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (boxUsername.Text == "Admin" 
                && boxPassword.Text == "1234")
            {
                MessageBox.Show("Login Succesful!");
                var InventroyForm = new Form2();
                InventroyForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed Please Try Again!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LOGO_Click(object sender, EventArgs e)
        {

        }
    }
}
