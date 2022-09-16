using System;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Staff
{
    public partial class FrmStaffList : Form
    {
        public FrmStaffList()
        {
            InitializeComponent();
            LoadTheme(this);
            LoadStudentList();
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.SLabel(control);
            ThemeTemplate.STextBox(control);
            ThemeTemplate.SIconButton(control,0);
            ThemeTemplate.SDataGridView(control, DataGridViewCellBorderStyle.Single);
        }

        private void LoadStudentList(string filter="")
        {
            var query = "";
            if (string.IsNullOrEmpty(filter))
            {
                query = "SELECT st.*, concat(dp.name,' (',cs.name,')') AS class_name " +
                        "FROM s_students AS st " +
                        "LEFT JOIN s_classes AS cs ON st.class_id=cs.id " +
                        "LEFT JOIN s_departments AS dp ON cs.department_id=dp.id " +
                        "WHERE roll <> 0";
            }
            var studentSet = Db.GetDataTable(query);
            dataGridViewStudentList.DataSource = studentSet;
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
                new FrmStaffDetails(id).ShowDialog();
            }
        }

        private void dataGridViewStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewStudentList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
