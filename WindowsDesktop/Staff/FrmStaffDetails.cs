using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.DbContext;
using WindowsDesktop.Properties;
using WindowsDesktop.Theme;
using MySql.Data.MySqlClient;

namespace WindowsDesktop.Staff
{
    public partial class FrmStaffDetails : Form
    {
        private string _staffId;
        private Button _currentBtn;

        public FrmStaffDetails(string id)
        {
            InitializeComponent();
            _staffId = id;
            LoadData();
            LoadTheme(flowLayoutPanelControl);
            LoadTheme(panelBody);
        }

        private void LoadDesignation()
        {
            try
            {
                var query = "SELECT id, name FROM s_employee_designations WHERE name <> 'SA' ORDER BY number ASC";
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
            var query = "SELECT * FROM vw_s_full_employee_info WHERE id='" + _staffId + "'";
            var staffDetails = Db.GetDataReader(query);
            if (staffDetails.HasRows)
            {
                staffDetails.Read();
                labelTitle.Text = staffDetails["name"].ToString();
            }
        }
        
        private void LoadDivision()
        {
            try
            {
                var query = "SELECT id, CONCAT(name, ' (', name_bn, ')') AS name FROM s_divisions ORDER BY name ASC";

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
                        "FROM s_districts where division_id=" + id + " ORDER BY name ASC";
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
                        "FROM s_upazilas where district_id=" + id + " ORDER BY name ASC";
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
                        "FROM s_unions where upazila_id=" + id + " ORDER BY name ASC";
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
                        "FROM s_villages where union_id=" + id + " ORDER BY name ASC";
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

                LoadDesignation();
                LoadDivision();
                tabControlProfile.Dock = DockStyle.Fill;
                tabControlProfile.Visible = true;

                var query = "SELECT * FROM vw_s_full_employee_info WHERE id='" + _staffId + "'";
                var dr = Db.GetDataReader(query);
                if (dr.HasRows)
                {
                    dr.Read();

                    // Personal Information
                    textBoxEmpId.Text = dr["emp_id"].ToString();
                    comboBoxDesignation.SelectedValue = dr["desig_id"].ToString();
                    textBoxFullName.Text = dr["name"].ToString();
                    textBoxPhone.Text = dr["phone"].ToString();
                    textBoxNid.Text = dr["nid"].ToString();
                    dateTimePickerDob.Value = dr["dob"] == DBNull.Value
                        ? DateTime.Now.Date
                        : Convert.ToDateTime(dr["dob"].ToString());
                    dateTimePickerJoiningDate.Value = dr["joining_date"] == DBNull.Value
                        ? DateTime.Now.Date
                        : Convert.ToDateTime(dr["joining_date"].ToString());

                    pictureBoxStaff.Image = GlobalSettings.ByteToImage(dr["image"], Resources.no_person_image);

                    // Present and Permanent Address


                    // ---------------- Address ---------------------
                    
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

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                    var cmd = new MySqlCommand();
                    cmd.CommandText = "UPDATE s_employees SET emp_id='" + textBoxEmpId.Text.Trim() +
                                      "', name='" + textBoxFullName.Text.Trim() +
                                      "', phone='" + textBoxPhone.Text.Trim() +
                                      "', nid='" + textBoxNid.Text.Trim() +
                                      "', desig_id ='" + comboBoxDesignation.SelectedValue +
                                      "', dob='" + dateTimePickerDob.Value.ToString(GlobalSettings.DateFormatSave) +
                                      "', joining_date='" +
                                      dateTimePickerJoiningDate.Value.ToString(GlobalSettings.DateFormatSave) +
                                      "', image=@img" +
                                      ", update_by='" + GlobalSettings.UserName +
                                      "', update_date=current_timestamp() " +
                                      "WHERE id='" + _staffId + "'";
                    cmd.Parameters.AddWithValue("@img", GlobalSettings.ImageToByte(pictureBoxStaff.Image));
                    var isUpdate = Db.QueryExecute(cmd);
                    MessageBox.Show(isUpdate ? "Update ok..." : "Failed");
                }
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
                var query = "UPDATE s_addresses SET p_division_id='" + comboBoxReviewPerDivision.SelectedValue +
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
                         "', update_date='" + DateTime.Now.ToString(GlobalSettings.DateFormatSave) +
                         "' WHERE person_id='" + _staffId + "' AND who='STF'";

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
                    pictureBoxStaff.Image = Image.FromFile(openFileDialog.FileName);
                }
                else
                {
                    if (MessageBox.Show("Set default?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
