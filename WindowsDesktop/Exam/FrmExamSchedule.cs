using System;
using System.IO;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Exam
{
    public partial class FrmExamSchedule : Form
    {
        public FrmExamSchedule()
        {
            InitializeComponent();
            ThemeTemplate.LoadTheme(this);

            LoadData();
            LoadExamSchedule();
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
                var query = "SELECT ES.ID, ES.EXAM_DATE, ES.EXAM_TIME, E.NAME AS EXAM_NAME, " +
                            "C.NAME AS CLASS_NAME, S.NAME AS SUBJECT_NAME " +
                            "FROM S_EXAM_SCHEDULE AS ES " +
                            "LEFT JOIN S_EXAM AS E ON ES.EXAM_ID = E.ID " +
                            "LEFT JOIN S_CLASS AS C ON ES.CLASS_ID = C.ID " +
                            "LEFT JOIN S_SUBJECT AS S ON ES.SUBJECT_ID = S.ID " +
                            "WHERE ES.EXAM_STATUS IS NULL OR ES.EXAM_STATUS = ''";

                dataGridViewExamSchedule.DataSource = Db.GetDataTable(query);
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
                        var isExist = Db.HasExisted("SELECT * FROM S_EXAM_SCHEDULE WHERE EXAM_ID=" +
                                                    comboBoxExamList.SelectedValue + " AND CLASS_ID=" +
                                                    comboBoxClassList.SelectedValue + " AND SUBJECT_ID=" +
                                                    comboBoxSubjectList.SelectedValue + " AND EXAM_DATE='" +
                                                    dateTimePickerExamDate.Value.ToString(GlobalSettings.DateFormatSave) + "'");
                        if (!isExist)
                        {
                            var query =
                                "INSERT INTO S_EXAM_SCHEDULE (ID, EXAM_ID, CLASS_ID, SUBJECT_ID, EXAM_DATE, EXAM_TIME, CREATE_BY, " +
                                "CREATE_DATE) VALUES ((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_EXAM_SCHEDULE)," +
                                comboBoxExamList.SelectedValue + "," + comboBoxClassList.SelectedValue + "," +
                                comboBoxSubjectList.SelectedValue + ",'" + 
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
                            MessageBox.Show("This schedule already created\nPlease try another schedule.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
