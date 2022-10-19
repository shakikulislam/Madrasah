using System;
using System.Data;

namespace WindowsDesktop.DbContext
{
    public class VillageDb
    {
        public DataTable VillageListByUnionId(string unionId)
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                            "FROM s_village where union_id=" + unionId + " ORDER BY name ASC";
                return Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
