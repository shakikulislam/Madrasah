using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Exam
{
    public partial class FrmExam : Form
    {
        private Form _currentChildForm;

        public FrmExam()
        {
            InitializeComponent();

            ThemeTemplate.LoadTheme(panelTopMenu);
        }
        
        private void buttonExamSchedule_Click(object sender, System.EventArgs e)
        {
            GlobalSettings.OpenChildForm(new FrmExamSchedule(), _currentChildForm, panelBody);
        }
    }
}
