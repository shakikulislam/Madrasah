using System;
using System.Data;

namespace WindowsDesktop.DbContext
{
    public class DivisionDb
    {
        public DataTable DivisionList()
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name FROM s_division ORDER BY name ASC";
                return Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
