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
            LanguageHelper.UpdateUI(this);
        }

        private void btnSendVerifCode_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (User.IsEmailRegistered("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit", email))
            {
                User.Email = tbEmail.Text;
                User.SendVerificationEmail(User.Email);
            }
            else
            {
                MessageBox.Show("Email not registered. Please sign up.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("You have not verified your email. Please press the 'Send Verification' button to send a verification code to your email.", 
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbVerif.Text))
            {
                MessageBox.Show("You have not entered the code you received in the new email. Please enter the code and press the 'Verify' button to verify your code.", 
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inputCode = tbVerif.Text;
            if (inputCode == User.generatedVerificationCode)
            {
                User.isEmailVerified = true;
                MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CreateNewPassword newpassword = new CreateNewPassword();
                newpassword.Show();
                this.Hide();
            }
            else
            {
                User.isEmailVerified = false; // Tetapkan ke false jika kode salah
                MessageBox.Show("The verification code is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
