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

namespace LoopFit
{
    public partial class ActivityUser : Form
    {
        public ActivityUser()
        {
            InitializeComponent();
            User.DisplayProfileImage(User.Username, picProfile);
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

        private void btnLoadActivityUser_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost; Port=5432; Username=postgres; Password=admin; Database=loopfit";

            try
            {
                // Membuat koneksi ke database
                using (var connection = new NpgsqlConnection(connString))
                {
                    connection.Open();

                    // Query untuk mendapatkan data dari tabel donate
                    string query = @"
                SELECT 
                    donateid, fixedprice, status, droppointloc, estimatedprice, 
                    clothingtype, isusable, material, isaccepted, pattern, 
                    colour, frontclothes, backclothes 
                FROM donate 
                ORDER BY donateid";

                    // Membuat command untuk menjalankan query
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Adapter untuk mengisi data ke dalam DataTable
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable donateData = new DataTable();
                            adapter.Fill(donateData);

                            // Menampilkan data di DataGridView
                            dgvActivityUser.DataSource = donateData;

                            // Mengatur urutan dan header kolom sesuai kebutuhan
                            dgvActivityUser.Columns["donateid"].HeaderText = "Donate ID";
                            dgvActivityUser.Columns["fixedprice"].HeaderText = "Fixed Price";
                            dgvActivityUser.Columns["status"].HeaderText = "Status";
                            dgvActivityUser.Columns["droppointloc"].HeaderText = "Drop Point Location";
                            dgvActivityUser.Columns["estimatedprice"].HeaderText = "Estimated Price";
                            dgvActivityUser.Columns["clothingtype"].HeaderText = "Clothing Type";
                            dgvActivityUser.Columns["isusable"].HeaderText = "Is Usable";
                            dgvActivityUser.Columns["material"].HeaderText = "Material";
                            dgvActivityUser.Columns["isaccepted"].HeaderText = "Is Accepted";
                            dgvActivityUser.Columns["pattern"].HeaderText = "Pattern";
                            dgvActivityUser.Columns["colour"].HeaderText = "Colour";
                            dgvActivityUser.Columns["frontclothes"].HeaderText = "Front Clothes";
                            dgvActivityUser.Columns["backclothes"].HeaderText = "Back Clothes";
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactUs contact = new ContactUs();
            contact.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            this.Hide();
        }

        private void lblLoopFit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            this.Hide();
        }
    }
}
