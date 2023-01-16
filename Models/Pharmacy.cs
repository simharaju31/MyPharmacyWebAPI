using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Models
{
    public class Pharmacy
    {
        public int PharmaId { get; set; }

        public string PharmaName { get; set; }

        public string AdressLine1 { get; set; }

        public string AdressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Pincode { get; set; }

        public string PharmaCharacteristics { get; set; }

        public int PhoneNumber { get; set; }

    }
}
