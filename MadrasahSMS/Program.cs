﻿using System;
using System.IO;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Common;

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
                var server = File.ReadAllText("host.txt");
                GlobalSettings.Server = server;
                //GlobalSettings.Server = "192.168.0.247;Port:3306";
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
                    GlobalSettings.OfficeInfo = Db.GetTable("SELECT * FROM s_office WHERE status='A'");
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
