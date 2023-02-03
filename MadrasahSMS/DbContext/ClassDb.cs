using System.Data;

namespace MadrasahSMS.DbContext
{
    public class ClassDb
    {
        public DataTable Get()
        {
            var query = "SELECT * FROM S_CLASS ORDER BY CLASS_NUMBER ASC";
            return Db.GetDataTable(query);
        }
    }
}
