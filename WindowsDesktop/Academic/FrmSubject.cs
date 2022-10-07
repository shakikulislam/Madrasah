using System.Windows.Forms;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Academic
{
    public partial class FrmSubject : Form
    {
        public FrmSubject()
        {
            InitializeComponent();
            LoadTheme(this);
        }

        private void LoadTheme(Control control)
        {
            ThemeTemplate.LoadTheme(control);
        }
    }
}
