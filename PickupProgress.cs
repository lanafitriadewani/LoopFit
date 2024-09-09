using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class PickupProgress
    {
        public int ProgressID { get; set; }
        public string CourierLocation { get; set; }
        public string EstimatedArrivalTime { get; set; }

        public List<PickupProgress> ViewProgress()
        {
            // Logic to view pickup progress
            return new List<PickupProgress>();
        }

        public void AddHistory(string courierLocation, string estimatedArrivalTime)
        {
            CourierLocation = courierLocation;
            EstimatedArrivalTime = estimatedArrivalTime;
        }
    }

}
