﻿using FontAwesome.Sharp;
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
using WindowsDesktop.DbContext;
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

            panelSideMenu.BackColor = SColor.MenuPanelBackColor;
            foreach (var iconButton in panelSideMenu.Controls.OfType<IconButton>())
            {
                iconButton.ForeColor = SColor.ForColor;
                iconButton.IconColor = SColor.ForColor;
                iconButton.BackColor = SColor.MenuPanelBackColor;
            }

            #endregion

            // Top title panel
            #region Top title panel

            panelTitleBar.BackColor = SColor.MenuPanelBackColor;
            iconPictureBoxCurrentChild.BackColor = SColor.MenuPanelBackColor;
            iconPictureBoxCurrentChild.IconColor = SColor.ForColor;
            labelCurrentChild.BackColor = SColor.MenuPanelBackColor;
            labelCurrentChild.ForeColor = SColor.ForColor;

            foreach (var iconButton in panelTitleBar.Controls.OfType<IconButton>())
            {
                iconButton.ForeColor = SColor.ForColor;
                iconButton.IconColor = SColor.ForColor;
                iconButton.BackColor = SColor.MenuPanelBackColor;
            }

            #endregion

            // Footer Panel
            #region Footer Panel

            panelFooter.BackColor = SColor.MenuPanelBackColor;

            foreach (var label in panelFooter.Controls.OfType<Label>())
            {
                label.BackColor = SColor.MenuPanelBackColor;
                label.ForeColor = SColor.ForColor;
            }

            #endregion

            // Body panel
            #region Body Panel

            panelBody.BackColor = SColor.BackColor;
            
            #endregion

        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Active button
                _currentBtn = (IconButton)senderBtn;
                _currentBtn.BackColor = SColor.ActiveBackColor;
                _currentBtn.ForeColor = SColor.ActiveForColor;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                _currentBtn.IconColor = SColor.ActiveForColor;
                _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                _leftMenuBtnBorder.BackColor = SColor.ActiveForColor;
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
                _currentBtn.BackColor = SColor.MenuPanelBackColor;
                _currentBtn.ForeColor = SColor.ForColor;
                _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                _currentBtn.IconColor = SColor.ForColor;
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


            // Load Theme

            #region Load Theme

            foreach (var label in _currentChildForm.Controls.OfType<Label>())
            {
                label.BackColor = SColor.BackColor;
                label.ForeColor = SColor.ForColor;
            }

            foreach (var textBox in _currentChildForm.Controls.OfType<TextBox>())
            {
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.ForeColor = SColor.ForColor;
                textBox.BackColor = SColor.TextFieldBackgroundColor;
            }

            foreach (var listView in _currentChildForm.Controls.OfType<ListView>())
            {
                listView.ForeColor = SColor.ForColor;
                listView.BackColor = SColor.TextFieldBackgroundColor;
            }

            // DataGridView
            foreach (var gridView in _currentChildForm.Controls.OfType<DataGridView>())
            {
                gridView.BackgroundColor = SColor.ForColor;
                gridView.RowsDefaultCellStyle.BackColor = SColor.ForColor;
                gridView.RowsDefaultCellStyle.SelectionBackColor = SColor.ActiveBackColor;
                gridView.RowsDefaultCellStyle.SelectionForeColor = SColor.ActiveForColor;
                gridView.ColumnHeadersDefaultCellStyle.BackColor = SColor.MenuPanelBackColor;
                gridView.ColumnHeadersDefaultCellStyle.ForeColor = SColor.ForColor;
                gridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = SColor.MenuPanelBackColor;
                gridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = SColor.ForColor;
                gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                gridView.RowsDefaultCellStyle.Font=new Font("Segoe UI", 10, FontStyle.Regular);
                
                gridView.AllowUserToAddRows = false;
                gridView.AllowUserToDeleteRows = false;
                gridView.ShowEditingIcon = false;
                gridView.EnableHeadersVisualStyles = false;
                gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridView.RowHeadersVisible = false;
                gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                gridView.ColumnHeadersHeight = 30;
                gridView.MultiSelect = false;
                gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                gridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                gridView.RowTemplate.Resizable = DataGridViewTriState.False;
                gridView.RowTemplate.DividerHeight = 1;
                gridView.RowTemplate.Height = 25;
                gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            
            #endregion


            _currentChildForm.Show();

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
    }
}
