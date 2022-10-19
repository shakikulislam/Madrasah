using System;
using System.Data;

namespace WindowsDesktop.DbContext
{
    public class UpazilaDb
    {
        public DataTable UpazilaListByDistrictId(string districtId)
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                            "FROM s_upazila where district_id=" + districtId + " ORDER BY name ASC";
                return Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
