using System;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Academic
{
    public partial class FrmExam : Form
    {
        public FrmExam()
        {
            InitializeComponent();
            ThemeTemplate.LoadTheme(this);
            ThemeTemplate.SDataGridView(this);
            LoadExam();
        }

        private void ClearField()
        {
            textBoxExamName.Clear();
            textBoxExamName.Tag = string.Empty;
            numericUpDownEffectPersent.Text = "0";
            buttonCancel.Visible = false;
            buttonAdd.Text = "Add";
            checkBoxEffectOnFinal.Checked = false;
        }

        private void LoadExam()
        {
            var dt = Db.GetDataTable("SELECT * FROM s_exams");
            dataGridViewExamList.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(this, errorProviderExam);
                if (isValid)
                {
                    if ((checkBoxEffectOnFinal.Checked && Convert.ToDouble(numericUpDownEffectPersent.Text)>0) || checkBoxEffectOnFinal.Checked==false)
                    {
                        var query = string.Empty;
                        switch (buttonAdd.Text)
                        {
                            case "Add":
                                query="INSERT INTO s_exams (name, effect_on_final, effect_percent) VALUES('" +
                                      textBoxExamName.Text.Trim() + "'," + checkBoxEffectOnFinal.Checked + "," + numericUpDownEffectPersent.Text + ")";
                                break;
                            case "Update":
                                query = "UPDATE s_exams SET name='" + textBoxExamName.Text.Trim() + "', effect_on_final=" +
                                        checkBoxEffectOnFinal.Checked + ", effect_percent=" + numericUpDownEffectPersent.Text 
                                        + " WHERE id=" + textBoxExamName.Tag + "";
                                break;
                        }
                    
                        var isSave = Db.QueryExecute(query);
                        if (isSave)
                        {
                            textBoxExamName.Clear();
                            LoadExam();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Effect Value");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewExamList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewExamList.Rows[e.RowIndex].Cells[ColumnSl.Index].Value = (e.RowIndex + 1).ToString();
        }

        private void checkBoxEffectOnFinal_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownEffectPersent.Enabled = checkBoxEffectOnFinal.Checked;
            numericUpDownEffectPersent.Text = "0";
        }

        private void dataGridViewExamList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewExamList.Rows.Count>0)
                {
                    textBoxExamName.Tag = dataGridViewExamList.SelectedRows[0].Cells[ColumnId.Index].Value.ToString();
                    textBoxExamName.Text = dataGridViewExamList.SelectedRows[0].Cells[ColumnName.Index].Value.ToString();
                    checkBoxEffectOnFinal.Checked = Convert.ToBoolean(dataGridViewExamList.SelectedRows[0].Cells[ColumnEffectFinal.Index].Value);
                    numericUpDownEffectPersent.Text = dataGridViewExamList.SelectedRows[0].Cells[ColumnEffectPercent.Index].Value.ToString();

                    buttonAdd.Text = "Update";
                    buttonCancel.Visible = true;
                }
                else
                {
                    ClearField();
                }
            }
            catch (Exception ex)
            {

                ClearField();
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
