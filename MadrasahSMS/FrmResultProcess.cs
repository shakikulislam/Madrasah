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

                // Exam schedule check
                var loading = new frmWaiting();
                loading.Show();
                Application.DoEvents();

                var query = "SELECT S.NAME, S.MARK, E.NAME AS TEACHER_NAME " +
                            "FROM S_SUBJECT AS S " +
                            "LEFT JOIN S_EMPLOYEE AS E ON S.TEACHER_ID = E.ID " +
                            "WHERE S.ID NOT IN(SELECT SUBJECT_ID FROM S_EXAM_SCHEDULE " +
                            "WHERE SCHOOL_YEAR = " + GlobalSettings.SchoolYear + " AND CLASS_ID = " +
                            class_id + " AND EXAM_ID = " + exam_id + ") " +
                            "AND S.CLASS_ID = " + class_id + " AND S.STATUS = 'A'";
                var dt = Db.GetDataTable(query);
                if (dt.Rows.Count > 0)
                {
                    loading.Close();
                    string[] columnHeaderText = {"Subject Name", "Mark", "Teacher Name"};
                    new FrmViewList("Exam Schedule Missing", dt, columnHeaderText,0).ShowDialog();
                    return;
                }

                // Mark entry check
                query = "SELECT ST.ROLL, ST.NAME AS STUDENT_NAME, S.NAME AS SUBJECT_NAME " +
                        "FROM S_MARK AS M " +
                        "LEFT JOIN S_SUBJECT AS S ON M.SUBJECT_ID = S.ID " +
                        "LEFT JOIN S_STUDENT AS ST ON M.STUDENT_ID = ST.ID " +
                        "WHERE M.SCHOOL_YEAR = " + GlobalSettings.SchoolYear +
                        " AND M.EXAM_ID = " + exam_id + " AND M.CLASS_ID = " + class_id +
                        " AND (M.STATUS IS NULL OR M.STATUS NOT IN('ME')) " +
                        "ORDER BY ST.ROLL, ST.NAME, S.NAME";
                dt = Db.GetDataTable(query);
                if (dt.Rows.Count>0)
                {
                    loading.Close();
                    string[] columnHeader = {"Roll", "Student Name", "Subject"};
                    new FrmViewList(ContentText.MarksMissing, dt, columnHeader, 1).ShowDialog();
                    return;
                }

                // Process result
                query = "";
                dt = Db.GetDataTable(query);
                if (dt.Rows.Count > 0)
                {
                    loading.Close();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
