using System.Data;

namespace WindowsDesktop.DbContext
{
    public class ExamDb
    {
        public DataTable Get()
        {
            var query = "SELECT * FROM S_EXAM ORDER BY NAME ASC";
            return Db.GetDataTable(query);
        }
    }
}
