using System;
using System.Drawing;
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

            var waiting = new frmWaiting();
            waiting.Show();
            Application.DoEvents();
            try
            {
                GlobalSettings.Server = File.ReadAllText("host.txt");
                GlobalSettings.LoggedEmployee = new EmployeeInfo();
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

                waiting.Close();
                Application.Run(new FrmMain());
            }
        }
    }
}
