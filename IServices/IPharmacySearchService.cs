using MyPharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.IServices
{
    public interface IPharmacySearchService
    {
        List<Pharmacy> PharmacySearch(string characteristics, string type, string city, string state, string pincode);
    }
}
