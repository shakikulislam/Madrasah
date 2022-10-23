using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
using WindowsDesktop.Properties;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Students
{
    public partial class FrmStudentDetails : Form
    {
        private string _studentId;
        private Button _currentBtn;

        public FrmStudentDetails(string studentId)
        {
            InitializeComponent();
            _studentId = studentId;
            LoadData();
            LoadTheme(flowLayoutPanelControl);
            LoadTheme(panelBody);
        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Active button
                _currentBtn = (Button)senderBtn;
                _currentBtn.BackColor = STheme.SColor.ActiveBackColor;
                _currentBtn.ForeColor = STheme.SColor.ActiveForColor;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = STheme.SColor.MenuPanelBackColor;
                _currentBtn.ForeColor = STheme.SColor.ForColor;
            }
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.LoadTheme(control);
        }

        private void LoadData()
        {
            var query = "SELECT name FROM vw_s_full_student_info WHERE id='" + _studentId + "'";
            var studentDetails = Db.GetDataReader(query);
            if (studentDetails.HasRows)
            {
                studentDetails.Read();
                labelTitle.Text = studentDetails["name"].ToString();
            }
        }

        private void LoadClass()
        {
            try
            {
                var query = "SELECT c.id, CONCAT(d.name, ' (', c.name, ')') AS name " +
                            "FROM s_class c " +
                            "left join s_department d on c.department_id=d.id " +
                            "ORDER BY d.name, c.class_number ASC";

                var dt = Db.GetDataTable(query);

                comboBoxReviewClass.DataSource = null;
                comboBoxReviewClass.DisplayMember = "name";
                comboBoxReviewClass.ValueMember = "id";
                comboBoxReviewClass.DataSource = dt;
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
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name FROM s_division ORDER BY name ASC";

                var dtPreDivision = Db.GetDataTable(query);
                comboBoxReviewPreDivision.DataSource = null;
                comboBoxReviewPreDivision.DisplayMember = "name";
                comboBoxReviewPreDivision.ValueMember = "id";
                comboBoxReviewPreDivision.DataSource = dtPreDivision;

                var dtPerDivision = Db.GetDataTable(query);
                comboBoxReviewPerDivision.DataSource = null;
                comboBoxReviewPerDivision.DisplayMember = "name";
                comboBoxReviewPerDivision.ValueMember = "id";
                comboBoxReviewPerDivision.DataSource = dtPerDivision;

                var dtGrdDivision = Db.GetDataTable(query);
                comboBoxReviewGrdDivision.DataSource = null;
                comboBoxReviewGrdDivision.DisplayMember = "name";
                comboBoxReviewGrdDivision.ValueMember = "id";
                comboBoxReviewGrdDivision.DataSource = dtGrdDivision;

            }
            catch
            {
                //
            }
        }

        private void LoadDistrict(object sender, ComboBox comboBox)
        {
            var cmdBox = (ComboBox) sender;
            var id = cmdBox.SelectedValue == null
                ? "0"
                : cmdBox.SelectedValue.ToString();

            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_district where division_id=" + id + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadUpazila(object sender, ComboBox comboBox)
        {
            var cmdBox = (ComboBox)sender;
            var id = cmdBox.SelectedValue == null
                ? "0"
                : cmdBox.SelectedValue.ToString();

            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_upazila where district_id=" + id + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadUnion(object sender, ComboBox comboBox)
        {
            var cmdBox = (ComboBox)sender;
            var id = cmdBox.SelectedValue == null
                ? "0"
                : cmdBox.SelectedValue.ToString();

            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_union where upazila_id=" + id + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        private void LoadVillage(object sender, ComboBox comboBox)
        {
            var cmdBox = (ComboBox)sender;
            var id = cmdBox.SelectedValue == null
                ? "0"
                : cmdBox.SelectedValue.ToString();

            var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name " +
                        "FROM s_village where union_id=" + id + " ORDER BY name ASC";
            comboBox.DataSource = null;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = Db.GetDataTable(query);
        }

        // Drag Control
        #region Drag Control

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveButton(sender);
                foreach (Control control in tabControlProfile.Controls)
                {
                    LoadTheme(control);
                }
                LoadDivision();
                LoadClass();
                tabControlProfile.Dock = DockStyle.Fill;
                tabControlProfile.Visible = true;

                var query = "SELECT * FROM vw_s_full_student_info WHERE id='" + _studentId + "'";
                var dr = Db.GetDataReader(query);

                if (dr.HasRows)
                {
                    dr.Read();

                    // Personal Information
                    textBoxReviewFullName.Text = dr["name"].ToString();
                    textBoxReviewPhone.Text = dr["phone"].ToString();
                    textBoxReviewBirthCertificeate.Text = dr["birth_certificate"].ToString();
                    textBoxReviewNid.Text = dr["nid"].ToString();
                    dateTimePickerReviewDob.Value = Convert.ToDateTime(dr["dob"].ToString());
                    pictureBoxStudent.Image = GlobalSettings.ByteToImage(dr["PICTURE"], Resources.no_person_image);

                    // Parent Information
                    textBoxReviewFatherName.Text = dr["father_name"].ToString();
                    textBoxReviewFatherPhone.Text = dr["father_phone"].ToString();
                    textBoxReviewFatherNid.Text = dr["father_nid"].ToString();
                    textBoxReviewMotherName.Text = dr["mother_name"].ToString();
                    textBoxReviewMotherPhone.Text = dr["mother_phone"].ToString();
                    textBoxReviewMotherNid.Text = dr["mother_nid"].ToString();

                    // Guardian information
                    textBoxReviewGrdName.Text = dr["guardian_name"].ToString();
                    textBoxReviewGrdPhone.Text = dr["guardian_phone"].ToString();

                    // Present and Permanent Address


                    // ---------------- Address ---------------------

                    // Guardian
                    var gDivisionId = dr["g_division_id"].ToString();
                    var gDistrictId = dr["g_district_id"].ToString();
                    var dUpazilaId = dr["g_upazila_id"].ToString();
                    var gUnionId = dr["g_union_id"].ToString();
                    var gVillageId = dr["g_village_id"].ToString();
                    textBoxReviewGrdDetails.Text = dr["g_details"].ToString();

                    // Permanent
                    var pDivisionId = dr["p_division_id"].ToString();
                    var pDistrictId = dr["p_district_id"].ToString();
                    var pUpazilaId = dr["p_upazila_id"].ToString();
                    var pUnionId = dr["p_union_id"].ToString();
                    var pVillageId = dr["p_village_id"].ToString();
                    textBoxReviewPerDetails.Text = dr["p_details"].ToString();

                    // Present/Mailing
                    var mDivisionId = dr["m_division_id"].ToString();
                    var mDistrictId = dr["m_district_id"].ToString();
                    var mUpazilaId = dr["m_upazila_id"].ToString();
                    var mUnionId = dr["m_union_id"].ToString();
                    var mVillageId = dr["m_village_id"].ToString();
                    textBoxReviewPreDetails.Text = dr["m_details"].ToString();

                    // Class
                    var classId = dr["class_id"].ToString();
                    textBoxReviewFormNo.Text = dr["form_number"].ToString();
                    textBoxReviewRoll.Text = dr["roll"].ToString();
                    textBoxReviewReg.Text = dr["reg"].ToString();

                    // Guardian
                    comboBoxReviewGrdDivision.SelectedValue = gDivisionId;
                    comboBoxReviewGrdDistrict.SelectedValue = gDistrictId;
                    comboBoxReviewGrdUpazila.SelectedValue = dUpazilaId;
                    comboBoxReviewGrdUnion.SelectedValue = gUnionId;
                    comboBoxReviewGrdVillage.SelectedValue = gVillageId;

                    // Permanent
                    comboBoxReviewPerDivision.SelectedValue = pDivisionId;
                    comboBoxReviewPerDistrict.SelectedValue = pDistrictId;
                    comboBoxReviewPerUpazila.SelectedValue = pUpazilaId;
                    comboBoxReviewPerUnion.SelectedValue = pUnionId;
                    comboBoxReviewPerVillage.SelectedValue = pVillageId;

                    // Present/Mailing
                    comboBoxReviewPreDivision.SelectedValue = mDivisionId;
                    comboBoxReviewPreDistrict.SelectedValue = mDistrictId;
                    comboBoxReviewPreUpazila.SelectedValue = mUpazilaId;
                    comboBoxReviewPreUnion.SelectedValue = mUnionId;
                    comboBoxReviewPreVillage.SelectedValue = mVillageId;

                    // Class
                    comboBoxReviewClass.SelectedValue = classId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewGrdDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDistrict(sender, comboBoxReviewGrdDistrict);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewGrdDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadUpazila(sender, comboBoxReviewGrdUpazila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewGrdUpazila_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadUnion(sender, comboBoxReviewGrdUnion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewGrdUnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadVillage(sender, comboBoxReviewGrdVillage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewGrdVillage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxReviewPreDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDistrict(sender, comboBoxReviewPreDistrict);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewPreDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadUpazila(sender, comboBoxReviewPreUpazila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewPreUpazila_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadUnion(sender, comboBoxReviewPreUnion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewPreUnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadVillage(sender, comboBoxReviewPreVillage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewPreVillage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxReviewPerDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDistrict(sender, comboBoxReviewPerDistrict);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewPerDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadUpazila(sender, comboBoxReviewPerUpazila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewPerUpazila_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadUnion(sender, comboBoxReviewPerUnion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewPerUnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadVillage(sender, comboBoxReviewPerVillage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxReviewPerVillage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPersonalInformationUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(tabPagePersonalInformation, errorProviderDetails);
                if (isValid)
                {
                    var cmd = new SqlCommand
                    {
                        CommandText = "UPDATE s_student SET name='" + textBoxReviewFullName.Text.Trim() +
                                      "', phone='" + textBoxReviewPhone.Text.Trim() +
                                      "', birth_certificate='" + textBoxReviewBirthCertificeate.Text.Trim() +
                                      "', nid='" + textBoxReviewNid.Text.Trim() +
                                      "', dob='" +
                                      dateTimePickerReviewDob.Value.ToString(GlobalSettings.DateFormatSave) +
                                      "',PICTURE=@img, update_by='" + GlobalSettings.UserName +
                                      "', update_date=current_timestamp WHERE id='" + _studentId + "'"
                    };
                    cmd.Parameters.AddWithValue("@img", GlobalSettings.ImageToByte(pictureBoxStudent.Image));
                    var isUpdate = Db.QueryExecute(cmd);
                    MessageBox.Show(isUpdate ? "Update ok..." : "Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonParentInformationUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(tabPageParentInfo, errorProviderDetails);
                if (!isValid) return;
                var query = "UPDATE s_student SET father_name='" + textBoxReviewFatherName.Text.Trim() +
                            "', father_phone='" + textBoxReviewFatherPhone.Text.Trim() +
                            "', father_nid='" + textBoxReviewFatherNid.Text.Trim() +
                            "', mother_name='" + textBoxReviewMotherName.Text.Trim() +
                            "', mother_phone='" + textBoxReviewMotherPhone.Text.Trim() +
                            "', mother_nid='" + textBoxReviewMotherNid.Text.Trim() +
                            "', update_by='" + GlobalSettings.UserName +
                            "', update_date=current_timestamp WHERE id='" + _studentId + "'";
                var isUpdate = Db.QueryExecute(query);
                MessageBox.Show(isUpdate ? "Update ok..." : "Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonGuardianInfoUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(tabPageGuardianInfo, errorProviderDetails);
                if (!isValid) return;
                var query = "UPDATE s_student SET guardian_name='" + textBoxReviewGrdName.Text.Trim() +
                            "', guardian_phone='" + textBoxReviewGrdPhone.Text.Trim() +
                            "', update_by='" + GlobalSettings.UserName +
                            "', update_date=current_timestamp WHERE id='" + _studentId + "'; ";

                query += "UPDATE s_address SET g_division_id='" + comboBoxReviewGrdDivision.SelectedValue +
                         "', g_district_id='" + comboBoxReviewGrdDistrict.SelectedValue +
                         "', g_upazila_id='" + comboBoxReviewGrdUpazila.SelectedValue +
                         "', g_union_id='" + comboBoxReviewGrdUnion.SelectedValue +
                         "', g_village_id='" + comboBoxReviewGrdVillage.SelectedValue +
                         "', g_details='" + textBoxReviewGrdDetails.Text.Trim() +
                         "', update_by='" + GlobalSettings.UserName +
                         "', update_date=current_timestamp WHERE person_id='" + _studentId + "' AND who='ST';";

                var isUpdate = Db.QueryExecute(query);
                MessageBox.Show(isUpdate ? "Update ok..." : "Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAddressUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(tabPageAddress, errorProviderDetails);
                if (!isValid) return;
                var query = "UPDATE s_address SET p_division_id='" + comboBoxReviewPerDivision.SelectedValue +
                         "', p_district_id='" + comboBoxReviewPerDistrict.SelectedValue +
                         "', p_upazila_id='" + comboBoxReviewPerUpazila.SelectedValue +
                         "', p_union_id='" + comboBoxReviewPerUnion.SelectedValue +
                         "', p_village_id='" + comboBoxReviewPerVillage.SelectedValue +
                         "', p_details='" + textBoxReviewPerDetails.Text.Trim() +
                         "', m_division_id='" + comboBoxReviewPreDivision.SelectedValue +
                         "', m_district_id='" + comboBoxReviewPreDistrict.SelectedValue +
                         "', m_upazila_id='" + comboBoxReviewPreUpazila.SelectedValue +
                         "', m_union_id='" + comboBoxReviewPreUnion.SelectedValue +
                         "', m_village_id='" + comboBoxReviewPreVillage.SelectedValue +
                         "', m_details='" + textBoxReviewPreDetails.Text.Trim() +
                         "', update_by='" + GlobalSettings.UserName +
                         "', update_date=current_timestamp WHERE person_id='" + _studentId + "' AND who='ST'";

                var isUpdate = Db.QueryExecute(query);
                MessageBox.Show(isUpdate ? "Update ok..." : "Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAcademicUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = ThemeTemplate.SValidate(tabPageAcademic, errorProviderDetails);
                if (!isValid) return;
                var query = "UPDATE s_student SET form_number='"+textBoxReviewFormNo.Text.Trim()+
                            "', roll='" + textBoxReviewRoll.Text.Trim() +
                            "', reg='" + textBoxReviewReg.Text.Trim() +
                            "', class_id='" + comboBoxReviewClass.SelectedValue +
                            "', update_by='" + GlobalSettings.UserName +
                            "', update_date=current_timestamp WHERE id='" + _studentId + "'";
                var isUpdate = Db.QueryExecute(query);
                MessageBox.Show(isUpdate ? "Update ok..." : "Failed");
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
