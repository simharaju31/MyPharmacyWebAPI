using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public string get()
        {
            //sub task in harika's major task
            //write the code to get the pharma types availale in pharmatype table in database
            //execute the storage procedure using the dapper library

            return " return type like retail,ltc... something which will be there in database";
        }
    }
}
