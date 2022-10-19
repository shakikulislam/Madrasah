using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsDesktop.DbContext
{
    public class DistrictDb
    {
        public DataTable DistrictListByDivisionId(string divisionId)
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                            "FROM s_district where division_id=" + divisionId + " ORDER BY name ASC";
                return Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
