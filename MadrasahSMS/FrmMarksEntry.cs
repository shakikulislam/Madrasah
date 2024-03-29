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
            labelSubjectMark.ForeColor = Color.Red;
            labelTotalStudent.ForeColor= Color.Red;
            labelDueEntry.ForeColor= Color.Red;
            labelMarkEntry.ForeColor= Color.Red;
        }

        private void LoadDetails()
        {
            try
            {
                var dg = dataGridViewStudentList.SelectedRows[0];
                textBoxName.Text = dg.Cells[ColumnName.Index].Value.ToString();
                textBoxRoll.Text = dg.Cells[ColumnRoll.Index].Value.ToString();
                textBoxReg.Text = dg.Cells[ColumnReg.Index].Value.ToString();
                textBoxMark.Text = dg.Cells[ColumnMark.Index].Value.ToString();
                textBoxMark.Tag = dg.Cells[ColumnId.Index].Value.ToString();
                labelSubjectMark.Text = "Sub. Mark= " + dg.Cells[ColumnSubjectMarks.Index].Value;
                labelSubjectMark.Tag = dg.Cells[ColumnSubjectMarks.Index].Value.ToString();
                textBoxMark.Focus();
                textBoxMark.SelectAll();
            }
            catch
            {
                //
            }
        }

        private void CalculateTotalEntry()
        {
            var entryCount = dataGridViewStudentList.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[ColumnStatus.Index].Value != null)
                .Count(row => row.Cells[ColumnStatus.Index].Value.ToString() == "ME");

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
                MessageBox.Show(ContentText.ExamScheduleNotFound + "\n" + ContentText.CreateExamSchedule);
                return false;
            }

            dateTimePickerExamDate.Value = Convert.ToDateTime(date);
            dateTimePickerExamDate.Refresh();
            return true;

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

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var isValid = ThemeTemplate.SValidate(panelSearch, errorProviderMark);
            if (isValid)
            {
                dataGridViewStudentList.Rows.Clear();

                if (!LoadExamDate())
                {
                    panelSearch.Enabled = true;
                    return;
                }

                var query = "SELECT ID, ROLL, REG, NAME FROM S_STUDENT " +
                            "WHERE CLASS_ID = " + comboBoxClass.SelectedValue + " ORDER BY ROLL ASC";
                var dt = Db.GetTable(query);

                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show(ContentText.StudentNotFound);
                    return;
                }

                var sub = new SubjectDb().GetById(comboBoxSubject.SelectedValue.ToString());
                var mandatory = sub.Mandatory ? 1 : 0;
                
                var insertQuery = "";
                foreach (DataRow row in dt.Rows)
                {
                    insertQuery += "INSERT INTO S_MARK (ID, " +
                                   "SCHOOL_YEAR, " +
                                   "EXAM_ID, " +
                                   "EXAM_DATE, " +
                                   "STUDENT_ID, " +
                                   "CLASS_ID, " +
                                   "SUBJECT_ID, " +
                                   "SUBJECT_MARKS, " +
                                   "UPDATE_BY, " +
                                   "UPDATE_DATE, " +
                                   "MANDATORY) " +
                                   "VALUES((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_MARK), " + GlobalSettings.OfficeInfo.SchoolYear +
                                   ", "
                                   + comboBoxExam.SelectedValue + ", '"
                                   + dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) + "',"
                                   + row["ID"] + "," + comboBoxClass.SelectedValue + ","
                                   + comboBoxSubject.SelectedValue + "," + sub.SubjectMark + ",'"
                                   + GlobalSettings.LoggedEmployee.UserName + "',current_timestamp, " + mandatory + "); ";
                }

                try
                {
                    Db.QueryExecute(insertQuery);
                }
                catch
                {
                }

                var markForEntry = "SELECT M.ID, M.EXAM_ID, M.EXAM_DATE, M.STUDENT_ID, M.CLASS_ID, " +
                                   "M.SUBJECT_ID, M.SUBJECT_MARKS, M.OBTAINED_MARKS, M.OBTAINED_MARKS_PCT, " +
                                   "M.GRADE_POINT, M.LETTER_GRADE, M.STATUS, " +
                                   "S.ROLL, S.REG, S.NAME " +
                                   "FROM S_MARK M " +
                                   "LEFT JOIN S_STUDENT S ON M.STUDENT_ID = S.ID " +
                                   "WHERE M.EXAM_ID=" + comboBoxExam.SelectedValue +
                                   " AND M.EXAM_DATE='" +
                                   dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) +
                                   "' AND M.CLASS_ID=" + comboBoxClass.SelectedValue +
                                   " AND M.SUBJECT_ID=" + comboBoxSubject.SelectedValue +
                                   " AND IS_ABSENT=0 " +
                                   "ORDER BY S.ROLL, S.REG ASC";
                var dtMark = Db.GetTable(markForEntry);
                foreach (DataRow row in dtMark.Rows)
                {
                    var dr = dataGridViewStudentList.Rows.Add();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnId.Index].Value = row["ID"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnRoll.Index].Value = row["ROLL"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnReg.Index].Value = row["REG"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnName.Index].Value = row["NAME"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnSubjectMarks.Index].Value = row["SUBJECT_MARKS"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnMark.Index].Value = row["OBTAINED_MARKS"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnGradePoint.Index].Value = row["GRADE_POINT"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnLetterGrade.Index].Value = row["LETTER_GRADE"].ToString();

                    var status = row["STATUS"].ToString();
                    dataGridViewStudentList.Rows[dr].Cells[ColumnStatus.Index].Value = status;
                    dataGridViewStudentList.Rows[dr].Cells[ColumnCheck.Index].Value = status == "ME"
                        ? Resources.check_mark
                        : new Bitmap(1, 1);

                    dataGridViewStudentList.Refresh();
                }

                CalculateTotalEntry();
                panelUpdate.Enabled = true;
                LoadDetails();
            }
            else
            {
                panelUpdate.Enabled = false;
            }
        }

        private void dataGridViewStudentList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewStudentList.SelectedRows[0].Cells[1].Value != null)
                {
                    LoadDetails();
                }
            }
            catch
            {
            }
        }

        private void textBoxMark_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    buttonUpdate.PerformClick();

                    var nextRow = dataGridViewStudentList.CurrentRow.Index + 1;
                    if (nextRow < dataGridViewStudentList.RowCount)
                    {
                        dataGridViewStudentList.CurrentCell = dataGridViewStudentList.Rows[nextRow]
                            .Cells[dataGridViewStudentList.CurrentCell.ColumnIndex];
                    }
                    else
                    {
                        MessageBox.Show(ContentText.LastRecordMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                textBoxMark.SelectAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var obtainedMark = Convert.ToDouble(textBoxMark.Text);
                var subjectMark = Convert.ToDouble(labelSubjectMark.Tag);

                var result = GlobalSettings.ResultCalculate(obtainedMark, subjectMark, GlobalSettings.MarkCalculateYear);

                var query = "UPDATE S_MARK SET OBTAINED_MARKS=" + obtainedMark + 
                            ", OBTAINED_MARKS_PCT=" + result.MarksPercentage + 
                            ", LETTER_GRADE='" + result.LetterGrade + 
                            "', GRADE_POINT=" + result.GradePoint + 
                            ", STATUS='" + GlobalSettings.Status.ME + 
                            "' WHERE ID=" + textBoxMark.Tag;

                var isUpdate = Db.QueryExecute(query);
                if (isUpdate)
                {
                    dataGridViewStudentList.SelectedRows[0].Cells[ColumnStatus.Index].Value = "ME";
                    dataGridViewStudentList.SelectedRows[0].Cells[ColumnCheck.Index].Value = Resources.check_mark;
                    dataGridViewStudentList.SelectedRows[0].Cells[ColumnGradePoint.Index].Value = result.GradePoint;
                    dataGridViewStudentList.SelectedRows[0].Cells[ColumnLetterGrade.Index].Value = result.LetterGrade;
                    dataGridViewStudentList.SelectedRows[0].Cells[ColumnMark.Index].Value = obtainedMark;
                    CalculateTotalEntry();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void textBoxMark_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double obtainedMark = Convert.ToDouble(textBoxMark.Text);
                double subMaxMark = Convert.ToDouble(labelSubjectMark.Tag);

                if (obtainedMark >= 0 && obtainedMark <= subMaxMark)
                {

                }
                else
                {
                    textBoxMark.Text = "0";
                    textBoxMark.SelectAll();
                }
            }
            catch
            {
                textBoxMark.Text = "0";
                textBoxMark.SelectAll();
            }
        }

        private void dataGridViewStudentList_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode==Keys.Delete)
            //{
            //    e.SuppressKeyPress = true;
            //    if (MessageBox.Show(ContentText.DeleteSelectionItem,"",MessageBoxButtons.YesNo)==DialogResult.Yes)
            //    {
            //        if (Db.QueryExecute("DELETE S_MARK WHERE ID="+textBoxMark.Tag))
            //        {
            //            dataGridViewStudentList.Rows.RemoveAt(dataGridViewStudentList.SelectedRows[0].Index);
            //            CalculateTotalEntry();
            //        }
            //    }
            //}
        }

        private void linkLabelAbsentList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LoadExamDate())
            {
                new FrmAbsentExamination(
                        GlobalSettings.OfficeInfo.SchoolYear,
                        comboBoxExam.SelectedValue,
                        comboBoxClass.SelectedValue)
                    .ShowDialog();
            }
        }

        private void linkLabelSetAbsent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(ContentText.MakeAbsentMessage,textBoxName.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                var query = "UPDATE S_MARK SET OBTAINED_MARKS=0, OBTAINED_MARKS_PCT=0, " +
                            "GRADE_POINT=0, LETTER_GRADE='', STATUS='I', IS_ABSENT=1 " +
                            "WHERE ID=" + textBoxMark.Tag;
                var isUpdate = Db.QueryExecute(query);
                if (isUpdate)
                {
                    dataGridViewStudentList.Rows.RemoveAt(dataGridViewStudentList.SelectedRows[0].Index);
                    CalculateTotalEntry();
                }
            }
        }
    }
}
