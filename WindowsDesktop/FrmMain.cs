using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDesktop
{
    public partial class FrmMain : Form
    {

        private IconButton _currentBtn;
        private Panel _leftMenuBtnBorder;
        private Form _currentChildForm;

        //Constructor
        public FrmMain()
        {
            InitializeComponent();
            _leftMenuBtnBorder = new Panel();
            _leftMenuBtnBorder.Size = new Size(7, 40);
            panelSideMenu.Controls.Add(_leftMenuBtnBorder);
            //MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        // Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(127, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
        }

        //Method
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Active button
                _currentBtn = (IconButton)senderBtn;
                _currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                _currentBtn.ForeColor = color;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                _currentBtn.IconColor = color;
                _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                _leftMenuBtnBorder.BackColor = color;
                _leftMenuBtnBorder.Location = new Point(0, _currentBtn.Location.Y);
                _leftMenuBtnBorder.Visible = true;
                _leftMenuBtnBorder.BringToFront();

                // Icon Current Child
                iconPictureBoxCurrentChild.IconChar = _currentBtn.IconChar;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                _currentBtn.ForeColor = Color.White;
                _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                _currentBtn.IconColor = Color.White; ;
                _currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                // Open only home
                _currentChildForm.Close();
            }

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
        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Form1());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new Form2());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new Form3());
        }

        // Drag Control
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal) 
            {
                WindowState = FormWindowState.Maximized;
                iconButtonMaximize.IconChar = IconChar.WindowRestore;
                toolTipMain.SetToolTip(iconButtonMaximize, "Restore");
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                iconButtonMaximize.IconChar = IconChar.WindowMaximize;
                toolTipMain.SetToolTip(iconButtonMaximize, "Maximize");


            }
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                iconButtonMaximize.IconChar = IconChar.WindowMaximize;
                toolTipMain.SetToolTip(iconButtonMaximize, "Maximize");
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                iconButtonMaximize.IconChar = IconChar.WindowRestore;
                toolTipMain.SetToolTip(iconButtonMaximize, "Restore");
            }
        }
    }
}
