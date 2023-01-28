using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPharmacyWebAPI.IServices;
using MyPharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemoveSavedPharmacies : ControllerBase
    {
        private IRemoveSavedPharmaciesService _oRemoveSavedPharmaciesService;

        private ISavedPharmaciesService _oSavedPharmaciesService;
        public RemoveSavedPharmacies(IRemoveSavedPharmaciesService oRemoveSavedPharmaciesService, ISavedPharmaciesService oSavedPharmaciesService )
        {
            _oRemoveSavedPharmaciesService = oRemoveSavedPharmaciesService;
            _oSavedPharmaciesService = oSavedPharmaciesService;
        }

        [HttpDelete]
        public List<Pharmacy> Remove(int memberId,string pharmaId)
        {
             _oRemoveSavedPharmaciesService.RemovePharmacies(memberId, pharmaId);

            return _oSavedPharmaciesService.GetSavedPharmacies(memberId);

        }
    }
}
