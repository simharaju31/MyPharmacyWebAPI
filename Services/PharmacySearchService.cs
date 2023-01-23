using Dapper;
using MyPharmacyWebAPI.Common;
using MyPharmacyWebAPI.IServices;
using MyPharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Services
{
    public class PharmacySearchService : IPharmacySearchService
    {
        List<Pharmacy> _oPharmacies = new List<Pharmacy>();
        public  List<Pharmacy> PharmacySearch(string characteristics, string type, string city, string state, string pincode)
        {
            _oPharmacies = new List<Pharmacy>();

            var procedureName = "get_pharmacies";
            var parameters = new DynamicParameters();
            parameters.Add("@characteristics", characteristics, DbType.String, ParameterDirection.Input);
            parameters.Add("@pharmatypeId", type, DbType.String, ParameterDirection.Input);
            parameters.Add("@city", city, DbType.String, ParameterDirection.Input);
            parameters.Add("@state", state, DbType.String, ParameterDirection.Input);
            parameters.Add("@pincode", pincode, DbType.String, ParameterDirection.Input);
            try
            {
                using (IDbConnection con = new SqlConnection(Global.ConnectionString))
                {
                    if (con.State == System.Data.ConnectionState.Closed) con.Open();
                    var oPharmacies = con.Query<Pharmacy>(procedureName, parameters, commandType: CommandType.StoredProcedure).ToList();


                    if (oPharmacies != null && oPharmacies.Count() > 0)
                    {
                        _oPharmacies = oPharmacies;
                    }

                    return _oPharmacies;
                }
            }
            catch (Exception e)
            {
                

            }
            return _oPharmacies;




            }
    }
}
