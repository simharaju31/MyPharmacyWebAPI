using MyPharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.IServices
{
    public interface ISavePharmacyService
    {
        List<SavePharmacy> Save(SavePharmacy savePharmacy);

    }
}
