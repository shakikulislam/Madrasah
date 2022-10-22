﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
using WindowsDesktop.Properties;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Students
{
    public partial class FrmAddNewStudent : Form
    {
        //ClassDb _classDb = new ClassDb();

        public FrmAddNewStudent()
        {
            InitializeComponent();

            dateTimePickerDob.MaxDate=DateTime.Now;

            LoadTheme(groupBoxPersonalInformation);
            //LoadTheme(this);

            LoadDivision();

            LoadClass();

            SetLocation(labelStudentName, 0);
            SetLocation(groupBoxPersonalInformation);
        }

        private void SetLocation(Control control, int y = 50)
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

        private static void LoadTheme(Control control)
        {
            ThemeTemplate.LoadTheme(control);
        }

        private void ClearAllField()
        {
            ClearReviewField();
            
            labelStudentName.Text = string.Empty;
            labelStudentName.Tag = string.Empty;
            textBoxFullName.Clear();
            textBoxStudentPhone.Clear();
            textBoxBirthCert.Clear();
            textBoxNid.Clear();
            dateTimePickerReviewDob.Value=DateTime.Now;

            textBoxPreAddressDetails.Clear();
            textBoxPerAddressDetails.Clear();

            checkBoxSameAsPresentAddress.Enabled = false;

            foreach (var textBox in groupBoxGuardianInformation.Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }

            textBoxRoll.Clear();
            textBoxReg.Clear();

            pictureBoxStudent.Image = Resources.no_person_image;
            pictureBoxReviewStudent.Image = Resources.no_person_image;
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
        
        private void LoadClass()
        {
            try
            {
                //var dt = new ClassDb().ClassList();

                //comboBoxClass.DataSource = null;
                //comboBoxClass.DisplayMember = "name";
                //comboBoxClass.ValueMember = "id";
                //comboBoxClass.DataSource = dt;
            }
            catch
            {
                //
            }
        }

        private void LoadDivision()
        {
            try
            {
                var dtPreAddressDivision = new DivisionDb().DivisionList();
                comboBoxPreAddressDivision.DataSource = null;
                comboBoxPreAddressDivision.DisplayMember = "name";
                comboBoxPreAddressDivision.ValueMember = "id";
                comboBoxPreAddressDivision.DataSource = dtPreAddressDivision;

                var dtPerAddressDivision = new DivisionDb().DivisionList();
                comboBoxPerAddressDivision.DataSource = null;
                comboBoxPerAddressDivision.DisplayMember = "name";
                comboBoxPerAddressDivision.ValueMember = "id";
                comboBoxPerAddressDivision.DataSource = dtPerAddressDivision;

                var dtGrdAddressDivision = new DivisionDb().DivisionList();
                comboBoxGrdAddressDivision.DataSource = null;
                comboBoxGrdAddressDivision.DisplayMember = "name";
                comboBoxGrdAddressDivision.ValueMember = "id";
                comboBoxGrdAddressDivision.DataSource = dtGrdAddressDivision;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void LoadDistrict(ComboBox comboBox, string divisionId)
        {
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = new DistrictDb().DistrictListByDivisionId(divisionId);
        }

        private void LoadUpazila(ComboBox comboBox, string districtId)
        {
           comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = new DistrictDb().DistrictListByDivisionId(districtId);
        }

        private void LoadUnion(ComboBox comboBox, string upazilaId)
        {
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = new UnionDb().UnionListByUpazilaId(upazilaId);
        }

        private void LoadVillage(ComboBox comboBox, string unionId)
        {
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = new VillageDb().VillageListByUnionId(unionId);
        }

        private void buttonSavePersonalInfo_Click(object sender, EventArgs e)
        {

            try
            {
                // Load Theme
                groupBoxAddress.Size = new Size(594, 619);
                groupBoxAddress.Location = groupBoxPersonalInformation.Location;
                groupBoxAddress.Anchor = AnchorStyles.Top;

                LoadTheme(groupBoxAddress);

                // Check Validation
                var isValid = ThemeTemplate.SValidate(groupBoxPersonalInformation, errorProviderNewStudent);

                if (isValid)
                {
                    //groupBoxPersonalInformation.Visible = false;

                    // Check already added
                    var query = "SELECT * FROM s_students WHERE birth_certificate='" + textBoxBirthCert.Text.Trim() + "' ";
                    var studentInfo = Db.GetDataReader(query);

                    if (studentInfo.HasRows)
                    {
                        studentInfo.Read();
                        if (studentInfo["guardian_name"] == DBNull.Value || studentInfo["guardian_name"].ToString() == "")
                        {
                            MessageBox.Show("Pending enrollment students");

                            labelStudentName.Text = studentInfo["name"].ToString();
                            labelStudentName.Tag = studentInfo["id"].ToString();

                            groupBoxPersonalInformation.Visible = false;
                            groupBoxAddress.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Already added this student\n\nStudent Name: " + studentInfo["name"] + "\nRoll No: " +
                                        studentInfo["roll"], @"Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Insert student basic information
                        query = "INSERT INTO s_students (name, phone, birth_certificate, nid, dob) VALUES ('" + textBoxFullName.Text.Trim() +
                                "', '" + textBoxStudentPhone.Text.Trim() + "', '" + textBoxBirthCert.Text.Trim() + "', '" + textBoxNid.Text.Trim() +
                                "', '" + dateTimePickerDob.Value.ToString(GlobalSettings.DateFormatSave) + "') ";

                        var isSaved = Db.QueryExecute(query);
                        if (isSaved)
                        {
                            query = "SELECT * FROM s_students WHERE birth_certificate='" + textBoxBirthCert.Text.Trim() + "' ";
                            studentInfo = Db.GetDataReader(query);
                            if (studentInfo.HasRows)
                            {
                                studentInfo.Read();
                                labelStudentName.Text = studentInfo["name"].ToString();
                                labelStudentName.Tag = studentInfo["id"].ToString();

                                groupBoxPersonalInformation.Visible = false;
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

        private void buttonAcademicBack_Click(object sender, EventArgs e)
        {
            groupBoxAcademicInformation.Visible = false;
            groupBoxGuardianInformation.Visible = true;
        }

        private void buttonAcademicNext_Click(object sender, EventArgs e)
        {
            try
            {
                ClearReviewField();
                var isValid = ThemeTemplate.SValidate(groupBoxAcademicInformation, errorProviderNewStudent);
                if (isValid)
                {
                    groupBoxAcademicInformation.Visible = false;

                    groupBoxReview.Location = groupBoxPersonalInformation.Location;
                    groupBoxReview.Anchor = AnchorStyles.Top;

                    LoadTheme(groupBoxReview);

                    // Set data
                    // Personal Information
                    textBoxReviewFullName.Text = textBoxFullName.Text;
                    textBoxReviewPhone.Text = textBoxStudentPhone.Text;
                    textBoxReviewBirthCertificeate.Text = textBoxBirthCert.Text;
                    textBoxReviewNid.Text = textBoxNid.Text;
                    dateTimePickerReviewDob.Value = dateTimePickerDob.Value;

                    pictureBoxReviewStudent.Image = pictureBoxStudent.Image;

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

                    // Parent Information
                    textBoxReviewFatherName.Text = textBoxFatherName.Text;
                    textBoxReviewFatherPhone.Text = textBoxFatherPhone.Text;
                    textBoxReviewFatherNid.Text = textBoxFatherNid.Text;

                    textBoxReviewMotherName.Text = textBoxMotherName.Text;
                    textBoxReviewMotherPhone.Text = textBoxMotherPhone.Text;
                    textBoxReviewMotherNid.Text = textBoxMotherNid.Text;

                    // Guardian Information
                    textBoxReviewGrdName.Text = textBoxGrdName.Text;
                    textBoxReviewGrdPhone.Text = textBoxGrdPhone.Text;

                    // Guardian Address
                    comboBoxReviewGrdDivision.DataSource = comboBoxGrdAddressDivision.DataSource;
                    comboBoxReviewGrdDistrict.DataSource = comboBoxGrdAddressDistrict.DataSource;
                    comboBoxReviewGrdUpazila.DataSource = comboBoxGrdAddressUpazila.DataSource;
                    comboBoxReviewGrdUnion.DataSource = comboBoxGrdAddressUnion.DataSource;
                    comboBoxReviewGrdVillage.DataSource = comboBoxGrdAddressVillage.DataSource;


                    comboBoxReviewGrdDivision.SelectedValue = comboBoxGrdAddressDivision.SelectedValue;
                    comboBoxReviewGrdDistrict.SelectedValue = comboBoxGrdAddressDistrict.SelectedValue;
                    comboBoxReviewGrdUpazila.SelectedValue = comboBoxGrdAddressUpazila.SelectedValue;
                    comboBoxReviewGrdUnion.SelectedValue = comboBoxGrdAddressUnion.SelectedValue;
                    comboBoxReviewGrdVillage.SelectedValue = comboBoxGrdAddressVillage.SelectedValue;
                    textBoxReviewGrdDetails.Text = textBoxGrdAddressDetails.Text;

                    // Academic Details
                    comboBoxReviewClass.DataSource = comboBoxClass.DataSource;

                    comboBoxReviewClass.SelectedValue = comboBoxClass.SelectedValue;
                    textBoxReviewFormNo.Text = textBoxFormNo.Text;
                    textBoxReviewRoll.Text = textBoxRoll.Text;
                    textBoxReviewReg.Text = textBoxReg.Text;

                    groupBoxReview.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                groupBoxAcademicInformation.Visible = false;
            }
        }

        private void buttonGuardianBack_Click(object sender, EventArgs e)
        {
            groupBoxGuardianInformation.Visible = false;
            groupBoxAddress.Visible = true;
        }

        private void buttonGuardianNext_Click(object sender, EventArgs e)
        {
            var isValid = ThemeTemplate.SValidate(groupBoxGuardianInformation, errorProviderNewStudent);

            if (isValid)
            {
                groupBoxGuardianInformation.Visible = false;
                groupBoxAcademicInformation.Size = new Size(594, 260);
                groupBoxAcademicInformation.Location = groupBoxPersonalInformation.Location;
                groupBoxAcademicInformation.Anchor = AnchorStyles.Top;
                
                LoadTheme(groupBoxAcademicInformation); 

                groupBoxAcademicInformation.Visible = true;
            }
        }

        private void buttonAddressBack_Click(object sender, EventArgs e)
        {
            groupBoxAddress.Visible = false;
            groupBoxPersonalInformation.Visible = true;
        }

        private void buttonAddressNext_Click(object sender, EventArgs e)
        {
            var isValid = ThemeTemplate.SValidate(groupBoxAddress, errorProviderNewStudent);

            if (isValid)
            {
                groupBoxAddress.Visible = false;
                groupBoxGuardianInformation.Size = new Size(594, 619);
                groupBoxGuardianInformation.Location = groupBoxPersonalInformation.Location;
                groupBoxGuardianInformation.Anchor = AnchorStyles.Top;

                LoadTheme(groupBoxGuardianInformation);

                groupBoxGuardianInformation.Visible = true;
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
            groupBoxAcademicInformation.Visible = true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    CommandText = "UPDATE s_students SET " +
                                  "form_number = '" + textBoxReviewFormNo.Text.Trim() +
                                  "',roll = '" + textBoxReviewRoll.Text.Trim() +
                                  "',reg = '" + textBoxReviewReg.Text.Trim() +
                                  "',name = '" + textBoxReviewFullName.Text.Trim() +
                                  "',phone = '" + textBoxReviewPhone.Text.Trim() +
                                  "',dob = '" + dateTimePickerReviewDob.Value.ToString(GlobalSettings.DateFormatSave) +
                                  "',birth_certificate = '" + textBoxReviewBirthCertificeate.Text.Trim() +
                                  "',nid = '" + textBoxReviewNid.Text.Trim() +
                                  "',father_name = '" + textBoxReviewFatherName.Text.Trim() +
                                  "',father_phone = '" + textBoxReviewFatherPhone.Text.Trim() +
                                  "',father_nid = '" + textBoxReviewFatherNid.Text.Trim() +
                                  "',mother_name = '" + textBoxReviewMotherName.Text.Trim() +
                                  "',mother_phone = '" + textBoxReviewMotherPhone.Text.Trim() +
                                  "',mother_nid = '" + textBoxReviewMotherNid.Text.Trim() +
                                  "',guardian_name = '" + textBoxReviewGrdName.Text.Trim() +
                                  "',guardian_phone = '" + textBoxReviewGrdPhone.Text.Trim() +
                                  "',class_id = '" + comboBoxReviewClass.SelectedValue +
                                  "',image=@img,status = 'A'," +
                                  "create_by = '" + GlobalSettings.UserName +
                                  "' WHERE id='" + labelStudentName.Tag + "' "
                };
                cmd.Parameters.AddWithValue("@img", GlobalSettings.ImageToByte(pictureBoxReviewStudent.Image));

                var queryAddress = "INSERT INTO s_addresses(person_id" +
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
                         "g_division_id," +
                         "g_district_id," +
                         "g_upazila_id," +
                         "g_union_id," +
                         "g_village_id," +
                         "g_details," +
                         "who)" +
                         "VALUES('"+labelStudentName.Tag+
                         "','"+comboBoxReviewPerDivision.SelectedValue+
                         "','"+comboBoxReviewPerDistrict.SelectedValue+
                         "','"+comboBoxReviewPerUpazila.SelectedValue+
                         "','"+comboBoxReviewPerUnion.SelectedValue+
                         "','"+comboBoxReviewPerVillage.SelectedValue+
                         "','"+textBoxReviewPerDetails.Text+
                         "','"+comboBoxReviewPreDivision.SelectedValue+
                         "','"+comboBoxReviewPreDistrict.SelectedValue+
                         "','"+comboBoxReviewPreUpazila.SelectedValue+
                         "','"+comboBoxReviewPreUnion.SelectedValue+
                         "','"+comboBoxReviewPreVillage.SelectedValue+
                         "','"+textBoxReviewPreDetails.Text+
                         "','"+comboBoxReviewGrdDivision.SelectedValue+
                         "','"+comboBoxReviewGrdDistrict.SelectedValue + 
                         "','"+comboBoxReviewGrdUpazila.SelectedValue + 
                         "','"+comboBoxReviewGrdUnion.SelectedValue + 
                         "','"+comboBoxReviewGrdVillage.SelectedValue + 
                         "','"+textBoxReviewGrdDetails.Text+
                         "','ST')";


                var isUpdate = Db.QueryExecute(cmd);
                if (isUpdate)
                {
                    var isInsert = Db.QueryExecute(queryAddress);
                    if (isInsert)
                    {
                        ClearAllField();
                        groupBoxReview.Visible = false;
                        groupBoxPersonalInformation.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png", Multiselect = false };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxStudent.Image = Image.FromFile(openFileDialog.FileName);
                }
                else
                {
                    if (MessageBox.Show("Set default?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        pictureBoxStudent.Image = Resources.no_person_image;
                    }
                }
            }
            catch (Exception ex)
            {
                pictureBoxStudent.Image = Resources.no_person_image;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
