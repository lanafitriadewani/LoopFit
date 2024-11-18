using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace LoopFit
{
    public partial class ConfirmDonate : Form
    {
        private GMapControl map1;
        private GMapControl map2;
        private GMapControl map3;
        private GMapControl map4;
        private GMapControl map5;

        public ConfirmDonate()
        {
            InitializeComponent();

            User.DisplayProfileImage(User.Username, picProfile);

            // Inisialisasi peta dengan masing-masing koordinat yang berbeda dan menambahkan marker
            map1 = CreateMapControl(new PointLatLng(-7.7877454, 110.3741478)); // Jakarta
            map2 = CreateMapControl(new PointLatLng(-7.7570287, 110.3933283)); // Tokyo
            map3 = CreateMapControl(new PointLatLng(-7.8575357, 110.1546624)); // New York
            map4 = CreateMapControl(new PointLatLng(-7.9651197, 110.5982374));  // London
            map5 = CreateMapControl(new PointLatLng(-7.8882312, 110.3252878)); // Sydney

            // Menambahkan marker ke masing-masing peta
            AddMarkerToMap(map1, new PointLatLng(-7.7877454, 110.3741478)); // Jakarta
            AddMarkerToMap(map2, new PointLatLng(-7.7570287, 110.3933283)); // Tokyo
            AddMarkerToMap(map3, new PointLatLng(-7.8575357, 110.1546624)); // New York
            AddMarkerToMap(map4, new PointLatLng(-7.9651197, 110.5982374));  // London
            AddMarkerToMap(map5, new PointLatLng(-7.8882312, 110.3252878)); // Sydney

            // Menambahkan peta ke form atau layout panel
            map1.Location = new System.Drawing.Point(278, 470);
            map2.Location = new System.Drawing.Point(489, 470);
            map3.Location = new System.Drawing.Point(700, 470);
            map4.Location = new System.Drawing.Point(911, 470);
            map5.Location = new System.Drawing.Point(1122, 470);

            map1.Size = map2.Size = map3.Size = map4.Size = map5.Size = new System.Drawing.Size(170, 180);

            this.Controls.Add(map1);
            this.Controls.Add(map2);
            this.Controls.Add(map3);
            this.Controls.Add(map4);
            this.Controls.Add(map5);
        }

        public void SetEstimatedPrice(string price)
        {
            lblNumPrice.Text = price;
        }

        private void btnConfirmDonate_Click(object sender, EventArgs e)
        {
            if (!rbYesDonate.Checked && !rbNoDonate.Checked)
            {
                MessageBox.Show("Please select whether you want to continue the donation or not.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Donate.IsAccepted = false;

            // Cek jika rbYesDonate dipilih
            if (rbYesDonate.Checked)
            {
                // Cek apakah ada salah satu drop point yang dipilih
                if (rbYogya.Checked || rbSleman.Checked || rbKulonProgo.Checked || rbGunungKidul.Checked || rbBantul.Checked)
                {
                    // Set DropPoint value based on selected radio button
                    if (rbYogya.Checked) Donate.DropPoint = "Kota Jogja";
                    else if (rbSleman.Checked) Donate.DropPoint = "Sleman";
                    else if (rbKulonProgo.Checked) Donate.DropPoint = "Kulon Progo";
                    else if (rbGunungKidul.Checked) Donate.DropPoint = "Gunung Kidul";
                    else if (rbBantul.Checked) Donate.DropPoint = "Bantul";

                    Donate.IsAccepted = true; // Set IsAccepted attribute to true if user chose to donate

                    // Save donation data to database
                    if (Donate.SaveDonateToDatabase("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=loopfit"))
                    {
                        MessageBox.Show("Donation data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ThanksDonate thanksDonateForm = new ThanksDonate();
                        thanksDonateForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save donation data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a drop point location before confirming donation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbNoDonate.Checked)
            {
                HomeDashboard homedashboard = new HomeDashboard(User.Username);
                homedashboard.Show();
                this.Hide();
            }
        }

        private GMapControl CreateMapControl(PointLatLng coordinates)
        {
            var map = new GMapControl();
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.Position = coordinates;
            map.MinZoom = 1;
            map.MaxZoom = 20;
            map.Zoom = 15;  // Atur tingkat zoom yang sesuai
            map.Dock = DockStyle.None;
            map.ShowCenter = false;
            map.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter; // Memungkinkan zoom dengan roda mouse di pusat peta
            map.CanDragMap = true;

            return map;
        }

        // Menambahkan marker ke peta
        private void AddMarkerToMap(GMapControl map, PointLatLng coordinates)
        {
            var markersOverlay = new GMapOverlay("markers");

            var marker = new GMarkerGoogle(coordinates, GMarkerGoogleType.red_dot);
            markersOverlay.Markers.Add(marker);

            map.Overlays.Add(markersOverlay);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            DonateClothInfo donateClothInfoForm = new DonateClothInfo();
            donateClothInfoForm.Show();
            this.Hide();
        }

        private void lblLoopFit2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void lblContactUs2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactUs contact = new ContactUs();
            contact.Show();
            this.Hide();
        }
    }
}
