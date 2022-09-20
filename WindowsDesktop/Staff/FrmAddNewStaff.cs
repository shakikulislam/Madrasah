using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
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
            ThemeTemplate.SLabel(control);
            ThemeTemplate.SLinkLabel(control);
            ThemeTemplate.STextBox(control);
            ThemeTemplate.SRichTextBox(control);
            ThemeTemplate.SButton(control);
            ThemeTemplate.SDateTimePicker(control);
            ThemeTemplate.SComboBox(control,ComboBoxStyle.DropDownList);
            ThemeTemplate.SPictureBox(control);
        }

        private void LoadDesignation()
        {
            try
            {
                var query = "SELECT id, name FROM s_employee_designations WHERE name <> 'SA' ORDER BY number ASC";
                var desigList = Db.GetDataTable(query);

                comboBoxDesignation.SelectedValue = "id";
                comboBoxDesignation.DisplayMember = "name";
                comboBoxDesignation.DataSource = desigList;
                comboBoxDesignation.SelectedIndex = 3;
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
            
            labelStaffName.Text = string.Empty;
            labelStaffName.Tag = string.Empty;
            textBoxFullName.Clear();
            textBoxStudentPhone.Clear();
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
            textBoxReviewBirthCertificeate.Clear();
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

            // Parent Information
            textBoxReviewFatherName.Clear();
            textBoxReviewFatherPhone.Clear();
            textBoxReviewFatherNid.Clear();

            textBoxReviewMotherName.Clear();
            textBoxReviewMotherPhone.Clear();
            textBoxReviewMotherNid.Clear();

            // Guardian Information
            textBoxReviewGrdName.Clear();
            textBoxReviewGrdPhone.Clear();

            // Guardian Address
            comboBoxReviewGrdDivision.DataSource = null;
            comboBoxReviewGrdDivision.DisplayMember = "name";
            comboBoxReviewGrdDivision.ValueMember = "id";

            comboBoxReviewGrdDistrict.DataSource = null;
            comboBoxReviewGrdDistrict.DisplayMember = "name";
            comboBoxReviewGrdDistrict.ValueMember = "id";

            comboBoxReviewGrdUpazila.DataSource = null;
            comboBoxReviewGrdUpazila.DisplayMember = "name";
            comboBoxReviewGrdUpazila.ValueMember = "id";

            comboBoxReviewGrdUnion.DataSource = null;
            comboBoxReviewGrdUnion.DisplayMember = "name";
            comboBoxReviewGrdUnion.ValueMember = "id";

            comboBoxReviewGrdVillage.DataSource = null;
            comboBoxReviewGrdVillage.DisplayMember = "name";
            comboBoxReviewGrdVillage.ValueMember = "id";

            textBoxReviewGrdDetails.Clear();

            // Academic Details
            comboBoxReviewClass.DataSource = null;
            comboBoxReviewClass.DisplayMember = "name";
            comboBoxReviewClass.ValueMember = "id";

            textBoxReviewRoll.Clear();
            textBoxReviewReg.Clear();
        }
        
        private void LoadDivision()
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name FROM s_divisions ORDER BY name ASC";
                
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
            try
            {
                labelStaffName.Text = textBoxFullName.Text;
                //// Load Theme
                //groupBoxAddress.Size = new Size(594, 619);
                //groupBoxAddress.Location = groupBoxStaffInformation.Location;
                //groupBoxAddress.Anchor = AnchorStyles.Top;

                //LoadTheme(groupBoxAddress);
                //ThemeTemplate.SComboBox(groupBoxAddress, ComboBoxStyle.DropDownList);

                //// Check Validation
                //var isValid = ThemeTemplate.SValidate(groupBoxStaffInformation, errorProviderStaff);

                //if (isValid)
                //{
                //    //groupBoxPersonalInformation.Visible = false;

                //    // Check already added
                //    var query = "SELECT * FROM s_students WHERE birth_certificate='" + textBoxBirthCert.Text.Trim() + "' ";
                //    var studentInfo = Db.GetDataReader(query);

                //    if (studentInfo.HasRows)
                //    {
                //        studentInfo.Read();
                //        if (studentInfo["guardian_name"] == DBNull.Value || studentInfo["guardian_name"].ToString() == "")
                //        {
                //            MessageBox.Show("Pending enrollment students");

                //            labelStaffName.Text = studentInfo["name"].ToString();
                //            labelStaffName.Tag = studentInfo["id"].ToString();

                //            groupBoxStaffInformation.Visible = false;
                //            groupBoxAddress.Visible = true;
                //        }
                //        else
                //        {
                //            MessageBox.Show("Already added this student\n\nStudent Name: " + studentInfo["name"] + "\nRoll No: " +
                //                        studentInfo["roll"], @"Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //        }
                //    }
                //    else
                //    {
                //        // Insert student basic information
                //        query = "INSERT INTO s_students (name, phone, birth_certificate, nid, dob) VALUES ('" + textBoxFullName.Text.Trim() +
                //                "', '" + textBoxStudentPhone.Text.Trim() + "', '" + textBoxBirthCert.Text.Trim() + "', '" + textBoxNid.Text.Trim() +
                //                "', '" + dateTimePickerDob.Value.ToString(GlobalSettings.DateFormatSave) + "') ";

                //        var isSaved = Db.QueryExecute(query);
                //        if (isSaved)
                //        {
                //            query = "SELECT * FROM s_students WHERE birth_certificate='" + textBoxBirthCert.Text.Trim() + "' ";
                //            studentInfo = Db.GetDataReader(query);
                //            if (studentInfo.HasRows)
                //            {
                //                studentInfo.Read();
                //                labelStaffName.Text = studentInfo["name"].ToString();
                //                labelStaffName.Tag = studentInfo["id"].ToString();

                //                groupBoxStaffInformation.Visible = false;
                //                groupBoxAddress.Visible = true;
                //            }
                //        }
                //    }
                //}
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
                //var query = "UPDATE s_students SET " +
                //            "form_number = '" + textBoxReviewFormNo.Text.Trim() + 
                //            "',roll = '" + textBoxReviewRoll.Text.Trim() + 
                //            "',reg = '" + textBoxReviewReg.Text.Trim() +
                //            "',name = '" + textBoxReviewFullName.Text.Trim() + 
                //            "',phone = '" + textBoxReviewPhone.Text.Trim() +
                //            "',dob = '" + dateTimePickerReviewDob.Value.ToString(GlobalSettings.DateFormatSave) +
                //            "',birth_certificate = '" + textBoxReviewBirthCertificeate.Text.Trim() +
                //            "',nid = '" + textBoxReviewNid.Text.Trim() + 
                //            "',father_name = '" + textBoxReviewFatherName.Text.Trim() +
                //            "',father_phone = '" + textBoxReviewFatherPhone.Text.Trim() +
                //            "',father_nid = '" + textBoxReviewFatherNid.Text.Trim() + 
                //            "',mother_name = '" + textBoxReviewMotherName.Text.Trim() + 
                //            "',mother_phone = '" + textBoxReviewMotherPhone.Text.Trim() +
                //            "',mother_nid = '" + textBoxReviewMotherNid.Text.Trim() + 
                //            "',guardian_name = '" + textBoxReviewGrdName.Text.Trim() + 
                //            "',guardian_phone = '" + textBoxReviewGrdPhone.Text.Trim() +
                //            "',class_id = '" + comboBoxReviewClass.SelectedValue + 
                //            "',status = 'A'," +
                //            "create_by = '" + GlobalSettings.UserName + 
                //            "',create_date = '" + DateTime.Now.ToString(GlobalSettings.DateFormatSave) + 
                //            "' WHERE id='" + labelStudentName.Tag + "' ";

                //var queryAddress = "INSERT INTO s_addresses(person_id" +
                //         ",p_division_id," +
                //         "p_district_id," +
                //         "p_upazila_id," +
                //         "p_union_id," +
                //         "p_village_id," +
                //         "p_details," +
                //         "m_division_id," +
                //         "m_district_id," +
                //         "m_upazila_id," +
                //         "m_union_id," +
                //         "m_village_id," +
                //         "m_details," +
                //         "g_division_id," +
                //         "g_district_id," +
                //         "g_upazila_id," +
                //         "g_union_id," +
                //         "g_village_id," +
                //         "g_details," +
                //         "who)" +
                //         "VALUES('"+labelStudentName.Tag+
                //         "','"+comboBoxReviewPerDivision.SelectedValue+
                //         "','"+comboBoxReviewPerDistrict.SelectedValue+
                //         "','"+comboBoxReviewPerUpazila.SelectedValue+
                //         "','"+comboBoxReviewPerUnion.SelectedValue+
                //         "','"+comboBoxReviewPerVillage.SelectedValue+
                //         "','"+textBoxReviewPerDetails.Text+
                //         "','"+comboBoxReviewPreDivision.SelectedValue+
                //         "','"+comboBoxReviewPreDistrict.SelectedValue+
                //         "','"+comboBoxReviewPreUpazila.SelectedValue+
                //         "','"+comboBoxReviewPreUnion.SelectedValue+
                //         "','"+comboBoxReviewPreVillage.SelectedValue+
                //         "','"+textBoxReviewPreDetails.Text+
                //         "','"+comboBoxReviewGrdDivision.SelectedValue+
                //         "','"+comboBoxReviewGrdDistrict.SelectedValue + 
                //         "','"+comboBoxReviewGrdUpazila.SelectedValue + 
                //         "','"+comboBoxReviewGrdUnion.SelectedValue + 
                //         "','"+comboBoxReviewGrdVillage.SelectedValue + 
                //         "','"+textBoxReviewGrdDetails.Text+
                //         "','ST')";


                //var isUpdate=Db.QueryExecute(query);
                //if (isUpdate)
                //{
                //    var isInsert = Db.QueryExecute(queryAddress);
                //    if (isInsert)
                //    {
                //        ClearAllField();
                //        groupBoxReview.Visible = false;
                //        groupBoxStaffInformation.Visible = true;
                //    }
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAddNewStaff_Load(object sender, EventArgs e)
        {
            LoadTheme(this);
            LoadTheme(groupBoxStaffInformation);
            SetLocation(labelStaffName,0);
            SetLocation(groupBoxStaffInformation);
            buttonBrowse.Font = new Font(buttonBrowse.Font.FontFamily, 10);
            LoadDesignation();
        }
    }
}
