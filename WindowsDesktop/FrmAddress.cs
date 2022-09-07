using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

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

            LoadThemeTemplate(panelAddress);
            LoadThemeTemplate(flowLayoutPanelAddress);
            LoadThemeTemplate(groupBoxAdd);
        }

        // Method

        private void LoadThemeTemplate(Control control)
        {
            ThemeTemplate.SLabel(control);
            ThemeTemplate.STextBox(control);
            ThemeTemplate.SDataGridView(control);
            ThemeTemplate.SButton(control);
        }

        private void GedAddressById(string tableName, string id)
        {
            try
            {
                var query = "select * from " + tableName + " where id=" + id;
                var hasData = Db.GetDataReader(query);
                if (hasData.HasRows)
                {
                    hasData.Read();
                    textBoxNameEnglish.Text = hasData["name"].ToString();
                    textBoxNameBangla.Text = hasData["name_bn"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadDivision()
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn FROM s_divisions ORDER BY name ASC";
                
                dataGridViewDivision.DataSource = Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewDivision_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDivision.Tag = string.Empty;
                dataGridViewDistrict.Tag = string.Empty;
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;
                dataGridViewVillage.Tag = string.Empty;

                textBoxDivision.Text = string.Empty;
                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;
                textBoxVillage.Text = string.Empty;

                dataGridViewDivision.Tag = dataGridViewDivision.SelectedRows[0].Cells["ColumnDivisionId"].Value;

                textBoxDivision.Text = dataGridViewDivision.SelectedRows[0].Cells["ColumnDivisionName"].Value.ToString();

                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn " +
                            "FROM s_districts where division_id=" + dataGridViewDivision.Tag + " ORDER BY name ASC";

                dataGridViewDistrict.DataSource = Db.GetDataTable(query);
            }
            catch
            {
                dataGridViewDivision.Tag = string.Empty;
                dataGridViewDistrict.Tag = string.Empty;
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;
                dataGridViewVillage.Tag = string.Empty;

                textBoxDivision.Text = string.Empty;
                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;
                textBoxVillage.Text = string.Empty;

                //MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewDistrict_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDistrict.Tag = string.Empty;
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;
                dataGridViewVillage.Tag = string.Empty;

                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;
                textBoxVillage.Text = string.Empty;

                dataGridViewDistrict.Tag = dataGridViewDistrict.SelectedRows[0].Cells["ColumnDistrictId"].Value;

                textBoxDistrict.Text = dataGridViewDistrict.SelectedRows[0].Cells["ColumnDistrictName"].Value.ToString();

                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn " +
                            "FROM s_upazilas where district_id=" + dataGridViewDistrict.Tag + " ORDER BY name ASC";

                dataGridViewUpazila.DataSource = Db.GetDataTable(query);
            }
            catch
            {
                dataGridViewDistrict.Tag = string.Empty;
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;
                dataGridViewVillage.Tag = string.Empty;

                textBoxDistrict.Text = string.Empty;
                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;
                textBoxVillage.Text = string.Empty;
            }
        }

        private void dataGridViewUpazila_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;
                dataGridViewVillage.Tag = string.Empty;

                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;
                textBoxVillage.Text = string.Empty;

                dataGridViewUpazila.Tag = dataGridViewUpazila.SelectedRows[0].Cells["ColumnUpazilaId"].Value;

                textBoxUpazila.Text = dataGridViewUpazila.SelectedRows[0].Cells["ColumnUpazilaName"].Value.ToString();

                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn " +
                            "FROM s_unions where upazila_id=" + dataGridViewUpazila.Tag + " ORDER BY name ASC";

                dataGridViewUnion.DataSource = Db.GetDataTable(query);
            }
            catch
            {
                dataGridViewUpazila.Tag = string.Empty;
                dataGridViewUnion.Tag = string.Empty;
                dataGridViewVillage.Tag = string.Empty;

                textBoxUpazila.Text = string.Empty;
                textBoxUnion.Text = string.Empty;
                textBoxVillage.Text = string.Empty;
            }
        }

        private void dataGridViewUnion_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewUnion.Tag = string.Empty;
                dataGridViewVillage.Tag = string.Empty;

                textBoxUnion.Text = string.Empty;
                textBoxVillage.Text = string.Empty;

                dataGridViewUnion.Tag = dataGridViewUnion.SelectedRows[0].Cells["ColumnUnionId"].Value;

                textBoxUnion.Text = dataGridViewUnion.SelectedRows[0].Cells["ColumnUnionName"].Value.ToString();

                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn " +
                            "FROM s_villages where union_id=" + dataGridViewUnion.Tag + " ORDER BY name ASC";

                dataGridViewVillage.DataSource = Db.GetDataTable(query);
            }
            catch
            {
                dataGridViewUnion.Tag = string.Empty;
                dataGridViewVillage.Tag = string.Empty;

                textBoxUnion.Text = string.Empty;
                textBoxVillage.Text = string.Empty;
            }
        }

        private void dataGridViewVillage_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewVillage.Tag = string.Empty;
                textBoxVillage.Text = string.Empty;

                dataGridViewVillage.Tag = dataGridViewVillage.SelectedRows[0].Cells["ColumnVillageId"].Value;
                textBoxVillage.Text = dataGridViewVillage.SelectedRows[0].Cells["ColumnVillageName"].Value.ToString();
            }
            catch
            {
                dataGridViewVillage.Tag = string.Empty;
                textBoxVillage.Text = string.Empty;
            }
        }

        private void iconPictureBoxAddDivision_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Add Division";
            buttonAdd.Text = "Add";
            groupBoxAdd.Visible = true;

            GedAddressById("s_divisions", dataGridViewDivision.Tag.ToString());
        }

        private void iconPictureBoxAddDistrict_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Add District";
            buttonAdd.Text = "Add";
            groupBoxAdd.Visible = true;

        }

        private void iconPictureBoxAddUpazila_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Add Upazila";
            buttonAdd.Text = "Add";
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxAddUnion_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Add Union";
            buttonAdd.Text = "Add";
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxAddVillage_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Add Village";
            buttonAdd.Text = "Add";
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxUpdateDivision_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Update District";
            buttonAdd.Text = "Update";
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxUpdateDistrict_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Update District";
            buttonAdd.Text = "Update";
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxUpdateUpazila_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Update Upazila";
            buttonAdd.Text = "Update";
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxUpdateUnion_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Update Union";
            buttonAdd.Text = "Update";
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxUpdateVillage_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxAdd.Text = "Update Village";
            buttonAdd.Text = "Update";
            groupBoxAdd.Visible = true;
        }

    }
}
