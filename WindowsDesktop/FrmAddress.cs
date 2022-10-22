using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop
{
    public partial class FrmAddress : Form
    {
        // Variable 
        private string _foreignKeyColumn;
        private string _foreignKeyValue;

        public FrmAddress()
        {
            InitializeComponent();
            
            LoadDivision();

            LoadThemeTemplate(panelAddress);
            LoadThemeTemplate(flowLayoutPanelAddress);
            LoadThemeTemplate(groupBoxAdd);
            ThemeTemplate.SPictureBox(panelAddress, BorderStyle.None);
            ThemeTemplate.SDataGridView(flowLayoutPanelAddress,BorderStyle.FixedSingle);
        }

        // Method

        private void LoadThemeTemplate(Control control)
        {
            ThemeTemplate.LoadTheme(control);
        }

        private void ClearField()
        {
            groupBoxAdd.Visible = false;

            _foreignKeyColumn = "";
            _foreignKeyValue = "";
            groupBoxAdd.Tag = "";
            buttonAdd.Tag = "";
            textBoxNameEnglish.Clear();
            textBoxNameBangla.Clear();

            groupBoxAdd.Location=new Point(3,4);
            groupBoxAdd.Size=new Size(362, 170);
        }
        
        private void ViewForEdit(string tableName, string id)
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
                    buttonAdd.Tag= hasData["id"].ToString();
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
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS bnen, name, name_bn FROM s_division ORDER BY name ASC";
                
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
                            "FROM s_district where division_id=" + dataGridViewDivision.Tag + " ORDER BY name ASC";

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
                            "FROM s_upazila where district_id=" + dataGridViewDistrict.Tag + " ORDER BY name ASC";

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
                            "FROM s_union where upazila_id=" + dataGridViewUpazila.Tag + " ORDER BY name ASC";

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
                            "FROM s_village where union_id=" + dataGridViewUnion.Tag + " ORDER BY name ASC";

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
            ClearField();
            groupBoxAdd.Text = "Add Division";
            buttonAdd.Text = "Add";
            groupBoxAdd.Tag = "s_divisions";
            _foreignKeyColumn = "";
            _foreignKeyValue = "";
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxAddDistrict_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Add District Under "+textBoxDivision.Text+" Division";
            buttonAdd.Text = "Add";
            groupBoxAdd.Tag = "s_districts";
            _foreignKeyColumn = "division_id";
            _foreignKeyValue = dataGridViewDivision.Tag.ToString();
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxAddUpazila_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Add Upazila Under " + textBoxDistrict.Text + " District";
            buttonAdd.Text = "Add";
            groupBoxAdd.Tag = "s_upazila";
            _foreignKeyColumn = "district_id";
            _foreignKeyValue = dataGridViewDistrict.Tag.ToString();
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxAddUnion_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Add Union Under " + textBoxUpazila.Text + " Upazila";
            buttonAdd.Text = "Add";
            groupBoxAdd.Tag = "s_union";
            _foreignKeyColumn = "upazila_id";
            _foreignKeyValue = dataGridViewUpazila.Tag.ToString();
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxAddVillage_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Add Village Under " + textBoxUnion.Text + " Union";
            buttonAdd.Text = "Add";
            groupBoxAdd.Tag = "s_village";
            _foreignKeyColumn = "union_id";
            _foreignKeyValue = dataGridViewUnion.Tag.ToString();
            groupBoxAdd.Visible = true;
        }

        private void iconPictureBoxUpdateDivision_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Update District";
            buttonAdd.Text = "Update";
            groupBoxAdd.Tag = "s_division";
            _foreignKeyColumn = "";
            _foreignKeyValue = "";
            groupBoxAdd.Visible = true;

            ViewForEdit("s_division", dataGridViewDivision.Tag.ToString());
        }

        private void iconPictureBoxUpdateDistrict_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Update District";
            buttonAdd.Text = "Update";
            groupBoxAdd.Tag = "s_district";
            _foreignKeyColumn = "division_id";
            _foreignKeyValue = dataGridViewDivision.Tag.ToString();
            groupBoxAdd.Visible = true;

            ViewForEdit("s_district", dataGridViewDistrict.Tag.ToString());
        }

        private void iconPictureBoxUpdateUpazila_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Update Upazila";
            buttonAdd.Text = "Update";
            groupBoxAdd.Tag = "s_upazila";
            _foreignKeyColumn = "district_id";
            _foreignKeyValue = dataGridViewDistrict.Tag.ToString();
            groupBoxAdd.Visible = true;

            ViewForEdit("s_upazila", dataGridViewUpazila.Tag.ToString());
        }

        private void iconPictureBoxUpdateUnion_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Update Union";
            buttonAdd.Text = "Update";
            groupBoxAdd.Tag = "s_union";
            _foreignKeyColumn = "upazila_id";
            _foreignKeyValue = dataGridViewUpazila.Tag.ToString();
            groupBoxAdd.Visible = true;

            ViewForEdit("s_union", dataGridViewUnion.Tag.ToString());
        }

        private void iconPictureBoxUpdateVillage_Click(object sender, EventArgs e)
        {
            ClearField();
            groupBoxAdd.Text = "Update Village";
            buttonAdd.Text = "Update";
            groupBoxAdd.Tag = "s_village";
            _foreignKeyColumn = "union_id";
            _foreignKeyValue = dataGridViewUnion.Tag.ToString();
            groupBoxAdd.Visible = true;

            ViewForEdit("s_village", dataGridViewVillage.Tag.ToString());
        }

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(groupBoxAdd, errorProviderAddress);

                if (isValid)
                {
                    var query = "";

                    var fkn = string.IsNullOrEmpty(_foreignKeyColumn) ? "" : _foreignKeyColumn + ",";
                    var fknu = string.IsNullOrEmpty(_foreignKeyColumn) ? "" : _foreignKeyColumn + "=";
                    var fkv=string.IsNullOrEmpty(_foreignKeyColumn) ? "" : _foreignKeyValue + ",";

                    switch (buttonAdd.Text)
                    {
                        case "Add":
                            query = "INSERT INTO " + groupBoxAdd.Tag + " (id, " + fkn + "name, name_bn) VALUES " +
                                    "((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM "+groupBoxAdd.Tag+")," + fkv + "'" +
                                    textBoxNameEnglish.Text.Trim() + "',N'" + textBoxNameBangla.Text + "')";
                            break;

                        case "Update":
                            query = "UPDATE " + groupBoxAdd.Tag + " SET " + fknu + fkv + " name='" + textBoxNameEnglish.Text.Trim() +
                                    "', name_bn=N'" + textBoxNameBangla.Text + "' WHERE id='" + buttonAdd.Tag + "'";
                            break;
                    }

                    var isExecute = Db.QueryExecute(query);
                    if (isExecute)
                    {
                        MessageBox.Show("Success...\nPlease change selected item and check again.");
                        ClearField();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
