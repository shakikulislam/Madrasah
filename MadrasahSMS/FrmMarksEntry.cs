﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
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

                var query = "SELECT ID, ROLL, REG, NAME " +
                            "FROM S_STUDENT " +
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
                                   "CREATE_BY, " +
                                   "CREATE_DATE) " +
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

                var markForEntry = "SELECT * FROM S_MARK WHERE EXAM_ID=" + comboBoxExam.SelectedValue +
                                   " AND EXAM_DATE='"
                                   + dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) + "' " +
                                   "AND CLASS_ID=" + comboBoxClass.SelectedValue + " AND SUBJECT_ID=" +
                                   comboBoxSubject.SelectedValue;
                var dtMark = Db.GetDataTable(markForEntry);


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
    }
}