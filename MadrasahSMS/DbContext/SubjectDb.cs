using System;
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

        public (DataTable details, double SubjectMark, bool Mandatory) GetById(string id)
        {
            var query = "SELECT * FROM S_SUBJECT WHERE ID=" + id;
            var sub = Db.GetDataTable(query);
            var subMark = Convert.ToDouble(sub.Rows[0]["MARK"].ToString());
            var mandatory = Convert.ToBoolean(sub.Rows[0]["MANDATORY"].ToString());
            return (sub, subMark, mandatory);
        }

    }
}
