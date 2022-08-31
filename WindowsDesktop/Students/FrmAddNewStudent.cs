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

            LoadDivision(comboBoxPreAddressDivision);
            LoadDivision(comboBoxPerAddressDivision);
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.SLabel(control);
            ThemeTemplate.SLinkLabel(control);
            ThemeTemplate.STextBox(control);
            ThemeTemplate.SRichTextBox(control);
            ThemeTemplate.SButton(control);
            ThemeTemplate.SDateTimePicker(control);
            ThemeTemplate.SComboBox(control);
        }

        private void LoadDivision(ComboBox comboBox)
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name FROM s_divisions ORDER BY name ASC";
                comboBox.DataSource = null;
                comboBox.DisplayMember = "name";
                comboBox.ValueMember = "id";
                comboBox.DataSource = Db.GetDataTable(query);
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
                
                LoadDistrict(comboBoxPreAddressDistrict,comboBoxPreAddressDivision.SelectedValue.ToString());
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

                LoadUpazila(comboBoxPreAddressUpazila, comboBoxPreAddressDistrict.SelectedValue.ToString());
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

                LoadUnion(comboBoxPreAddressUnion, comboBoxPreAddressUpazila.SelectedValue.ToString());
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

                LoadVillage(comboBoxPreAddressVillage, comboBoxPreAddressUnion.SelectedValue.ToString());
            }
            catch
            {
                comboBoxPreAddressVillage.DataSource = null;
            }
        }
    }
}
