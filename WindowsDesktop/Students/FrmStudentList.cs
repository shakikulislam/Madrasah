using System;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Students
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
                var studentSet = new StudentDb().List();
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
