using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace LoopFit
{
    public partial class ContentAdmin : Form
    {
        public ContentAdmin()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void ContentAdmin_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoadContent_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connstring))
            {
                connection.Open();
                string query = "SELECT contentid, contenttitle, contenturl FROM content"; // SQL query to retrieve catalog data

                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable catalogData = new DataTable();
                        adapter.Fill(catalogData);

                        // Setting the DataGridView DataSource to the DataTable
                        dgvContentAdmin.DataSource = catalogData;
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int contentId = int.Parse(tbId.Text);
                string contentTitle = tbTitle.Text;
                string contentUrl = tbVideoLink.Text;

                conn.Open();
                sql = "INSERT INTO content (contentid, contenttitle, contenturl) VALUES (@contentId, @contentTitle, @contentUrl)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("contentTitle", contentTitle);
                cmd.Parameters.AddWithValue("contentUrl", contentUrl);
                cmd.Parameters.AddWithValue("contentId", contentId);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal memperbarui data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int contentId = int.Parse(tbId.Text);
                string contentTitle = tbTitle.Text;
                string contentUrl = tbVideoLink.Text;

                conn.Open();
                sql = "UPDATE content SET contenttitle = @contentTitle, contenturl = @contentUrl WHERE contentid = @contentId";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("contentTitle", contentTitle);
                cmd.Parameters.AddWithValue("contentUrl", contentUrl);
                cmd.Parameters.AddWithValue("contentId", contentId);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal memperbarui data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int contentId = int.Parse(tbId.Text);

                conn.Open();
                sql = "DELETE FROM content WHERE contentid = @contentId";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("contentId", contentId);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal menghapus data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void llProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void picProfile_Click(object sender, EventArgs e)
        {

        }

        private void dgvContentAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvContentAdmin.Rows[e.RowIndex];

            // Menampilkan nilai-nilai dari kolom ke textbox
            tbId.Text = r.Cells["contentid"].Value.ToString();
            tbTitle.Text = r.Cells["contenttitle"].Value.ToString();
            tbVideoLink.Text = r.Cells["contenturl"].Value.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage = new WelcomePage();
            welcomepage.Show();
            this.Hide();
        }
    }
}
