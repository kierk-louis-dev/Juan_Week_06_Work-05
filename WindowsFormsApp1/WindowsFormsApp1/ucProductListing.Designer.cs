namespace WindowsFormsApp1
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
            this.btsAdd = new System.Windows.Forms.Button();
            this.btsDelete = new System.Windows.Forms.Button();
            this.buxItems = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtAmunt = new System.Windows.Forms.TextBox();
            this.ibxItems = new System.Windows.Forms.ListBox();
            this.CmdUnit = new System.Windows.Forms.ComboBox();
            this.buxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // btsAdd
            // 
            this.btsAdd.Location = new System.Drawing.Point(790, 126);
            this.btsAdd.Name = "btsAdd";
            this.btsAdd.Size = new System.Drawing.Size(75, 23);
            this.btsAdd.TabIndex = 0;
            this.btsAdd.Text = "Add";
            this.btsAdd.UseVisualStyleBackColor = true;
            this.btsAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btsDelete
            // 
            this.btsDelete.Location = new System.Drawing.Point(790, 176);
            this.btsDelete.Name = "btsDelete";
            this.btsDelete.Size = new System.Drawing.Size(75, 23);
            this.btsDelete.TabIndex = 1;
            this.btsDelete.Text = "Delete";
            this.btsDelete.UseVisualStyleBackColor = true;
            // 
            // buxItems
            // 
            this.buxItems.Controls.Add(this.CmdUnit);
            this.buxItems.Controls.Add(this.txtAmunt);
            this.buxItems.Controls.Add(this.txtDescrip);
            this.buxItems.Controls.Add(this.label2);
            this.buxItems.Controls.Add(this.label1);
            this.buxItems.Location = new System.Drawing.Point(73, 81);
            this.buxItems.Name = "buxItems";
            this.buxItems.Size = new System.Drawing.Size(666, 160);
            this.buxItems.TabIndex = 2;
            this.buxItems.TabStop = false;
            this.buxItems.Text = "Item Details";
            this.buxItems.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(143, 38);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(489, 20);
            this.txtDescrip.TabIndex = 2;
            // 
            // txtAmunt
            // 
            this.txtAmunt.Location = new System.Drawing.Point(143, 98);
            this.txtAmunt.Name = "txtAmunt";
            this.txtAmunt.Size = new System.Drawing.Size(245, 20);
            this.txtAmunt.TabIndex = 3;
            // 
            // ibxItems
            // 
            this.ibxItems.FormattingEnabled = true;
            this.ibxItems.Location = new System.Drawing.Point(73, 262);
            this.ibxItems.Name = "ibxItems";
            this.ibxItems.Size = new System.Drawing.Size(698, 277);
            this.ibxItems.TabIndex = 3;
            // 
            // CmdUnit
            // 
            this.CmdUnit.FormattingEnabled = true;
            this.CmdUnit.Location = new System.Drawing.Point(409, 98);
            this.CmdUnit.Name = "CmdUnit";
            this.CmdUnit.Size = new System.Drawing.Size(223, 21);
            this.CmdUnit.TabIndex = 4;
            // 
            // ucProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ibxItems);
            this.Controls.Add(this.btsAdd);
            this.Controls.Add(this.buxItems);
            this.Controls.Add(this.btsDelete);
            this.Name = "ucProductListing";
            this.Size = new System.Drawing.Size(926, 581);
            this.Load += new System.EventHandler(this.ucProductListing_Load);
            this.buxItems.ResumeLayout(false);
            this.buxItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btsAdd;
        private System.Windows.Forms.Button btsDelete;
        private System.Windows.Forms.GroupBox buxItems;
        private System.Windows.Forms.TextBox txtAmunt;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ibxItems;
        private System.Windows.Forms.ComboBox CmdUnit;
    }
}
