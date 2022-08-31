using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Students
{
    public partial class FrmAddNewStudent : Form
    {
        public FrmAddNewStudent()
        {
            InitializeComponent();

            dateTimePickerDob.MaxDate=DateTime.Now;

            LoadTheme(groupBoxPersonalInformation);

            LoadDivision();
        }

        private static void LoadTheme(Control control)
        {
            ThemeTemplate.SLabel(control);
            ThemeTemplate.SLinkLabel(control);
            ThemeTemplate.STextBox(control);
            ThemeTemplate.SRichTextBox(control);
            ThemeTemplate.SButton(control);
            ThemeTemplate.SDateTimePicker(control);
            ThemeTemplate.SComboBox(control);
        }

        private void LoadDivision()
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name FROM s_divisions ORDER BY name ASC";
                var dt= Db.GetDataTable(query);

                comboBoxPreAddressDivision.DataSource = null;
                comboBoxPreAddressDivision.DisplayMember = "name";
                comboBoxPreAddressDivision.ValueMember = "id";
                comboBoxPreAddressDivision.DataSource = dt;

                comboBoxPerAddressDivision.DataSource = null;
                comboBoxPerAddressDivision.DisplayMember = "name";
                comboBoxPerAddressDivision.ValueMember = "id";
                comboBoxPerAddressDivision.DataSource = dt;

                comboBoxGrdAddressDivision.DataSource = null;
                comboBoxGrdAddressDivision.DisplayMember = "name";
                comboBoxGrdAddressDivision.ValueMember = "id";
                comboBoxGrdAddressDivision.DataSource = dt;
            }
            catch
            {
                //
            }
        }

        private void LoadDistrict(ComboBox comboBox, string divisionId)
        {
            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_districts where division_id=" + divisionId + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadUpazila(ComboBox comboBox, string districtId)
        {
            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_upazilas where district_id=" + districtId + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadUnion(ComboBox comboBox, string upazilaId)
        {
            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_unions where upazila_id=" + upazilaId + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadVillage(ComboBox comboBox, string unionId)
        {
            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_villages where union_id=" + unionId + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void buttonSavePersonalInfo_Click(object sender, EventArgs e)
        {
            groupBoxPersonalInformation.Visible = false;
            groupBoxAddress.Size = new Size(594, 619);
            groupBoxAddress.Location = groupBoxPersonalInformation.Location;
            groupBoxAddress.Anchor = AnchorStyles.Top;
            
            LoadTheme(groupBoxAddress);

            labelAddressName.Text = textBoxFullName.Text + " (" + textBoxNameBangla.Text + ")";
            labelAddressName.Font = new Font(STheme.SFont.Font, 12, FontStyle.Bold);

            groupBoxAddress.Visible = true;
        }

        private void buttonAcademicBack_Click(object sender, EventArgs e)
        {
            groupBoxAcademicInformation.Visible = false;
            groupBoxGuardianInformation.Visible = true;
        }

        private void buttonAcademicNext_Click(object sender, EventArgs e)
        {
            groupBoxAcademicInformation.Visible = false;
        }

        private void buttonGuardianBack_Click(object sender, EventArgs e)
        {
            groupBoxGuardianInformation.Visible = false;
            groupBoxAddress.Visible = true;
        }

        private void buttonGuardianNext_Click(object sender, EventArgs e)
        {
            groupBoxGuardianInformation.Visible = false;
            groupBoxAcademicInformation.Size = new Size(594, 260);
            groupBoxAcademicInformation.Location = groupBoxPersonalInformation.Location;
            groupBoxAcademicInformation.Anchor = AnchorStyles.Top;

            LoadTheme(groupBoxAcademicInformation);

            labelAcademicStudentName.Text = textBoxFullName.Text + " (" + textBoxNameBangla.Text + ")";
            labelAcademicStudentName.Font = new Font(STheme.SFont.Font, 12, FontStyle.Bold);

            groupBoxAcademicInformation.Visible = true;
        }

        private void buttonAddressBack_Click(object sender, EventArgs e)
        {
            groupBoxAddress.Visible = false;
            groupBoxPersonalInformation.Visible = true;
        }

        private void buttonAddressNext_Click(object sender, EventArgs e)
        {
            groupBoxAddress.Visible = false;
            groupBoxGuardianInformation.Size = new Size(594, 619);
            groupBoxGuardianInformation.Location = groupBoxPersonalInformation.Location;
            groupBoxGuardianInformation.Anchor = AnchorStyles.Top;

            LoadTheme(groupBoxGuardianInformation);

            labelGuardianInfoName.Text = textBoxFullName.Text + " (" + textBoxNameBangla.Text + ")";
            labelGuardianInfoName.Font = new Font(STheme.SFont.Font, 12, FontStyle.Bold);

            groupBoxGuardianInformation.Visible = true;
        }

        private void comboBoxPreAddressDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxPreAddressDistrict.DataSource = null;
                comboBoxPreAddressUpazila.DataSource = null;
                comboBoxPreAddressUnion.DataSource = null;
                comboBoxPreAddressVillage.DataSource = null;

                var id = comboBoxPreAddressDivision.SelectedValue == null
                    ? "0"
                    : comboBoxPreAddressDivision.SelectedValue.ToString();
                LoadDistrict(comboBoxPreAddressDistrict,id);
            }
            catch
            {
                comboBoxPreAddressDistrict.DataSource = null;
                comboBoxPreAddressUpazila.DataSource = null;
                comboBoxPreAddressUnion.DataSource = null;
                comboBoxPreAddressVillage.DataSource = null;
            }
        }

        private void comboBoxPreAddressDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxPreAddressUpazila.DataSource = null;
                comboBoxPreAddressUnion.DataSource = null;
                comboBoxPreAddressVillage.DataSource = null;

                var id = comboBoxPreAddressDistrict.SelectedValue == null
                    ? "0"
                    : comboBoxPreAddressDistrict.SelectedValue.ToString();
                LoadUpazila(comboBoxPreAddressUpazila, id);
            }
            catch
            {
                comboBoxPreAddressUpazila.DataSource = null;
                comboBoxPreAddressUnion.DataSource = null;
                comboBoxPreAddressVillage.DataSource = null;
            }
        }

        private void comboBoxPreAddressUpazila_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxPreAddressUnion.DataSource = null;
                comboBoxPreAddressVillage.DataSource = null;
                var id = comboBoxPreAddressUpazila.SelectedValue == null
                    ? "0"
                    : comboBoxPreAddressUpazila.SelectedValue.ToString();
                LoadUnion(comboBoxPreAddressUnion, id);
            }
            catch
            {
                comboBoxPreAddressUnion.DataSource = null;
                comboBoxPreAddressVillage.DataSource = null;
            }
        }

        private void comboBoxPreAddressUnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxPreAddressVillage.DataSource = null;
                var id = comboBoxPreAddressUnion.SelectedValue == null
                    ? "0"
                    : comboBoxPreAddressUnion.SelectedValue.ToString();
                LoadVillage(comboBoxPreAddressVillage, id);
            }
            catch (Exception)
            {
                comboBoxPreAddressVillage.DataSource = null;
            }
        }

        private void comboBoxPreAddressVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {
                //
            }
        }

        private void comboBoxPerAddressDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxPerAddressDistrict.DataSource = null;
                comboBoxPerAddressUpazila.DataSource = null;
                comboBoxPerAddressUnion.DataSource = null;
                comboBoxPerAddressVillage.DataSource = null;

                var id = comboBoxPerAddressDivision.SelectedValue == null
                    ? "0"
                    : comboBoxPerAddressDivision.SelectedValue.ToString();
                LoadDistrict(comboBoxPerAddressDistrict, id);
            }
            catch
            {
                comboBoxPerAddressDistrict.DataSource = null;
                comboBoxPerAddressUpazila.DataSource = null;
                comboBoxPerAddressUnion.DataSource = null;
                comboBoxPerAddressVillage.DataSource = null;
            }
        }

        private void comboBoxPerAddressDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxPerAddressUpazila.DataSource = null;
                comboBoxPerAddressUnion.DataSource = null;
                comboBoxPerAddressVillage.DataSource = null;

                var id = comboBoxPerAddressDistrict.SelectedValue == null
                    ? "0"
                    : comboBoxPerAddressDistrict.SelectedValue.ToString();
                LoadUpazila(comboBoxPerAddressUpazila, id);
            }
            catch
            {
                comboBoxPerAddressUpazila.DataSource = null;
                comboBoxPerAddressUnion.DataSource = null;
                comboBoxPerAddressVillage.DataSource = null;
            }
        }

        private void comboBoxPerAddressUpazila_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxPerAddressUnion.DataSource = null;
                comboBoxPerAddressVillage.DataSource = null;
                var id = comboBoxPerAddressUpazila.SelectedValue == null
                    ? "0"
                    : comboBoxPerAddressUpazila.SelectedValue.ToString();
                LoadUnion(comboBoxPerAddressUnion, id);
            }
            catch
            {
                comboBoxPerAddressUnion.DataSource = null;
                comboBoxPerAddressVillage.DataSource = null;
            }
        }

        private void comboBoxPerAddressUnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxPerAddressVillage.DataSource = null;
                var id = comboBoxPerAddressUnion.SelectedValue == null
                    ? "0"
                    : comboBoxPerAddressUnion.SelectedValue.ToString();
                LoadVillage(comboBoxPerAddressVillage, id);
            }
            catch (Exception)
            {
                comboBoxPerAddressVillage.DataSource = null;
            }
        }

        private void comboBoxPerAddressVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                //
            }
        }

        private void comboBoxGrdAddressDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxGrdAddressDistrict.DataSource = null;
                comboBoxGrdAddressUpazila.DataSource = null;
                comboBoxGrdAddressUnion.DataSource = null;
                comboBoxGrdAddressVillage.DataSource = null;

                var id = comboBoxGrdAddressDivision.SelectedValue == null
                    ? "0"
                    : comboBoxGrdAddressDivision.SelectedValue.ToString();
                LoadDistrict(comboBoxGrdAddressDistrict, id);
            }
            catch
            {
                comboBoxGrdAddressDistrict.DataSource = null;
                comboBoxGrdAddressUpazila.DataSource = null;
                comboBoxGrdAddressUnion.DataSource = null;
                comboBoxGrdAddressVillage.DataSource = null;
            }
        }

        private void comboBoxGrdAddressDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxGrdAddressUpazila.DataSource = null;
                comboBoxGrdAddressUnion.DataSource = null;
                comboBoxGrdAddressVillage.DataSource = null;

                var id = comboBoxGrdAddressDistrict.SelectedValue == null
                    ? "0"
                    : comboBoxGrdAddressDistrict.SelectedValue.ToString();
                LoadUpazila(comboBoxGrdAddressUpazila, id);
            }
            catch
            {
                comboBoxGrdAddressUpazila.DataSource = null;
                comboBoxGrdAddressUnion.DataSource = null;
                comboBoxGrdAddressVillage.DataSource = null;
            }
        }

        private void comboBoxGrdAddressUpazila_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxGrdAddressUnion.DataSource = null;
                comboBoxGrdAddressVillage.DataSource = null;
                var id = comboBoxGrdAddressUpazila.SelectedValue == null
                    ? "0"
                    : comboBoxGrdAddressUpazila.SelectedValue.ToString();
                LoadUnion(comboBoxGrdAddressUnion, id);
            }
            catch
            {
                comboBoxGrdAddressUnion.DataSource = null;
                comboBoxGrdAddressVillage.DataSource = null;
            }
        }

        private void comboBoxGrdAddressUnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxGrdAddressVillage.DataSource = null;
                var id = comboBoxGrdAddressUnion.SelectedValue == null
                    ? "0"
                    : comboBoxGrdAddressUnion.SelectedValue.ToString();
                LoadVillage(comboBoxGrdAddressVillage, id);
            }
            catch (Exception)
            {
                comboBoxGrdAddressVillage.DataSource = null;
            }
        }

        private void comboBoxGrdAddressVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                //
            }
        }
    }
}
