namespace store_client.Views
{
    partial class Home
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.lblRegisterName = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterMail = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.lblStatusLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblRegisterAddress = new System.Windows.Forms.Label();
            this.txtboxRegisterMail = new System.Windows.Forms.TextBox();
            this.txtboxRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtboxRegisterName = new System.Windows.Forms.TextBox();
            this.txtboxRegisterAddress = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.registerTab.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.registerTab);
            this.tabControl.Controls.Add(this.loginTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(200, 24);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(464, 327);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // registerTab
            // 
            this.registerTab.Controls.Add(this.txtboxRegisterAddress);
            this.registerTab.Controls.Add(this.txtboxRegisterName);
            this.registerTab.Controls.Add(this.txtboxRegisterPassword);
            this.registerTab.Controls.Add(this.txtboxRegisterMail);
            this.registerTab.Controls.Add(this.lblRegisterAddress);
            this.registerTab.Controls.Add(this.lblRegisterName);
            this.registerTab.Controls.Add(this.lblRegisterPassword);
            this.registerTab.Controls.Add(this.lblRegisterMail);
            this.registerTab.Controls.Add(this.btnRegister);
            this.registerTab.Location = new System.Drawing.Point(4, 4);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(4);
            this.registerTab.Size = new System.Drawing.Size(456, 295);
            this.registerTab.TabIndex = 0;
            this.registerTab.Text = "Register";
            this.registerTab.UseVisualStyleBackColor = true;
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.AutoSize = true;
            this.lblRegisterName.Location = new System.Drawing.Point(32, 126);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(57, 23);
            this.lblRegisterName.TabIndex = 3;
            this.lblRegisterName.Text = "Name";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(32, 78);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(86, 23);
            this.lblRegisterPassword.TabIndex = 2;
            this.lblRegisterPassword.Text = "Password";
            // 
            // lblRegisterMail
            // 
            this.lblRegisterMail.AutoSize = true;
            this.lblRegisterMail.Location = new System.Drawing.Point(32, 32);
            this.lblRegisterMail.Name = "lblRegisterMail";
            this.lblRegisterMail.Size = new System.Drawing.Size(46, 23);
            this.lblRegisterMail.TabIndex = 1;
            this.lblRegisterMail.Text = "Mail";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(172, 224);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 35);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.lblStatusLogin);
            this.loginTab.Controls.Add(this.btnLogin);
            this.loginTab.Controls.Add(this.txtPassword);
            this.loginTab.Controls.Add(this.txtMail);
            this.loginTab.Controls.Add(this.lblPassword);
            this.loginTab.Controls.Add(this.lblMail);
            this.loginTab.Location = new System.Drawing.Point(4, 4);
            this.loginTab.Margin = new System.Windows.Forms.Padding(4);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(4);
            this.loginTab.Size = new System.Drawing.Size(456, 295);
            this.loginTab.TabIndex = 1;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // lblStatusLogin
            // 
            this.lblStatusLogin.AutoSize = true;
            this.lblStatusLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLogin.Location = new System.Drawing.Point(29, 124);
            this.lblStatusLogin.Name = "lblStatusLogin";
            this.lblStatusLogin.Size = new System.Drawing.Size(0, 19);
            this.lblStatusLogin.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(172, 224);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(133, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(211, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(133, 84);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(211, 30);
            this.txtMail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(19, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(19, 87);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(46, 23);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail";
            // 
            // lblRegisterAddress
            // 
            this.lblRegisterAddress.AutoSize = true;
            this.lblRegisterAddress.Location = new System.Drawing.Point(32, 171);
            this.lblRegisterAddress.Name = "lblRegisterAddress";
            this.lblRegisterAddress.Size = new System.Drawing.Size(75, 23);
            this.lblRegisterAddress.TabIndex = 4;
            this.lblRegisterAddress.Text = "Address";
            // 
            // txtboxRegisterMail
            // 
            this.txtboxRegisterMail.Location = new System.Drawing.Point(140, 29);
            this.txtboxRegisterMail.Name = "txtboxRegisterMail";
            this.txtboxRegisterMail.Size = new System.Drawing.Size(211, 30);
            this.txtboxRegisterMail.TabIndex = 5;
            // 
            // txtboxRegisterPassword
            // 
            this.txtboxRegisterPassword.Location = new System.Drawing.Point(140, 75);
            this.txtboxRegisterPassword.Name = "txtboxRegisterPassword";
            this.txtboxRegisterPassword.Size = new System.Drawing.Size(211, 30);
            this.txtboxRegisterPassword.TabIndex = 6;
            // 
            // txtboxRegisterName
            // 
            this.txtboxRegisterName.Location = new System.Drawing.Point(140, 123);
            this.txtboxRegisterName.Name = "txtboxRegisterName";
            this.txtboxRegisterName.Size = new System.Drawing.Size(211, 30);
            this.txtboxRegisterName.TabIndex = 7;
            // 
            // txtboxRegisterAddress
            // 
            this.txtboxRegisterAddress.Location = new System.Drawing.Point(140, 168);
            this.txtboxRegisterAddress.Name = "txtboxRegisterAddress";
            this.txtboxRegisterAddress.Size = new System.Drawing.Size(211, 30);
            this.txtboxRegisterAddress.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 327);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.tabControl.ResumeLayout(false);
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblStatusLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegisterName;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterMail;
        private System.Windows.Forms.TextBox txtboxRegisterAddress;
        private System.Windows.Forms.TextBox txtboxRegisterName;
        private System.Windows.Forms.TextBox txtboxRegisterPassword;
        private System.Windows.Forms.TextBox txtboxRegisterMail;
        private System.Windows.Forms.Label lblRegisterAddress;
    }
}