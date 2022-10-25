using System.Windows.Forms;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Exam
{
    public partial class FrmSeatPlan : Form
    {
        public FrmSeatPlan()
        {
            InitializeComponent();
            ThemeTemplate.LoadTheme(this);
        }
    }
}
