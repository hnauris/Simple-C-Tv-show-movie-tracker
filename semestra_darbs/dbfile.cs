using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using System.Data.SQLite;

namespace semestra_darbs
{
    class dbfile
    {
        SQLiteConnection m_dbConnection;
        string dbRoute = @"C:/database.sqlite";
        TvShow showClass = new TvShow();

        

        public void initializeDb()
        {

            if (!File.Exists(dbRoute))
            {
                SQLiteConnection.CreateFile(dbRoute);
            }
            m_dbConnection = new SQLiteConnection("Data Source=C:/database.sqlite;Version=3;");

            m_dbConnection.Open();

            //table for user
            string user = "CREATE TABLE IF NOT EXISTS users (username_id INTEGER PRIMARY KEY AUTOINCREMENT not null, image_link TEXT, username VARCHAR(15) not null," +
                " password VARCHAR(20) not null, CONSTRAINT username_unique UNIQUE (username))";
            SQLiteCommand userTableCreate = new SQLiteCommand(user, m_dbConnection);
            userTableCreate.ExecuteNonQuery();

            //table for tv_show
            string tv_show = "CREATE TABLE IF NOT EXISTS tvshows (tvshow_id INTEGER PRIMARY KEY AUTOINCREMENT not null, title VARCHAR(25) not null, " +
                "description TEXT, image TEXT, season INTEGER, episode INTEGER, status INTEGER not null, user_id INTEGER, FOREIGN KEY(user_id) REFERENCES users(username_id))";
            SQLiteCommand tvshowTableCreate = new SQLiteCommand(tv_show, m_dbConnection);
            tvshowTableCreate.ExecuteNonQuery();


            //table for movies
            string movie = "CREATE TABLE IF NOT EXISTS movies (movie_id INTEGER PRIMARY KEY AUTOINCREMENT not null, title VARCHAR(25) not null, " +
                "description TEXT, image TEXT, release_date TEXT, status INTEGER not null, user_id INTEGER, FOREIGN KEY(user_id) REFERENCES users(username_id))";
            SQLiteCommand movieTableCreate = new SQLiteCommand(movie, m_dbConnection);
            movieTableCreate.ExecuteNonQuery();

            m_dbConnection.Close();
        }

        public bool RegisterUser(string username, string password1, string password2)
        {
            if (password1 == password2 && username.Length >= 5)
            {
                //variables for more advanced stuff later on
                m_dbConnection.Open();
                string confirmed_password = password1;
                string confirmed_username = username;
                string register = String.Format("INSERT INTO users (username, password) values ('{0}', '{1}')", confirmed_username, confirmed_password);
                SQLiteCommand registerUser = new SQLiteCommand(register, m_dbConnection);
                registerUser.ExecuteNonQuery();
                m_dbConnection.Close();
                MessageBox.Show("Account created successfully...", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Please try again...", "Boo-hoo", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return false;
            }
        }
        public bool LogIn(string username, string password)
        {
            m_dbConnection = new SQLiteConnection("Data Source=C:/database.sqlite;Version=3;");
            int userFound = 0;
            m_dbConnection.Open();
            string userMatch = String.Format("SELECT * FROM users WHERE username = '{0}' AND password = '{1}'", username, password);
            SQLiteCommand logIn = new SQLiteCommand(userMatch, m_dbConnection);
            SQLiteDataReader reader = logIn.ExecuteReader();
            while (reader.Read())
            {
                userFound += 1;
            }
            if (userFound == 1)
            {
                m_dbConnection.Close();
                MessageBox.Show("Welcome!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                m_dbConnection.Close();
                MessageBox.Show("Please try again...", "Boo-hoo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public int AssignId(string username, string password)
        {
            initializeDb();
            m_dbConnection.Open();
            int userID = 0;
            string userMatch = String.Format("SELECT * FROM users WHERE username = '{0}' AND password = '{1}'", username, password);
            SQLiteCommand assignId = new SQLiteCommand(userMatch, m_dbConnection);
            SQLiteDataReader reader = assignId.ExecuteReader();
            if (reader.Read())
            {
                userID = Convert.ToInt32(reader["username_id"]);
            }
            m_dbConnection.Close();
            return userID;
        }

        public string ReturnImgLink(int userID)
        {
            initializeDb();
            m_dbConnection.Open();
            string imgLink = "";
            string idMatch = String.Format("SELECT * FROM users WHERE username_id = '{0}'", userID);
            SQLiteCommand returnImgLink = new SQLiteCommand(idMatch, m_dbConnection);
            SQLiteDataReader reader = returnImgLink.ExecuteReader();
            if (reader.Read())
            {
                imgLink = Convert.ToString(reader["image_link"]);
            }
            m_dbConnection.Close();
            return imgLink;
        }

        public void UploadImage(string img_link, int userID)
        {
            //could return bools for checking success in form
            initializeDb();
            m_dbConnection.Open();
            string addImgLink = String.Format("UPDATE users SET image_link = '{0}' WHERE username_id = '{1}'", img_link, userID);
            SQLiteCommand addingImage = new SQLiteCommand(addImgLink, m_dbConnection);
            addingImage.ExecuteNonQuery();
            m_dbConnection.Close();
            
        }

        public void ChangePassword(string newPassword, int userID)
        {
            //could return bools for checking success in form
            initializeDb();
            m_dbConnection.Open();
            string passwordSql = String.Format("UPDATE users SET password = '{0}' WHERE username_id = '{1}'",newPassword, userID);
            SQLiteCommand changingPassword = new SQLiteCommand(passwordSql, m_dbConnection);
            changingPassword.ExecuteNonQuery();
            m_dbConnection.Close();
            MessageBox.Show("Success", "Password changed successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteTvshow(int tvshowID)
        {
            initializeDb();
            m_dbConnection.Open();
            string sqlString = String.Format("DELETE FROM tvshows WHERE tvshow_id = '{0}'", tvshowID);
            SQLiteCommand deletingShow = new SQLiteCommand(sqlString, m_dbConnection);
            deletingShow.ExecuteNonQuery();
            m_dbConnection.Close();
            MessageBox.Show("Success", "Tv show removed successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool AddTvShow(string title, string description, string image, int season, int episode, int status, int userID, int updatestatus = 0)
        {
            initializeDb();
            if (updatestatus == 0)
            {
                m_dbConnection.Open();
                string sqlString = String.Format("INSERT INTO tvshows (title, description, image, season, episode, status, user_id) VALUES " +
                    "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", title, description, image, season, episode, status, userID);
                SQLiteCommand addingShow = new SQLiteCommand(sqlString, m_dbConnection);
                addingShow.ExecuteNonQuery();
                m_dbConnection.Close();
                MessageBox.Show("Success", "Tv show added successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                m_dbConnection.Open();
                string sqlString = String.Format("UPDATE tvshows SET title = '{0}', description = '{1}', image = '{2}', season = '{2}', episode = '{3}'", title, description, image, season, episode);
                SQLiteCommand editingShow = new SQLiteCommand(sqlString, m_dbConnection);
                editingShow.ExecuteNonQuery();
                m_dbConnection.Close();
                return true;
            }
            
        }
        public List<TvShow> GetUserTvShows(int userID)
        {
            List<TvShow> userList = new List<TvShow>();

            initializeDb();
            m_dbConnection.Open();
            string sqlString = String.Format("SELECT * FROM tvshows WHERE user_id = '{0}' AND status = 1", userID);
            SQLiteCommand returnUsers = new SQLiteCommand(sqlString, m_dbConnection);
            SQLiteDataReader reader = returnUsers.ExecuteReader();
            while (reader.Read())
            {
                TvShow show = new TvShow() {
                    title = Convert.ToString(reader["title"]),
                    description = Convert.ToString(reader["description"]),
                    image = Convert.ToString(reader["image"]),
                    season = Convert.ToInt32(reader["season"]),
                    episode = Convert.ToInt32(reader["episode"]),
                    status = Convert.ToInt32(reader["status"]),
                    userID = Convert.ToInt32(reader["user_id"]),
                    tvshowID = Convert.ToInt32(reader["tvshow_id"])
                };
                userList.Add(show);
            }
            m_dbConnection.Close();
            return userList;
        }

        public TvShow TvShowForEditing(int tvshowID)
        {
            
            initializeDb();
            m_dbConnection.Open();
            string sqlString = String.Format("SELECT * FROM tvshows WHERE tvshow_id = '{0}' AND status = 1", tvshowID);
            SQLiteCommand returnShow = new SQLiteCommand(sqlString, m_dbConnection);
            SQLiteDataReader reader = returnShow.ExecuteReader();
            reader.Read();
            TvShow show = new TvShow()
            {
                title = Convert.ToString(reader["title"]),
                description = Convert.ToString(reader["description"]),
                image = Convert.ToString(reader["image"]),
                season = Convert.ToInt32(reader["season"]),
                episode = Convert.ToInt32(reader["episode"]),
                status = Convert.ToInt32(reader["status"]),
                userID = Convert.ToInt32(reader["user_id"]),
                tvshowID = Convert.ToInt32(reader["tvshow_id"])
            };
            m_dbConnection.Close();
            return show;
            
        }

    }
}
