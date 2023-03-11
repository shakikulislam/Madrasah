using System;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Academic
{
    public partial class FrmSubject : Form
    {
        public FrmSubject()
        {
            InitializeComponent();
            ClearField();

            LoadTheme(this);
            LoadTime();
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.LoadTheme(control);
            ThemeTemplate.SDataGridView(control);
            
        }

        private void LoadTime()
        {
            var classList = Db.GetTable("SELECT id, name FROM s_class WHERE NAME <> '' ORDER BY class_number");
            comboBoxClass.ValueMember = "id";
            comboBoxClass.DisplayMember = "name";
            comboBoxClass.DataSource = classList;

            var teacherList = Db.GetTable("SELECT id, name FROM s_employee WHERE status='A'");
            comboBoxTeacher.ValueMember = "id";
            comboBoxTeacher.DisplayMember = "name";
            comboBoxTeacher.DataSource = teacherList;

            LoadSubject();
        }

        private void LoadSubject()
        {
            var subjectList = Db.GetTable(query: "SELECT s.id, s.code, s.name, s.mark, s.class_id, S.MANDATORY, " +
                                                     "c.name AS class_name, s.teacher_id, e.name AS teacher_name " +
                                                     "FROM s_subject s " +
                                                     "LEFT JOIN s_class c ON s.class_id = c.id " +
                                                     "LEFT JOIN s_employee e ON s.teacher_id = e.id");

            dataGridViewSubjectList.Columns[ColumnCode.Index].DataPropertyName = "code";
            dataGridViewSubjectList.Columns[ColumnName.Index].DataPropertyName = "name";
            dataGridViewSubjectList.Columns[ColumnMark.Index].DataPropertyName = "mark";
            dataGridViewSubjectList.Columns[ColumnClass.Index].DataPropertyName = "class_name";
            dataGridViewSubjectList.Columns[ColumnMandatory.Index].DataPropertyName = "MANDATORY";
            dataGridViewSubjectList.Columns[ColumnTeacher.Index].DataPropertyName = "teacher_name";
            dataGridViewSubjectList.Columns[ColumnSubjectId.Index].DataPropertyName = "id";
            dataGridViewSubjectList.Columns[ColumnClassId.Index].DataPropertyName = "class_id";
            dataGridViewSubjectList.Columns[ColumnTeacherId.Index].DataPropertyName = "teacher_id";

            dataGridViewSubjectList.DataSource = subjectList;
        }

        private void ClearField()
        {
            buttonSubmit.Text = "Add";
            buttonSubmit.Height = 56;

            textBoxSubjectCode.Clear();
            textBoxSubjectCode.Tag = string.Empty;
            textBoxSubjectName.Clear();
            textBoxSubjectCode.Enabled = true;

            checkBoxMandatory.Checked = false;
        }

        private void buttonSubmit_Click(object sender, System.EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(this, errorProviderSubject);
                if (!isValid) return;

                var mandatory = checkBoxMandatory.Checked ? 1 : 0;

                var query = "";
                switch (buttonSubmit.Text)
                {
                    case "Add":
                        query = "INSERT INTO s_subject (id, class_id, code, name, mark, teacher_id, create_by, create_date, status, MANDATORY)" +
                                "VALUES((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_SUBJECT),"
                                + comboBoxClass.SelectedValue + ",'" + textBoxSubjectCode.Text.Trim() +
                                "',N'" + textBoxSubjectName.Text.Trim() + "'," + numericUpDownMark.Text + "," +
                                comboBoxTeacher.SelectedValue + ",'" + GlobalSettings.UserName + "', '" +
                                DateTime.Now.ToString(GlobalSettings.DateFormatSave) + "','A', " + mandatory + " )";
                        break;
                    case "Update":
                        query = "UPDATE s_subject SET class_id=" + comboBoxClass.SelectedValue + ", CODE='" +
                                textBoxSubjectCode.Text.Trim() + "', name=N'" +
                                textBoxSubjectName.Text.Trim() + "', mark=" + numericUpDownMark.Text + ", teacher_id=" +
                                comboBoxTeacher.SelectedValue + ", update_by='" + GlobalSettings.UserName +
                                "', update_date='" + DateTime.Now.ToString(GlobalSettings.DateFormatSave) +
                                "', MANDATORY=" + mandatory + " WHERE id=" + textBoxSubjectCode.Tag + "";
                        break;
                }
                    
                var isSave = Db.QueryExecute(query);
                if (!isSave) return;

                ClearField();
                LoadSubject();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearField();
            }
        }

        private void dataGridViewSubjectList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewSubjectList.Rows[e.RowIndex].Cells[ColumnSl.Index].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewSubjectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dgv = dataGridViewSubjectList.SelectedRows[0];
                textBoxSubjectCode.Text = dgv.Cells[ColumnCode.Index].Value.ToString();
                textBoxSubjectCode.Tag = dgv.Cells[ColumnSubjectId.Index].Value;
                textBoxSubjectName.Text = dgv.Cells[ColumnName.Index].Value.ToString();
                numericUpDownMark.Text = dgv.Cells[ColumnMark.Index].Value.ToString();
                comboBoxClass.SelectedValue = dgv.Cells[ColumnClassId.Index].Value;
                comboBoxTeacher.SelectedValue = dgv.Cells[ColumnTeacherId.Index].Value;
                checkBoxMandatory.Checked = (bool) dgv.Cells[ColumnMandatory.Index].Value;

                //textBoxSubjectCode.Enabled = false;
                buttonSubmit.Text = "Update";
                buttonSubmit.Height = 39;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearField();
            }
        }

        private void linkLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearField();
        }
    }
}
