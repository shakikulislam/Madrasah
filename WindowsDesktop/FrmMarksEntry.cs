using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop
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

        private void LoadData()
        {
            try
            {
                comboBoxClass.DisplayMember = "NAME";
                comboBoxClass.ValueMember = "ID";
                comboBoxClass.DataSource = new ClassDb().Get();

                comboBoxExam.DisplayMember = "NAME";
                comboBoxExam.ValueMember = "ID";
                comboBoxExam.DataSource = new ExamDb().Get();
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
            try
            {
                var isValid = ThemeTemplate.SValidate(panelSearch, errorProviderMark);
                if (isValid)
                {
                    panelSearch.Enabled = false;

                    var query = "SELECT S.ID, S.ROLL, S.REG, S.NAME " +
                                "FROM VW_S_FULL_STUDENT_INFO AS S " +
                                "WHERE S.CLASS_ID = " + comboBoxClass.SelectedValue + "";
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





                    panelUpdate.Enabled = true;
                }
                else
                {
                    panelSearch.Enabled = true;
                    panelUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
