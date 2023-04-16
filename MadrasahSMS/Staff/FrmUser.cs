using System.Data;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Staff
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
            ThemeTemplate.LoadTheme(this);
            ThemeTemplate.SDataGridView(this, BorderStyle.FixedSingle);

            LoadEmp();
            LoadUser();
        }

        private void LoadEmp()
        {
            var query = "SELECT * FROM VW_S_FULL_EMPLOYEE_INFO ORDER BY EMP_ID";
            var dt = Db.GetTable(query);
            var dg = dataGridViewEmpList;
            dg.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                var s = dg.Rows.Add();
                dg.Rows[s].Cells[ColumnId.Index].Value = row["ID"].ToString();
                dg.Rows[s].Cells[ColumnEmpId.Index].Value = row["EMP_ID"].ToString();
                dg.Rows[s].Cells[ColumnName.Index].Value = row["NAME"].ToString();
                dg.Rows[s].Cells[ColumnDesig.Index].Value = row["DESIGNATION_NAME"].ToString();
            }
        }

        private void LoadUser()
        {
            var query = "SELECT * FROM VW_S_FULL_EMPLOYEE_INFO WHERE STATUS='" + GlobalSettings.Status.A + "' ORDER BY EMP_ID";
            var dt = Db.GetTable(query);
            var dg = dataGridViewUserList;
            dg.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                var s = dg.Rows.Add();
                dg.Rows[s].Cells[ColumnUlId.Index].Value = row["ID"].ToString();
                dg.Rows[s].Cells[ColumnUlEmpId.Index].Value = row["EMP_ID"].ToString();
                dg.Rows[s].Cells[ColumnUlDesig.Index].Value = row["DESIGNATION_NAME"].ToString();
                dg.Rows[s].Cells[ColumnUlUserName.Index].Value = row["USER_NAME"].ToString();
                dg.Rows[s].Cells[ColumnUlName.Index].Value = row["NAME"].ToString();
                dg.Rows[s].Cells[ColumnUlPass.Index].Value = row["PASSWORD"].ToString();
            }
        }


        private void dataGridViewEmpList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewEmpList.Rows[e.RowIndex].Cells[ColumnSl.Index].Value = (e.RowIndex + 1);
        }

        private void dataGridViewUserList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewUserList.Rows[e.RowIndex].Cells[ColumnUlSl.Index].Value = (e.RowIndex + 1);
        }
    }
}
