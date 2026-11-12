using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juan
{
    public partial class ucProductListing : UserControl
    {
        public ucProductListing()
        {
            InitializeComponent();
        }
        string[] units = { "Piece", "Box", "Kilogram", "Liter", };

        List<string> shoppingList = new List<string>();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrompt.Text = "";
            lblPrompt.Visible = false;
        }

        private void ucProductListing_Load(object sender, EventArgs e)
        {
            cmbUnit.Items.AddRange(units);
            cmbUnit.SelectedIndex = 0;

            //binding data source
            lbxItems.DataSource = shoppingList;
        }

        private void updateGUI()

        {
            lbxItems.DataSource = null;
            lbxItems.DataSource = shoppingList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = txtDescription.Text;
            double amount = double.Parse(txtAmount.Text);
            string unit = cmbUnit.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item) &&
                !string.IsNullOrEmpty(amount.ToString()))
            {
                string row = $"{item}\t\t" +
                    $"{amount} {unit} ";
                shoppingList.Add(row);
                updateGUI();

                MessageBox.Show("Item Added");
                txtAmount.Clear();
                txtDescr.Clear();
                cmbUnit.Refresh();
                txtDescr.Focus();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = lbxItems.SelectedIndex;

            if (index != -1)
            {
                DialogResult deleteMessage = MessageBox.Show("Are you sure you want to delete?",
                    "Delete Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                MessageBox.Show(shoppingList[index] + "deleted.");

                shoppingList.RemoveAt(index);
                updateGUI();
            }
            else
            {
                lblPrompt.Text = "Please select an item to delete.";
                lblPrompt.Visible = true;
            }


        }
    }

}
