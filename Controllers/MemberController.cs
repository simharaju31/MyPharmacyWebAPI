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
    public class MemberController : ControllerBase
    {

        private IMemberService _oMemberService;

        public MemberController(IMemberService oMemberService)
        {
            _oMemberService = oMemberService;
        }

        [HttpGet]
        public Member Get(int memberId)
        {
            //harika task

            //write the code to get member detailes from database, you will getting member id as query paramater, and return the member detaiels 
            //refer to model class that i created in model folder.
            //execute the storage procedure using the dapper library


            return _oMemberService.Get(memberId);            
        }
    }
}
