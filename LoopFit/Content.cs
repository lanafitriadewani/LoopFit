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

            if (videoData.Rows.Count > 0)
            {
                lblContent1.Text = videoData.Rows.Count > 0 ? videoData.Rows[0]["contenttitle"].ToString() : "No Title";
                lblContent2.Text = videoData.Rows.Count > 1 ? videoData.Rows[1]["contenttitle"].ToString() : "No Title";
                lblContent3.Text = videoData.Rows.Count > 2 ? videoData.Rows[2]["contenttitle"].ToString() : "No Title";
            }
            else
            {
                lblContent1.Text = "No Title";
                lblContent2.Text = "No Title";
                lblContent3.Text = "No Title";
            }
        }

        private void PlayVideo(int contentid, WebView2 webView)
        {
            DataRow[] rows = videoData.Select($"contentid = {contentid}");
            if (rows.Length > 0)
            {
                string videoUrl = rows[0]["contenturl"].ToString();
                string embedUrl = "";

                // Menangani URL YouTube Shorts
                if (videoUrl.Contains("youtube.com/shorts"))
                {
                    string videoId = videoUrl.Split('/')[4].Split('?')[0]; // Ambil video ID dari URL Shorts
                    embedUrl = $"https://www.youtube.com/embed/{videoId}";
                }
                // Menangani URL YouTube biasa (youtu.be atau youtube.com)
                else if (videoUrl.Contains("youtu.be"))
                {
                    string videoId = videoUrl.Split('/').Last().Split('?')[0]; // Menangkap video ID
                    embedUrl = $"https://www.youtube.com/embed/{videoId}";
                }
                else if (videoUrl.Contains("youtube.com"))
                {
                    string videoId = videoUrl.Split('=')[1]; // Menangkap video ID dari URL youtube.com
                    embedUrl = $"https://www.youtube.com/embed/{videoId}";
                }
                else
                {
                    embedUrl = videoUrl; // Untuk jenis video selain YouTube
                }

                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<style>body, html {margin: 0; padding: 0; overflow: hidden;} iframe {position: absolute; top: 0; left: 0; width: 100%; height: 100%;}</style>";
                html += $"<iframe id='video' src='{embedUrl}' frameborder='0' allowfullscreen></iframe>";
                html += "</head></html>";

                webView.NavigateToString(html);
            }
            else
            {
                MessageBox.Show("Video tidak ditemukan untuk WebView ini.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void picTiktok_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.tiktok.com/@kmteti");
        }

        private void btnVid1_Click(object sender, EventArgs e)
        {
            PlayVideo(1, webView1);
        }

        private void btnVid2_Click(object sender, EventArgs e)
        {
            PlayVideo(2, webView2);
        }

        private void btnVid3_Click(object sender, EventArgs e)
        {
            PlayVideo(3, webView3);
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
    }
}
