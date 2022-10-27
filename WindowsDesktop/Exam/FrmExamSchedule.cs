using System;
using System.IO;
using System.Windows.Forms;
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
    }
}
