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
                //var query="SELECT * FROM "
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
