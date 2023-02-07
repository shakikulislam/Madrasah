using System.Data;

namespace MadrasahSMS.DbContext
{
    public class SubjectDb
    {
        public DataTable GetByClassId(string classId)
        {
            var query = "SELECT * FROM S_SUBJECT WHERE CLASS_ID=" + classId + " ORDER BY NAME ASC";
            return Db.GetDataTable(query);
        }

        public string Mark(string id)
        {
            var query = "SELECT MARK FROM S_SUBJECT WHERE ID=" + id;
            return Db.GetSingleValue(query);
        }
    }
}
