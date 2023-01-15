using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.IServices
{
    public interface ISavePharmacyService
    {
        void SavePharmacy(int memberId, string pharmacyId);

    }
}
