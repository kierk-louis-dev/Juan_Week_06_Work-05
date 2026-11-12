namespace Juan
{
    partial class ucProductListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrompt = new Label();
            lbxItems = new ListBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            cmbUnit = new ComboBox();
            txtAmount = new TextBox();
            txtDescr = new TextBox();
            lblAmount1 = new Label();
            txtDescription = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.BackColor = Color.IndianRed;
            lblPrompt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrompt.Location = new Point(52, 443);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(411, 34);
            lblPrompt.TabIndex = 15;
            lblPrompt.Text = "Promp";
            lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbxItems
            // 
            lbxItems.FormattingEnabled = true;
            lbxItems.ItemHeight = 15;
            lbxItems.Location = new Point(52, 181);
            lbxItems.Name = "lbxItems";
            lbxItems.Size = new Size(411, 244);
            lbxItems.TabIndex = 14;
            lbxItems.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(469, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbUnit);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(txtDescr);
            groupBox1.Controls.Add(lblAmount1);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Location = new Point(50, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 109);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Description";
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(196, 66);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(121, 23);
            cmbUnit.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(82, 66);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(108, 23);
            txtAmount.TabIndex = 3;
            // 
            // txtDescr
            // 
            txtDescr.Location = new Point(82, 28);
            txtDescr.Name = "txtDescr";
            txtDescr.Size = new Size(278, 23);
            txtDescr.TabIndex = 2;
            // 
            // lblAmount1
            // 
            lblAmount1.AutoSize = true;
            lblAmount1.Location = new Point(9, 69);
            lblAmount1.Name = "lblAmount1";
            lblAmount1.Size = new Size(51, 15);
            lblAmount1.TabIndex = 1;
            lblAmount1.Text = "Amount";
            // 
            // txtDescription
            // 
            txtDescription.AutoSize = true;
            txtDescription.Location = new Point(9, 31);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(67, 15);
            txtDescription.TabIndex = 0;
            txtDescription.Text = "Description";
            // 
            // button1
            // 
            button1.Location = new Point(469, 77);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ucProductListing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrompt);
            Controls.Add(lbxItems);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "ucProductListing";
            Size = new Size(567, 519);
            Load += ucProductListing_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPrompt;
        private ListBox lbxItems;
        private Button button2;
        private GroupBox groupBox1;
        private ComboBox cmbUnit;
        private TextBox txtAmount;
        private TextBox txtDescr;
        private Label lblAmount1;
        private Label txtDescription;
        private Button button1;
    }
}
