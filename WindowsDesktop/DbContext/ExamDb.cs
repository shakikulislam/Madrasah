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
        
        public DataTable GetWithoutResult()
        {
            var query = "SELECT DISTINCT E.ID, E.NAME " +
                        "FROM S_EXAM E " +
                        "RIGHT JOIN S_EXAM_SCHEDULE AS ES ON E.ID = ES.EXAM_ID " +
                        "WHERE ES.EXAM_STATUS IS NULL OR ES.EXAM_STATUS = '' " +
                        "ORDER BY E.NAME ASC";
            return Db.GetDataTable(query);
        }
    }
}
