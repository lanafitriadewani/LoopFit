using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditProfile : Form
    {

        private string currentUsername = User.Username;
        public EditProfile()
        {
            InitializeComponent();
            LoadUserData();
            User.ResetEmailVerification();
            User.DisplayProfileImage(User.Username, picProfile);
            CheckProfileImage();
        }

        private void LoadUserData()
        {
            // Connection string to the PostgreSQL database
            string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";

            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT username, firstname, lastname, email, phonenumber, profileimage FROM \"User\" WHERE username = @username";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", currentUsername);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbUsername.Text = reader["username"].ToString();
                            tbFirstName.Text = reader["firstname"].ToString();
                            tbLastName.Text = reader["lastname"].ToString();
                            tbEmail.Text = reader["email"].ToString();
                            tbPhoneNumber.Text = reader["phonenumber"].ToString();

                            // Sinkronkan email ke User.Email
                            User.Email = reader["email"].ToString();

                            byte[] profileImageBytes = reader["profileimage"] as byte[];
                            if (profileImageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(profileImageBytes))
                                {
                                    profilePic.Image = Image.FromStream(ms);
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

        private void CheckProfileImage()
        {
            // Connection string to the PostgreSQL database
            string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";

            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT profileimage FROM \"User\" WHERE username = @username";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", currentUsername); // Use the logged-in username

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Check if profileimage is NULL or has data
                            if (reader["profileimage"] == DBNull.Value || reader["profileimage"] == null)
                            {
                                btnChangeImage.Text = "Upload Image"; // No image
                            }
                            else
                            {
                                btnChangeImage.Text = "Change Image"; // Image exists
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


        private void btnSendVerifCode_Click(object sender, EventArgs e)
        {
            User.NewEmail = tbEmail.Text;
            User.SendVerificationEmail(User.NewEmail);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string inputCode = tbVerifCode.Text;
            if (inputCode == User.generatedVerificationCode)
            {
                User.isEmailVerified = true; // Tandai bahwa email telah diverifikasi
                MessageBox.Show("Verifikasi berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                User.isEmailVerified = false; // Tetapkan ke false jika kode salah
                MessageBox.Show("Kode verifikasi salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profilePic.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            string currentUsername = User.Username; // Username pengguna yang sedang login
            string inputCode = tbVerifCode.Text;
            string newUsername = tbUsername.Text; // Username baru dari input pengguna
            string newFirstName = tbFirstName.Text;
            string newLastName = tbLastName.Text;
            string newEmail = tbEmail.Text;
            string newPhoneNumber = tbPhoneNumber.Text;
            string newPassword = tbNewPw.Text;
            string confirmPassword = tbConfirmPw.Text;

            // Validasi verifikasi email
            if (newEmail != User.Email) // Jika email berubah
            {
                // 1. Belum menekan tombol "Send Verification"
                if (string.IsNullOrEmpty(User.generatedVerificationCode))
                {
                    MessageBox.Show("Anda belum memverifikasi email baru. Silakan tekan tombol 'Send Code' untuk mengirimkan kode verifikasi ke email baru Anda.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Sudah menekan "Send Verification" tetapi belum menginputkan kode
                if (string.IsNullOrWhiteSpace(tbVerifCode.Text))
                {
                    MessageBox.Show("Anda belum menginputkan code yang Anda dapatkan di email baru. Silakan input code dan tekan tombol 'Verify' untuk memverifikasi code Anda.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Sudah menginputkan kode tetapi belum menekan "Verify"
                if (!User.isEmailVerified)
                {
                    MessageBox.Show("Code verifikasi Anda masih salah. Silakan periksa kembali code pada email baru dan tekan tombol 'Verify' untuk memverifikasi code Anda.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }



            string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";
            byte[] profileImageBytes = null;

            // Konversi gambar ke byte array jika ada gambar yang diunggah
            if (profilePic.Image != null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    profilePic.Image.Save(ms, profilePic.Image.RawFormat);
                    profileImageBytes = ms.ToArray();
                }
            }

            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();

                // Validasi jika username baru sudah digunakan oleh pengguna lain
                if (newUsername != currentUsername)
                {
                    string queryCheckUsername = "SELECT COUNT(*) FROM \"User\" WHERE username = @newUsername";
                    using (var command = new NpgsqlCommand(queryCheckUsername, connection))
                    {
                        command.Parameters.AddWithValue("@newUsername", newUsername);

                        int usernameExists = Convert.ToInt32(command.ExecuteScalar());
                        if (usernameExists > 0)
                        {
                            MessageBox.Show("Username sudah digunakan. Pilih username lain.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Jika password baru diisi
                if (!string.IsNullOrEmpty(newPassword) || !string.IsNullOrEmpty(confirmPassword))
                {
                    // Periksa apakah password dan konfirmasi password cocok
                    if (newPassword != confirmPassword)
                    {
                        MessageBox.Show("Password yang dimasukkan tidak sama!",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    // Jika tidak diisi, ambil password lama dari database
                    string queryGetPassword = "SELECT password FROM \"User\" WHERE username = @username";
                    using (var command = new NpgsqlCommand(queryGetPassword, connection))
                    {
                        command.Parameters.AddWithValue("@username", currentUsername);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            newPassword = result.ToString(); // Set password lama sebagai password baru
                        }
                        else
                        {
                            MessageBox.Show("Pengguna tidak ditemukan!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Update data pengguna termasuk gambar profil
                string queryUpdate = "UPDATE \"User\" SET username = @newUsername, firstname = @firstname, lastname = @lastname, email = @email, phonenumber = @phonenumber, password = @password, profileimage = @profileimage WHERE username = @currentUsername";

                using (var command = new NpgsqlCommand(queryUpdate, connection))
                {
                    command.Parameters.AddWithValue("@newUsername", newUsername);
                    command.Parameters.AddWithValue("@firstname", newFirstName);
                    command.Parameters.AddWithValue("@lastname", newLastName);
                    command.Parameters.AddWithValue("@email", newEmail);
                    command.Parameters.AddWithValue("@phonenumber", newPhoneNumber);
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@profileimage", (object)profileImageBytes ?? DBNull.Value); // Masukkan gambar sebagai byte array
                    command.Parameters.AddWithValue("@currentUsername", currentUsername);

                    command.ExecuteNonQuery();
                }

                // Perbarui username dalam class User
                User.Username = newUsername;

                User.Email = newEmail;

                MessageBox.Show("Data berhasil diperbarui!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void llProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }
    }
}
