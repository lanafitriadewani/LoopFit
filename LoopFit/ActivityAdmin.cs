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
    public partial class ActivityAdmin : Form
    {
        private string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";

        public ActivityAdmin()
        {
            InitializeComponent();
        }

        private void btnDonateAct_Click(object sender, EventArgs e)
        {
            ActivityAdmin activityadmin = new ActivityAdmin();
            activityadmin.Show();
            this.Hide();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            CatalogAdmin catalogadmin = new CatalogAdmin();
            catalogadmin.Show();
            this.Hide();
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            ContentAdmin contentadmin = new ContentAdmin();
            contentadmin.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }

        private void llProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void picProfile_Click(object sender, EventArgs e)
        {

        }

        private void dgvDonateActivity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Mendapatkan baris yang dipilih
                DataGridViewRow selectedRow = dgvDonateActivity.Rows[e.RowIndex];

                // Mengisi TextBox berdasarkan baris yang dipilih
                tbDonateId.Text = selectedRow.Cells["donateid"].Value.ToString();
                tbStatus.Text = selectedRow.Cells["status"].Value?.ToString() ?? string.Empty;
                tbFixedPrice.Text = selectedRow.Cells["fixedprice"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnLoadDonate_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();

                // Ganti dengan nama view yang menggabungkan tabel donate dan user
                string query = "SELECT userid, username, donateid, fixedprice, status, droppointloc, estimatedprice, clothingtype, isusable, material, isaccepted, pattern, colour, frontclothes, backclothes FROM donate_user_view";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable donateData = new DataTable();
                        adapter.Fill(donateData);

                        // Set DataGridView DataSource ke DataTable
                        dgvDonateActivity.DataSource = donateData;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDonateId.Text) || string.IsNullOrWhiteSpace(tbStatus.Text) || string.IsNullOrWhiteSpace(tbFixedPrice.Text))
            {
                MessageBox.Show("Please fill in all fields to update the record.");
                return;
            }

            int donateId = int.Parse(tbDonateId.Text);
            string status = tbStatus.Text;
            string fixedPrice = tbFixedPrice.Text;

            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                string query = "UPDATE donate SET status = @status, fixedprice = @fixedprice WHERE donateid = @donateid";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@donateid", donateId);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@fixedprice", fixedPrice);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No Data found to update.");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDonateId.Text))
            {
                MessageBox.Show("Please select a data to delete.");
                return;
            }

            int donateId = int.Parse(tbDonateId.Text);

            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                string query = "DELETE FROM donate WHERE donateid = @donateid";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@donateid", donateId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No data found to delete.");
                    }
                }
            }
        }
    }
}
