using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SQLite;

namespace semestra_darbs
{
    public partial class Login : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        dbfile database = new dbfile();
        public string CurrentUsername;
        
        public Login()
        {
            InitializeComponent();
            
            this.Text = "WatchMeApp";
            // Theme part
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE
            );

            //db intitialzation
            database.initializeDb();

            //for fixing the background error
            //
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;


        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            
        }

 

        private void materialFlatButton2_Click_1(object sender, EventArgs e)
        {
            if (database.LogIn(usernameLogin.Text, passwordLogin.Text))
            {

                MainWindow newForm = new MainWindow(usernameLogin.Text, passwordLogin.Text);
                this.Hide();
                newForm.Location = this.Location;
                CurrentUsername = usernameLogin.Text;
                newForm.ShowDialog();
                this.Show();
               
            }

            
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            if (database.RegisterUser(regUsername.Text, regPassword1.Text, regPassword2.Text))
            {
                loginTabcontrol.SelectedIndex = 0;
            }
        }

    
    }
}
