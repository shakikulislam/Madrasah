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
