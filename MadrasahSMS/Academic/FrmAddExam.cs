using System;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Academic
{
    public partial class FrmAddExam : Form
    {
        public FrmAddExam()
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
            checkBoxFinal.Checked = false;
        }

        private void LoadExam()
        {
            ClearField();
            var dt = Db.GetTable("SELECT * FROM S_EXAM");
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
                        if (buttonAdd.Text == "Add")
                        {
                            query = "INSERT INTO S_EXAM (ID, NAME, EFFECT_ON_FINAL, EFFECT_PERCENT, IS_FINAL) " +
                                    "VALUES((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_EXAM),N'" +
                                    textBoxExamName.Text.Trim() + "','" + checkBoxEffectOnFinal.Checked + "'," +
                                    numericUpDownEffectPersent.Text;

                            if (checkBoxFinal.Checked)
                            {
                                if (Db.HasExisted("SELECT * FROM S_EXAM WHERE IS_FINAL = 1"))
                                {
                                    MessageBox.Show(ContentText.FinalExamAlreadyExist);
                                    return;
                                }
                                else
                                {
                                    query += ", IS_FINAL = 1";
                                }
                            }
                            else
                            {
                                query += ", IS_FINAL = 0";
                            }

                        }
                        else if (buttonAdd.Text == "Update")
                        {
                            query = "UPDATE S_EXAM SET NAME=N'" + textBoxExamName.Text.Trim() +
                                    "', EFFECT_ON_FINAL='" + checkBoxEffectOnFinal.Checked +
                                    "', EFFECT_PERCENT=" + numericUpDownEffectPersent.Text;

                            if (checkBoxFinal.Checked)
                            {
                                var dg = dataGridViewExamList.SelectedRows[0];
                                var query1 = "SELECT * FROM S_EXAM WHERE IS_FINAL=1 ";
                                query1 += Convert.ToBoolean(dg.Cells[ColumnIsFinal.Index].Value)
                                    ? " AND ID!=" + dg.Cells[ColumnId.Index].Value
                                    : "";
                                if (Db.HasExisted(query1))
                                {
                                    MessageBox.Show(ContentText.FinalExamAlreadyExist);
                                    return;
                                }
                                else
                                {
                                    query += ", IS_FINAL = 1";
                                }
                            }
                            else
                            {
                                query += ", IS_FINAL = 0";
                            }

                            query += " WHERE ID = " + textBoxExamName.Tag;
                        }

                        var isSave = Db.QueryExecute(query);
                        if (isSave)
                        {
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
                    checkBoxFinal.Checked = Convert.ToBoolean(dataGridViewExamList.SelectedRows[0].Cells[ColumnIsFinal.Index].Value);

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

        private void checkBoxFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFinal.Checked)
            {
                checkBoxEffectOnFinal.Checked = false;
                checkBoxEffectOnFinal.Enabled = false;
            }
            else
            {
                checkBoxEffectOnFinal.Enabled = true;
            }
        }
    }
}
