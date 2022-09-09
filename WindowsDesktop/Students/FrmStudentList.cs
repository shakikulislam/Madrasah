﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.SLabel(control);
            ThemeTemplate.STextBox(control);
            ThemeTemplate.SIconButton(control,0);
            ThemeTemplate.SDataGridView(control);
        }

        private void LoadColumn()
        {
            var dg = dataGridViewStudentList;
            dg.DataSource = null;

            int totalColumn = 5;
            dg.ColumnCount = totalColumn;

            dg.Columns[0].Name = "sl";
            dg.Columns[0].HeaderText = "#";
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].Name = "id";
            dg.Columns[1].HeaderText = "ID";
            dg.Columns[1].DataPropertyName = "id";
            dg.Columns[1].Visible = false;
            dg.Columns[2].Name = "roll";
            dg.Columns[2].DataPropertyName = "roll";
            dg.Columns[2].HeaderText = "Roll";
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].Name = "name";
            dg.Columns[3].DataPropertyName = "name";
            dg.Columns[3].HeaderText = "Name";
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].Name = "class_name";
            dg.Columns[4].DataPropertyName = "class_name";
            dg.Columns[4].HeaderText = "Class";
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                //LoadColumn();   
                
                var query = "";
                if (string.IsNullOrEmpty(textBoxSearch.Text))
                {
                    query = "SELECT st.*, cs.name AS class_name " +
                            "FROM s_students st " +
                            "LEFT JOIN s_classes cs ON st.class_id=cs.id";
                }
                else
                {
                    query = "SELECT * FROM s_students WHERE roll='" + textBoxSearch.Text + "' OR reg='" +
                            textBoxSearch.Text + "' OR name LIKE '%" + textBoxSearch.Text + "%'";
                }

                var studentSet = Db.GetDataTable(query);
                dataGridViewStudentList.DataSource = studentSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudentList.Columns[e.ColumnIndex].Name=="Edit")
            {
                MessageBox.Show("Edit\n" + dataGridViewStudentList.SelectedRows[0].Cells[5].Value);
            }
            else if (dataGridViewStudentList.Columns[e.ColumnIndex].Name == "Delete")
            {
                MessageBox.Show("Delete\n" + dataGridViewStudentList.SelectedRows[0].Cells[6].Value);
            }
        }

        private void dataGridViewStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewStudentList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
