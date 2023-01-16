using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Models
{
    public class SearchCriteria
    {
        public string Characteristics { get; set; }

        public string Type { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Pincode { get; set; }
    }
}
