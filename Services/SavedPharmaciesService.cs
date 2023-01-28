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
    public class SavedPharmaciesService : ISavedPharmaciesService
    {
        List<Pharmacy> _oPharmacies = new List<Pharmacy>();

        public List<Pharmacy> GetSavedPharmacies(int memberId)
        {

            _oPharmacies = new List<Pharmacy>();
            var procedureName = "get_savedpharmacies";
            var parameters = new DynamicParameters();
            parameters.Add("@memberId", memberId, DbType.Int32, ParameterDirection.Input);

            try
            {
                using (IDbConnection con = new SqlConnection(Global.ConnectionString))
                {
                    if (con.State == ConnectionState.Closed) con.Open();
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
