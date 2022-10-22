using System;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Academic
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
            ThemeTemplate.LoadTheme(this);
        }
        
        private void LoadDepartment(Control control)
        {
            var query = "select id, name from s_department";
            var departmentList = Db.GetDataTable(query);

            switch (control)
            {
                case ComboBox comboBox:
                    comboBox.DataSource = null;
                    comboBox.DisplayMember = "name";
                    comboBox.ValueMember = "id";
                    comboBox.DataSource = departmentList;
                    break;

                case DataGridView dataGridView:
                    dataGridView.DataSource = departmentList;
                    break;
            }
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDepartment(dataGridViewDepartment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            if (buttonAddNew.Text == "Add Department")
            {
                buttonAddNew.Text = "Cancel";
                textBoxDepartmentName.Clear();
                textBoxDepartmentName.ReadOnly = false;
                buttonAddDepartment.Text = "Add";
                buttonAddDepartment.Visible = true;
            }
            else if (buttonAddNew.Text=="Cancel")
            {
                buttonAddNew.Text = "Add Department";
                textBoxDepartmentName.Clear();
                textBoxDepartmentName.ReadOnly = true;
                buttonAddDepartment.Visible = false;
            }

        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(this, errorProviderDepartment);
                if (isValid)
                {
                    var query = "";

                    if (buttonAddDepartment.Text == "Add")
                    {
                        query = "insert into s_department (Id, Name) values ((SELECT ISNULL(MAX(Id)+1,1) AS Id FROM S_Department),'" + textBoxDepartmentName.Text.Trim() + "')";
                    }
                    else if (buttonAddDepartment.Text == "Update")
                    {
                        query = "update s_department set name='" + textBoxDepartmentName.Text.Trim() +
                                "' where id='" + textBoxDepartmentName.Tag + "'";
                    }

                    var isExecute = Db.QueryExecute(query);

                    if (isExecute)
                    {
                        textBoxDepartmentName.Clear();
                        textBoxDepartmentName.ReadOnly = true;
                        buttonAddDepartment.Visible = false;
                    }

                    LoadDepartment(dataGridViewDepartment);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDepartment_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDepartment.RowCount > 0)
                {
                    textBoxDepartmentName.Text = dataGridViewDepartment.SelectedRows[0].Cells["ColumnDepartmentName"].Value.ToString();
                    textBoxDepartmentName.Tag = dataGridViewDepartment.SelectedRows[0].Cells["ColumnDepartmentId"].Value.ToString();

                    textBoxDepartmentName.ReadOnly = false;
                    buttonAddDepartment.Text = "Update";
                    buttonAddDepartment.Visible = true;
                    buttonAddNew.Text = "Cancel";
                }
            }
            catch
            {
                textBoxDepartmentName.Clear();
                textBoxDepartmentName.Tag = string.Empty;
                textBoxDepartmentName.ReadOnly = true;
                buttonAddDepartment.Visible = false;
                buttonAddNew.Text = "Add Department";
            }
        }
    }
}
