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
using Microsoft.Web.WebView2.WinForms;
using Npgsql;

namespace LoopFit
{
    public partial class Content : Form
    {
        private string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";
        private DataTable videoData;
        public Content()
        {
            InitializeComponent();
            User.DisplayProfileImage(User.Username, picProfile);
            InitializeWebView();
            LoadVideoData();
            LanguageHelper.UpdateUI(this);
        }

        private async void InitializeWebView()
        {
            await webView1.EnsureCoreWebView2Async(null);
            await webView2.EnsureCoreWebView2Async(null);
            await webView3.EnsureCoreWebView2Async(null);
        }

        private void LoadVideoData()
        {
            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT contentid, contenttitle, contenturl FROM content";
                using (var command = new NpgsqlCommand(query, connection))
                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    videoData = new DataTable();
                    adapter.Fill(videoData);
                }
            }

            Helper.LoadContentLabels(videoData, lblContent1, lblContent2, lblContent3);

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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void picTiktok_Click(object sender, EventArgs e)
        {
            Helper.OpenUrl("https://www.tiktok.com/@kmteti");
        }

        private void btnVid1_Click(object sender, EventArgs e)
        {
            Helper.PlayVideo(1, webView1, videoData);

        }

        private void btnVid2_Click(object sender, EventArgs e)
        {
            Helper.PlayVideo(2, webView2, videoData);
        }

        private void btnVid3_Click(object sender, EventArgs e)
        {
            Helper.PlayVideo(3, webView3, videoData);
        }

        private void lblLoopFit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void lblContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactUs contact = new ContactUs();
            contact.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
