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
    public partial class UnameAndPassword : Form
    {
        public UnameAndPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit";

            // Simpan username dan password dari input
            User.Username = tbUname.Text;
            User.Password = tbPassword.Text;

            // Cek apakah username sudah digunakan
            if (IsUsernameRegistered(User.Username, connectionString))
            {
                MessageBox.Show("Username sudah digunakan. Gunakan username lain.",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hentikan proses jika username sudah ada
            }

            // Simpan ke database jika username belum digunakan
            if (User.SaveUserToDatabase(connectionString))
            {
                MessageBox.Show("Data pengguna berhasil disimpan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data pengguna.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUsernameRegistered(string username, string connectionString)
        {
            string query = "SELECT COUNT(*) FROM \"User\" WHERE username = @Username";

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Mengembalikan true jika username ditemukan
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memeriksa username di database: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void llLoopFit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }
    }
}
