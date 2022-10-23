using System.Data;

namespace WindowsDesktop.DbContext
{
    public class ClassDb
    {
        public DataTable GetWithDepartment()
        {
            var query = "SELECT C.ID, CONCAT( D.NAME,' (', C.NAME, ')') AS NAME " +
                        "FROM S_CLASS AS C " +
                        "LEFT JOIN S_Department AS D ON C.DEPARTMENT_ID=D.Id " +
                        "ORDER BY D.Name ASC";
            return Db.GetDataTable(query);
        }
    }
}
