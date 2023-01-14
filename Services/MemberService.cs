using Dapper;
using MyPharmacyWebAPI.Common;
using MyPharmacyWebAPI.IServices;
using MyPharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Services
{
    public class MemberService : IMemberService
    {
        Member _oMember = new Member();

        public Member Get(int memberId)
        {
            _oMember = new Member();

            using (System.Data.IDbConnection con = new System.Data.SqlClient.SqlConnection(Global.ConnectionString))
            {
                if (con.State == System.Data.ConnectionState.Closed) con.Open();
                var oMembers = con.Query<Member>("select * from members where memberId = " + memberId).ToList();

                if(oMembers!=null && oMembers.Count() > 0)
                {
                    _oMember = oMembers.SingleOrDefault();
                }
                return _oMember;
            }

            
           
        }
    }
}
