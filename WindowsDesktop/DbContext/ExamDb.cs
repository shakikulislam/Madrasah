using System;
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

        public DataTable GetExamSchedule()
        {
            var query = "SELECT ES.ID, ES.EXAM_DATE, ES.EXAM_TIME, E.NAME AS EXAM_NAME, " +
                        "C.NAME AS CLASS_NAME, S.NAME AS SUBJECT_NAME " +
                        "FROM S_EXAM_SCHEDULE AS ES " +
                        "LEFT JOIN S_EXAM AS E ON ES.EXAM_ID = E.ID " +
                        "LEFT JOIN S_CLASS AS C ON ES.CLASS_ID = C.ID " +
                        "LEFT JOIN S_SUBJECT AS S ON ES.SUBJECT_ID = S.ID " +
                        "WHERE ES.EXAM_STATUS IS NULL OR ES.EXAM_STATUS = ''";
            return Db.GetDataTable(query);
        }

        public string GetExamDate(string examId, string classId, string subjectId)
        {
            var query = "SELECT EXAM_DATE FROM S_EXAM_SCHEDULE WHERE EXAM_ID='" + examId +
                        "' AND CLASS_ID='" + classId + "' AND SUBJECT_ID='" + subjectId + "'";
            var dr = Db.GetDataReader(query);
            if (dr.HasRows)
            {
                dr.Read();
                return dr["EXAM_DATE"].ToString();
            }

            return string.Empty;
        }
 
    }
}
