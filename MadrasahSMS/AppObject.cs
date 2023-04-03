using MadrasahSMS.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MadrasahSMS.DbContext;
using MadrasahSMS.Properties;

namespace MadrasahSMS
{
    public class AppObject
    {
        public static void Office()
        {
            var officeInfo = Db.GetReader("SELECT * FROM S_OFFICE WHERE STATUS='A'");
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
                GlobalSettings.OfficeInfo.Logo = GlobalSettings.ByteToImage(officeInfo["LOGO"], Resources.NoLogo);
                GlobalSettings.OfficeInfo.PreExamEffFinal = Convert.ToBoolean(officeInfo["PRE_EXAM_EFF_FINAL"]);

                officeInfo.Close();
            }
        }
    }
}
