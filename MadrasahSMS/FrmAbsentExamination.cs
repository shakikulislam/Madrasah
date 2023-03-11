using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Properties;
using MadrasahSMS.Theme;

namespace MadrasahSMS
{
    public partial class FrmAbsentExamination : Form
    {
        public FrmAbsentExamination(string school_year, object examId, object classId)
        {
            InitializeComponent();
            ThemeTemplate.LoadTheme(panelBody);

            AbsentStudentList(school_year, examId, classId);
        }

        private void AbsentStudentList(string school_year, object examId, object classId)
        {
            var markForEntry = "SELECT M.ID, M.STUDENT_ID, M.STATUS, S.ROLL, S.REG, " +
                               "S.NAME AS STUDENT_NAME, SB.NAME AS SUBJECT_NAME " +
                               "FROM S_MARK M " +
                               "LEFT JOIN S_STUDENT S ON M.STUDENT_ID = S.ID " +
                               "LEFT JOIN S_SUBJECT SB ON M.SUBJECT_ID = SB.ID " +
                               "WHERE SCHOOL_YEAR=" + school_year +
                               " AND M.EXAM_ID=" + examId + "" +
                               " AND M.CLASS_ID=" + classId +
                               " AND IS_ABSENT=1 " +
                               " ORDER BY S.ROLL, M.SUBJECT_ID";
            var dtMark = Db.GetTable(markForEntry);
            
            foreach (DataRow row in dtMark.Rows)
            {
                var dr = dataGridViewExaminationAbsentList.Rows.Add();
                dataGridViewExaminationAbsentList.Rows[dr].Cells[ColumnId.Index].Value = row["ID"].ToString();
                dataGridViewExaminationAbsentList.Rows[dr].Cells[ColumnRoll.Index].Value = row["ROLL"].ToString();
                dataGridViewExaminationAbsentList.Rows[dr].Cells[ColumnStudentName.Index].Value = row["STUDENT_NAME"].ToString();
                dataGridViewExaminationAbsentList.Rows[dr].Cells[ColumnSubject.Index].Value = row["SUBJECT_NAME"].ToString();
                dataGridViewExaminationAbsentList.Refresh();
            }

        }

        // Drag Control
        #region Drag Control

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewExaminationAbsentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = dataGridViewExaminationAbsentList;
            if (dg.Columns[e.ColumnIndex].Name == "makeAttend")
            {
                if (MessageBox.Show(ContentText.MakeAttendMessage, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var query = "UPDATE S_MARK SET IS_ABSENT=0 " +
                                "WHERE ID=" + dg.SelectedRows[0].Cells[ColumnId.Index].Value;
                    var isUpdate = Db.QueryExecute(query);
                    if (isUpdate)
                    {
                        dg.Rows.RemoveAt(dg.SelectedRows[0].Index);
                        dg.Refresh();
                    }
                }
                
            }
        }
    }
}
