using Dapper;
using MyPharmacyWebAPI.Common;
using MyPharmacyWebAPI.IServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Services
{

    public class RemoveSavedPharmaciesService : IRemoveSavedPharmaciesService
    {
        public void RemovePharmacies(int memberid, string pharmaId)
        {
            var procedureName = "delete_savedpharmacies";
            var parameters = new DynamicParameters();

            parameters.Add("@memberId",memberid, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@pharmaId", pharmaId, DbType.String, ParameterDirection.Input);

            try
            {
                using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Global.ConnectionString))
                {
                    if (con.State == System.Data.ConnectionState.Closed) con.Open();
                    var oSavedPharmacy = con.Query(procedureName, parameters, commandType: CommandType.StoredProcedure).ToList();

                }
            }
            catch (Exception e)
            {
                
            }
           
    }
    }
}
