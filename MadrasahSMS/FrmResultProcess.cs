using System;
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

        private bool LoadExamDate()
        {
            if (string.IsNullOrEmpty(comboBoxClass.Text)) return false;
            if (string.IsNullOrEmpty(comboBoxExam.Text)) return false;
            if (string.IsNullOrEmpty(comboBoxSubject.Text)) return false;

            var date = new ExamDb().GetExamDate(
                comboBoxExam.SelectedValue.ToString(), comboBoxClass.SelectedValue.ToString(),
                comboBoxSubject.SelectedValue.ToString());

            if (string.IsNullOrEmpty(date))
            {
                MessageBox.Show(ContentText.ExamScheduleNotFound);
                return false;
            }
            return true;

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxSubject.DisplayMember = "NAME";
                comboBoxSubject.ValueMember = "ID";
                comboBoxSubject.DataSource = new SubjectDb().GetByClassId(comboBoxClass.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProcess_Click(object sender, System.EventArgs e)
        {

            //if (!LoadExamDate())
            //{
            //    return;
            //}

            //panelSearch.Enabled = false;

            //var query = "SELECT ID, ROLL, REG, NAME FROM S_STUDENT " +
            //            "WHERE CLASS_ID = " + comboBoxClass.SelectedValue + " ORDER BY ROLL ASC";
            //var dt = Db.GetDataTable(query);
            //var subjectMark = new SubjectDb().Mark(comboBoxSubject.SelectedValue.ToString());

            //var insertQuery = "";
            //foreach (DataRow row in dt.Rows)
            //{
            //    insertQuery += "";
            //}

            //try
            //{
            //    //Db.QueryExecute(insertQuery);
            //}
            //catch
            //{
            //}

            //var markForEntry = "";
            //var dtMark = Db.GetDataTable(markForEntry);
            //foreach (DataRow row in dtMark.Rows)
            //{
            //    var dr = dataGridViewStudentList.Rows.Add();
            //    dataGridViewStudentList.Rows[dr].Cells[ColumnId.Index].Value = row["ID"].ToString();
            //    dataGridViewStudentList.Rows[dr].Cells[ColumnRoll.Index].Value = row["ROLL"].ToString();
            //    dataGridViewStudentList.Rows[dr].Cells[ColumnName.Index].Value = row["NAME"].ToString();
            //    dataGridViewStudentList.Rows[dr].Cells[ColumnSubjectMarks.Index].Value =
            //        row["SUBJECT_MARKS"].ToString();
            //    dataGridViewStudentList.Rows[dr].Cells[ColumnMark.Index].Value = row["OBTAINED_MARKS"].ToString();

            //    var status = row["STATUS"].ToString();
            //    dataGridViewStudentList.Rows[dr].Cells[ColumnStatus.Index].Value = status;

            //    dataGridViewStudentList.Refresh();
            //}
        }

    }
}
