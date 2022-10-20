using System;
using System.Data;
using WindowsDesktop.Models;

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

        private Student GetById(string id)
        {
            var student_info=new Student();

            var query = "SELECT * FROM vw_s_full_student_info WHERE id='" + id + "'";
            var dr = Db.GetDataReader(query);
            if (dr.HasRows)
            {
                dr.Read();
                student_info.Id = Convert.ToInt32(dr["ID"].ToString());
                student_info.Name = dr["NAME"].ToString();
                student_info.Roll = Convert.ToInt32(dr["ROLL"].ToString());
                student_info.Reg = Convert.ToInt32(dr["REG"].ToString());
                student_info.FORM_NUMBER = dr["FORM_NUMBER"].ToString();
                student_info.Phone = dr["PHONE"].ToString();
                student_info.Dob = Convert.ToDateTime(dr["DOB"].ToString());
                student_info.Birth_Certificate = dr["BIRTH_CERTIFICATE"].ToString();
                student_info.Nid = dr["NID"].ToString();
                student_info.Father_Name = dr["FATHER_NAME"].ToString();
                student_info.Father_Phone = dr["FATHER_PHONE"].ToString();
                student_info.Father_Nid = dr["FATHER_NID"].ToString();
                student_info.Mother_Name = dr["MOTHER_NAME"].ToString();
                student_info.Mother_Phone = dr["MOTHER_PHONE"].ToString();
                student_info.Mother_Nid = dr["MOTHER_NID"].ToString();
                student_info.Guardian_Name = dr["GUARDIAN_NAME"].ToString();
                student_info.Guardian_Phone = dr["GUARDIAN_PHONE"].ToString();
                student_info.Name= dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
                student_info.Name = dr["NAME"].ToString();
            }
        }
    }
}
