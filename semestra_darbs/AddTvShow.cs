using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;


namespace semestra_darbs
{
    public partial class AddTvShow : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        dbfile database = new dbfile();
        int CurrentUserID { get; set; }
        int ShowID { get; set; }

        public AddTvShow(int userID, int showID = 0)
        {
            //standart initializations
            ShowID = showID;
            this.Text = "TV SHOW";
            CurrentUserID = userID;
            InitializeComponent();
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE
            );



            //initialization for edit show action
            if (showID != 0)
            {
                var showForEditing = database.TvShowForEditing(showID);
                titleField.Text = showForEditing.title;
                seasonField.Text = Convert.ToString(showForEditing.season);
                episodeField.Text = Convert.ToString(showForEditing.episode);
                urlField.Text = showForEditing.image;
                descriptionField.Text = showForEditing.description;
            }

        }

        private void AddTvShow_Load(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void addIcon_Click(object sender, EventArgs e)
        {
            if (ShowID != 0)
            {
                if (database.AddTvShow(titleField.Text, descriptionField.Text, urlField.Text, Convert.ToInt32(seasonField.Text), Convert.ToInt32(episodeField.Text), 1, CurrentUserID, 1))
                {
                    this.Hide();
                }

            }
            else
            {
                if (database.AddTvShow(titleField.Text, descriptionField.Text, urlField.Text, Convert.ToInt32(seasonField.Text), Convert.ToInt32(episodeField.Text), 1, CurrentUserID))
                {
                    this.Hide();
                }
            }
            
            
        }
    }
}
