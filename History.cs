using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class History
    {
        public int HistoryID { get; set; }
        public string DonationDate { get; set; }
        public string DonationDetails { get; set; }

        public List<History> ViewHistory()
        {
            // Logic to view history
            return new List<History>();
        }

        public void AddHistory(string donationDate, string donationDetails)
        {
            DonationDate = donationDate;
            DonationDetails = donationDetails;
        }
    }

}
