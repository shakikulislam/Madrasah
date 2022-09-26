using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop
{
    public partial class FrmAcademic : Form
    {
        public FrmAcademic()
        {
            InitializeComponent();

            foreach (var panel in Controls.OfType<Panel>())
            {
                panel.BackColor = STheme.SColor.BackColor;
            }
            LoadTheme(panelTopMenu);
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
            var staffList= Db.GetDataTable(query);

            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = staffList;
        }

        private void LoadClass()
        {
            ThemeTemplate.SDataGridView(panelClass, DataGridViewCellBorderStyle.Single);

            var query = "select c.id, c.name, c.class_number as classNumber, d.name as department, " +
                        "e.name as teacher_name from s_classes c " +
                        "left join s_departments d on c.department_id = d.id " +
                        "left join s_employees e on c.teacher_id = e.id " +
                        "order by c.department_id, c.class_number asc";
            var classList = Db.GetDataTable(query);
            dataGridViewClass.DataSource = classList;
        }

        private void PanelHide()
        {
            foreach (var panel in Controls.OfType<Panel>())
            {
                if (panel.Name!=panelTopMenu.Name)
                {
                    panel.Visible = false;
                }
            }
        }

        private static void LoadTheme(Control control)
        {
            ThemeTemplate.SDataGridView(control);
            ThemeTemplate.SButton(control);
            ThemeTemplate.SLabel(control);
            ThemeTemplate.STextBox(control);
        }

        private void buttonClass_Click(object sender, System.EventArgs e)
        {
            try
            {
                LoadTheme(panelClass);
                PanelHide();
                panelClass.Size = new Size(660, 315);
                panelClass.Location = new Point((Width / 2) - (panelClass.Width / 2), panelTopMenu.Height + 5);
                panelClass.Anchor = AnchorStyles.Top;

                panelClass.Visible = true;
                Application.DoEvents();
                LoadClass();
                LoadDepartment(comboBoxClassDepartment);
                LoadTeacher(comboBoxTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAddNewClass_Click(object sender, EventArgs e)
        {
            if (buttonAddNewClass.Text == "Add Class")
            {
                buttonAddNewClass.Text = "Cancel";
                comboBoxClassDepartment.Enabled = true;
                textBoxClassName.Enabled = true;
                textBoxClassName.Clear();
                numericUpDownClassNumber.Enabled = true;
                numericUpDownClassNumber.Text = "0";
                comboBoxTeacher.Enabled = true;
                buttonClassUpdate.Visible = true;
                buttonClassUpdate.Text = "Add";
            }
            else
            {
                buttonAddNewClass.Text = "Add Class";
                comboBoxClassDepartment.Enabled = false;
                textBoxClassName.Enabled = false;
                textBoxClassName.Clear();
                numericUpDownClassNumber.Enabled = false;
                numericUpDownClassNumber.Text = "0";
                comboBoxTeacher.Enabled = false;
                buttonClassUpdate.Visible = false;
            }
        }

        private void buttonClassUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "";

                if (buttonClassUpdate.Text=="Add")
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

                var isExecute=Db.QueryExecute(query);
                if (isExecute)
                {
                    buttonAddNewClass.Text = "Add Class";
                    comboBoxClassDepartment.Enabled = false;
                    textBoxClassName.Enabled = false;
                    textBoxClassName.Clear();
                    numericUpDownClassNumber.Enabled = false;
                    numericUpDownClassNumber.Text = "0";
                    comboBoxTeacher.Enabled = false;
                    buttonClassUpdate.Visible = false;
                }

                LoadClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTheme(panelDepartment);
                PanelHide();
                panelDepartment.Size = new Size(600, 315);
                panelDepartment.Location = new Point((Width / 2) - (panelDepartment.Width / 2), panelTopMenu.Height + 5);
                panelDepartment.Anchor = AnchorStyles.Top;

                panelDepartment.Visible = true;
                Application.DoEvents();
                LoadDepartment(dataGridViewDepartment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            textBoxDepartmentName.Clear();
            textBoxDepartmentName.ReadOnly = false;
            buttonAddDepartment.Text = "Add";
            buttonAddDepartment.Visible = true;
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "";

                if (buttonAddDepartment.Text == "Add")
                {
                    query = "insert into s_departments (name) values ('"+textBoxDepartmentName.Text.Trim()+"')";
                }
                else if (buttonAddDepartment.Text=="Update")
                {
                    query = "update s_departments set name='" + textBoxDepartmentName.Text.Trim() + 
                            "' where id='" + textBoxDepartmentName.Tag + "'";
                }

                var isExecute= Db.QueryExecute(query);

                if (isExecute)
                {
                    textBoxDepartmentName.Clear();
                    textBoxDepartmentName.ReadOnly = true;
                    buttonAddDepartment.Visible = false;
                }

                LoadDepartment(dataGridViewDepartment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewDepartment_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDepartment.RowCount>0)
                {
                    textBoxDepartmentName.Text = dataGridViewDepartment.SelectedRows[0].Cells["ColumnDepartmentName"].Value.ToString();
                    textBoxDepartmentName.Tag = dataGridViewDepartment.SelectedRows[0].Cells["ColumnDepartmentId"].Value.ToString();

                    textBoxDepartmentName.ReadOnly = false;
                    buttonAddDepartment.Text = "Update";
                    buttonAddDepartment.Visible = true;
                }
            }
            catch
            {
                textBoxDepartmentName.Clear();
                textBoxDepartmentName.Tag = string.Empty;
                textBoxDepartmentName.ReadOnly = true;
                buttonAddDepartment.Visible = false;
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
                    textBoxClassName.Enabled = true;

                    comboBoxClassDepartment.Enabled = true;
                    comboBoxClassDepartment.Text= dataGridViewClass.SelectedRows[0].Cells["ColumnClassDepartment"].Value.ToString();

                    numericUpDownClassNumber.Enabled = true;
                    numericUpDownClassNumber.Text=dataGridViewClass.SelectedRows[0].Cells["ColumnClassNumber"].Value.ToString();

                    comboBoxTeacher.Enabled = true;
                    comboBoxTeacher.Text = dataGridViewClass.SelectedRows[0].Cells["teacher_name"].Value.ToString();

                    buttonAddNewClass.Text = "Cancel";
                    buttonClassUpdate.Text = "Update";
                    buttonClassUpdate.Visible = true;
                }
            }
            catch (Exception ex)
            {
                buttonAddNewClass.Text = "Add Class";
                comboBoxClassDepartment.Enabled = false;
                textBoxClassName.Enabled = false;
                textBoxClassName.Clear();
                numericUpDownClassNumber.Enabled = false;
                numericUpDownClassNumber.Text = "0";
                comboBoxTeacher.Enabled = false;
                buttonClassUpdate.Visible = false;
            }
        }
    }
}
