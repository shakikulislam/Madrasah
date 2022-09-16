using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsDesktop.Theme;
using FontAwesome.Sharp;

namespace WindowsDesktop.Staff
{
    public partial class FrmStaff : Form
    {
        private Form _currentChildForm;
        private IconButton _currentBtn;

        public FrmStaff()
        {
            InitializeComponent();

            LoadTheme(panelControl);
            LoadTheme(panelBody);
        }

        private static void LoadTheme(Control control)
        {
            ThemeTemplate.SLabel(control);
            ThemeTemplate.SLinkLabel(control);
            ThemeTemplate.STextBox(control);
            ThemeTemplate.SRichTextBox(control);
            ThemeTemplate.SButton(control);
            ThemeTemplate.SDateTimePicker(control);
            ThemeTemplate.SComboBox(control);
        }

        private void OpenChildForm(Form childForm)
        {
            CloseChildForm();

            _currentChildForm = childForm;
            
            _currentChildForm.TopLevel = false;
            _currentChildForm.FormBorderStyle = FormBorderStyle.None;
            _currentChildForm.Dock = DockStyle.Fill;
            _currentChildForm.BackColor = panelBody.BackColor;

            panelBody.Controls.Add(_currentChildForm);
            panelBody.Tag = _currentChildForm;

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
        
        private void iconButtonStaffList_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmStaffList());
        }

        private void iconButtonAddStaff_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmAddNewStaff());
        }
    }
}
