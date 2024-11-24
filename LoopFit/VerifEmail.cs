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
    public partial class VerifEmail : Form
    {
        public VerifEmail(string email)
        {
            InitializeComponent();

            string descriptionText = string.Format(Resources.EmailVerificationDescription, email);

            lblDesc_Verif.Text = descriptionText;

            LanguageHelper.UpdateUI(this);
        }

        public string generatedVerificationCode;
        private void btnVerify_Click(object sender, EventArgs e)
        {
            string inputCode = tbVerifNum1.Text + tbVerifNum2.Text + tbVerifNum3.Text + tbVerifNum4.Text;
            if (inputCode == User.generatedVerificationCode)
            {
                MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UnameAndPassword unameandpassword = new UnameAndPassword();
                unameandpassword.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The verification code is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
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

        private void llLogin_VerifEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User.ResetEmailVerification();
            User.SendVerificationEmail(User.Email);
            MessageBox.Show("A new verification code has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
