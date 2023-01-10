using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavePharmacyController : ControllerBase
    {
       

        [HttpPost]
        public string Post(int memberId,string pharmacyId)
        {
            //shilpi's task

            //you will be getting memberId and Pharmacyid as a parameter,
            ////( you will be getting a list of pharmaid's as the user selects more than one pharmacies,
            ///so you will recieve them in string as csv(comma separated values its not excel file)
            //csv in the sense "4,2,6,7"
            //write the code to execute the storage procedure
            //execute the storage procedure using the dapper library
            //and return nothing


            return "shilpi" +" " + memberId + " " + pharmacyId;
        }
    }
}
