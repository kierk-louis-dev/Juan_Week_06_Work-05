namespace Am_is_Week06_Work05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin"
                && txtPassword.Text == "1234")
            {
                MessageBox.Show("Login successful!");
                var inventoryForm = new frmInventory();
                inventoryForm.Show();
                this.Hide();

            }
              

        }
    }
}
