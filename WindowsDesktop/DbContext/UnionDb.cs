using System;
using System.Data;

namespace WindowsDesktop.DbContext
{
    public class UnionDb
    {
        public DataTable UnionListByUpazilaId(string upazilaId)
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                            "FROM s_union where upazila_id=" + upazilaId + " ORDER BY name ASC";
                return Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
