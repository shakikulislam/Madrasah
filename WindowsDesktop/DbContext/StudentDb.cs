using System;
using System.Data;
using WindowsDesktop.Common;
using WindowsDesktop.Models;
using WindowsDesktop.Properties;

namespace WindowsDesktop.DbContext
{
    public class StudentDb
    {
        public Student GetStudentByBirthCertificate(Student student)
        {
            var query = "SELECT * FROM s_student WHERE birth_certificate='" + student.Birth_Certificate + "' ";
            return new Student();
        }

        public DataTable List()
        {
            try
            {
                var query = "SELECT ID, FORM_NUMBER, ROLL, REG, NAME, PHONE, DOB, BIRTH_CERTIFICATE, NID, FATHER_NAME, FATHER_PHONE, FATHER_NID, " +
                            "MOTHER_NAME, MOTHER_PHONE, MOTHER_NID, GUARDIAN_NAME, GUARDIAN_PHONE, CLASS_ID, REMARK, PICTURE, STATUS, CREATE_BY, " +
                            "CREATE_DATE, UPDATE_BY, UPDATE_DATE, CONCAT(DEPARTMENT, '(', CLASS, ')') AS CLASS_NAME " +
                            "FROM vw_s_full_student_info WHERE roll<> 0";
                return Db.GetDataTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Student GetById(string id)
        {
            var studentInfo=new Student();

            var query = "SELECT * FROM vw_s_full_student_info WHERE id='" + id + "'";
            var dr = Db.GetDataReader(query);
            if (dr.HasRows)
            {
                dr.Read();
                studentInfo.Id = Convert.ToDouble(dr["ID"].ToString());
                studentInfo.Name = dr["NAME"].ToString();
                studentInfo.Roll = Convert.ToInt32(dr["ROLL"].ToString());
                studentInfo.Reg = Convert.ToInt32(dr["REG"].ToString());
                studentInfo.FORM_NUMBER = dr["FORM_NUMBER"].ToString();
                studentInfo.Phone = dr["PHONE"].ToString();
                studentInfo.Dob = Convert.ToDateTime(dr["DOB"].ToString());
                studentInfo.Birth_Certificate = dr["BIRTH_CERTIFICATE"].ToString();
                studentInfo.Nid = dr["NID"].ToString();
                studentInfo.Father_Name = dr["FATHER_NAME"].ToString();
                studentInfo.Father_Phone = dr["FATHER_PHONE"].ToString();
                studentInfo.Father_Nid = dr["FATHER_NID"].ToString();
                studentInfo.Mother_Name = dr["MOTHER_NAME"].ToString();
                studentInfo.Mother_Phone = dr["MOTHER_PHONE"].ToString();
                studentInfo.Mother_Nid = dr["MOTHER_NID"].ToString();
                studentInfo.Guardian_Name = dr["GUARDIAN_NAME"].ToString();
                studentInfo.Guardian_Phone = dr["GUARDIAN_PHONE"].ToString();
                studentInfo.Class_Id= Convert.ToDouble(dr["CLASS_ID"].ToString());
                studentInfo.Remark = dr["REMARK"].ToString();
                studentInfo.Picture = GlobalSettings.ByteToImage(dr["PICTURE"], Resources.no_person_image);
                studentInfo.Status = dr["STATUS"].ToString();
                studentInfo.Create_By = dr["CREATE_BY"].ToString();
                studentInfo.Create_Date = Convert.ToDateTime(dr["CREATE_DATE"].ToString());
                studentInfo.Update_By = dr["UPDATE_BY"].ToString();
                studentInfo.Update_Date = Convert.ToDateTime(dr["UPDATE_DATE"].ToString());
                
                
            }
            else
            {
                studentInfo = null;
            }

            return studentInfo;
        }
    }
}
