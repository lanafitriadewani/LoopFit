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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoopFit
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
            User.ResetEmailVerification();
        }

        private void btnSendVerifCode_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsEmailRegistered("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit", email))
            {
                User.Email = tbEmail.Text;
                User.SendVerificationEmail(User.Email);
            }
            else
            {
                MessageBox.Show("Email not registered. Please sign up.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsEmailRegistered(string connString, string email)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT COUNT(*) FROM ""User"" WHERE email = @Email";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        // Mengambil hasil query
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Please enter an email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }

            if (string.IsNullOrEmpty(User.generatedVerificationCode))
            {
                MessageBox.Show("Anda belum memverifikasi email Anda. Silakan tekan tombol 'Send Verification' untuk mengirimkan kode verifikasi ke email Anda.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbVerif.Text))
            {
                MessageBox.Show("Anda belum menginputkan code yang Anda dapatkan di email baru. Silakan input code dan tekan tombol 'Verify' untuk memverifikasi code Anda.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inputCode = tbVerif.Text;
            if (inputCode == User.generatedVerificationCode)
            {
                User.isEmailVerified = true;
                MessageBox.Show("Verifikasi berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CreateNewPassword newpassword = new CreateNewPassword();
                newpassword.Show();
                this.Hide();
            }
            else
            {
                User.isEmailVerified = false; // Tetapkan ke false jika kode salah
                MessageBox.Show("Kode verifikasi salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text)) // Jika email berubah
            {
                // 1. Belum menekan tombol "Send Verification"
                if (string.IsNullOrEmpty(User.generatedVerificationCode))
                {
                    MessageBox.Show("Anda belum menginputkan email Anda. Silakan input email dan tekan tombol 'Send Verification' untuk mengirimkan kode verifikasi ke email Anda.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Sudah menekan "Send Verification" tetapi belum menginputkan kode
                if (string.IsNullOrWhiteSpace(tbVerif.Text))
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

            CreateNewPassword newpassword = new CreateNewPassword();
            newpassword.Show();
            this.Hide();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }
    }
}
