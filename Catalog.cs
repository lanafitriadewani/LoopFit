using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class Catalog
    {
        public int CatalogID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public double Price { get; set; }
        public bool Availability { get; set; }

        public List<Catalog> ViewCatalog()
        {
            // Logic to view catalog
            return new List<Catalog>();
        }

        public void BuyProduct(int catalogID)
        {
            // Logic to buy product
        }

        public void AddCatalog(string productName, string productImage, double price, bool availability)
        {
            ProductName = productName;
            ProductImage = productImage;
            Price = price;
            Availability = availability;
        }
    }

}
