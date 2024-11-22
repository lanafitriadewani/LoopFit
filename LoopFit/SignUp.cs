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

        private (bool emailExists, bool phoneExists) CheckEmailAndPhoneStatus(string email, string phoneNumber)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit";
            string query = "SELECT email, phonenumber FROM \"User\" WHERE email = @Email OR phonenumber = @PhoneNumber";

            bool emailExists = false;
            bool phoneExists = false;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["email"] != DBNull.Value && reader["email"].ToString() == email)
                                {
                                    emailExists = true;
                                }
                                if (reader["phonenumber"] != DBNull.Value && reader["phonenumber"].ToString() == phoneNumber)
                                {
                                    phoneExists = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memeriksa database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (emailExists, phoneExists);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah semua textbox sudah diisi
                if (string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                    string.IsNullOrWhiteSpace(tbLastName.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) ||
                    string.IsNullOrWhiteSpace(tbPhoneNum.Text))
                {
                    MessageBox.Show("Harap isi semua data dengan lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Menghentikan eksekusi jika ada field yang kosong
                }

                string email = tbEmail.Text;
                string phoneNumber = tbPhoneNum.Text;

                // Cek keberadaan email dan nomor telepon di database
                var (emailExists, phoneExists) = CheckEmailAndPhoneStatus(email, phoneNumber);

                if (emailExists && phoneExists)
                {
                    MessageBox.Show("Email dan nomor telepon sudah terdaftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Hentikan eksekusi jika keduanya sudah ada
                }
                else if (emailExists)
                {
                    MessageBox.Show("Email sudah terdaftar. Harap gunakan email lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Hentikan eksekusi jika hanya email yang ada
                }
                else if (phoneExists)
                {
                    MessageBox.Show("Nomor telepon sudah terdaftar. Harap gunakan nomor lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Hentikan eksekusi jika hanya nomor telepon yang ada
                }

                // Assign data ke properti User
                User.FirstName = tbFirstName.Text;
                User.LastName = tbLastName.Text;
                User.Email = email;
                User.PhoneNumber = phoneNumber;

                // Kirim email verifikasi
                User.SendVerificationEmail(User.Email);

                // Tampilkan form verifikasi email
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

                string email = profile.EmailAddresses?[0]?.Value ?? "Not Available";

                // Periksa apakah email sudah terdaftar di database
                if (IsEmailRegistered(email))
                {
                    MessageBox.Show("Email sudah terdaftar. Harap gunakan email lain atau login dengan akun yang sesuai.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Hentikan proses jika email sudah ada
                }

                // Simpan informasi pengguna ke dalam atribut User
                User.FirstName = profile.Names?[0]?.GivenName ?? "Not Available";
                User.LastName = profile.Names?[0]?.FamilyName ?? "Not Available";
                User.Email = email;
                User.PhoneNumber = "Unfilled"; // Mengisi Phone Number otomatis dengan "Unfilled"

                // Membuat Username dan Password otomatis
                User.Username = (User.FirstName + User.LastName).ToLower();
                User.Password = (User.FirstName + User.LastName).ToLower();

                // Simpan pengguna ke database
                string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit";
                if (User.SaveUserToDatabase(connectionString))
                {
                    MessageBox.Show("Pendaftaran berhasil. Silakan login dengan akun Anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Pindahkan ke form login
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during authentication: {ex.Message}");
            }
        }

        private bool IsEmailRegistered(string email)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit";
            string query = "SELECT COUNT(*) FROM \"User\" WHERE email = @Email";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Mengembalikan true jika email ditemukan
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memeriksa email di database: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
