﻿using System;
using System.Data;
using System.Windows.Forms;
using WindowsDesktop.DbContext;

namespace WindowsDesktop
{
    public partial class FrmAddress : Form
    {
        // Variable 
        private string _division_id;
        private string _district_id;
        private string _upazila_id;
        private string _union_id;

        public FrmAddress()
        {
            InitializeComponent();

            LoadDivision();
        }

        // Method

        private void LoadDivision()
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn FROM s_divisions ORDER BY name ASC";
                
                dataGridViewDivision.DataSource = Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadDistrict(int id=0)
        {
            try
            {
                dataGridViewDivision.Tag = string.Empty;
                dataGridViewDistrict.Tag = string.Empty;
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;

                textBoxDivision.Text = string.Empty;
                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;

                dataGridViewDivision.Tag = dataGridViewDivision.SelectedRows[0].Cells["ColumnDivisionId"].Value;

                textBoxDivision.Text = dataGridViewDivision.SelectedRows[0].Cells["ColumnDivisionName"].Value.ToString();

                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn " +
                            "FROM s_districts where division_id=" + id + " ORDER BY name ASC";

                dataGridViewDistrict.DataSource = Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                dataGridViewDivision.Tag = string.Empty;
                dataGridViewDistrict.Tag = string.Empty;
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;

                textBoxDivision.Text = string.Empty;
                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;

                MessageBox.Show(ex.ToString());
            }
        }
        
        private void LoadUpazila(int id=0)
        {
            try
            {
                dataGridViewDistrict.Tag = string.Empty;
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;

                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;

                dataGridViewDistrict.Tag = dataGridViewDistrict.SelectedRows[0].Cells["ColumnDistrictId"].Value;

                textBoxDistrict.Text = dataGridViewDistrict.SelectedRows[0].Cells["ColumnDistrictName"].Value.ToString();

                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn " +
                            "FROM s_upazilas where district_id=" + id + " ORDER BY name ASC";

                dataGridViewDistrict.DataSource = Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                dataGridViewDistrict.Tag = string.Empty;
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;

                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;

                MessageBox.Show(ex.ToString());
            }
        }

        private void listViewDivision_Click(object sender, EventArgs e)
        {
            try
            {
                _division_id = listViewDivision.SelectedItems[0].Tag.ToString();
                textBoxDivision.Text = listViewDivision.SelectedItems[0].SubItems[0].Text;
                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;

                var query = "select * from s_districts where division_id="+_division_id+" order by name asc";
                var list = Db.GetDataTable(query);

                listViewDistrict.Items.Clear();
                listViewUpazila.Items.Clear();
                listViewUnion.Items.Clear();

                foreach (DataRow row in list.Rows)
                {
                    var lvi = new ListViewItem(row["name"] + " (" + row["name_bn"] + ")");
                    lvi.Tag = row["id"].ToString();

                    listViewDistrict.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                _division_id = "";
                _district_id = "";
                _upazila_id = "";
                _union_id = "";

                textBoxDivision.Text = string.Empty;
                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;

                MessageBox.Show(ex.ToString());
            }
        }

        private void listViewDistrict_Click(object sender, EventArgs e)
        {
            try
            {
                _district_id = listViewDistrict.SelectedItems[0].Tag.ToString();
                textBoxDistrict.Text = listViewDistrict.SelectedItems[0].SubItems[0].Text;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;

                var query = "select * from s_upazilas where district_id=" + _district_id + " order by name asc";
                var list = Db.GetDataTable(query);

                listViewUpazila.Items.Clear();
                listViewUnion.Items.Clear();

                foreach (DataRow row in list.Rows)
                {
                    var lvi = new ListViewItem(row["name"] + " (" + row["name_bn"] + ")");
                    lvi.Tag = row["id"].ToString();

                    listViewUpazila.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                _district_id = "";
                _upazila_id = "";
                _union_id = "";

                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;

                MessageBox.Show(ex.ToString());
            }
        }

        private void listViewUpazila_Click(object sender, EventArgs e)
        {
            try
            {
                _upazila_id = listViewUpazila.SelectedItems[0].Tag.ToString();
                textBoxUpazila.Text = listViewUpazila.SelectedItems[0].SubItems[0].Text;
                textBoxUnion.Text = string.Empty;

                var query = "select * from s_unions where upazilla_id =" + _upazila_id + " order by name asc";
                var list = Db.GetDataTable(query);

                listViewUnion.Items.Clear();

                foreach (DataRow row in list.Rows)
                {
                    var lvi = new ListViewItem(row["name"] + " (" + row["name_bn"] + ")");
                    lvi.Tag = row["id"].ToString();

                    listViewUnion.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                _upazila_id = "";
                _union_id = "";

                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;
                MessageBox.Show(ex.ToString());
            }
        }

        private void listViewUnion_Click(object sender, EventArgs e)
        {
            try
            {
                _union_id = listViewUnion.SelectedItems[0].Tag.ToString();
                textBoxUnion.Text = listViewUnion.SelectedItems[0].SubItems[0].Text;
            }
            catch (Exception ex)
            {
                _union_id = "";
                textBoxUnion.Text = string.Empty;
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewDivision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDistrict(Convert.ToInt32(dataGridViewDivision.Tag));
        }

        private void dataGridViewDistrict_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadUpazila(Convert.ToInt32(dataGridViewDistrict.Tag));
        }
    }
}
