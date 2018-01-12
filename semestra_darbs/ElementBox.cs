using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace semestra_darbs
{
    class ElementBox : FlowLayoutPanel
    {

        dbfile database = new dbfile();
        private string Title, Description, Image;
        private int UserID, TvshowID, Season, Episode, Status;
        public ToolTip Tooltip;

        public ElementBox(int userID, int tvshowID, string title, string description, string image, int season, int episode, int status)
        {
            TvshowID = tvshowID;
            UserID = userID;
            FlowDirection = FlowDirection.TopDown;
            TvshowID = tvshowID;

            var Title = new MaterialSkin.Controls.MaterialLabel()
            {
                
            };

            var Description = new MaterialSkin.Controls.MaterialLabel()
            {
                
            };

            var Image = new PictureBox()
            {
                ImageLocation = image,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            var Season = new MaterialSkin.Controls.MaterialLabel()
            {
                
            };

            var Episode = new MaterialSkin.Controls.MaterialLabel()
            {
                
            };

            var Tooltip = new ToolTip()
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true
            };

            var EditIcon = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = semestra_darbs.Properties.Resources.editv2,
                BackgroundImage = semestra_darbs.Properties.Resources.editv2,
                Height = 15,
                Width = 15
            };

            var DeleteIcon = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = semestra_darbs.Properties.Resources.delete,
                BackgroundImage = semestra_darbs.Properties.Resources.delete,
                Height = 15,
                Width = 15
            };

            //Controls.Add(Season);
            //Controls.Add(Episode);
            //Controls.Add(Title);
            //Controls.Add(Description);
            Controls.Add(Image);
            Controls.Add(EditIcon);
            Controls.Add(DeleteIcon);

            Tooltip.SetToolTip(Image, "Title: " + title + Environment.NewLine +  "Description: " + description + Environment.NewLine
                + "Season: " + season + Environment.NewLine + "Episode: " + episode);


            DeleteIcon.MouseClick += DeleteIcon_MouseClick;
            EditIcon.MouseClick += EditIcon_MouseClick;
        }

        private void EditIcon_MouseClick(object sender, MouseEventArgs e)
        {
            AddTvShow newForm = new AddTvShow(UserID, TvshowID);
            newForm.ShowDialog();
            this.Refresh();
        }

        private void DeleteIcon_MouseClick(object sender, MouseEventArgs e)
        {
            var confirmationResult = MessageBox.Show("Are you sure you want to remove this item?", "Confirm Delete!", MessageBoxButtons.YesNo);
            if (confirmationResult == DialogResult.Yes)
            {
                database.DeleteTvshow(TvshowID);
            }
            else
            {
                Console.WriteLine("Something went wrong!!!...");
            }
        }
    }
}
