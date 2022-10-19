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
    }
}
