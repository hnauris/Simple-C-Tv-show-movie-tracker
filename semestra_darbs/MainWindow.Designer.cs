namespace semestra_darbs
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabMenuControl = new MaterialSkin.Controls.MaterialTabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutMadeByLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.profilePictureSelectButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.profileToggleScheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.profileCurrentUserLabel = new MaterialSkin.Controls.MaterialLabel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addTvShowIcon = new System.Windows.Forms.PictureBox();
            this.bigFlowPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.userShowCounter = new MaterialSkin.Controls.MaterialLabel();
            this.tabMenuControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTvShowIcon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenuControl
            // 
            this.tabMenuControl.Controls.Add(this.homeTab);
            this.tabMenuControl.Controls.Add(this.profileTab);
            this.tabMenuControl.Controls.Add(this.tabPage1);
            this.tabMenuControl.Controls.Add(this.tabPage2);
            this.tabMenuControl.Controls.Add(this.tabPage3);
            this.tabMenuControl.Depth = 0;
            this.tabMenuControl.Location = new System.Drawing.Point(0, 65);
            this.tabMenuControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMenuControl.Name = "tabMenuControl";
            this.tabMenuControl.SelectedIndex = 0;
            this.tabMenuControl.Size = new System.Drawing.Size(1201, 611);
            this.tabMenuControl.TabIndex = 0;
            this.tabMenuControl.SelectedIndexChanged += new System.EventHandler(this.tabMenuControl_SelectedIndexChanged);
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.pictureBox1);
            this.homeTab.Controls.Add(this.aboutMadeByLabel);
            this.homeTab.Controls.Add(this.panel2);
            this.homeTab.Controls.Add(this.panel1);
            this.homeTab.Controls.Add(this.materialLabel4);
            this.homeTab.Location = new System.Drawing.Point(4, 22);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1193, 585);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "about";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::semestra_darbs.Properties.Resources.githubIcon;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::semestra_darbs.Properties.Resources.githubIcon;
            this.pictureBox1.Location = new System.Drawing.Point(406, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aboutMadeByLabel
            // 
            this.aboutMadeByLabel.AutoSize = true;
            this.aboutMadeByLabel.Depth = 0;
            this.aboutMadeByLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.aboutMadeByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutMadeByLabel.Location = new System.Drawing.Point(61, 453);
            this.aboutMadeByLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutMadeByLabel.Name = "aboutMadeByLabel";
            this.aboutMadeByLabel.Size = new System.Drawing.Size(130, 57);
            this.aboutMadeByLabel.TabIndex = 4;
            this.aboutMadeByLabel.Text = "Made by N.Horsts\r\nfor LLU IT\r\n2018";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(65, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 67);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.PowderBlue;
            this.panel1.Location = new System.Drawing.Point(44, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 40);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(40, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "About";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(18, 101);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(508, 306);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = resources.GetString("materialLabel4.Text");
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.userShowCounter);
            this.profileTab.Controls.Add(this.panel3);
            this.profileTab.Controls.Add(this.panel4);
            this.profileTab.Controls.Add(this.materialFlatButton1);
            this.profileTab.Controls.Add(this.materialLabel2);
            this.profileTab.Controls.Add(this.materialLabel3);
            this.profileTab.Controls.Add(this.materialLabel1);
            this.profileTab.Controls.Add(this.profilePictureSelectButton);
            this.profileTab.Controls.Add(this.profileToggleScheme);
            this.profileTab.Controls.Add(this.profileCurrentUserLabel);
            this.profileTab.Controls.Add(this.profilePicture);
            this.profileTab.Location = new System.Drawing.Point(4, 22);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(1193, 585);
            this.profileTab.TabIndex = 1;
            this.profileTab.Text = "profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(65, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 67);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.ForeColor = System.Drawing.Color.PowderBlue;
            this.panel4.Location = new System.Drawing.Point(44, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 40);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(40, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Profile";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(9, 515);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(144, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Change password";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(83, 225);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Already watched:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(33, 177);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(169, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Items in \"To Watch List:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(100, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "My Tv Shows:";
            // 
            // profilePictureSelectButton
            // 
            this.profilePictureSelectButton.AutoSize = true;
            this.profilePictureSelectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profilePictureSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureSelectButton.Depth = 0;
            this.profilePictureSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePictureSelectButton.Location = new System.Drawing.Point(108, 260);
            this.profilePictureSelectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.profilePictureSelectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.profilePictureSelectButton.Name = "profilePictureSelectButton";
            this.profilePictureSelectButton.Primary = false;
            this.profilePictureSelectButton.Size = new System.Drawing.Size(94, 36);
            this.profilePictureSelectButton.TabIndex = 6;
            this.profilePictureSelectButton.Text = "Choose IMG";
            this.profilePictureSelectButton.UseVisualStyleBackColor = true;
            this.profilePictureSelectButton.Click += new System.EventHandler(this.profilePictureSelectButton_Click);
            // 
            // profileToggleScheme
            // 
            this.profileToggleScheme.AutoSize = true;
            this.profileToggleScheme.Depth = 0;
            this.profileToggleScheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.profileToggleScheme.Location = new System.Drawing.Point(1046, 519);
            this.profileToggleScheme.Margin = new System.Windows.Forms.Padding(0);
            this.profileToggleScheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.profileToggleScheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileToggleScheme.Name = "profileToggleScheme";
            this.profileToggleScheme.Ripple = true;
            this.profileToggleScheme.Size = new System.Drawing.Size(130, 30);
            this.profileToggleScheme.TabIndex = 4;
            this.profileToggleScheme.Text = "Theme Switcher";
            this.profileToggleScheme.UseVisualStyleBackColor = true;
            this.profileToggleScheme.CheckedChanged += new System.EventHandler(this.profileToggleScheme_CheckedChanged);
            // 
            // profileCurrentUserLabel
            // 
            this.profileCurrentUserLabel.AutoSize = true;
            this.profileCurrentUserLabel.Depth = 0;
            this.profileCurrentUserLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.profileCurrentUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileCurrentUserLabel.Location = new System.Drawing.Point(294, 209);
            this.profileCurrentUserLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileCurrentUserLabel.Name = "profileCurrentUserLabel";
            this.profileCurrentUserLabel.Size = new System.Drawing.Size(128, 19);
            this.profileCurrentUserLabel.TabIndex = 0;
            this.profileCurrentUserLabel.Text = "BNEBEBEBEBBEE";
            this.profileCurrentUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(281, 46);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(150, 150);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 5;
            this.profilePicture.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addTvShowIcon);
            this.tabPage1.Controls.Add(this.bigFlowPanel1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1193, 585);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "my tv shows";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addTvShowIcon
            // 
            this.addTvShowIcon.Image = global::semestra_darbs.Properties.Resources.addIconv2;
            this.addTvShowIcon.Location = new System.Drawing.Point(41, 479);
            this.addTvShowIcon.Name = "addTvShowIcon";
            this.addTvShowIcon.Size = new System.Drawing.Size(50, 50);
            this.addTvShowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addTvShowIcon.TabIndex = 1;
            this.addTvShowIcon.TabStop = false;
            this.addTvShowIcon.Click += new System.EventHandler(this.addTvShowIcon_Click);
            // 
            // bigFlowPanel1
            // 
            this.bigFlowPanel1.AutoScroll = true;
            this.bigFlowPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bigFlowPanel1.Location = new System.Drawing.Point(149, 42);
            this.bigFlowPanel1.Name = "bigFlowPanel1";
            this.bigFlowPanel1.Size = new System.Drawing.Size(857, 465);
            this.bigFlowPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1193, 585);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "to watch list";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(473, 228);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(181, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "UNDER DEVELOPMENT...";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialLabel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1193, 585);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "already watched";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(473, 228);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(181, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "UNDER DEVELOPMENT...";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabMenuControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(125, 33);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(618, 26);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "HOME";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.Image = global::semestra_darbs.Properties.Resources.reloadIcon;
            this.refreshButton.Location = new System.Drawing.Point(727, 29);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(30, 30);
            this.refreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshButton.TabIndex = 2;
            this.refreshButton.TabStop = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // userShowCounter
            // 
            this.userShowCounter.AutoSize = true;
            this.userShowCounter.Depth = 0;
            this.userShowCounter.Font = new System.Drawing.Font("Roboto", 11F);
            this.userShowCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userShowCounter.Location = new System.Drawing.Point(208, 126);
            this.userShowCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.userShowCounter.Name = "userShowCounter";
            this.userShowCounter.Size = new System.Drawing.Size(0, 19);
            this.userShowCounter.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 645);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabMenuControl);
            this.Name = "MainWindow";
            this.Text = "WatchMeApp";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabMenuControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addTvShowIcon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabMenuControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage profileTab;
        private MaterialSkin.Controls.MaterialLabel profileCurrentUserLabel;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialCheckBox profileToggleScheme;
        private System.Windows.Forms.PictureBox profilePicture;
        private MaterialSkin.Controls.MaterialFlatButton profilePictureSelectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel aboutMadeByLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.FlowLayoutPanel bigFlowPanel1;
        private System.Windows.Forms.PictureBox addTvShowIcon;
        private System.Windows.Forms.PictureBox refreshButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel userShowCounter;
    }
}