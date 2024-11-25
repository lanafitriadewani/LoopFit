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
    public partial class DonateClothInfo : Form
    {
        public DonateClothInfo()
        {
            InitializeComponent();
            User.DisplayProfileImage(User.Username, picProfile);
            LanguageHelper.UpdateUI(this);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            Helper.UploadImage(pbClothImage);
        }

        private void btnUploadImage2_Click(object sender, EventArgs e)
        {
            Helper.UploadImage(pbClothImage2);
        }

        private void DonateClothInfo_Load(object sender, EventArgs e)
        {
            /*cbClothType.Items.Add("Inner Top");
            cbClothType.Items.Add("Outer Top");
            cbClothType.Items.Add("Pants");
            cbClothType.Items.Add("Skirt");
            cbClothType.Items.Add("Hijab");
            cbClothType.Items.Add("Overall");
            cbClothType.Items.Add("Other");

            cbMaterial.Items.Add("Cotton");
            cbMaterial.Items.Add("Linen");
            cbMaterial.Items.Add("Silk");
            cbMaterial.Items.Add("Wool");
            cbMaterial.Items.Add("Polyester");
            cbMaterial.Items.Add("Nylon");
            cbMaterial.Items.Add("Denim");
            cbMaterial.Items.Add("Leather");
            cbMaterial.Items.Add("Satin");
            cbMaterial.Items.Add("Jersey");
            cbMaterial.Items.Add("Other");

            cbClothColour.Items.Add("Red");
            cbClothColour.Items.Add("Orange");
            cbClothColour.Items.Add("Yellow");
            cbClothColour.Items.Add("Green");
            cbClothColour.Items.Add("Blue");
            cbClothColour.Items.Add("Indigo");
            cbClothColour.Items.Add("Violet");
            cbClothColour.Items.Add("Black");
            cbClothColour.Items.Add("White");
            cbClothColour.Items.Add("Grey");
            cbClothColour.Items.Add("Brown");
            cbClothColour.Items.Add("Other");*/
        }



        private void btnClothInfoNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi: Periksa apakah semua data telah diisi
                if (string.IsNullOrWhiteSpace(cbClothType.Text) || // Jenis pakaian
                    (!rbCondUsable_Info.Checked && !rbCondNonUsable_Info.Checked) || // Kondisi pakaian
                    string.IsNullOrWhiteSpace(cbMaterial.Text) || // Material pakaian
                    pbClothImage.Image == null || // Gambar depan
                    pbClothImage2.Image == null || // Gambar belakang
                    string.IsNullOrWhiteSpace(cbClothColour.Text) || // Warna pakaian
                    (!rbPatternYes_Info.Checked && !rbPatternNo_Info.Checked)) // Pola pakaian
                {
                    MessageBox.Show("Please complete all the required data before proceeding.",
                                    "Incomplete Data",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Semua validasi terpenuhi, lanjutkan proses
                Donate.ClothingType = cbClothType.Text;
                Donate.IsUsable = rbCondUsable_Info.Checked;
                Donate.Material = cbMaterial.Text;

                using (MemoryStream msFront = new MemoryStream())
                {
                    pbClothImage.Image.Save(msFront, pbClothImage.Image.RawFormat);
                    Donate.FrontClothes = msFront.ToArray();
                }

                using (MemoryStream msBack = new MemoryStream())
                {
                    pbClothImage2.Image.Save(msBack, pbClothImage2.Image.RawFormat);
                    Donate.BackClothes = msBack.ToArray();
                }

                Donate.Colour = cbClothColour.Text;
                Donate.Pattern = rbPatternYes_Info.Checked;
                Donate.EstimatedPrice = Donate.GetEstimatedPrice();

                // Buat instance form ConfirmDonate dan set label harga
                ConfirmDonate confirmDonateForm = new ConfirmDonate();
                confirmDonateForm.SetEstimatedPrice(Donate.EstimatedPrice);

                // Tampilkan form ConfirmDonate
                confirmDonateForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
