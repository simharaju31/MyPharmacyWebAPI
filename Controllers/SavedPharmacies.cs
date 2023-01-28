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
    public class SavedPharmacies : ControllerBase
    {
        private ISavedPharmaciesService _oSavedPharmaciesService;
        public SavedPharmacies(ISavedPharmaciesService oSavedPharmaciesService)
        {
            _oSavedPharmaciesService = oSavedPharmaciesService;

        }

        [HttpGet]
        public List<Pharmacy> Get(int memberId)
        {
            return _oSavedPharmaciesService.GetSavedPharmacies(memberId);
        }

    }
}
