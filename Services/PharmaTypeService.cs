using Dapper;
using MyPharmacyWebAPI.Common;
using MyPharmacyWebAPI.IServices;
using MyPharmacyWebAPI.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyPharmacyWebAPI.Services
{
    public class PharmaTypeService : IPharmaTypeService
    {

        List<PharmaType> _oPharmaTypes = new List<PharmaType>();
        public List<PharmaType> Gets()
        {

            _oPharmaTypes = new List<PharmaType>();

            var procedureName = "get_pharmaType";
            
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == System.Data.ConnectionState.Closed) con.Open();
                var oPharmaTypes = con.Query<PharmaType>(procedureName,commandType: CommandType.StoredProcedure).ToList();

                if (oPharmaTypes != null && oPharmaTypes.Count() > 0)
                {
                    _oPharmaTypes = oPharmaTypes;
                }
                return _oPharmaTypes;
            }
        }
    }
}
