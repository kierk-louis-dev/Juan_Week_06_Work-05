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
    public partial class ucProductListing : UserControl
    {
        public ucProductListing()
        {
            InitializeComponent();
        }
        string[] units = { "Piece", "Box", "Kilogram", "Litero", "cm", "ft" };

        List<string> shopingList = new List<string>();
        private void ucProductListing_Load(object sender, EventArgs e)
        {
            CmdUnit.Items.AddRange(units);
            CmdUnit.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = txtDescrip.Text;
            double amount = double.Parse(txtAmunt.Text);
            string unit = CmdUnit.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item) && ! string.IsNullOrEmpty(amount.ToString()))
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
