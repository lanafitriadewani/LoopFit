using Npgsql;
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
    public partial class Catalog : Form
    {
        private string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";
        public Catalog()
        {
            InitializeComponent();
            User.DisplayProfileImage(User.Username, picProfile);
            LoadProductData();
            LanguageHelper.UpdateUI(this);
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

        private void LoadProductData()
        {
            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT catalogid, productname, productimage, price, linkproduct FROM catalog ORDER BY catalogid"; // Retrieve data from catalog table sorted by catalogid

                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // Loop through each row of the result set
                        while (reader.Read())
                        {
                            int catalogId = reader.GetInt32(0);
                            string productName = reader.GetString(1);
                            byte[] productImageBytes = reader["productimage"] as byte[]; // Assuming productimage is byte array
                            double price = reader.GetDouble(3);
                            string linkProduct = reader["linkproduct"].ToString();

                            // Get image from byte array
                            Image productImage = null;
                            if (productImageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(productImageBytes))
                                {
                                    productImage = Image.FromStream(ms);
                                }
                            }

                            // Update controls based on catalogid
                            if (catalogId == 1)
                            {
                                picProduct1.Image = productImage;
                                lblProduct1.Text = productName;
                                lblPrice1.Text = $"Rp {price}";
                                if (!string.IsNullOrEmpty(linkProduct))
                                {
                                    llShopee1.Tag = linkProduct;
                                }
                            }
                            else if (catalogId == 2)
                            {
                                picProduct2.Image = productImage;
                                lblProduct2.Text = productName;
                                lblPrice2.Text = $"Rp {price}";
                                if (!string.IsNullOrEmpty(linkProduct))
                                {
                                    llShopee2.Tag = linkProduct;
                                }
                            }
                            else if (catalogId == 3)
                            {
                                picProduct3.Image = productImage;
                                lblProduct3.Text = productName;
                                lblPrice3.Text = $"Rp {price}";
                                if (!string.IsNullOrEmpty(linkProduct))
                                {
                                    llShopee3.Tag = linkProduct;
                                }
                            }
                            else if (catalogId == 4)
                            {
                                picProduct4.Image = productImage;
                                lblProduct4.Text = productName;
                                lblPrice4.Text = $"Rp {price}";
                                if (!string.IsNullOrEmpty(linkProduct))
                                {
                                    llShopee4.Tag = linkProduct;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void llShopee1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llShopee1.Tag != null)
            {
                string url = llShopee1.Tag.ToString();
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true // Make sure it opens in the browser
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

        private void llShopee2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llShopee2.Tag != null)
            {
                string url = llShopee2.Tag.ToString();
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

        private void llShopee3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llShopee3.Tag != null)
            {
                string url = llShopee3.Tag.ToString();
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

        private void llShopee4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llShopee4.Tag != null)
            {
                string url = llShopee4.Tag.ToString();
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
