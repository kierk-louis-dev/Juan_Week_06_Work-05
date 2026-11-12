namespace WindowsFormsApp1
{
    partial class frmLogin
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
            this.lgnUsername = new System.Windows.Forms.Label();
            this.lgnPassword = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.LOGO = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lgnUsername
            // 
            this.lgnUsername.AutoSize = true;
            this.lgnUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnUsername.Location = new System.Drawing.Point(178, 148);
            this.lgnUsername.Name = "lgnUsername";
            this.lgnUsername.Size = new System.Drawing.Size(55, 13);
            this.lgnUsername.TabIndex = 0;
            this.lgnUsername.Text = "Username";
            this.lgnUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lgnUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lgnPassword
            // 
            this.lgnPassword.AutoSize = true;
            this.lgnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnPassword.Location = new System.Drawing.Point(180, 205);
            this.lgnPassword.Name = "lgnPassword";
            this.lgnPassword.Size = new System.Drawing.Size(53, 13);
            this.lgnPassword.TabIndex = 1;
            this.lgnPassword.Text = "Password";
            this.lgnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lgnPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxUsername
            // 
            this.boxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUsername.Location = new System.Drawing.Point(259, 143);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(167, 22);
            this.boxUsername.TabIndex = 2;
            this.boxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boxPassword
            // 
            this.boxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPassword.Location = new System.Drawing.Point(258, 200);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(168, 22);
            this.boxPassword.TabIndex = 3;
            this.boxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxPassword.UseSystemPasswordChar = true;
            this.boxPassword.TextChanged += new System.EventHandler(this.boxPassword_TextChanged);
            // 
            // LOGO
            // 
            this.LOGO.AutoSize = true;
            this.LOGO.BackColor = System.Drawing.SystemColors.Control;
            this.LOGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGO.Location = new System.Drawing.Point(321, 98);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(45, 16);
            this.LOGO.TabIndex = 4;
            this.LOGO.Text = "Login";
            this.LOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LOGO.Click += new System.EventHandler(this.LOGO_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(258, 243);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 22);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(344, 243);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(82, 22);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Signup";
            this.btnSignup.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 376);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LOGO);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this.lgnPassword);
            this.Controls.Add(this.lgnUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgnUsername;
        private System.Windows.Forms.Label lgnPassword;
        private System.Windows.Forms.TextBox boxUsername;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label LOGO;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
    }
}

