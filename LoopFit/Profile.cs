using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopFit
{
    public partial class Profile : Form
    {
        // Assume User.Username is already set during login
        private string currentUsername = User.Username;
        private string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit"; // Connection string to your database

        public Profile()
        {
            InitializeComponent();
            User.DisplayProfileImage(User.Username, picProfile);
            LoadUserData();
            LanguageHelper.UpdateUI(this);
        }

        private void LoadUserData()
        {
            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT username, firstname, lastname, email, phonenumber, password, profileimage FROM \"User\" WHERE username = @username";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", currentUsername);  // Use the current username

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve and display user data
                            lblDataUser_Profile.Text = reader["username"].ToString();
                            lblDataFullName_Profile.Text = $"{reader["firstname"]} {reader["lastname"]}";
                            lblDataEmail_Profile.Text = reader["email"].ToString();
                            lblDataPhone_Profile.Text = reader["phonenumber"].ToString();

                            // Mask password with stars
                            string password = reader["password"].ToString();
                            lblDataPassword_Profile.Text = new string('*', 8);

                            // Optionally display profile image if available
                            byte[] profileImageBytes = reader["profileimage"] as byte[];
                            if (profileImageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(profileImageBytes))
                                {
                                    picUserProfile.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editprofile = new EditProfile();
            editprofile.Show();
            this.Hide();
        }

        private void llProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            string username = User.Username;
            HomeDashboard homedashboard = new HomeDashboard(username);
            homedashboard.Show();
            this.Hide();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            ActivityUser activityuser = new ActivityUser();
            activityuser.Show();
            this.Hide();
        }

        private void btnLogOut_Profile_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void btnSubmitLanguage_Click(object sender, EventArgs e)
        {
            if (rbIndo_Profile.Checked)
            {
                LanguageHelper.SetLanguage("indonesia");
            }
            else if (rbEnglish_Profile.Checked)
            {
                LanguageHelper.SetLanguage("english");
            }
        }
    }
}
