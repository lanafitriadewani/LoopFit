using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.DataFormats;
using Google.Apis.Auth.OAuth2;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace LoopFit
{
    public partial class SignUp : Form
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

        public SignUp()
        {
            InitializeComponent();
            User.ResetEmailVerification();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                User.FirstName = tbFirstName.Text;
                User.LastName = tbLastName.Text;
                User.Email = tbEmail.Text;
                User.PhoneNumber = tbPhoneNum.Text;

                User.SendVerificationEmail(User.Email);


                VerifEmail verifemail = new VerifEmail(User.Email);
                verifemail.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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

                // Pindahkan ke form Verifikasi Email (atau form berikutnya yang Anda inginkan)
                UnameAndPassword unameandpassword = new UnameAndPassword();
                unameandpassword.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during authentication: {ex.Message}");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }
    }
}
