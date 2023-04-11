using MadrasahSMS.Common;
using System;
using MadrasahSMS.DbContext;
using MadrasahSMS.Properties;
using ShakikulFramework.Method;

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

        public static bool DoLogin(string userName, string password, int desigCode)
        {
            var result = false;

            if (desigCode==1)
            {
                GlobalSettings.LoggedEmployee = new EmployeeInfo();
                GlobalSettings.LoggedEmployee.DesigId = "1";
                GlobalSettings.LoggedEmployee.UserName = "SYSDBA";

                return true;
            }


            var pass = new Password().Encrypt(password);
            var query = "SELECT * FROM S_EMPLOYEE WHERE STATUS = 'A' " +
                        "AND USER_NAME='" + userName + "' AND PASSWORD='" + pass + "'";
            var dr = Db.GetReader(query);
            if (dr.HasRows)
            {
                dr.Read();
                GlobalSettings.LoggedEmployee = new EmployeeInfo();

                GlobalSettings.LoggedEmployee.Id = dr["ID"].ToString();
                GlobalSettings.LoggedEmployee.EmpId = dr["EMP_ID"].ToString();
                GlobalSettings.LoggedEmployee.Name = dr["NAME"].ToString();
                GlobalSettings.LoggedEmployee.Phone = dr["PHONE"].ToString();
                GlobalSettings.LoggedEmployee.Nid = dr["NID"].ToString();
                GlobalSettings.LoggedEmployee.DesigId = dr["DESIG_ID"].ToString();
                GlobalSettings.LoggedEmployee.Dob = Convert.ToDateTime(dr["DOB"].ToString());
                GlobalSettings.LoggedEmployee.JoiningDate = Convert.ToDateTime(dr["JOINING_DATE"].ToString());
                GlobalSettings.LoggedEmployee.LeavingDate = Convert.ToDateTime(dr["LEAVING_DATE"].ToString());
                GlobalSettings.LoggedEmployee.Remark = dr["REMARK"].ToString();
                GlobalSettings.LoggedEmployee.Status = dr["STATUS"].ToString();
                GlobalSettings.LoggedEmployee.Picture = GlobalSettings.ByteToImage(dr["PICTURE"].ToString(),Properties.Resources.no_person_image);
                GlobalSettings.LoggedEmployee.CreateBy = dr["CREATE_BY"].ToString();
                GlobalSettings.LoggedEmployee.CreateDate = Convert.ToDateTime(dr["CREATE_DATE"].ToString());
                GlobalSettings.LoggedEmployee.UpdateBy = dr["UPDATE_BY"].ToString();
                GlobalSettings.LoggedEmployee.UpdateDate = Convert.ToDateTime(dr["UPDATE_DATE"].ToString());
                GlobalSettings.LoggedEmployee.UserName = dr["USER_NAME"].ToString();
                GlobalSettings.LoggedEmployee.Password = string.Empty;
                
                dr.Close();

                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
