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
                MessageBox.Show("Username atau Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLoginGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                // Tentukan scope Google API (email, profil)
                string[] scopes = {
                    "https://www.googleapis.com/auth/userinfo.email",
                    "https://www.googleapis.com/auth/userinfo.profile"
                };

                string tokenPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "LoopFit_" + DateTime.Now.ToString("yyyyMMddHHmmss"), "token.json");

                if (File.Exists(tokenPath))
                {
                    File.Delete(tokenPath); // Menghapus token lama
                }

                // Parse kredensial dari string JSON
                UserCredential credential;
                using (var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(CLIENT_SECRET_JSON)))
                {
                    var clientSecrets = GoogleClientSecrets.FromStream(stream);
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        clientSecrets.Secrets,
                        scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(tokenPath, true)); // Menyimpan token baru
                }

                // Inisialisasi layanan People API
                var service = new PeopleServiceService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Your Windows App"
                });

                // Dapatkan informasi pengguna menggunakan People API
                var request = service.People.Get("people/me");
                request.PersonFields = "names,emailAddresses";
                Person profile = await request.ExecuteAsync();

                // Simpan informasi pengguna ke dalam atribut User
                User.FirstName = profile.Names?[0]?.GivenName ?? "Not Available";
                User.LastName = profile.Names?[0]?.FamilyName ?? "Not Available";
                User.Email = profile.EmailAddresses?[0]?.Value ?? "Not Available";
                User.PhoneNumber = "Unfilled";  // Mengisi Phone Number otomatis dengan "Unfilled"

                string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit";

                User.Username = User.GetUsernameByEmail(connectionString, User.Email);

                if (User.ValidateUserGoogle(connectionString, User.Username))
                {
                    HomeDashboard homedashboard = new HomeDashboard(User.Username);
                    homedashboard.Show();
                    this.Hide();
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
