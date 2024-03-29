﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MadrasahSMS.Theme;
using FontAwesome.Sharp;

namespace MadrasahSMS.Staff
{
    public partial class FrmStaff : Form
    {
        private Form _currentChildForm;
        private ToolStripMenuItem _currentBtn;

        public FrmStaff()
        {
            InitializeComponent();
            LoadTheme(panelBody);
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
                _currentBtn = (ToolStripMenuItem)senderBtn;
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
             //   _currentBtn.IconColor = STheme.SColor.ForColor;
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

        private void iconButtonUserManage_Click(object sender, EventArgs e)
        {

        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmStaffList());
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmAddNewStaff());
        }

        private void userManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FrmUser());
        }
    }
}
