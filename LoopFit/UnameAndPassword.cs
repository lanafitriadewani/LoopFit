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
            User.Username = tbUname.Text;
            User.Password = tbPassword.Text;

            if (User.SaveUserToDatabase("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit"))
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
