using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Exam
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
            GlobalSettings.OpenChildForm(new FrmSeatPlan(), _currentChildForm, panelBody);
        }
    }
}
