using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.WinForms;

namespace LoopFit
{
    public class Helper
    {
        public static void OpenUrl(string url)
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
                MessageBox.Show($"Cannot open the url: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void OpenProductLink(LinkLabel linkLabel)
        {
            if (linkLabel.Tag != null)
            {
                string url = linkLabel.Tag.ToString();
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Link product not available.");
            }
        }

        public static void PlayVideo(int contentid, WebView2 webView, DataTable videoData)
        {
            DataRow[] rows = videoData.Select($"contentid = {contentid}");
            if (rows.Length > 0)
            {
                string videoUrl = rows[0]["contenturl"].ToString();
                string embedUrl = GetEmbedUrl(videoUrl);
                string html = GenerateHtml(embedUrl);
                webView.NavigateToString(html);
            }
            else
            {
                MessageBox.Show("No video found for this box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static string GetEmbedUrl(string videoUrl)
        {
            string embedUrl = "";

            // Menangani URL YouTube Shorts
            if (videoUrl.Contains("youtube.com/shorts"))
            {
                string videoId = videoUrl.Split('/')[4].Split('?')[0];
                embedUrl = $"https://www.youtube.com/embed/{videoId}";
            }
            // Menangani URL YouTube biasa (youtu.be atau youtube.com)
            else if (videoUrl.Contains("youtu.be"))
            {
                string videoId = videoUrl.Split('/').Last().Split('?')[0];
                embedUrl = $"https://www.youtube.com/embed/{videoId}";
            }
            else if (videoUrl.Contains("youtube.com"))
            {
                string videoId = videoUrl.Split('=')[1];
                embedUrl = $"https://www.youtube.com/embed/{videoId}";
            }
            else
            {
                embedUrl = videoUrl;
            }

            return embedUrl;
        }

        private static string GenerateHtml(string embedUrl)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<style>body, html {margin: 0; padding: 0; overflow: hidden;} iframe {position: absolute; top: 0; left: 0; width: 100%; height: 100%;}</style>";
            html += $"<iframe id='video' src='{embedUrl}' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            return html;
        }

        public static void LoadContentLabelsById(DataTable videoData, Dictionary<int, Label> labelMapping)
        {
            foreach (var pair in labelMapping)
            {
                int contentId = pair.Key;
                Label label = pair.Value;

                // Mencari baris berdasarkan contentid
                DataRow[] rows = videoData.Select($"contentid = {contentId}");
                if (rows.Length > 0)
                {
                    label.Text = rows[0]["contenttitle"].ToString();
                }
                else
                {
                    label.Text = "No Title";
                }
            }
        }

        public static void UploadImage(PictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

    }
}
