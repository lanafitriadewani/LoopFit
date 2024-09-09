using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class Donate
    {
        public int DonateID { get; set; }
        public string ClothingType { get; set; }
        public bool IsUsable { get; set; }
        public string Material { get; set; }
        public string ClothingImage { get; set; }
        public double EstimatedPrice { get; set; }
        public bool IsAccepted { get; set; }

        public DropPoint DropPoint { get; set; }
        public PickupProgress PickupProgress { get; set; }
        public List<History> Histories { get; set; }

        public Donate()
        {
            Histories = new List<History>();
        }
        public void InputClothingData(string clothingType, bool isUsable, string material, string clothingImage)
        {
            ClothingType = clothingType;
            IsUsable = isUsable;
            Material = material;
            ClothingImage = clothingImage;
        }

        public double GetEstimatedPrice()
        {
            // Logic to calculate estimated price
            return EstimatedPrice;
        }

        public void ConfirmDonation(bool isAccepted)
        {
            IsAccepted = isAccepted;
        }

        public List<DropPoint> GetDropPoints()
        {
            // Logic to retrieve available drop points
            return new List<DropPoint>();
        }

        public void InputLocation(string address, string rt, string rw, string kelurahan, string kecamatan, string postalCode, string detailAddress)
        {
            // Logic to input location for pickup
        }
    }

}
