using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
using WindowsDesktop.Properties;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Staff
{
    public partial class FrmAddNewStaff : Form
    {
        public FrmAddNewStaff()
        {
            InitializeComponent();

            dateTimePickerDob.MaxDate=DateTime.Now;
            
            LoadDivision();
        }

        private static void LoadTheme(Control control)
        {
            ThemeTemplate.LoadTheme(control);
        }
        
        private void LoadDesignation()
        {
            try
            {
                var query = "SELECT id, name FROM s_employee_designation WHERE name <> 'SA' ORDER BY number ASC";
                var desigList = Db.GetDataTable(query);

                comboBoxDesignation.ValueMember = "id";
                comboBoxDesignation.DisplayMember = "name";
                comboBoxDesignation.DataSource = desigList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetLocation(Control control, int y=50)
        {
            foreach (var box in Controls.OfType<GroupBox>())
            {
                box.Visible = false;
            }

            var x = (this.Width / 2) - (control.Width / 2);
            control.Location = new Point(x, y);
            control.Anchor = AnchorStyles.Top;
            control.Visible = true;
        }

        private void ClearAllField()
        {
            ClearReviewField();
            
            labelFullName.Text = string.Empty;
            labelFullName.Tag = string.Empty;
            textBoxFullName.Clear();
            textBoxPhone.Clear();
            textBoxNid.Clear();
            dateTimePickerReviewDob.Value=DateTime.Now;

            textBoxPreAddressDetails.Clear();
            textBoxPerAddressDetails.Clear();

            checkBoxSameAsPresentAddress.Enabled = false;

        }

        private void ClearReviewField()
        {
            // Set data
            // Personal Information
            textBoxReviewFullName.Clear();
            textBoxReviewPhone.Clear();
            //textBoxReviewBirthCertificeate.Clear();
            textBoxReviewNid.Clear();
            dateTimePickerReviewDob.Value = DateTime.Now;

            // Present Address
            comboBoxReviewPreDivision.DataSource = null;
            comboBoxReviewPreDivision.DisplayMember = "name";
            comboBoxReviewPreDivision.ValueMember = "id";

            comboBoxReviewPreDistrict.DataSource = null;
            comboBoxReviewPreDistrict.DisplayMember="name";
            comboBoxReviewPreDistrict.ValueMember="id";

            comboBoxReviewPreUpazila.DataSource = null;
            comboBoxReviewPreUpazila.DisplayMember = "name";
            comboBoxReviewPreUpazila.ValueMember = "id";

            comboBoxReviewPreUnion.DataSource = null;
            comboBoxReviewPreUnion.DisplayMember = "name";
            comboBoxReviewPreUnion.ValueMember = "id";

            comboBoxReviewPreVillage.DataSource = null;
            comboBoxReviewPreVillage.DisplayMember = "name";
            comboBoxReviewPreVillage.ValueMember = "id";

            textBoxReviewPreDetails.Clear();

            // Permanent Address
            comboBoxReviewPerDivision.DataSource = null;
            comboBoxReviewPerDivision.DisplayMember = "name";
            comboBoxReviewPerDivision.ValueMember = "id";

            comboBoxReviewPerDistrict.DataSource = null;
            comboBoxReviewPerDistrict.DisplayMember = "name";
            comboBoxReviewPerDistrict.ValueMember = "id";

            comboBoxReviewPerUpazila.DataSource = null;
            comboBoxReviewPerUpazila.DisplayMember = "name";
            comboBoxReviewPerUpazila.ValueMember = "id";

            comboBoxReviewPerUnion.DataSource = null;
            comboBoxReviewPerUnion.DisplayMember = "name";
            comboBoxReviewPerUnion.ValueMember = "id";

            comboBoxReviewPerVillage.DataSource = null;
            comboBoxReviewPerVillage.DisplayMember = "name";
            comboBoxReviewPerVillage.ValueMember = "id";

            textBoxReviewPerDetails.Clear();
            pictureBoxStaff.Image = Resources.no_person_image;
            pictureBoxReviewStaffImg.Image = Resources.no_person_image;

        }
        
        private void LoadDivision()
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name FROM s_division ORDER BY name ASC";
                
                var dtPreAddressDivision = Db.GetDataTable(query);
                comboBoxPreAddressDivision.DataSource = null;
                comboBoxPreAddressDivision.DisplayMember = "name";
                comboBoxPreAddressDivision.ValueMember = "id";
                comboBoxPreAddressDivision.DataSource = dtPreAddressDivision;

                var dtPerAddressDivision = Db.GetDataTable(query);
                comboBoxPerAddressDivision.DataSource = null;
                comboBoxPerAddressDivision.DisplayMember = "name";
                comboBoxPerAddressDivision.ValueMember = "id";
                comboBoxPerAddressDivision.DataSource = dtPerAddressDivision;
            }
            catch
            {
                //
            }
        }

        private void LoadDistrict(ComboBox comboBox, string divisionId)
        {
            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_district where division_id=" + divisionId + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadUpazila(ComboBox comboBox, string districtId)
        {
            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_upazila where district_id=" + districtId + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadUnion(ComboBox comboBox, string upazilaId)
        {
            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_union where upazila_id=" + upazilaId + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadVillage(ComboBox comboBox, string unionId)
        {
            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_village where union_id=" + unionId + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void buttonSavePersonalInfo_Click(object sender, EventArgs e)
        {
            try
            {
                labelFullName.Text = textBoxFullName.Text;
                // Load Theme
                groupBoxAddress.Size = new Size(594, 619);
                groupBoxAddress.Location = groupBoxStaffInformation.Location;
                groupBoxAddress.Anchor = AnchorStyles.Top;

                LoadTheme(groupBoxAddress);

                // Check Validation
                var isValid = ThemeTemplate.SValidate(groupBoxStaffInformation, errorProviderStaff);

                if (isValid)
                {
                    var already = false;
                    var query = "select * from s_employee where nid='" + textBoxNid.Text.Trim() + "' ";
                    var staffInfo = Db.GetDataReader(query);

                    if (staffInfo.HasRows)
                    {
                        staffInfo.Read();
                        if (staffInfo["create_by"] == DBNull.Value || staffInfo["create_by"].ToString() == string.Empty)
                        {
                            MessageBox.Show("Pending enrollment");
                            labelFullName.Text = textBoxFullName.Text.Trim();
                            labelFullName.Tag = staffInfo["id"].ToString();

                            groupBoxStaffInformation.Visible = false;
                            groupBoxAddress.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("already added this staff\n\nstaff name" + staffInfo["name"], "Information");
                        }
                    }
                    else
                    {
                        // insert student basic information
                        var imgConv = new ImageConverter();
                        var bytes = (byte[]) imgConv.ConvertTo(pictureBoxStaff.Image, Type.GetType("System.Byte[]"));

                        var cmd = new SqlCommand
                        {
                            CommandText =
                                "insert into s_employee (id, emp_id, name, phone, nid, desig_id,joining_date,image) " +
                                "values ((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_EMPLOYEE),'" +
                                textBoxEmpId.Text.Trim() +
                                "', '" + textBoxFullName.Text.Trim() + "', '" + textBoxPhone.Text.Trim() + "', '" +
                                textBoxNid.Text.Trim() +
                                "', '" + comboBoxDesignation.SelectedValue + "','" +
                                dateTimePickerJoiningDate.Value.ToString(GlobalSettings.DateFormatSave) + "',@img) "
                        };
                        cmd.Parameters.AddWithValue("@img", bytes);

                        var isSaved = Db.QueryExecute(cmd);

                        if (isSaved)
                        {
                            query = "select * from s_employee where nid='" + textBoxNid.Text.Trim() + "' ";
                            staffInfo = Db.GetDataReader(query);
                            if (staffInfo.HasRows)
                            {
                                staffInfo.Read();
                                labelFullName.Text = staffInfo["name"].ToString();
                                labelFullName.Tag = staffInfo["id"].ToString();

                                groupBoxStaffInformation.Visible = false;
                                groupBoxAddress.Visible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void buttonAddressBack_Click(object sender, EventArgs e)
        {
            groupBoxAddress.Visible = false;
            groupBoxStaffInformation.Visible = true;
        }

        private void buttonAddressNext_Click(object sender, EventArgs e)
        {
            var isValid = ThemeTemplate.SValidate(groupBoxAddress, errorProviderStaff);

            if (isValid)
            {
                groupBoxAddress.Visible = false;
                groupBoxReview.Location = groupBoxAddress.Location;
                groupBoxReview.Anchor = AnchorStyles.Top;
                
                LoadTheme(groupBoxReview);

                // Set data
                // Personal Information
                textBoxReviewFullName.Text = textBoxFullName.Text;
                textBoxReviewPhone.Text = textBoxPhone.Text;
                textBoxReviewNid.Text = textBoxNid.Text;
                dateTimePickerReviewDob.Value = dateTimePickerDob.Value;
                dateTimePickerReviewJoiningDate.Value = dateTimePickerJoiningDate.Value;
                pictureBoxReviewStaffImg.Image = pictureBoxStaff.Image;

                comboBoxReviewDesignation.DisplayMember = comboBoxDesignation.DisplayMember;
                comboBoxReviewDesignation.ValueMember = comboBoxDesignation.ValueMember;
                comboBoxReviewDesignation.DataSource = comboBoxDesignation.DataSource;
                comboBoxReviewDesignation.SelectedValue = comboBoxDesignation.SelectedValue;

                // Present Address
                comboBoxReviewPreDivision.DataSource = comboBoxPreAddressDivision.DataSource;
                comboBoxReviewPreDistrict.DataSource = comboBoxPreAddressDistrict.DataSource;
                comboBoxReviewPreUpazila.DataSource = comboBoxPreAddressUpazila.DataSource;
                comboBoxReviewPreUnion.DataSource = comboBoxPreAddressUnion.DataSource;
                comboBoxReviewPreVillage.DataSource = comboBoxPreAddressVillage.DataSource;

                comboBoxReviewPreDivision.SelectedValue = comboBoxPreAddressDivision.SelectedValue;
                comboBoxReviewPreDistrict.SelectedValue = comboBoxPreAddressDistrict.SelectedValue;
                comboBoxReviewPreUpazila.SelectedValue = comboBoxPreAddressUpazila.SelectedValue;
                comboBoxReviewPreUnion.SelectedValue = comboBoxPreAddressUnion.SelectedValue;
                comboBoxReviewPreVillage.SelectedValue = comboBoxPreAddressVillage.SelectedValue;
                textBoxReviewPreDetails.Text = textBoxPreAddressDetails.Text;

                // Permanent Address
                comboBoxReviewPerDivision.DataSource = comboBoxPerAddressDivision.DataSource;
                comboBoxReviewPerDistrict.DataSource = comboBoxPerAddressDistrict.DataSource;
                comboBoxReviewPerUpazila.DataSource = comboBoxPerAddressUpazila.DataSource;
                comboBoxReviewPerUnion.DataSource = comboBoxPerAddressUnion.DataSource;
                comboBoxReviewPerVillage.DataSource = comboBoxPerAddressVillage.DataSource;

                comboBoxReviewPerDivision.SelectedValue = comboBoxPerAddressDivision.SelectedValue;
                comboBoxReviewPerDistrict.SelectedValue = comboBoxPerAddressDistrict.SelectedValue;
                comboBoxReviewPerUpazila.SelectedValue = comboBoxPerAddressUpazila.SelectedValue;
                comboBoxReviewPerUnion.SelectedValue = comboBoxPerAddressUnion.SelectedValue;
                comboBoxReviewPerVillage.SelectedValue = comboBoxPerAddressVillage.SelectedValue;
                textBoxReviewPerDetails.Text = textBoxPerAddressDetails.Text;

                
                groupBoxReview.Visible = true;


            }

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

                if (checkBoxSameAsPresentAddress.Checked)
                {
                    comboBoxPerAddressDivision.SelectedValue = comboBoxPreAddressDivision.SelectedValue;
                }
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

                if (checkBoxSameAsPresentAddress.Checked)
                {
                    comboBoxPerAddressDistrict.SelectedValue = comboBoxPreAddressDistrict.SelectedValue;
                }
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

                if (checkBoxSameAsPresentAddress.Checked)
                {
                    comboBoxPerAddressUpazila.SelectedValue = comboBoxPreAddressUpazila.SelectedValue;
                }
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

                if (checkBoxSameAsPresentAddress.Checked)
                {
                    comboBoxPerAddressUnion.SelectedValue = comboBoxPreAddressUnion.SelectedValue;
                }
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

                if (checkBoxSameAsPresentAddress.Checked)
                {
                    comboBoxPerAddressVillage.SelectedValue = comboBoxPreAddressVillage.SelectedValue;
                }

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

        private void checkBoxSameAsPresentAddress_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxSameAsPresentAddress.Checked)
                {
                    comboBoxPerAddressDivision.Enabled = false;
                    comboBoxPerAddressDistrict.Enabled = false;
                    comboBoxPerAddressUpazila.Enabled = false;
                    comboBoxPerAddressUnion.Enabled = false;
                    comboBoxPerAddressVillage.Enabled = false;
                    textBoxPerAddressDetails.Enabled = false;

                    comboBoxPerAddressDivision.SelectedValue = comboBoxPreAddressDivision.SelectedValue;
                    comboBoxPerAddressDistrict.SelectedValue = comboBoxPreAddressDistrict.SelectedValue;
                    comboBoxPerAddressUpazila.SelectedValue = comboBoxPreAddressUpazila.SelectedValue;
                    comboBoxPerAddressUnion.SelectedValue = comboBoxPreAddressUnion.SelectedValue;
                    comboBoxPerAddressVillage.SelectedValue = comboBoxPreAddressVillage.SelectedValue;
                    textBoxPerAddressDetails.Text = textBoxPreAddressDetails.Text;
                }
                else
                {
                    comboBoxPerAddressDivision.Enabled = true;
                    comboBoxPerAddressDistrict.Enabled = true;
                    comboBoxPerAddressUpazila.Enabled = true;
                    comboBoxPerAddressUnion.Enabled = true;
                    comboBoxPerAddressVillage.Enabled = true;
                    textBoxPerAddressDetails.Enabled = true;
                }
            }
            catch 
            {
                //
            }
        }

        private void textBoxPreAddressDetails_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxSameAsPresentAddress.Checked)
            {
                textBoxPerAddressDetails.Text = textBoxPreAddressDetails.Text;
            }
        }

        private void buttonReviewBack_Click(object sender, EventArgs e)
        {
            groupBoxReview.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var imgCon=new ImageConverter();
                var bytes = (byte[]) imgCon.ConvertTo(pictureBoxReviewStaffImg.Image, Type.GetType("System.Byte[]"));

                var cmd=new SqlCommand();

                cmd.CommandText = "UPDATE s_employee SET " +
                            "emp_id = '" + textBoxReviewEmpId.Text.Trim() +
                            "',name = '" + textBoxReviewFullName.Text.Trim() +
                            "',phone = '" + textBoxReviewPhone.Text.Trim() +
                            "',nid = '" + textBoxReviewNid.Text.Trim() +
                            "',desig_id  = '" + comboBoxReviewDesignation.SelectedValue +
                            "',joining_date = '" + dateTimePickerReviewJoiningDate.Value.ToString(GlobalSettings.DateFormatSave) +
                            "',PICTURE = @img" +
                            ",create_by = '" + GlobalSettings.UserName +
                            "',create_date = current_timestamp " +
                            "WHERE id='" + labelFullName.Tag + "' ";
                cmd.Parameters.AddWithValue("@img", bytes);

                var queryAddress = "INSERT INTO s_address(ID, person_id" +
                         ",p_division_id," +
                         "p_district_id," +
                         "p_upazila_id," +
                         "p_union_id," +
                         "p_village_id," +
                         "p_details," +
                         "m_division_id," +
                         "m_district_id," +
                         "m_upazila_id," +
                         "m_union_id," +
                         "m_village_id," +
                         "m_details," +
                         "who)" +
                         "VALUES((SELECT ISNULL(MAX(ID)+1,1) AS ID FROM S_ADDRESS),'" + labelFullName.Tag +
                         "','" + comboBoxReviewPerDivision.SelectedValue +
                         "','" + comboBoxReviewPerDistrict.SelectedValue +
                         "','" + comboBoxReviewPerUpazila.SelectedValue +
                         "','" + comboBoxReviewPerUnion.SelectedValue +
                         "','" + comboBoxReviewPerVillage.SelectedValue +
                         "','" + textBoxReviewPerDetails.Text +
                         "','" + comboBoxReviewPreDivision.SelectedValue +
                         "','" + comboBoxReviewPreDistrict.SelectedValue +
                         "','" + comboBoxReviewPreUpazila.SelectedValue +
                         "','" + comboBoxReviewPreUnion.SelectedValue +
                         "','" + comboBoxReviewPreVillage.SelectedValue +
                         "','" + textBoxReviewPreDetails.Text +
                         "','STF')";


                var isUpdate = Db.QueryExecute(cmd);
                if (isUpdate)
                {
                    var isInsert = Db.QueryExecute(queryAddress);
                    if (isInsert)
                    {
                        ClearAllField();
                        groupBoxReview.Visible = false;
                        groupBoxStaffInformation.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAddNewStaff_Load(object sender, EventArgs e)
        {
            //LoadTheme(this);
            LoadTheme(groupBoxStaffInformation);
            SetLocation(labelFullName,0);
            SetLocation(groupBoxStaffInformation);
            buttonBrowse.Font = new Font(buttonBrowse.Font.FontFamily, 10);
            LoadDesignation();
            labelFullName.BackColor = STheme.SColor.BackColor;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog() {Filter = "JPG|*.jpg|PNG|*.png", Multiselect = false};

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxStaff.Image = Image.FromFile(openFileDialog.FileName);
                }
                else
                {
                    if (MessageBox.Show("Set default?","Confirmation", MessageBoxButtons.OKCancel)==DialogResult.OK)
                    {
                        pictureBoxStaff.Image = Resources.no_person_image;
                    }
                }
            }
            catch (Exception ex)
            {
                pictureBoxStaff.Image = Resources.no_person_image;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
