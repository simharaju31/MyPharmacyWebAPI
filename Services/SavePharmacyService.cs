using Dapper;
using MyPharmacyWebAPI.Common;
using MyPharmacyWebAPI.IServices;
using MyPharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Services
{
    public class SavePharmacyService : ISavePharmacyService
    {

        List<SavePharmacy> _oSavedPharmacy = new List<SavePharmacy>();

        public List<SavePharmacy> Save(SavePharmacy savePharmacy)
        {

            _oSavedPharmacy = new List<SavePharmacy>();

            var procedureName = "savePharma";
            var parameters = new DynamicParameters();

            parameters.Add("@memberId", savePharmacy.Members_memberId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@pharmaId", savePharmacy.Pharmacy_pharmaId, DbType.String, ParameterDirection.Input);

            using (System.Data.IDbConnection con = new System.Data.SqlClient.SqlConnection(Global.ConnectionString))
            {
                if (con.State == System.Data.ConnectionState.Closed) con.Open();
                var oSavedPharmacy = con.Query<SavePharmacy>(procedureName, parameters, commandType: CommandType.StoredProcedure).ToList();
                
                if (oSavedPharmacy != null && oSavedPharmacy.Count() > 0)
                {
                    _oSavedPharmacy = oSavedPharmacy;
                }
                return _oSavedPharmacy;

            }
        }
    }
}