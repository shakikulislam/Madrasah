using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using WindowsDesktop.Students;
using WindowsDesktop.Theme;

namespace WindowsDesktop
{
    public partial class FrmMain : Form
    {

        #region Variable

        private IconButton _currentBtn;
        private Panel _leftMenuBtnBorder;
        private Form _currentChildForm;

        #endregion

        //Constructor
        public FrmMain()
        {
            InitializeComponent();

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
            // Side menu panel
            #region Side menu panel

            panelSideMenu.BackColor = STheme.SColor.MenuPanelBackColor;
            foreach (var iconButton in panelSideMenu.Controls.OfType<IconButton>())
            {
                iconButton.ForeColor = STheme.SColor.ForColor;
                iconButton.IconColor = STheme.SColor.ForColor;
                iconButton.BackColor = STheme.SColor.MenuPanelBackColor;
            }

            #endregion

            // Top title panel
            #region Top title panel

            panelTitleBar.BackColor = STheme.SColor.MenuPanelBackColor;
            iconPictureBoxCurrentChild.BackColor = STheme.SColor.MenuPanelBackColor;
            iconPictureBoxCurrentChild.IconColor = STheme.SColor.ForColor;
            labelCurrentChild.BackColor = STheme.SColor.MenuPanelBackColor;
            labelCurrentChild.ForeColor = STheme.SColor.ForColor;

            foreach (var iconButton in panelTitleBar.Controls.OfType<IconButton>())
            {
                iconButton.ForeColor = STheme.SColor.ForColor;
                iconButton.IconColor = STheme.SColor.ForColor;
                iconButton.BackColor = STheme.SColor.MenuPanelBackColor;
            }

            #endregion

            // Footer Panel
            #region Footer Panel

            panelFooter.BackColor = STheme.SColor.MenuPanelBackColor;

            foreach (var label in panelFooter.Controls.OfType<Label>())
            {
                label.BackColor = STheme.SColor.MenuPanelBackColor;
                label.ForeColor = STheme.SColor.ForColor;
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
                _currentBtn.BackColor = STheme.SColor.ActiveBackColor;
                _currentBtn.ForeColor = STheme.SColor.ActiveForColor;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                _currentBtn.IconColor = STheme.SColor.ActiveForColor;
                _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                _leftMenuBtnBorder.BackColor = STheme.SColor.ActiveForColor;
                _leftMenuBtnBorder.Location = new Point(0, _currentBtn.Location.Y);
                _leftMenuBtnBorder.Visible = true;
                _leftMenuBtnBorder.BringToFront();

                // Current Child
                iconPictureBoxCurrentChild.IconChar = _currentBtn.IconChar;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = STheme.SColor.MenuPanelBackColor;
                _currentBtn.ForeColor = STheme.SColor.ForColor;
                _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                _currentBtn.IconColor = STheme.SColor.ForColor;
                _currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
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

        }

        private void CloseChildForm()
        {
            if (_currentChildForm != null)
            {
                // Open only home
                _currentChildForm.Close();
            }
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
            //OpenChildForm(new FrmStudent());
        }

        private void iconButtonAddress_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmAddress());
        }

        private void iconButtonStudent_MouseHover(object sender, EventArgs e)
        {
            ActiveButton(sender);
            panelStudentSubMenu.Visible = true;
        }

        private void iconButtonStudent_MouseLeave(object sender, EventArgs e)
        {
            //DisableButton();
            //panelStudentSubMenu.Visible = false;
        }

        private void iconButtonAddStudent_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmAddNewStudent());
            panelStudentSubMenu.Visible = false;
        }
    }
}
