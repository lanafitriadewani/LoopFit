using Google.Apis.Auth.OAuth2;
using Google.Apis.PeopleService.v1.Data;
using Google.Apis.PeopleService.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoopFit
{
    public partial class Login : Form
    {
        private const string CLIENT_SECRET_JSON = @"{
            ""installed"": {
                ""client_id"": ""93623369431-pe3krpjioac9ic0tat9atrn6v1q97b04.apps.googleusercontent.com"",
                ""project_id"": ""loopfit"",
                ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
                ""token_uri"": ""https://oauth2.googleapis.com/token"",
                ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
                ""client_secret"": ""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"",
                ""redirect_uris"": [""http://localhost""]
            }
        }";

        public Login()
        {
            InitializeComponent();
            LanguageHelper.UpdateUI(this);
        }

        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string input = tbUname.Text; // Masukkan input sementara
            User.Password = tbPassword.Text;

            // Cek jika input Username atau Password kosong
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(User.Password))
            {
                MessageBox.Show("Username or Password cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan proses login jika ada input kosong
            }

            string role, email, username;
            if (User.ValidateUser("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit", input, User.Password, out role, out username, out email))
            {
                // Set Username dan Email ke User setelah validasi
                User.Username = username;
                User.Email = email;

                // Periksa peran pengguna
                if (role == "admin")
                {
                    ActivityAdmin activityadmin = new ActivityAdmin();
                    activityadmin.Show();
                }
                else
                {
                    HomeDashboard homedashboard = new HomeDashboard(User.Username);
                    homedashboard.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLoginGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                var profile = await User.AuthenticateWithGoogleAsync(CLIENT_SECRET_JSON, "loopfit");

                User.Email = profile.EmailAddresses?[0]?.Value ?? "Not Available";
                User.Username = User.GetUsernameByEmail("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit", User.Email);

                if (User.ValidateUserGoogle("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit", User.Username))
                {
                    HomeDashboard homedashboard = new HomeDashboard(User.Username);
                    homedashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user or email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during authentication: {ex.Message}");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forget = new ForgetPassword();
            forget.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }
    }
}
