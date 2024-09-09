using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string RT { get; set; }
        public string RW { get; set; }
        public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string PostalCode { get; set; }
        public string AdditionalDetails { get; set; }

        public void AddAddress(string streetAddress, string rt, string rw, string kelurahan, string kecamatan, string postalCode, string additionalDetails)
        {
            StreetAddress = streetAddress;
            RT = rt;
            RW = rw;
            Kelurahan = kelurahan;
            Kecamatan = kecamatan;
            PostalCode = postalCode;
            AdditionalDetails = additionalDetails;
        }
    }
}

