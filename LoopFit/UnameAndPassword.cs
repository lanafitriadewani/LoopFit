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
            LanguageHelper.UpdateUI(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit";

            // Simpan username dan password dari input
            User.Username = tbUname.Text;
            User.Password = tbPassword.Text;

            // Cek apakah username sudah digunakan
            if (User.IsUsernameRegistered(User.Username, connectionString))
            {
                MessageBox.Show("Username is already in use. Please use another username.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hentikan proses jika username sudah ada
            }

            // Simpan ke database jika username belum digunakan
            if (User.SaveUserToDatabase(connectionString))
            {
                MessageBox.Show("User data successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to save user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
