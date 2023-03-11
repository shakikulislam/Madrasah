using System;
using System.Windows.Forms;
using MadrasahSMS.DbContext;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Students
{
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
            LoadTheme(this);
            LoadStudentList();
            ThemeTemplate.SIconButton(this, 0);
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.LoadTheme(control);
            ThemeTemplate.SDataGridView(control);
        }

        private void LoadStudentList()
        {
            try
            {
                var query = "SELECT ID, FORM_NUMBER, ROLL, REG, NAME, PHONE, DOB, BIRTH_CERTIFICATE, NID, FATHER_NAME, FATHER_PHONE, FATHER_NID, " +
                            "MOTHER_NAME, MOTHER_PHONE, MOTHER_NID, GUARDIAN_NAME, GUARDIAN_PHONE, CLASS_ID, REMARK, PICTURE, STATUS, CREATE_BY, " +
                            "CREATE_DATE, UPDATE_BY, UPDATE_DATE, CLASS AS CLASS_NAME " +
                            "FROM vw_s_full_student_info WHERE roll<> 0 ORDER BY CLASS_ID ASC";
                
                var studentSet = Db.GetTable(query);
                dataGridViewStudentList.DataSource = studentSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            iconButtonSearch.PerformClick();
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LoadStudentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudentList.Columns[e.ColumnIndex].Name=="details")
            {
                var id = dataGridViewStudentList.SelectedRows[0].Cells["ColumnId"].Value.ToString();
                new FrmStudentDetails(id).ShowDialog();
            }
        }

        private void dataGridViewStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewStudentList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
