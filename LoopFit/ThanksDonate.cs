using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopFit
{
    public partial class ThanksDonate : Form
    {
        public ThanksDonate()
        {
            InitializeComponent();
            User.DisplayProfileImage(User.Username, picProfile);
            LanguageHelper.UpdateUI(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeDashboard homedashboard = new HomeDashboard(User.Username);
            homedashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            ActivityUser activityuser = new ActivityUser();
            activityuser.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            string username = User.Username;
            HomeDashboard homedashboard = new HomeDashboard(username);
            homedashboard.Show();
            this.Hide();
        }

        private void llProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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

        private void picInstagram_Click(object sender, EventArgs e)
        {
            Helper.OpenUrl("https://www.instagram.com/dtetiugm/");
        }

        private void picTiktok_Click(object sender, EventArgs e)
        {
            Helper.OpenUrl("https://www.tiktok.com/@kmteti");
        }

        private void picTwitter_Click(object sender, EventArgs e)
        {
            Helper.OpenUrl("https://x.com/KMTETI");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactUs contact = new ContactUs();
            contact.Show();
            this.Hide();
        }
    }
}
