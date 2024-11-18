using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoopFit
{
    public class Donate
    {
        public int DonateID { get; set; }
        public static string ClothingType { get; set; }
        public static bool IsUsable { get; set; }
        public static string Material { get; set; }
        public static byte[] FrontClothes { get; set; }
        public static byte[] BackClothes { get; set; }
        public static string EstimatedPrice { get; set; }
        public static bool IsAccepted { get; set; }
        public static bool Pattern { get; set; }
        public static string Colour { get; set; }

        public static string DropPoint { get; set; }

        public Donate()
        {
        }

        public static string GetEstimatedPrice()
        {
            // Inisialisasi variabel harga estimasi
            string estimatedPrice = "";

            // Cek apakah warna Mono atau Color
            bool isMono = (Colour == "Black" || Colour == "White" || Colour == "Brown");

            // Cek tipe pakaian
            if (ClothingType == "Skirt" || ClothingType == "Inner Top" || ClothingType == "Hijab" || ClothingType == "Other")
            {
                // Kondisi material untuk Skirt, Inner Top, Hijab, Other
                if (Material == "Silk" || Material == "Leather" || Material == "Wool")
                {
                    if (Pattern) // Pola: Ya
                    {
                        estimatedPrice = IsUsable ? (isMono ? "Rp27.000,00 - Rp49.000,00" : "Rp21.000,00 - Rp37.000,00") : (isMono ? "Rp12.000,00 - Rp27.000,00" : "Rp8.000,00 - Rp22.000,00");
                    }
                    else // Pola: Tidak
                    {
                        estimatedPrice = IsUsable ? (isMono ? "Rp27.000,00 - Rp49.000,00" : "Rp21.000,00 - Rp37.000,00") : (isMono ? "Rp12.000,00 - Rp27.000,00" : "Rp8.000,00 - Rp22.000,00");
                    }
                }
                else if (Material == "Satin" || Material == "Linen" || Material == "Denim")
                {
                    if (Pattern) // Pola: Ya
                    {
                        estimatedPrice = IsUsable ? (isMono ? "Rp22.000,00 - Rp42.000,00" : "Rp18.000,00 - Rp32.000,00") : (isMono ? "Rp8.000,00 - Rp22.000,00" : "Rp2.000,00 - Rp18.000,00");
                    }
                    else // Pola: Tidak
                    {
                        estimatedPrice = IsUsable ? (isMono ? "Rp22.000,00 - Rp42.000,00" : "Rp18.000,00 - Rp32.000,00") : (isMono ? "Rp8.000, 00 - Rp22.000,00" : "Rp2.000,00 - Rp18.000,00");
                    }
                }
                else if (Material == "Cotton" || Material == "Jersey" || Material == "Polyester")
                {
                    if (Pattern) // Pola: Ya
                    {
                        estimatedPrice = IsUsable ? (isMono ? "18k-38k" : "12k-28k") : (isMono ? "5k-18k" : "2k-15k");
                    }
                    else // Pola: Tidak
                    {
                        estimatedPrice = IsUsable ? (isMono ? "18k-38k" : "12k-28k") : (isMono ? "5k-18k" : "2k-15k");
                    }
                }
                else if (Material == "Nylon" || Material == "Other")
                {
                    if (Pattern) // Pola: Ya
                    {
                        estimatedPrice = IsUsable ? (isMono ? "12k-32k" : "10k-22k") : (isMono ? "2k-12k" : "2k-10k");
                    }
                    else // Pola: Tidak
                    {
                        estimatedPrice = IsUsable ? (isMono ? "12k-32k" : "10k-22k") : (isMono ? "2k-12k" : "2k-10k");
                    }
                }
            }
            else if (ClothingType == "Pants" || ClothingType == "Outer Top" || ClothingType == "Overall")
            {
                // Kondisi material untuk Pants, Outer Top, Overall
                if (Material == "Silk" || Material == "Leather" || Material == "Wool")
                {
                    if (Pattern) // Pola: Ya
                    {
                        estimatedPrice = IsUsable ? (isMono ? "30k-50k" : "25k-40k") : (isMono ? "15k-30k" : "10k-25k");
                    }
                    else // Pola: Tidak
                    {
                        estimatedPrice = IsUsable ? (isMono ? "30k-50k" : "25k-40k") : (isMono ? "15k-30k" : "10k-25k");
                    }
                }
                else if (Material == "Satin" || Material == "Linen" || Material == "Denim")
                {
                    if (Pattern) // Pola: Ya
                    {
                        estimatedPrice = IsUsable ? (isMono ? "25k-45k" : "20k-35k") : (isMono ? "10k-25k" : "5k-20k");
                    }
                    else // Pola: Tidak
                    {
                        estimatedPrice = IsUsable ? (isMono ? "25k-45k" : "20k-35k") : (isMono ? "10k-25k" : "5k-20k");
                    }
                }
                else if (Material == "Cotton" || Material == "Jersey" || Material == "Polyester")
                {
                    if (Pattern) // Pola: Ya
                    {
                        estimatedPrice = IsUsable ? (isMono ? "20k-40k" : "15k-30k") : (isMono ? "5k-20k" : "2k-15k");
                    }
                    else // Pola: Tidak
                    {
                        estimatedPrice = IsUsable ? (isMono ? "20k-40k" : "15k-30k") : (isMono ? "5k-20k" : "2k-15k");
                    }
                }
                else if (Material == "Nylon" || Material == "Other")
                {
                    if (Pattern) // Pola: Ya
                    {
                        estimatedPrice = IsUsable ? (isMono ? "15k-35k" : "10k-25k") : (isMono ? "2k-15k" : "2k-10k");
                    }
                    else // Pola: Tidak
                    {
                        estimatedPrice = IsUsable ? (isMono ? "15k-35k" : "10k-25k") : (isMono ? "2k-15k" : "2k-10k");
                    }
                }
            }

            return estimatedPrice;
        }

        public static bool SaveDonateToDatabase(string connstring)
        {
            int? userId = User.GetUserId(connstring, User.Username); // Memanggil GetUserId untuk mendapatkan userid

            if (userId == null)
            {
                MessageBox.Show("User ID not found for the given username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (var conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();

                    string sql = @"INSERT INTO donate 
                   (clothingtype, isusable, material, estimatedprice, isaccepted, pattern, colour, frontclothes, backclothes, droppointloc, userid, status, fixedprice)
                   VALUES (@clothingtype, @isusable, @material, @estimatedprice, @isaccepted, @pattern, @colour, @frontclothes, @backclothes, @droppointloc, @userid, @status, @fixedprice)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("clothingtype", ClothingType);
                        cmd.Parameters.AddWithValue("isusable", IsUsable);
                        cmd.Parameters.AddWithValue("material", Material);
                        cmd.Parameters.AddWithValue("estimatedprice", EstimatedPrice);
                        cmd.Parameters.AddWithValue("isaccepted", IsAccepted);
                        cmd.Parameters.AddWithValue("pattern", Pattern);
                        cmd.Parameters.AddWithValue("colour", Colour);
                        cmd.Parameters.AddWithValue("frontclothes", FrontClothes ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("backclothes", BackClothes ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("droppointloc", DropPoint);
                        cmd.Parameters.AddWithValue("userid", userId.Value); // Pastikan userId tidak null dengan userId.Value
                        cmd.Parameters.AddWithValue("status", "Waiting for the fixed price");
                        cmd.Parameters.AddWithValue("fixedprice", "Not decided");

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }



        public void ConfirmDonation(bool isAccepted)
        {
            IsAccepted = isAccepted;
        }


        public void InputLocation(string address, string rt, string rw, string kelurahan, string kecamatan, string postalCode, string detailAddress)
        {
            // Logic to input location for pickup
        }
    }
}
