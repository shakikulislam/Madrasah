using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Theme;
using MySql.Data.MySqlClient;

namespace WindowsDesktop.Students
{
    public partial class FrmStudentDetails : Form
    {
        private string _id;
        private Button _currentBtn;

        public FrmStudentDetails(string id)
        {
            InitializeComponent();
            _id = id;
            LoadTheme(flowLayoutPanelControl);
            LoadData();
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
            ThemeTemplate.SButton(control);
            ThemeTemplate.SDateTimePicker(control);
            ThemeTemplate.STabControl(control);
            ThemeTemplate.SComboBox(control,ComboBoxStyle.DropDownList);
        }

        private void LoadData()
        {
            var query = "SELECT * FROM vw_s_full_student_info WHERE id='" + _id + "'";
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
                            "FROM s_classes c " +
                            "left join s_departments d on c.department_id=d.id " +
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
                LoadDivision();
                LoadClass();
                tabControlProfile.Dock = DockStyle.Fill;
                tabControlProfile.Visible = true;

                var query = "SELECT * FROM vw_s_full_student_info WHERE id='" + _id + "'";
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
                    textBoxReviewGrdDetails.Text = dr["g_details"].ToString();


                    // ---------------- Address ---------------------

                    var gDivisionId = dr["g_division_id"].ToString();
                    var gDistrictId = dr["g_district_id"].ToString();
                    var dUpazilaId = dr["g_upazila_id"].ToString();
                    var gUnionId = dr["g_union_id"].ToString();
                    var gVillageId = dr["g_village_id"].ToString();

                    comboBoxReviewGrdDivision.SelectedValue = gDivisionId;
                    comboBoxReviewGrdDistrict.SelectedValue = gDistrictId;
                    comboBoxReviewGrdUpazila.SelectedValue = dUpazilaId;
                    comboBoxReviewGrdUnion.SelectedValue = gUnionId;
                    comboBoxReviewGrdVillage.SelectedValue = gVillageId;
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
    }
}
