using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsDesktop.Theme;
using FontAwesome.Sharp;

namespace WindowsDesktop.Students
{
    public partial class FrmStudent : Form
    {
        private Form _currentChildForm;
        private IconButton _currentBtn;

        public FrmStudent()
        {
            InitializeComponent();

            LoadTheme(panelStudentControl);
            LoadTheme(panelStudentBody);
        }

        private static void LoadTheme(Control control)
        {
            ThemeTemplate.LoadTheme(control);
        }

        private void OpenChildForm(Form childForm)
        {
            CloseChildForm();

            _currentChildForm = childForm;
            
            _currentChildForm.TopLevel = false;
            _currentChildForm.FormBorderStyle = FormBorderStyle.None;
            _currentChildForm.Dock = DockStyle.Fill;
            _currentChildForm.BackColor = panelStudentBody.BackColor;

            panelStudentBody.Controls.Add(_currentChildForm);
            panelStudentBody.Tag = _currentChildForm;

            _currentChildForm.Show();

        }

        private void CloseChildForm()
        {
            if (_currentChildForm != null)
            {
                // Open only home
                _currentChildForm.Close();
            }
        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Active button
                _currentBtn = (IconButton)senderBtn;
                _currentBtn.BackColor = STheme.SColor.ActiveBackColor;
                _currentBtn.ForeColor = STheme.SColor.ActiveForColor;
                //_currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                _currentBtn.IconColor = STheme.SColor.ActiveForColor;
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
                _currentBtn.IconColor = STheme.SColor.ForColor;
                //_currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //_currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButtonAddStudent_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmAddNewStudent());
        }

        private void iconButtonStudentList_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmStudentList());
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
