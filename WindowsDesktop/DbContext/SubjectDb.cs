using System.Data;

namespace WindowsDesktop.DbContext
{
    public class SubjectDb
    {
        public DataTable GetByClassId(string classId)
        {
            var query = "SELECT * FROM S_SUBJECT WHERE CLASS_ID=" + classId + " ORDER BY NAME ASC";
            return Db.GetDataTable(query);
        }
    }
}
