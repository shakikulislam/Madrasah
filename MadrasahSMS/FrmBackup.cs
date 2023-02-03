using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MadrasahSMS.DbContext;
using MadrasahSMS.Common;

namespace MadrasahSMS
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
            //ThemeTemplate.LoadTheme(this);
            textBoxUrl.Text = "D:\\S_BACKUP\\";
        }

        private void DbBackup()
        {
            try
            {
                var directoryLocation = textBoxUrl.Text.Trim() + @"\";
                var dr = new DirectoryInfo(directoryLocation);
                if (!dr.Exists)
                {
                    dr.Create();
                }

                var query = "BACKUP DATABASE " + Db.DbName + " TO  DISK = N'" + directoryLocation + "S_" +
                            DateTime.Now.ToString("dddd_dd-MMM-yyyy_HH-mm-ss") + ".bak'";
                query += "ALTER DATABASE " + Db.DbName + " SET MULTI_USER";

                Db.QueryExecute(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxUrl.Text = fbd.SelectedPath + @"\";
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frm = new frmWaiting(DbBackup))
                {
                    frm.ShowDialog();
                }

                MessageBox.Show("Backup Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
