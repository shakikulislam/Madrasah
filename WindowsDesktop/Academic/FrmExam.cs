using System.Windows.Forms;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Academic
{
    public partial class FrmExam : Form
    {
        public FrmExam()
        {
            InitializeComponent();
            ThemeTemplate.LoadTheme(this);
        }

    }
}
