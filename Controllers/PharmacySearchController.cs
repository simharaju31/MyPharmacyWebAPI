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
    public class PharmacySearchController : ControllerBase
    {
        public string Get()
        {
            //simharaju's task


            return "the list of pharmacies";

        }
    }
}
