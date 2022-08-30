using System;
using System.Drawing;
using System.Windows.Forms;
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
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.SLabel(control);
            ThemeTemplate.SLinkLabel(control);
            ThemeTemplate.STextBox(control);
            ThemeTemplate.SButton(control);
            ThemeTemplate.SDateTimePicker(control);
            ThemeTemplate.SComboBox(control);
        }

        private void buttonSavePersonalInfo_Click(object sender, EventArgs e)
        {
            groupBoxPersonalInformation.Visible = false;
            groupBoxAcademicInformation.Size = groupBoxPersonalInformation.Size;
            groupBoxAcademicInformation.Location = groupBoxPersonalInformation.Location;
            groupBoxAcademicInformation.Anchor = AnchorStyles.Top;
            
            LoadTheme(groupBoxAcademicInformation);

            labelAcademicStudentName.Text = textBoxFullName.Text + " (" + textBoxNameBangla.Text + ")";
            labelAcademicStudentName.Font = new Font(STheme.SFont.Font, 12, FontStyle.Bold);

            groupBoxAcademicInformation.Visible = true;
        }

        private void buttonAcademicBack_Click(object sender, EventArgs e)
        {
            groupBoxAcademicInformation.Visible = false;
            groupBoxPersonalInformation.Visible = true;
        }

        private void buttonAcademicNext_Click(object sender, EventArgs e)
        {
            groupBoxAcademicInformation.Visible = false;
            groupBoxGuardianInformation.Size = groupBoxAcademicInformation.Size;
            groupBoxGuardianInformation.Location = groupBoxAcademicInformation.Location;
            groupBoxGuardianInformation.Anchor = AnchorStyles.Top;

            LoadTheme(groupBoxGuardianInformation);
            groupBoxGuardianInformation.Visible = true;
        }

        private void buttonGuardianBack_Click(object sender, EventArgs e)
        {
            groupBoxGuardianInformation.Visible = false;
            groupBoxAcademicInformation.Visible = true;
        }

        private void buttonGuardianNext_Click(object sender, EventArgs e)
        {
            groupBoxGuardianInformation.Visible = false;
        }
    }
}
