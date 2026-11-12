namespace Juan
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            productListToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutUSToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(554, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { inventoryToolStripMenuItem, aboutUSToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(554, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, productListToolStripMenuItem, exitToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(69, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // hOMEToolStripMenuItem
            // 
            hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            hOMEToolStripMenuItem.Size = new Size(180, 22);
            hOMEToolStripMenuItem.Text = "Home";
            hOMEToolStripMenuItem.Click += hOMEToolStripMenuItem_Click;
            // 
            // productListToolStripMenuItem
            // 
            productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            productListToolStripMenuItem.Size = new Size(180, 22);
            productListToolStripMenuItem.Text = "Product List";
            productListToolStripMenuItem.Click += productListToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutUSToolStripMenuItem
            // 
            aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            aboutUSToolStripMenuItem.Size = new Size(69, 20);
            aboutUSToolStripMenuItem.Text = "About US";
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(12, 27);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(542, 403);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += panel1_Paint;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(pnlContent);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "frmInventory";
            Text = "frmInventory";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private ToolStripMenuItem aboutUSToolStripMenuItem;
        private ToolStripMenuItem productListToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel pnlContent;
    }
}