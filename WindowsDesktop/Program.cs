using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop.DbContext;
using Hospital_MS_SSC.Common;

namespace WindowsDesktop
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
            frmWaiting waiting = new frmWaiting();
            waiting.Show();
            try
            {
                //GlobalSettings.Server = File.ReadAllText("host.txt");
                GlobalSettings.Server = "localhost";
            }
            catch { }
            if (string.IsNullOrEmpty(GlobalSettings.Server))
            {
                MessageBox.Show("Server Not Found");
                Application.Exit();
            }
            else
            {
                try
                {
                    GlobalSettings.OfficeInfo = Db.GetDataTable("SELECT * FROM s_offices WHERE status='A'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Application.Exit();
                    return;
                }
                //catch
                //{
                //    MessageBox.Show("Could Not Connect To Server");
                //    Application.Exit();
                //    return;
                //}

                waiting.Close();
                Application.Run(new FrmMain());
            }
        }
    }
}
