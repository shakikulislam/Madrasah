using System;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Academic
{
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();
            LoadDepartment(comboBoxClassDepartment);
            LoadTeacher(comboBoxTeacher);
            LoadClass();
            ThemeTemplate.LoadTheme(this);
            ThemeTemplate.LoadTheme(panelClassForm);
        }
        
        private void LoadDepartment(Control control)
        {
            var query = "select id, name from s_departments";
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

        private void LoadTeacher(ComboBox comboBox)
        {
            var query = "select id, name from s_employees WHERE status='A'";
            var staffList = Db.GetDataTable(query);

            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = staffList;
        }

        private void LoadClass()
        {
            var query = "select c.id, c.name AS className, c.class_number as classNumber, d.name as department, " +
                        "e.name as teacher_name from s_classes c " +
                        "left join s_departments d on c.department_id = d.id " +
                        "left join s_employees e on c.teacher_id = e.id " +
                        "order by c.department_id, c.class_number asc";
            var classList = Db.GetDataTable(query);
            dataGridViewClass.DataSource = classList;
        }

        private void buttonAddNewClass_Click(object sender, EventArgs e)
        {
            if (buttonAddNewClass.Text == "Add Class")
            {
                buttonAddNewClass.Text = "Cancel";
                textBoxClassName.Clear();
                numericUpDownClassNumber.Text = "0";
                buttonClassUpdate.Text = "Add";
                buttonClassUpdate.Visible = true;
                panelClassForm.Visible = true;
            }
            else
            {
                buttonAddNewClass.Text = "Add Class";
                textBoxClassName.Clear();
                numericUpDownClassNumber.Text = "0";
                buttonClassUpdate.Visible = false;
                panelClassForm.Visible = false;
            }
        }

        private void buttonClassUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(panelClassForm, errorProviderClass);
                if (isValid)
                {
                    var query = "";

                    if (buttonClassUpdate.Text == "Add")
                    {
                        query = "insert into s_classes (name,class_number,department_id,teacher_id) values ('" +
                                textBoxClassName.Text.Trim() + "','" + numericUpDownClassNumber.Text.Trim() +
                                "','" + comboBoxClassDepartment.SelectedValue + "','" + comboBoxTeacher.SelectedValue + "')";
                    }
                    else if (buttonClassUpdate.Text == "Update")
                    {
                        query = "update s_classes set name='" + textBoxClassName.Text.Trim() +
                                "', class_number='" + numericUpDownClassNumber.Text.Trim() +
                                "', department_id='" + comboBoxClassDepartment.SelectedValue +
                                "', teacher_id='" + comboBoxTeacher.SelectedValue +
                                "', update_by = '" + GlobalSettings.UserName +
                                "', update_date=CURRENT_TIMESTAMP() where id = '" + textBoxClassName.Tag + "'";
                    }

                    var isExecute = Db.QueryExecute(query);
                    if (isExecute)
                    {
                        buttonAddNewClass.Text = "Add Class";
                        textBoxClassName.Clear();
                        numericUpDownClassNumber.Text = "0";
                        buttonClassUpdate.Visible = false;
                        panelClassForm.Visible = false;
                    }

                    LoadClass();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewClass_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewClass.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewClass_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewClass.RowCount > 0)
                {
                    textBoxClassName.Text = dataGridViewClass.SelectedRows[0].Cells["ColumnClassName"].Value.ToString();
                    textBoxClassName.Tag = dataGridViewClass.SelectedRows[0].Cells["ColumnClassId"].Value.ToString();
                    
                    comboBoxClassDepartment.Text = dataGridViewClass.SelectedRows[0].Cells["ColumnClassDepartment"].Value.ToString();

                    numericUpDownClassNumber.Text = dataGridViewClass.SelectedRows[0].Cells["ColumnClassNumber"].Value.ToString();

                    comboBoxTeacher.Text = dataGridViewClass.SelectedRows[0].Cells["teacher_name"].Value.ToString();

                    buttonAddNewClass.Text = "Cancel";
                    buttonClassUpdate.Text = "Update";
                    buttonClassUpdate.Visible = true;
                    panelClassForm.Visible = true;
                }
            }
            catch
            {
                buttonAddNewClass.Text = "Add Class";
                textBoxClassName.Clear();
                numericUpDownClassNumber.Text = "0";
                buttonClassUpdate.Visible = false;
                panelClassForm.Visible = false;
            }
        }
    }
}
