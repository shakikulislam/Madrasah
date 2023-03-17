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

            frmWaiting waiting = new frmWaiting();
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
                    var officeInfo = Db.GetReader("SELECT * FROM s_office WHERE status='A'");
                    GlobalSettings.OfficeInfo = new OfficeInfo();
                    if (officeInfo.HasRows)
                    {
                        officeInfo.Read();

                        GlobalSettings.OfficeInfo.Id = officeInfo["ID"].ToString();
                        GlobalSettings.OfficeInfo.NameEnglish = officeInfo["NAME_EN"].ToString();
                        GlobalSettings.OfficeInfo.NameBangla = officeInfo["NAME_BN"].ToString();
                        GlobalSettings.OfficeInfo.NameArabic = officeInfo["NAME_AR"].ToString();
                        GlobalSettings.OfficeInfo.SchoolYear = officeInfo["SCHOOL_YEAR"].ToString();
                        GlobalSettings.OfficeInfo.InstallDate = officeInfo["INSTALL_DATE"].ToString();
                        GlobalSettings.OfficeInfo.CurrentVersion = officeInfo["CURRENT_VERSION"].ToString();
                        GlobalSettings.OfficeInfo.Status = officeInfo["STATUS"].ToString();
                        GlobalSettings.OfficeInfo.Logo = GlobalSettings.ByteToImage(officeInfo["LOGO"], new Bitmap(1, 1));

                        officeInfo.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Db.CloseConnection();
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
