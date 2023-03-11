using System;
using System.Windows.Forms;
using MadrasahSMS.DbContext;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Staff
{
    public partial class FrmStaffList : Form
    {
        public FrmStaffList()
        {
            InitializeComponent();
            LoadTheme(this);
            
            LoadStaffList();
            ThemeTemplate.SIconButton(this, 0);
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.LoadTheme(control);
            ThemeTemplate.SDataGridView(control);
        }

        private void LoadStaffList(string filter="")
        {
            var query = "";
            if (string.IsNullOrEmpty(filter))
            {
                query = "SELECT emp.id, emp.emp_id, emp.name, emp.phone, d.name AS designation " +
                        "FROM s_employee emp " +
                        "LEFT JOIN s_employee_designation d ON emp.desig_id = d.id";
            }
            var studentSet = Db.GetTable(query);
            dataGridViewStaffList.DataSource = studentSet;
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
                LoadStaffList(textBoxSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStaffList.Columns[e.ColumnIndex].Name=="details")
            {
                var id = dataGridViewStaffList.SelectedRows[0].Cells["ColumnId"].Value.ToString();
                new FrmStaffDetails(id).ShowDialog();
            }
        }

        private void dataGridViewStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewStaffList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
