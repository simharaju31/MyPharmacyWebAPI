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
    public class PharmacySearchController : ControllerBase
    {

        private IPharmacySearchService _oPharmacySearchService;

        public PharmacySearchController(IPharmacySearchService oPharmacySearchService)
        {
            _oPharmacySearchService = oPharmacySearchService;
        }


        [HttpGet]
        public List<Pharmacy> Get(string characteristics,string type, string city,string state, int pincode)
        {
            //simharaju's task

            return _oPharmacySearchService.PharmacySearch(characteristics, type, city, state, pincode);

        }
    }
}
