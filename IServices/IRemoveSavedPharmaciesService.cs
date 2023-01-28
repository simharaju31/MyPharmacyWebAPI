using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.IServices
{
    public interface IRemoveSavedPharmaciesService
    {
        void RemovePharmacies(int memberid, string pharmaId);
    }
}
