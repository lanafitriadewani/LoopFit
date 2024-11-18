using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoopFit
{
    public partial class HomeDashboard : Form
    {

        private string username;
        public HomeDashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadUserData();
            User.DisplayProfileImage(User.Username, picProfile);
        }
        private void LoadUserData()
        {
            User user = User.GetFirstName("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit", username);
            if (user != null)
            {
                lblFirstName.Text = $"{User.FirstName}!";
            }
            else
            {
                lblFirstName.Text = "!";
            }
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Agar URL dibuka dengan browser default
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tidak dapat membuka URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDonate_Click(object sender, EventArgs e)
        {
            DonateClothInfo donateclothinfo = new DonateClothInfo();
            donateclothinfo.Show();
            this.Hide();
        }

        private void lblDonate_Click(object sender, EventArgs e)
        {
            DonateClothInfo donateclothinfo = new DonateClothInfo();
            donateclothinfo.Show();
            this.Hide();
        }

        private void lblDescDonate_Click(object sender, EventArgs e)
        {
            DonateClothInfo donateclothinfo = new DonateClothInfo();
            donateclothinfo.Show();
            this.Hide();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            DonateClothInfo donateclothinfo = new DonateClothInfo();
            donateclothinfo.Show();
            this.Hide();
        }

        private void picSosmed_Click(object sender, EventArgs e)
        {
            Content content = new Content();
            content.Show();
            this.Hide();
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            Content content = new Content();
            content.Show();
            this.Hide();
        }

        private void lblContent_Click(object sender, EventArgs e)
        {
            Content content = new Content();
            content.Show();
            this.Hide();
        }

        private void lblDescContent_Click(object sender, EventArgs e)
        {
            Content content = new Content();
            content.Show();
            this.Hide();
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }

        private void lblDescProduct_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void picInstagram_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.instagram.com/dtetiugm/");
        }

        private void picTiktok_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.tiktok.com/@kmteti");
        }

        private void picTwitter_Click(object sender, EventArgs e)
        {
            OpenUrl("https://x.com/KMTETI");
        }

        private void HomeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
