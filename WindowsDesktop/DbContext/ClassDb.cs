using System;
using System.Data;

namespace WindowsDesktop.DbContext
{
    public class ClassDb
    {
        public DataTable ClassList()
        {
            try
            {
                var query = "SELECT c.id, CONCAT(d.name, ' (', c.name, ')') AS name " +
                            "FROM s_class c " +
                            "left join s_department d on c.department_id=d.id " +
                            "ORDER BY d.name, c.class_number ASC";

                return Db.GetDataTable(query);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
