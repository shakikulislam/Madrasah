using System;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Exam
{
    public partial class FrmExamSchedule : Form
    {
        private static string _scheduleId;

        public FrmExamSchedule()
        {
            InitializeComponent();
            ThemeTemplate.LoadTheme(this);

            LoadData();
            LoadExamSchedule();
        }

        private void ClearField()
        {
            _scheduleId = string.Empty;

            linkLabelCancel.Visible = false;
            buttonAddSchedule.Text = "Add";

            comboBoxExamList.Text = string.Empty;
            comboBoxClassList.Text = string.Empty;
            comboBoxSubjectList.Text = string.Empty;

            buttonAddSchedule.Width = 139;

        }

        private void LoadData()
        {
            try
            {
                comboBoxExamList.DisplayMember = "NAME";
                comboBoxExamList.ValueMember = "ID";
                comboBoxExamList.DataSource = new ExamDb().Get();

                comboBoxClassList.DisplayMember = "NAME";
                comboBoxClassList.ValueMember = "ID";
                comboBoxClassList.DataSource = new ClassDb().Get();

                for (var i = 1; i <= 12; i++)
                {
                    string hour;

                    if (i<10)
                    {
                        hour = "0" + i;
                    }
                    else
                    {
                        hour = i.ToString();
                    }

                    comboBoxHour.Items.Add(hour);
                }
                
                for (var i = 0; i < 60; i++)
                {
                    string min;

                    if (i<10)
                    {
                        min = "0" + i;
                    }
                    else
                    {
                        min = i.ToString();
                    }

                    comboBoxMinutes.Items.Add(min);
                }
                
                comboBoxAmPm.Items.Add("AM");
                comboBoxAmPm.Items.Add("PM");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadExamSchedule()
        {
            try
            {
                dataGridViewExamSchedule.DataSource = new ExamDb().GetExamSchedule();
                dataGridViewExamSchedule.Columns[EXAM_DATE.Index].DefaultCellStyle.Format = GlobalSettings.DateFormatShortView;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void comboBoxClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxSubjectList.DisplayMember = "NAME";
                comboBoxSubjectList.ValueMember = "ID";
                comboBoxSubjectList.DataSource = new SubjectDb().GetByClassId(comboBoxClassList.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(this, errorProviderExamSchedule);

                if (isValid)
                {
                    var examTime = comboBoxHour.Text + ":" + comboBoxMinutes.Text + " " + comboBoxAmPm.Text;
                    var msg = "Exam : " + comboBoxExamList.Text +
                              Environment.NewLine + "Class : " + comboBoxClassList.Text +
                              Environment.NewLine + "Subject : " + comboBoxSubjectList.Text +
                              Environment.NewLine + "Date & Time: " +
                              dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatShortView)
                              + " " + examTime + Environment.NewLine + Environment.NewLine + 
                              "Are you sure create this schedule?";
                    if (MessageBox.Show(msg, "Schedule Confirmation", MessageBoxButtons.OK)==DialogResult.OK)
                    {
                        if (buttonAddSchedule.Text=="Add")
                        {
                            var isExist = Db.HasExisted("SELECT * FROM S_EXAM_SCHEDULE WHERE EXAM_ID=" +
                                                        comboBoxExamList.SelectedValue + " AND CLASS_ID=" +
                                                        comboBoxClassList.SelectedValue + " AND SUBJECT_ID=" +
                                                        comboBoxSubjectList.SelectedValue + " AND EXAM_DATE='" +
                                                        dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) + "'");
                            if (!isExist)
                            {
                                var query =
                                    "INSERT INTO S_EXAM_SCHEDULE (ID, SCHOOL_YEAR, EXAM_ID, CLASS_ID, SUBJECT_ID, EXAM_DATE, EXAM_TIME, CREATE_BY, " +
                                    "CREATE_DATE) VALUES ((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_EXAM_SCHEDULE), " +
                                    GlobalSettings.SchoolYear + "," + comboBoxExamList.SelectedValue + "," +
                                    comboBoxClassList.SelectedValue + "," + comboBoxSubjectList.SelectedValue + ",'" +
                                    dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) + "','" +
                                    examTime + "','" + GlobalSettings.UserName + "',current_timestamp)";
                                var isSave = Db.QueryExecute(query);
                                if (isSave)
                                {
                                    LoadExamSchedule();
                                }
                            }
                            else
                            {
                                MessageBox.Show("This schedule already exist.");
                            }
                        }
                        else if (buttonAddSchedule.Text=="Update")
                        {
                            var isExist = Db.HasExisted("SELECT * FROM S_EXAM_SCHEDULE WHERE EXAM_ID=" +
                                                        comboBoxExamList.SelectedValue + " AND CLASS_ID=" +
                                                        comboBoxClassList.SelectedValue + " AND SUBJECT_ID=" +
                                                        comboBoxSubjectList.SelectedValue + " AND EXAM_DATE='" +
                                                        dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave)
                                                        + "' AND ID <> " + _scheduleId + "");
                            if (!isExist)
                            {
                                var query =
                                    "UPDATE S_EXAM_SCHEDULE SET EXAM_ID=" + comboBoxExamList.SelectedValue +
                                    ", CLASS_ID=" + comboBoxClassList.SelectedValue +
                                    ", SUBJECT_ID=" + comboBoxSubjectList.SelectedValue +
                                    ", EXAM_DATE='" + dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) +
                                    "', EXAM_TIME='" + examTime +
                                    "', UPDATE_BY='" + GlobalSettings.UserName +
                                    "', UPDATE_DATE= current_timestamp " +
                                    "WHERE ID=" + _scheduleId + "";

                                var flag = Db.QueryExecute(query);
                                if (flag)
                                {
                                    ClearField();
                                    LoadExamSchedule();
                                }
                            }
                            else
                            {
                                MessageBox.Show("This schedule already exist.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewExamSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dg = dataGridViewExamSchedule;
                if (dg.Rows.Count>0)
                {
                    _scheduleId = dg.Rows[e.RowIndex].Cells[Id.Index].Value.ToString();
                    comboBoxExamList.Text = dg.Rows[e.RowIndex].Cells[EXAM_NAME.Index].Value.ToString();
                    comboBoxClassList.Text = dg.Rows[e.RowIndex].Cells[CLASS_NAME.Index].Value.ToString();
                    comboBoxSubjectList.Text = dg.Rows[e.RowIndex].Cells[SUBJECT_NAME.Index].Value.ToString();
                    dateTimePickerExamDate.Value = Convert.ToDateTime(dg.Rows[e.RowIndex].Cells[EXAM_DATE.Index].Value);
                    var time = dg.Rows[e.RowIndex].Cells[EXAM_TIME.Index].Value.ToString().Split(new Char[] {':',' '});
                    comboBoxHour.Text = time[0];
                    comboBoxMinutes.Text = time[1];
                    comboBoxAmPm.Text = time[2];

                    buttonAddSchedule.Width = 82;
                    buttonAddSchedule.Text = "Update";
                    linkLabelCancel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ClearField();
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearField();
        }

    }
}
