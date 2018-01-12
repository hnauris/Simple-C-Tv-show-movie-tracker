using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

using Microsoft.VisualBasic;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SQLite;

namespace semestra_darbs
{
    public partial class MainWindow : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        dbfile database = new dbfile();
        string CurrentUsername { get; set; }
        string CurrentPassword { get; set; }
        int CurrentUserID { get; set; }
        string CurrentUserImgLink { get; set; }
        string tempImgLink { get; set; }
        int UserTvShowCounter { get; set; }
        

        public MainWindow(string passedUsername, string passedPassword)
        {
            this.Text = "WatchMeApp";
            InitializeComponent();
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE
            );

            CurrentUsername = passedUsername;
            CurrentPassword = passedPassword;
            CurrentUserID = database.AssignId(passedUsername, passedPassword);
            CurrentUserImgLink = database.ReturnImgLink(CurrentUserID);


            //profile info
            profileCurrentUserLabel.Text = CurrentUsername.ToUpper();
            userShowCounter.Text = Convert.ToString(UserTvShowCounter);

            //test for img
            if (CurrentUserImgLink.Length > 0)
            {
                WebRequest req = WebRequest.Create(CurrentUserImgLink);
                WebResponse res = req.GetResponse();
                Stream imgStream = res.GetResponseStream();
                Image img1 = Image.FromStream(imgStream);
                imgStream.Close();
                profilePicture.Image = img1;
            }



            //autopanel for tvshows
            var UserTvShowList = database.GetUserTvShows(CurrentUserID);
            foreach (var user in UserTvShowList)
            {
                UserTvShowCounter += 1;
                bigFlowPanel1.Controls.Add(new ElementBox(user.userID, user.tvshowID, user.title, user.description, user.image, user.season, user.episode, user.status));
            }

            bigFlowPanel1.Controls.Add(new ElementBox(15, 22, "title1", "description1", "https://html.com/wp-content/uploads/very-large-flamingo.jpg", 3, 22, 1));
            bigFlowPanel1.Controls.Add(new ElementBox(15, 22, "title1", "description1", "https://html.com/wp-content/uploads/very-large-flamingo.jpg", 3, 22, 1));
            bigFlowPanel1.Controls.Add(new ElementBox(15, 22, "title1", "description1", "https://html.com/wp-content/uploads/very-large-flamingo.jpg", 3, 22, 1));
            bigFlowPanel1.Controls.Add(new ElementBox(15, 22, "title1", "description1", "https://html.com/wp-content/uploads/very-large-flamingo.jpg", 3, 22, 1));
            bigFlowPanel1.Controls.Add(new ElementBox(15, 22, "title1", "description1", "https://html.com/wp-content/uploads/very-large-flamingo.jpg", 3, 22, 1));
            bigFlowPanel1.Controls.Add(new ElementBox(15, 22, "title1", "description1", "https://html.com/wp-content/uploads/very-large-flamingo.jpg", 3, 22, 1));
            bigFlowPanel1.Controls.Add(new ElementBox(15, 22, "title1", "description1", "https://html.com/wp-content/uploads/very-large-flamingo.jpg", 3, 22, 1));
            bigFlowPanel1.Controls.Add(new ElementBox(15, 22, "title1", "description1", "https://html.com/wp-content/uploads/very-large-flamingo.jpg", 3, 22, 1));


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            userShowCounter.Text = Convert.ToString(UserTvShowCounter);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            profilePicture.Refresh();
        }

        private void tabMenuControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMenuControl.SelectedTab == tabMenuControl.TabPages["homeTab"])
            {
                //for active tab styling
  
            }
            if (tabMenuControl.SelectedTab == tabMenuControl.TabPages["profileTab"])
            {
                //for active tab styling
                
            }
        }

        private void profileToggleScheme_CheckedChanged(object sender, EventArgs e)
        {
            if (profileToggleScheme.Checked == true)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
        }

        private void profilePictureSelectButton_Click(object sender, EventArgs e)
        {
            string imageURL = Interaction.InputBox("Paste the image URL below!", "Dear user...", "...");
            if (imageURL.Length > 0)
            {
                database.UploadImage(imageURL, CurrentUserID);
                tempImgLink = imageURL;
                WebRequest req = WebRequest.Create(tempImgLink);
                WebResponse res = req.GetResponse();
                Stream imgStream = res.GetResponseStream();
                Image img1 = Image.FromStream(imgStream);
                imgStream.Close();
                profilePicture.Image = img1;
            }
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hnauris");
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string newPassword = Interaction.InputBox("Input your desired password below!", "Dear User...", "...");
            if (newPassword.Length < 20)
            {
                database.ChangePassword(newPassword, CurrentUserID);
            }
        }

        private void addTvShowIcon_Click(object sender, EventArgs e)
        {
            AddTvShow newForm = new AddTvShow(CurrentUserID);
            newForm.ShowDialog();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            MainWindow newForm = new MainWindow(CurrentUsername, CurrentPassword);
            this.Hide();
            newForm.Location = this.Location;
            newForm.ShowDialog();
        }
    }
}
