using System;
using System.IO;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;

namespace MadrasahSMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalSettings.Waiting = new frmWaiting();
            GlobalSettings.Waiting.Show();
            Application.DoEvents();
            try
            {
                GlobalSettings.Server = File.ReadAllText("host.txt");
            }
            catch
            {
                //
            }
            if (string.IsNullOrEmpty(GlobalSettings.Server))
            {
                MessageBox.Show(@"Server Not Found");
                Application.Exit();
            }
            else
            {
                try
                {
                    AppObject.Office();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Db.CloseConnection();
                    Application.Exit();
                }

                GlobalSettings.Waiting.Hide();
                Application.Run(new FrmLogin());
            }
        }
    }
}
