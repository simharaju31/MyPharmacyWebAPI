using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Models
{
    public class Member
    {
        //create a member class same as database table
        public int MemberId { get; set; }

        public string Name { get; set; }

        public string State { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }

    }
}
