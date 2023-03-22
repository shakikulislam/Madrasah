using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Theme;

namespace MadrasahSMS
{
    public partial class FrmResultProcess : Form
    {
        private bool _isMandatory;
        private bool _isFinal;

        public FrmResultProcess()
        {
            InitializeComponent();

            ThemeTemplate.LoadTheme(panelSearch);
            ThemeTemplate.SDataGridView(this, BorderStyle.FixedSingle, true);
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
                // Count Mandatory Subject
                var mandatoryCount = Db.GetSingleValue("SELECT COUNT(*) AS TOTAL_SUB FROM S_SUBJECT WHERE CLASS_ID=" +
                                                       comboBoxClass.SelectedValue + " AND STATUS='A' AND MANDATORY=1");
                if (Convert.ToInt32(mandatoryCount) > 0)
                {
                    _isMandatory = true;
                    linkLabelMandatory.Text = mandatoryCount + @" Mandatory Subject";
                    linkLabelMandatory.Visible = _isMandatory;
                }
                else
                {
                    linkLabelMandatory.Visible = false;
                }

                // Load teacher name
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

        private void comboBoxExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT * FROM S_EXAM WHERE ID=" + comboBoxExam.SelectedValue + " AND IS_FINAL=1";
                _isFinal = Db.HasExisted(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            var loading = new frmWaiting();
            try
            {
                var classId = comboBoxClass.SelectedValue.ToString();
                var examId = comboBoxExam.SelectedValue.ToString();

                var dg = dataGridViewStudentList;
                dg.Columns[ColumnPreExamMarks.Index].Visible = false;
                dg.Rows.Clear();

                string query;
                DataTable dt;

                loading.Show();
                Application.DoEvents();

                #region Exam schedule check

                query = "SELECT S.NAME, S.MARK, E.NAME AS TEACHER_NAME " +
                            "FROM S_SUBJECT AS S " +
                            "LEFT JOIN S_EMPLOYEE AS E ON S.TEACHER_ID = E.ID " +
                            "WHERE S.ID NOT IN(SELECT SUBJECT_ID FROM S_EXAM_SCHEDULE " +
                            "WHERE SCHOOL_YEAR = " + GlobalSettings.OfficeInfo.SchoolYear + " AND CLASS_ID = " +
                            classId + " AND EXAM_ID = " + examId + ") " +
                            "AND S.CLASS_ID = " + classId + " AND S.STATUS = '" + GlobalSettings.Active + "'";
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
                        "WHERE SCHOOL_YEAR=" + GlobalSettings.OfficeInfo.SchoolYear +
                        " AND M.EXAM_ID=" + examId + "" +
                        " AND M.CLASS_ID=" + classId +
                        " AND IS_ABSENT=1 " +
                        " ORDER BY S.ROLL, M.SUBJECT_ID";
                dt = Db.GetTable(query);
                if (dt.Rows.Count > 0)
                {
                    loading.Close();
                    string[] columnHeaderText = { "Roll", "Student Name", "Subject" };
                    var isProcess = FrmViewList.Show(ContentText.AbsentList, dt, columnHeaderText, 1, true,"Process Result");
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
                        "WHERE M.SCHOOL_YEAR = " + GlobalSettings.OfficeInfo.SchoolYear +
                        " AND M.EXAM_ID = " + examId + " AND M.CLASS_ID = " + classId +
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

                #region Result Check

                query = "SELECT * FROM S_RESULT_MST WHERE SCHOOL_YEAR=" + GlobalSettings.OfficeInfo.SchoolYear +
                        " AND CLASS_ID=" + classId + " AND EXAM_ID=" + examId;

                dt = Db.GetTable(query);
                if (dt.Rows.Count>0)
                {
                    if (MessageBox.Show(ContentText.ResultAlreadyProcessed+Environment.NewLine+ContentText.ReprocessResult,"",MessageBoxButtons.YesNo)!=DialogResult.Yes)
                    {
                        loading.Close();
                        return;
                    }
                }

                #endregion

                #region Process result

                query = "SELECT M.SCHOOL_YEAR, M.CLASS_ID, M.EXAM_ID, M.STUDENT_ID, S.ROLL, S.REG, S.FORM_NUMBER" +
                        ", SUM(ISNULL(M.SUBJECT_MARKS, 0))  AS TOTAL_MARKS" +
                        ", SUM(ISNULL(M.OBTAINED_MARKS, 0)) AS TOTAL_OBTAINED_MARKS " +
                        "FROM S_MARK AS M " +
                        "LEFT JOIN S_STUDENT AS S ON M.STUDENT_ID = S.ID " +
                        "WHERE M.SCHOOL_YEAR = " + GlobalSettings.OfficeInfo.SchoolYear +
                        " AND M.CLASS_ID = " + classId +
                        " AND M.EXAM_ID = " + examId +
                        " GROUP BY M.SCHOOL_YEAR, M.CLASS_ID, M.EXAM_ID, M.STUDENT_ID, S.ROLL, S.REG, S.FORM_NUMBER " +
                        "ORDER BY M.CLASS_ID, M.EXAM_ID, M.STUDENT_ID";

                dt = Db.GetTable(query);
                if (dt.Rows.Count > 0)
                {
                    // Delete existing result
                    query = "DELETE S_RESULT_MST WHERE SCHOOL_YEAR=" + GlobalSettings.OfficeInfo.SchoolYear +
                            " AND CLASS_ID=" + classId + " AND EXAM_ID=" + examId;
                    Db.QueryExecute(query);

                    // Insert new result
                    query = string.Empty;
                    foreach (DataRow row in dt.Rows)
                    {
                        query += "INSERT INTO S_RESULT_MST (ID, SCHOOL_YEAR, CLASS_ID, EXAM_ID, STUDENT_ID, " +
                                 "ROLL, REG, FORM_NUMBER, TOTAL_SUB_MARKS, OBTAINED_MARKS, CREATE_BY" +
                                 ") VALUES (" +
                                 "(SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_RESULT_MST), " +
                                 row["SCHOOL_YEAR"] + ", " + row["CLASS_ID"] + ", " +
                                 row["EXAM_ID"] + ", " + row["STUDENT_ID"] + ", " +
                                 row["ROLL"] + ", " + row["REG"] + ", " + row["FORM_NUMBER"] + ", " +
                                 row["TOTAL_MARKS"] + ", " + row["TOTAL_OBTAINED_MARKS"] + ", '" + 
                                 GlobalSettings.LoggedEmployee.UserName + "') ";
                    }

                    try
                    {
                        Db.QueryExecute(query);
                    }
                    catch
                    {
                        //
                    }

                    // Load result data

                    query = "SELECT M.*, S.NAME AS STUDENT_NAME FROM S_RESULT_MST AS M " +
                            "LEFT JOIN S_STUDENT AS S ON M.STUDENT_ID=S.ID " +
                            "WHERE M.SCHOOL_YEAR = " + GlobalSettings.OfficeInfo.SchoolYear +
                            " AND M.CLASS_ID = " + classId + " AND M.EXAM_ID = " + examId +
                            " ORDER BY M.ROLL";
                    dt = Db.GetTable(query);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            var s = dg.Rows.Add();
                            dg.Rows[s].Cells[ColumnId.Index].Value = row["ID"].ToString();
                            dg.Rows[s].Cells[ColumnRoll.Index].Value = row["ROLL"].ToString();
                            dg.Rows[s].Cells[ColumnName.Index].Value = row["STUDENT_NAME"].ToString();
                            dg.Rows[s].Cells[ColumnSubjectMarks.Index].Value = row["TOTAL_SUB_MARKS"].ToString();
                            dg.Rows[s].Cells[ColumnObtainedMark.Index].Value = row["OBTAINED_MARKS"].ToString();
                            dg.Rows[s].Cells[ColumnObtainedPct.Index].Value = row["TOTAL_OBTAINED_PCT"].ToString();
                            dg.Rows[s].Cells[ColumnGradePoint.Index].Value = row["GRADE_POINT"].ToString();
                            dg.Rows[s].Cells[ColumnLetterGrade.Index].Value = row["LETTER_GRADE"].ToString();
                            dg.Rows[s].Cells[ColumnStudentId.Index].Value = row["STUDENT_ID"].ToString();
                            dg.Rows[s].Cells[ColumnPreExamMarks.Index].Value = row["PRE_EXM_MARKS"].ToString();
                        }

                        dataGridViewStudentList.Refresh();
                    }

                    // Process result
                    if (dg.RowCount > 0)
                    {
                        bool isFail;
                        string studentId;

                        for (var s = 0; s < dg.RowCount; s++)
                        {
                            isFail = false;
                            studentId = dg.Rows[s].Cells[ColumnStudentId.Index].Value.ToString();

                            dg.Rows[s].Selected = true;

                            // Check mandatory
                            if (_isMandatory)
                            {
                                query = "SELECT * FROM S_MARK WHERE SCHOOL_YEAR = " + GlobalSettings.OfficeInfo.SchoolYear +
                                        " AND EXAM_ID = " + examId +
                                        " AND STUDENT_ID = " + studentId +
                                        " AND CLASS_ID = " + classId +
                                        " AND GRADE_POINT<=0 AND MANDATORY = 1";
                                dt = Db.GetTable(query);
                                isFail = dt.Rows.Count > 0;
                            }

                            // Previous exam marks

                            double preExamMark = 0;
                            string preExamMarkDtl = "";

                            if (_isFinal && GlobalSettings.OfficeInfo.PreExamEffFinal)
                            {
                                dg.Columns[ColumnPreExamMarks.Index].Visible = true;
                                query = "SELECT R.EXAM_ID, R.TOTAL_OBTAINED_MARKS, E.EFFECT_PERCENT " +
                                        ",((R.TOTAL_OBTAINED_MARKS * E.EFFECT_PERCENT) / 100) AS PRE_EXAM_MARKS " +
                                        "FROM S_RESULT_MST AS R " +
                                        "LEFT JOIN S_EXAM AS E ON R.EXAM_ID = E.ID " +
                                        "WHERE R.SCHOOL_YEAR = " + GlobalSettings.OfficeInfo.SchoolYear +
                                        " AND R.CLASS_ID = " + classId +
                                        " AND R.STUDENT_ID = " + studentId +
                                        " AND E.EFFECT_ON_FINAL = 1" +
                                        " AND E.IS_FINAL = 0";
                                dt = Db.GetTable(query);
                                 if (dt.Rows.Count > 0)
                                 {
                                     foreach (DataRow row in dt.Rows)
                                     {
                                         preExamMark += Convert.ToDouble(row["PRE_EXAM_MARKS"].ToString());
                                         preExamMarkDtl += string.IsNullOrEmpty(preExamMarkDtl)
                                             ? "E" + row["EXAM_ID"] + "M" + row["TOTAL_OBTAINED_MARKS"] + "%" + row["EFFECT_PERCENT"] + "=" + row["PRE_EXAM_MARKS"]
                                             : ",E" + row["EXAM_ID"] + "M" + row["TOTAL_OBTAINED_MARKS"] + "%" + row["EFFECT_PERCENT"] + "=" + row["PRE_EXAM_MARKS"];
                                     }
                                 }
                            }

                            // Calculate result
                            var totalSubjectMark = Convert.ToDouble(dg.Rows[s].Cells[ColumnSubjectMarks.Index].Value);
                            var obtainedTotalMark = Convert.ToDouble(dg.Rows[s].Cells[ColumnObtainedMark.Index].Value) + preExamMark;

                            var obtainedFinalMark = obtainedTotalMark > totalSubjectMark ? totalSubjectMark : obtainedTotalMark;
                            var grade = GlobalSettings.ResultCalculate(isFail ? 0 : obtainedFinalMark, totalSubjectMark, GlobalSettings.MarkCalculateYear);
                            
                            var finalMarksPercentage = grade.MarksPercentage;
                            var finalGradePoint = grade.GradePoint;
                            var finalLetterGrade = grade.LetterGrade;

                            // Update result PRE_EXM_MARKS, PRE_EXM_MARKS_DTL
                            query = "UPDATE S_RESULT_MST SET PRE_EXM_MARKS=" + preExamMark + 
                                    ", TOTAL_OBTAINED_MARKS="+obtainedFinalMark+
                                    ", TOTAL_OBTAINED_PCT=" + finalMarksPercentage +
                                    ", GRADE_POINT=" + finalGradePoint +
                                    ", LETTER_GRADE='" + finalLetterGrade +
                                    "', CREATE_BY='" + GlobalSettings.LoggedEmployee.UserName +
                                    "', PRE_EXM_MARKS_DTL='" + preExamMarkDtl +
                                    "' WHERE ID=" + dg.Rows[s].Cells[ColumnId.Index].Value;
                            if (Db.QueryExecute(query))
                            {
                                dg.Rows[s].Cells[ColumnPreExamMarks.Index].Value = preExamMark;
                                dg.Rows[s].Cells[ColumnObtainedPct.Index].Value = finalMarksPercentage;
                                dg.Rows[s].Cells[ColumnGradePoint.Index].Value = finalGradePoint;
                                dg.Rows[s].Cells[ColumnLetterGrade.Index].Value = finalLetterGrade;
                            }
                            
                            dataGridViewStudentList.Refresh();
                        }

                        loading.Close();
                    }
                    else
                    {
                        loading.Close();
                    }
                }
                else
                {
                    loading.Close();
                    MessageBox.Show(ContentText.StudentNotFound);
                }

                #endregion

            }
            catch (Exception ex)
            {
                loading.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkLabelMandatory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var subList = Db.GetTable("SELECT CODE, NAME, MARK FROM S_SUBJECT WHERE CLASS_ID=" +
                                      comboBoxClass.SelectedValue + " AND STATUS='A' AND MANDATORY=1");

            FrmViewList.Show(ContentText.MandatorySubjectList, subList, new[] {"Code", "Name", "Mark"}, 1);
        }

    }
}
