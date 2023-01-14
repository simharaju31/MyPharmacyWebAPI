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
    public class PharmacyTypeController : ControllerBase
    {

        private IPharmaTypeService _oPharmaTypeService;

        public PharmacyTypeController(IPharmaTypeService oPharmaTypeService)
        {
            _oPharmaTypeService = oPharmaTypeService;
        }

        [HttpGet]
        public List<PharmaType> get()
        {
            //sub task in harika's major task
            //write the code to get the pharma types availale in pharmatype table in database
            //execute the storage procedure using the dapper library

            return _oPharmaTypeService.Gets();
        }
    }
}
