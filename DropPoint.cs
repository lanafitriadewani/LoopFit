using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class DropPoint
    {
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public List<DropPoint> GetAvailableDropPoints()
        {
            // Logic to get drop points
            return new List<DropPoint>();
        }

        public void ChooseDropPoint(string locationName)
        {
            LocationName = locationName;
        }
    }

}
