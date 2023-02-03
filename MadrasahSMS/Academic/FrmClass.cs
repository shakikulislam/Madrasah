using System;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Academic
{
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();
            LoadTeacher(comboBoxTeacher);
            LoadClass();
            ThemeTemplate.LoadTheme(this);
            ThemeTemplate.LoadTheme(panelClassForm);
        }
        
        private void LoadTeacher(ComboBox comboBox)
        {
            var query = "select id, name from s_employee WHERE status='A'";
            var staffList = Db.GetDataTable(query);

            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = staffList;
        }

        private void LoadClass()
        {
            var query = "select c.id, c.name AS className, c.class_number as classNumber, " +
                        "e.name as teacher_name from s_class c " +
                        "left join s_employee e on c.teacher_id = e.id " +
                        "order by c.class_number asc";
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
                        query = "insert into s_class (id, name,class_number,teacher_id) values " +
                                "((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_CLASS),'" +
                                textBoxClassName.Text.Trim() + "','" + numericUpDownClassNumber.Text.Trim() +
                                "','" + comboBoxTeacher.SelectedValue + "')";
                    }
                    else if (buttonClassUpdate.Text == "Update")
                    {
                        query = "update s_class set name='" + textBoxClassName.Text.Trim() +
                                "', class_number='" + numericUpDownClassNumber.Text.Trim() +
                                "', teacher_id='" + comboBoxTeacher.SelectedValue +
                                "', update_by = '" + GlobalSettings.UserName +
                                "', update_date='" + DateTime.Now.ToString(GlobalSettings.DateFormatSave) +
                                "' where id = '" + textBoxClassName.Tag + "'";
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
