using System;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Properties;
using MadrasahSMS.Theme;

namespace MadrasahSMS
{
    public partial class FrmResultProcess : Form
    {
        public FrmResultProcess()
        {
            InitializeComponent();

            ThemeTemplate.LoadTheme(panelSearch);
            ThemeTemplate.SDataGridView(this, BorderStyle.FixedSingle);
            dataGridViewStudentList.ColumnHeadersDefaultCellStyle.Font =
                new Font(STheme.SFont.Font, STheme.SFont.Size, FontStyle.Bold);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                comboBoxClass.DisplayMember = "NAME";
                comboBoxClass.ValueMember = "ID";
                comboBoxClass.DataSource = new ClassDb().Get();

                comboBoxExam.DisplayMember = "NAME";
                comboBoxExam.ValueMember = "ID";
                comboBoxExam.DataSource = new ExamDb().GetWithoutResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var classTeacher =
                    Db.GetSingleValue(
                        "SELECT E.NAME FROM S_CLASS C LEFT JOIN S_EMPLOYEE E ON C.TEACHER_ID=E.ID WHERE C.ID=" +
                        comboBoxClass.SelectedValue);
                labelClassTeacher.Text = classTeacher;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProcess_Click(object sender, System.EventArgs e)
        {
            try
            {
                var class_id = comboBoxClass.SelectedValue.ToString();
                var exam_id = comboBoxExam.SelectedValue.ToString();
                
                dataGridViewStudentList.Rows.Clear();

                var query = string.Empty;
                DataTable dt = null;

                var loading = new frmWaiting();
                loading.Show();
                Application.DoEvents();

                #region Exam schedule check

                query = "SELECT S.NAME, S.MARK, E.NAME AS TEACHER_NAME " +
                            "FROM S_SUBJECT AS S " +
                            "LEFT JOIN S_EMPLOYEE AS E ON S.TEACHER_ID = E.ID " +
                            "WHERE S.ID NOT IN(SELECT SUBJECT_ID FROM S_EXAM_SCHEDULE " +
                            "WHERE SCHOOL_YEAR = " + GlobalSettings.SchoolYear + " AND CLASS_ID = " +
                            class_id + " AND EXAM_ID = " + exam_id + ") " +
                            "AND S.CLASS_ID = " + class_id + " AND S.STATUS = '" + GlobalSettings.Active + "'";
                dt = Db.GetTable(query);
                if (dt.Rows.Count > 0)
                {
                    loading.Close();
                    string[] columnHeaderText = { "Subject Name", "Mark", "Teacher Name" };
                    FrmViewList.Show(ContentText.ExamScheduleNotFound, dt, columnHeaderText, 0);
                    return;
                }

                #endregion
                
                #region Absent Check

                query = "SELECT S.ROLL, S.NAME AS STUDENT_NAME, SB.NAME AS SUBJECT_NAME " +
                        "FROM S_MARK M " +
                        "LEFT JOIN S_STUDENT S ON M.STUDENT_ID = S.ID " +
                        "LEFT JOIN S_SUBJECT SB ON M.SUBJECT_ID = SB.ID " +
                        "WHERE SCHOOL_YEAR=" + GlobalSettings.SchoolYear +
                        " AND M.EXAM_ID=" + exam_id + "" +
                        " AND M.CLASS_ID=" + class_id +
                        " AND IS_ABSENT=1 " +
                        " ORDER BY S.ROLL, M.SUBJECT_ID";
                dt = Db.GetTable(query);
                if (dt.Rows.Count > 0)
                {
                    loading.Close();
                    string[] columnHeaderText = { "Roll", "Student Name", "Subject" };
                    var isProcess = FrmViewList.Show(ContentText.AbsentList, dt, columnHeaderText, 1, true);
                    if (isProcess)
                    {
                        loading = new frmWaiting();
                        loading.Show();
                        goto MarkEntryCheck;
                    }

                    return;

                }

                #endregion
                
                #region Mark entry check

                MarkEntryCheck:
                query = "SELECT ST.ROLL, ST.NAME AS STUDENT_NAME, S.NAME AS SUBJECT_NAME " +
                        "FROM S_MARK AS M " +
                        "LEFT JOIN S_SUBJECT AS S ON M.SUBJECT_ID = S.ID " +
                        "LEFT JOIN S_STUDENT AS ST ON M.STUDENT_ID = ST.ID " +
                        "WHERE M.SCHOOL_YEAR = " + GlobalSettings.SchoolYear +
                        " AND M.EXAM_ID = " + exam_id + " AND M.CLASS_ID = " + class_id +
                        " AND (M.STATUS IS NULL OR M.STATUS NOT IN('" + GlobalSettings.MarkEntry + "')) " +
                        "AND IS_ABSENT=0 " +
                        "ORDER BY ST.ROLL, S.NAME";
                dt = Db.GetTable(query);
                if (dt.Rows.Count > 0)
                {
                    loading.Close();
                    string[] columnHeader = { "Roll", "Student Name", "Subject" };
                    FrmViewList.Show(ContentText.MarksMissing, dt, columnHeader, 1);
                    return;
                }

                #endregion

                #region Process result

                query = "SELECT M.SCHOOL_YEAR, M.CLASS_ID, M.EXAM_ID, M.STUDENT_ID, S.ROLL, S.REG, S.FORM_NUMBER" +
                        ", SUM(ISNULL(M.SUBJECT_MARKS, 0))  AS TOTAL_MARKS" +
                        ", SUM(ISNULL(M.OBTAINED_MARKS, 0)) AS TOTAL_OBTAINED_MARKS " +
                        "FROM S_MARK AS M " +
                        "LEFT JOIN S_STUDENT AS S ON M.STUDENT_ID = S.ID " +
                        "WHERE M.SCHOOL_YEAR = " + GlobalSettings.SchoolYear +
                        " AND M.CLASS_ID = " + class_id +
                        " AND M.EXAM_ID = " + exam_id +
                        " GROUP BY M.SCHOOL_YEAR, M.CLASS_ID, M.EXAM_ID, M.STUDENT_ID, S.ROLL, S.REG, S.FORM_NUMBER " +
                        "ORDER BY M.CLASS_ID, M.EXAM_ID, M.STUDENT_ID";

                dt = Db.GetTable(query);
                if (dt.Rows.Count > 0)
                {
                    // Delete existing result
                    query = "DELETE S_RESULT_MST WHERE SCHOOL_YEAR=" + GlobalSettings.SchoolYear +
                            " AND CLASS_ID=" + class_id + " AND EXAM_ID=" + exam_id;
                    Db.QueryExecute(query);

                    // Insert new result fields
                    query = string.Empty;
                    foreach (DataRow row in dt.Rows)
                    {
                        query += "INSERT INTO S_RESULT_MST (" +
                                "ID, " +
                                "SCHOOL_YEAR, " +
                                "CLASS_ID, " +
                                "EXAM_ID, " +
                                "STUDENT_ID, " +
                                "ROLL, " +
                                "REG, " +
                                "FORM_NUMBER, " +
                                "TOTAL_MARKS, " +
                                "TOTAL_OBTAINED_MARKS" +
                                ") VALUES (" +
                                "(SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_RESULT_MST), " +
                                row["SCHOOL_YEAR"] + ", " +
                                row["CLASS_ID"] + ", " +
                                row["EXAM_ID"] + ", " +
                                row["STUDENT_ID"] + ", " +
                                row["ROLL"] + ", " +
                                row["REG"] + ", " +
                                row["FORM_NUMBER"] + ", " +
                                row["TOTAL_MARKS"] + ", " +
                                row["TOTAL_OBTAINED_MARKS"] +
                                ") ";
                    }

                    var saveResult = Db.QueryExecute(query);
                    if (saveResult)
                    {
                        query = "SELECT M.*, S.NAME AS STUDENT_NAME " +
                                "FROM S_RESULT_MST AS M " +
                                "LEFT JOIN S_STUDENT AS S ON M.STUDENT_ID=S.ID " +
                                "WHERE M.SCHOOL_YEAR = " + GlobalSettings.SchoolYear +
                                " AND M.CLASS_ID = " + class_id +
                                " AND M.EXAM_ID = " + exam_id +
                                " ORDER BY M.ROLL";
                        dt = Db.GetTable(query);
                        if (dt.Rows.Count > 0)
                        {
                            var dg = dataGridViewStudentList;
                            foreach (DataRow row in dt.Rows)
                            {
                                var s = dg.Rows.Add();
                                dg.Rows[s].Cells[ColumnId.Index].Value = row["ID"].ToString();
                                dg.Rows[s].Cells[ColumnRoll.Index].Value = row["ROLL"].ToString();
                                dg.Rows[s].Cells[ColumnName.Index].Value = row["STUDENT_NAME"].ToString();
                                dg.Rows[s].Cells[ColumnSubjectMarks.Index].Value = row["TOTAL_MARKS"].ToString();
                                dg.Rows[s].Cells[ColumnObtainedMark.Index].Value = row["TOTAL_OBTAINED_MARKS"].ToString();
                                dg.Rows[s].Cells[ColumnObtainedPct.Index].Value = row["TOTAL_OBTAINED_PCT"].ToString();
                                dg.Rows[s].Cells[ColumnGradePoint.Index].Value = row["GRADE_POINT"].ToString();
                                dg.Rows[s].Cells[ColumnLetterGrade.Index].Value = row["LETTER_GRADE"].ToString();
                            }

                            loading.Close();
                            return;

                        }
                    }
                    else
                    {
                        loading.Close();
                        return;
                    }
                }
                else
                {
                    loading.Close();
                    MessageBox.Show(ContentText.StudentNotFound);
                    return;
                }

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
