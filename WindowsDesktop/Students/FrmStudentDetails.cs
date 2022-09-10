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

namespace WindowsDesktop.Students
{
    public partial class FrmStudentDetails : Form
    {
        private string _id;
        public FrmStudentDetails(string id)
        {
            InitializeComponent();
            _id = id;
            LoadTheme(flowLayoutPanelControl);
            LoadData();
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.SButton(control);
            ThemeTemplate.SDateTimePicker(control);
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
                LoadTheme(groupBoxReview);

                var query = "SELECT * FROM vw_s_full_student_info WHERE id='" + _id + "'";
                var dr = Db.GetDataReader(query);
                if (dr.HasRows)
                {
                    dr.Read();
                    textBoxReviewFullName.Text = dr["name"].ToString();
                    textBoxReviewPhone.Text = dr["phone"].ToString();
                    textBoxReviewBirthCertificeate.Text = dr["birth_certificate"].ToString();
                    textBoxReviewNid.Text = dr["nid"].ToString();
                    dateTimePickerReviewDob.Value = Convert.ToDateTime(dr["dob"].ToString());



                    groupBoxReview.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
