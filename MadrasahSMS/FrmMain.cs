using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MadrasahSMS.Academic;
using MadrasahSMS.Common;
using MadrasahSMS.Exam;
using MadrasahSMS.Staff;
using MadrasahSMS.Students;
using MadrasahSMS.Theme;
using MadrasahSMS.Common;

namespace MadrasahSMS
{
    public partial class FrmMain : Form
    {

        #region Variable

        private frmWaiting _waiting;

        private IconButton _currentBtn;
        private Panel _leftMenuBtnBorder;
        private Form _currentChildForm;

        #endregion

        //Constructor
        public FrmMain()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            _leftMenuBtnBorder = new Panel {Size = new Size(3, 40)};
            panelSideMenu.Controls.Add(_leftMenuBtnBorder);
            //MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            LoadTheme();
            LoadOfficeInfo();
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

        //Method
        #region Method

        private void LoadTheme()
        {
            // Left Side menu panel
            #region Left Side menu panel

            panelSideMenu.BackColor = STheme.SColor.SiteMenuBackColor;
            panelSideMenu.ForeColor = STheme.SColor.SiteMenuForColor;
            foreach (var iconButton in panelSideMenu.Controls.OfType<IconButton>())
            {
                iconButton.ForeColor = STheme.SColor.SiteMenuForColor;
                iconButton.IconColor = STheme.SColor.SiteMenuForColor;
                iconButton.BackColor = STheme.SColor.SiteMenuBackColor;
            }

            #endregion

            // Top title panel
            #region Top title panel

            //panelTitleBar.BackColor = STheme.SColor.MenuPanelBackColor;
            //iconPictureBoxCurrentChild.BackColor = STheme.SColor.MenuPanelBackColor;
            //iconPictureBoxCurrentChild.IconColor = STheme.SColor.ForColor;
            //labelCurrentChild.BackColor = STheme.SColor.MenuPanelBackColor;
            //labelCurrentChild.ForeColor = STheme.SColor.ForColor;


            panelTitleBar.BackColor = STheme.SColor.TopMenuBackColor;
            iconPictureBoxCurrentChild.BackColor = STheme.SColor.TopMenuBackColor;
            iconPictureBoxCurrentChild.IconColor = STheme.SColor.TopMenuForColor;
            labelCurrentChild.BackColor = STheme.SColor.TopMenuBackColor;
            labelCurrentChild.ForeColor = STheme.SColor.TopMenuForColor;

            foreach (var iconButton in panelTitleBar.Controls.OfType<IconButton>())
            {
                iconButton.ForeColor = STheme.SColor.TopMenuForColor;
                iconButton.IconColor = STheme.SColor.TopMenuForColor;
                iconButton.BackColor = STheme.SColor.TopMenuBackColor;
            }

            #endregion

            // Top divider panel
            #region Top divider panel

            panelTopDivider.BackColor = STheme.SColor.BackColor;

            #endregion

            // Right panel
            #region Right panel

            panelRight.BackColor = STheme.SColor.BackColor;

            #endregion

            // Footer Panel
            #region Footer Panel

            panelFooter.BackColor = STheme.SColor.MenuPanelBackColor;

            foreach (var label in panelFooter.Controls.OfType<Label>())
            {
                label.BackColor = STheme.SColor.MenuPanelBackColor;
                label.ForeColor = STheme.SColor.ForColor;
                label.Font = new Font(STheme.SFont.Font, 12);
            }

            #endregion

            // Body panel
            #region Body Panel

            panelBody.BackColor = STheme.SColor.BackColor;
            
            #endregion

        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Active button
                _currentBtn = (IconButton)senderBtn;
                _currentBtn.BackColor = STheme.SColor.SiteMenuForColor;
                _currentBtn.ForeColor = STheme.SColor.SiteMenuBackColor;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                _currentBtn.IconColor = STheme.SColor.SiteMenuBackColor;
                _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                _currentBtn.Font = new Font(_currentBtn.Font.FontFamily, _currentBtn.Font.Size, FontStyle.Bold);

                // Left border button
                _leftMenuBtnBorder.BackColor = STheme.SColor.TopMenuBackColor;
                _leftMenuBtnBorder.Location = new Point(0, _currentBtn.Location.Y);
                _leftMenuBtnBorder.Visible = true;
                _leftMenuBtnBorder.BringToFront();

                // Current Child
                iconPictureBoxCurrentChild.IconChar = _currentBtn.IconChar;
                iconPictureBoxCurrentChild.IconFont = _currentBtn.IconFont;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = STheme.SColor.SiteMenuBackColor;
                _currentBtn.ForeColor = STheme.SColor.SiteMenuForColor;
                _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                _currentBtn.IconColor = STheme.SColor.SiteMenuForColor;
                _currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                _currentBtn.Font = new Font(_currentBtn.Font.FontFamily, _currentBtn.Font.Size, FontStyle.Regular);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            _waiting = new frmWaiting();
            _waiting.Show();

            Application.DoEvents();

            CloseChildForm();

            _currentChildForm = childForm;

            labelCurrentChild.Text = _currentChildForm.Text;

            _currentChildForm.TopLevel = false;
            _currentChildForm.FormBorderStyle = FormBorderStyle.None;
            _currentChildForm.Dock = DockStyle.Fill;
            _currentChildForm.BackColor = panelBody.BackColor;

            panelBody.Controls.Add(_currentChildForm);
            panelBody.Tag = _currentChildForm;
            
            _currentChildForm.Show();

            // Loading
            _waiting.Close();
        }

        private void CloseChildForm()
        {
            _currentChildForm?.Close();
        }
        
        private void LoadOfficeInfo()
        {
            labelOfficeName.Text = GlobalSettings.OfficeInfo.Rows[0]["name"].ToString();
        }
        
        #endregion

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMaximize_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Maximized;
                    iconButtonMaximize.IconChar = IconChar.WindowRestore;
                    toolTipMain.SetToolTip(iconButtonMaximize, "Restore");
                    break;

                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Normal;
                    iconButtonMaximize.IconChar = IconChar.WindowMaximize;
                    toolTipMain.SetToolTip(iconButtonMaximize, "Maximize");
                    break;

                case FormWindowState.Minimized:
                    break;
            }
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    iconButtonMaximize.IconChar = IconChar.WindowMaximize;
                    toolTipMain.SetToolTip(iconButtonMaximize, "Maximize");
                    break;

                case FormWindowState.Maximized:
                    iconButtonMaximize.IconChar = IconChar.WindowRestore;
                    toolTipMain.SetToolTip(iconButtonMaximize, "Restore");
                    break;

                case FormWindowState.Minimized:
                    break;
            }
        }

        private void iconButtonStudent_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmStudent());
        }

        private void iconButtonAddress_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmAddress());
        }
        
        private void iconButtonAcademic_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmAcademic());
        }

        private void iconButtonStaff_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmStaff());
        }

        private void iconButtonMarksEntry_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmMarksEntry());
        }

        private void iconButtonExam_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmExam());
        }

        private void iconButtonBackup_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            new FrmBackup().ShowDialog();
        }

        private void iconButtonResultProcess_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmResultProcess());
        }
    }
}
