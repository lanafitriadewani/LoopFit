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
            LanguageHelper.UpdateUI(this);
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
                    MessageBox.Show("Please fill in all data completely.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Menghentikan eksekusi jika ada field yang kosong
                }

                string email = tbEmail.Text;
                string phoneNumber = tbPhoneNum.Text;

                // Cek keberadaan email dan nomor telepon di database
                var (emailExists, phoneExists) = User.CheckEmailAndPhoneStatus(email, phoneNumber);

                if (emailExists && phoneExists)
                {
                    MessageBox.Show("Email and phone number are already registered. Please use another email and phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Hentikan eksekusi jika keduanya sudah ada
                }
                else if (emailExists)
                {
                    MessageBox.Show("Email is already registered. Please use another email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Hentikan eksekusi jika hanya email yang ada
                }
                else if (phoneExists)
                {
                    MessageBox.Show("Phone number is already registered. Please use another phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var profile = await User.AuthenticateWithGoogleAsync(CLIENT_SECRET_JSON, "loopfit");

                string email = profile.EmailAddresses?[0]?.Value ?? "Not Available";

                if (User.IsEmailRegistered("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit", email))
                {
                    MessageBox.Show("Email is already registered. Please use another email or go to the login page.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Simpan informasi pengguna ke atribut User
                User.FirstName = profile.Names?[0]?.GivenName ?? "Not Available";
                User.LastName = profile.Names?[0]?.FamilyName ?? "Not Available";
                User.Email = email;
                User.PhoneNumber = "Unfilled"; // Mengisi Phone Number otomatis dengan "Unfilled"
                User.Username = (User.FirstName + User.LastName).ToLower();
                User.Password = User.EncryptPassword((User.FirstName + User.LastName).ToLower());

                // Simpan pengguna ke database
                if (User.SaveUserToDatabase("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit"))
                {
                    MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
