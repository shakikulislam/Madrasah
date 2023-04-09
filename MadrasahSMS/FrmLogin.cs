using System;
using System.Drawing;
using System.Windows.Forms;
using MadrasahSMS.DbContext;

namespace MadrasahSMS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            textBoxUserName.Text = Properties.Settings.Default.UserName;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Db.CloseConnection();
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (checkBoxRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = textBoxUserName.Text;
                Properties.Settings.Default.Save();
            }
            Db.CloseConnection();
            Application.Exit();
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBoxPassword.Focus();
                textBoxPassword.SelectAll();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonLogin.PerformClick();
            }
        }

        private void labelClose_MouseHover(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }
    }
}
