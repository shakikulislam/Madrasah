﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Properties;
using MadrasahSMS.Theme;

namespace MadrasahSMS
{
    public partial class FrmMarksEntry : Form
    {
        public FrmMarksEntry()
        {
            InitializeComponent();

            ThemeTemplate.LoadTheme(panelSearch);
            ThemeTemplate.LoadTheme(panelUpdate);
            ThemeTemplate.SDataGridView(this, BorderStyle.FixedSingle);

            LoadData();
        }

        private void CalculateTotalEntry()
        {
            var entryCount = dataGridViewStudentList.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[ColumnStatus.Index].Value != null)
                .Count(row => row.Cells[ColumnStatus.Index].Value.ToString() == "E");

            int total = dataGridViewStudentList.RowCount;
            int dueEntry = total - entryCount;

            labelTotalStudent.Text = total.ToString();
            labelMarkEntry.Text = entryCount.ToString();
            labelDueEntry.Text = dueEntry.ToString();
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
                MessageBox.Show("Exam schedule not found\nPlease create exam schedule and try again.");
                return false;
            }
            else
            {
                dateTimePickerExamDate.Value = Convert.ToDateTime(date);
                dateTimePickerExamDate.Refresh();
                return true;
            }

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

        private void comboBoxSubject_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, System.EventArgs e)
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var isValid = ThemeTemplate.SValidate(panelSearch, errorProviderMark);
            if (isValid)
            {
                if (!LoadExamDate())
                {
                    panelSearch.Enabled = true;
                    return;
                }

                panelSearch.Enabled = false;

                var query = "SELECT ID, ROLL, REG, NAME FROM S_STUDENT " +
                            "WHERE CLASS_ID = " + comboBoxClass.SelectedValue + " ORDER BY ROLL ASC";
                var dt = Db.GetDataTable(query);

                var insertQuery = "";
                foreach (DataRow row in dt.Rows)
                {
                    insertQuery += "INSERT INTO S_MARK (ID, " +
                                   "EXAM_ID, " +
                                   "EXAM_DATE, " +
                                   "STUDENT_ID, " +
                                   "CLASS_ID, " +
                                   "SUBJECT_ID, " +
                                   "UPDATE_BY, " +
                                   "UPDATE_DATE) " +
                                   "VALUES((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_MARK), "
                                   + comboBoxExam.SelectedValue + ", '"
                                   + dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) + "',"
                                   + row["ID"] + "," + comboBoxClass.SelectedValue + ","
                                   + comboBoxSubject.SelectedValue + ",'"
                                   + GlobalSettings.UserName + "',current_timestamp); ";
                }

                try
                {
                    Db.QueryExecute(insertQuery);
                }
                catch { }

                var markForEntry = "SELECT M.ID, M.EXAM_ID, M.EXAM_DATE, M.STUDENT_ID, M.CLASS_ID, " +
                                   "M.SUBJECT_ID, M.MARKS, M.OBTAINED_MARKS, M.OBTAINED_MARKS_PCT, M.STATUS, " +
                                   "S.ROLL, S.REG, S.NAME " +
                                   "FROM S_MARK M " +
                                   "LEFT JOIN S_STUDENT S ON M.STUDENT_ID = S.ID " +
                                   "WHERE M.EXAM_ID=" + comboBoxExam.SelectedValue +
                                   " AND M.EXAM_DATE='" + dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) +
                                   "' AND M.CLASS_ID=" + comboBoxClass.SelectedValue +
                                   " AND M.SUBJECT_ID=" + comboBoxSubject.SelectedValue;
                var dtMark = Db.GetDataTable(markForEntry);
                foreach (DataRow row in dtMark.Rows)
                {
                    var dr = dataGridViewStudentList.Rows.Add();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnId.Index].Value = row["ID"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnRoll.Index].Value = row["ROLL"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnReg.Index].Value = row["REG"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnName.Index].Value = row["NAME"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnMark.Index].Value = row["MARKS"].ToString();
                    
                    var status = row["STATUS"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnStatus.Index].Value = status;
                    dataGridViewStudentList.Rows[dr].Cells[ColumnCheck.Index].Value = status == "E"
                        ? Resources.check_mark
                        : new Bitmap(1, 1);
                    
                    dataGridViewStudentList.Refresh();
                }

                CalculateTotalEntry();
                panelUpdate.Enabled = true;
            }
            else
            {
                panelSearch.Enabled = true;
                panelUpdate.Enabled = false;
            }
        }

        private void comboBoxExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewStudentList_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
