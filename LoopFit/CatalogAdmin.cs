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
using System.Xml.Linq;

namespace LoopFit
{
    public partial class CatalogAdmin : Form
    {
        private string conn = "Host=localhost; Port=5432;Username=postgres;Password=admin;Database=loopfit";
        private DataGridViewRow? r = null;
        public CatalogAdmin()
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picProduct.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnUpdateCatalog_Click(object sender, EventArgs e)
        {
            string catalogIdText = tbCatalogId.Text; // TextBox untuk Catalog ID
            string productName = tbProductName.Text; // TextBox untuk nama produk
            string linkProduct = tbLink.Text;
            double productPrice; // Variabel untuk harga produk

            if (!double.TryParse(tbProductPrice.Text, out productPrice))
            {
                MessageBox.Show("Invalid price format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Memeriksa apakah image ada, dan field lain telah diisi
            if (picProduct.Image != null && !string.IsNullOrEmpty(catalogIdText) && !string.IsNullOrEmpty(productName) && productPrice > 0)
            {
                byte[] productImage = ImageToByteArray(picProduct.Image);

                using (var connection = new NpgsqlConnection(conn))
                {
                    connection.Open();

                    // Query untuk mengupdate data pada tabel catalog berdasarkan catalogid
                    string query = "UPDATE catalog SET productname = @productname, productimage = @productimage, price = @price, linkproduct = @linkproduct WHERE catalogid = @catalogid";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@catalogid", int.Parse(catalogIdText)); // Parse catalogid
                        command.Parameters.AddWithValue("@productname", productName);
                        command.Parameters.AddWithValue("@productimage", productImage);
                        command.Parameters.AddWithValue("@price", productPrice);
                        command.Parameters.AddWithValue("@linkproduct", linkProduct);

                        int rowsAffected = command.ExecuteNonQuery(); // Mengeksekusi query

                        // Mengecek apakah ada baris yang terupdate
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given Catalog ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields and upload an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnLoadCatalog_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT catalogid, productname, productimage, price, linkproduct FROM catalog"; // SQL query to retrieve catalog data

                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable catalogData = new DataTable();
                        adapter.Fill(catalogData);

                        // Setting the DataGridView DataSource to the DataTable
                        dgvCatalogAdmin.DataSource = catalogData;
                    }
                }
            }
        }

        private void dgvCatalogAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvCatalogAdmin.Rows[e.RowIndex];

            // Menampilkan nilai-nilai dari kolom ke textbox
            tbCatalogId.Text = r.Cells["catalogid"].Value.ToString();
            tbProductName.Text = r.Cells["productname"].Value.ToString();
            tbProductPrice.Text = r.Cells["price"].Value.ToString();
            tbLink.Text = r.Cells["linkproduct"].Value.ToString();

            // Mengambil byte array dari kolom productimage dan mengonversinya ke Image
            byte[] productImageBytes = r.Cells["productimage"].Value as byte[];

            if (productImageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(productImageBytes))
                {
                    picProduct.Image = Image.FromStream(ms); // Mengonversi byte array menjadi gambar
                }
            }
            else
            {
                picProduct.Image = null; // Jika tidak ada gambar, set null atau gambar default
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string catalogIdText = tbCatalogId.Text; // Assuming there's a TextBox named txtCatalogId for the catalog ID
            string productName = tbProductName.Text; // Assuming there's a TextBox named txtProductName for the product name
            string linkProduct = tbLink.Text;
            double productPrice; // Assuming there's a NumericUpDown named numericPrice for the price

            if (!double.TryParse(tbProductPrice.Text, out productPrice))
            {
                MessageBox.Show("Invalid price format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (picProduct.Image != null && !string.IsNullOrEmpty(catalogIdText) && !string.IsNullOrEmpty(productName) && productPrice > 0)
            {
                byte[] productImage = ImageToByteArray(picProduct.Image);

                using (var connection = new NpgsqlConnection(conn))
                {
                    connection.Open();
                    string query = "INSERT INTO catalog (catalogid, productname, productimage, price, linkproduct) VALUES (@catalogid, @productname, @productimage, @price, @linkproduct)";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@catalogid", int.Parse(catalogIdText)); // Parse the catalog ID as integer
                        command.Parameters.AddWithValue("@productname", productName);
                        command.Parameters.AddWithValue("@productimage", productImage);
                        command.Parameters.AddWithValue("@price", productPrice);
                        command.Parameters.AddWithValue("@linkproduct", linkProduct);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all fields and upload an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void picProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
