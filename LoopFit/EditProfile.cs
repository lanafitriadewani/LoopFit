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
            LanguageHelper.UpdateUI(this);
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

        private void btnSendVerifCode_Click(object sender, EventArgs e)
        {
            User.NewEmail = tbEmail.Text;
            User.SendVerificationEmail(User.NewEmail);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (User.IsEmailVerified(tbVerifCode.Text))
            {
                MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The verification code is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            Helper.UploadImage(profilePic);
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
                    MessageBox.Show("You have not verified your new email. Please press the 'Send Code' button to send a verification code to your new email.", 
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Sudah menekan "Send Verification" tetapi belum menginputkan kode
                if (string.IsNullOrWhiteSpace(tbVerifCode.Text))
                {
                    MessageBox.Show("You have not entered the code you received in the new email. Please enter the code and press the 'Verify' button to verify your code.", 
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Sudah menginputkan kode tetapi belum menekan "Verify"
                if (!User.isEmailVerified)
                {
                    MessageBox.Show("Your verification code is still wrong. Please check the code in the new email again and press the 'Verify' button to verify your code.", 
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
                if (newUsername != currentUsername && User.IsUsernameTaken(newUsername))
                {
                    MessageBox.Show("Username is already in use. Please choose another username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Jika password baru diisi
                if (!string.IsNullOrEmpty(newPassword) || !string.IsNullOrEmpty(confirmPassword))
                {
                    // Periksa apakah password dan konfirmasi password cocok
                    if (newPassword != confirmPassword)
                    {
                        MessageBox.Show("The password entered does not match!",
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
                            MessageBox.Show("User not found!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Update data pengguna termasuk gambar profil
                User.UpdateUserData(newUsername, newFirstName, newLastName, newEmail, newPhoneNumber, newPassword, profileImageBytes);


                // Perbarui username dalam class User
                User.Username = newUsername;

                User.Email = newEmail;

                MessageBox.Show("Data updated successfully!",
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
