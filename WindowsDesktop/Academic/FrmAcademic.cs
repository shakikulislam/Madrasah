using System;
using System.Linq;
using System.Windows.Forms;
using WindowsDesktop.Common;
using WindowsDesktop.Theme;

namespace WindowsDesktop.Academic
{
    public partial class FrmAcademic : Form
    {
        private Form _currentChildForm;
        private Button _currentBtn;

        public FrmAcademic()
        {
            InitializeComponent();

            foreach (var panel in Controls.OfType<Panel>())
            {
                panel.BackColor = STheme.SColor.BackColor;
            }
            ThemeTemplate.LoadTheme(panelTopMenu);
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
                //_currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //_currentBtn.IconColor = STheme.SColor.ActiveForColor;
                //_currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //_currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = STheme.SColor.MenuPanelBackColor;
                _currentBtn.ForeColor = STheme.SColor.ForColor;
                //_currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //_currentBtn.IconColor = STheme.SColor.ForColor;
                //_currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //_currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        
        private void buttonClass_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender);
            _currentChildForm = GlobalSettings.OpenChildForm(new FrmClass(), _currentChildForm, panelAcademicBody);
        }
        
        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _currentChildForm = GlobalSettings.OpenChildForm(new FrmDepartment(), _currentChildForm, panelAcademicBody);
        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _currentChildForm = GlobalSettings.OpenChildForm(new FrmSubject(), _currentChildForm, panelAcademicBody);
        }

        private void buttonExam_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _currentChildForm = GlobalSettings.OpenChildForm(new FrmAddExam(), _currentChildForm, panelAcademicBody);
        }
    }
}
