namespace semestra_darbs
{
    partial class Login
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
            this.loginTabcontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.regPassword1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.regUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.regPassword2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.loginTabselector = new MaterialSkin.Controls.MaterialTabSelector();
            this.loginTabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTabcontrol
            // 
            this.loginTabcontrol.Controls.Add(this.tabPage1);
            this.loginTabcontrol.Controls.Add(this.tabPage2);
            this.loginTabcontrol.Depth = 0;
            this.loginTabcontrol.Location = new System.Drawing.Point(12, 69);
            this.loginTabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTabcontrol.Name = "loginTabcontrol";
            this.loginTabcontrol.SelectedIndex = 0;
            this.loginTabcontrol.Size = new System.Drawing.Size(398, 300);
            this.loginTabcontrol.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialFlatButton2);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.passwordLogin);
            this.tabPage1.Controls.Add(this.usernameLogin);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(390, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "log in";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(181, 184);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(55, 36);
            this.materialFlatButton2.TabIndex = 11;
            this.materialFlatButton2.Text = "Log In";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click_1);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(38, 130);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(75, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Password";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(38, 91);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(77, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Username";
            // 
            // passwordLogin
            // 
            this.passwordLogin.Depth = 0;
            this.passwordLogin.Hint = "";
            this.passwordLogin.Location = new System.Drawing.Point(152, 130);
            this.passwordLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '*';
            this.passwordLogin.SelectedText = "";
            this.passwordLogin.SelectionLength = 0;
            this.passwordLogin.SelectionStart = 0;
            this.passwordLogin.Size = new System.Drawing.Size(131, 23);
            this.passwordLogin.TabIndex = 8;
            this.passwordLogin.UseSystemPasswordChar = false;
            // 
            // usernameLogin
            // 
            this.usernameLogin.Depth = 0;
            this.usernameLogin.Hint = "";
            this.usernameLogin.Location = new System.Drawing.Point(152, 87);
            this.usernameLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.PasswordChar = '\0';
            this.usernameLogin.SelectedText = "";
            this.usernameLogin.SelectionLength = 0;
            this.usernameLogin.SelectionStart = 0;
            this.usernameLogin.Size = new System.Drawing.Size(131, 23);
            this.usernameLogin.TabIndex = 8;
            this.usernameLogin.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(177, 35);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(48, 18);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Log In";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialFlatButton3);
            this.tabPage2.Controls.Add(this.regPassword1);
            this.tabPage2.Controls.Add(this.regUsername);
            this.tabPage2.Controls.Add(this.regPassword2);
            this.tabPage2.Controls.Add(this.materialLabel10);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(390, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "register";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(140, 204);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(129, 36);
            this.materialFlatButton3.TabIndex = 11;
            this.materialFlatButton3.Text = "Create Account";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // regPassword1
            // 
            this.regPassword1.Depth = 0;
            this.regPassword1.Hint = "";
            this.regPassword1.Location = new System.Drawing.Point(158, 127);
            this.regPassword1.MouseState = MaterialSkin.MouseState.HOVER;
            this.regPassword1.Name = "regPassword1";
            this.regPassword1.PasswordChar = '*';
            this.regPassword1.SelectedText = "";
            this.regPassword1.SelectionLength = 0;
            this.regPassword1.SelectionStart = 0;
            this.regPassword1.Size = new System.Drawing.Size(107, 23);
            this.regPassword1.TabIndex = 8;
            this.regPassword1.UseSystemPasswordChar = false;
            // 
            // regUsername
            // 
            this.regUsername.Depth = 0;
            this.regUsername.Hint = "";
            this.regUsername.Location = new System.Drawing.Point(158, 93);
            this.regUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.regUsername.Name = "regUsername";
            this.regUsername.PasswordChar = '\0';
            this.regUsername.SelectedText = "";
            this.regUsername.SelectionLength = 0;
            this.regUsername.SelectionStart = 0;
            this.regUsername.Size = new System.Drawing.Size(107, 23);
            this.regUsername.TabIndex = 9;
            this.regUsername.UseSystemPasswordChar = false;
            // 
            // regPassword2
            // 
            this.regPassword2.Depth = 0;
            this.regPassword2.Hint = "";
            this.regPassword2.Location = new System.Drawing.Point(158, 162);
            this.regPassword2.MouseState = MaterialSkin.MouseState.HOVER;
            this.regPassword2.Name = "regPassword2";
            this.regPassword2.PasswordChar = '*';
            this.regPassword2.SelectedText = "";
            this.regPassword2.SelectionLength = 0;
            this.regPassword2.SelectionStart = 0;
            this.regPassword2.Size = new System.Drawing.Size(107, 23);
            this.regPassword2.TabIndex = 10;
            this.regPassword2.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(17, 162);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(136, 18);
            this.materialLabel10.TabIndex = 3;
            this.materialLabel10.Text = "Repeat Password *";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(67, 127);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(85, 18);
            this.materialLabel9.TabIndex = 2;
            this.materialLabel9.Text = "Password *";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(65, 93);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(87, 18);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "Username *";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(136, 32);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(127, 18);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Registration Form";
            // 
            // loginTabselector
            // 
            this.loginTabselector.BaseTabControl = this.loginTabcontrol;
            this.loginTabselector.Depth = 0;
            this.loginTabselector.Location = new System.Drawing.Point(12, 35);
            this.loginTabselector.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTabselector.Name = "loginTabselector";
            this.loginTabselector.Size = new System.Drawing.Size(231, 17);
            this.loginTabselector.TabIndex = 7;
            this.loginTabselector.Text = "materialTabSelector1";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(422, 381);
            this.Controls.Add(this.loginTabselector);
            this.Controls.Add(this.loginTabcontrol);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.loginTabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialTabControl loginTabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector loginTabselector;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordLogin;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialSingleLineTextField regPassword1;
        private MaterialSkin.Controls.MaterialSingleLineTextField regUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField regPassword2;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
    }
}

