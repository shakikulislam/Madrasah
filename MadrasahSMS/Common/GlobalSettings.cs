using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MadrasahSMS.DbContext;

namespace MadrasahSMS.Common
{
    public class GlobalSettings
    {
        //Property
        public static string DevUser { get; } = "DEVELOPER";
        public static string DevPass { get; } = "developer12345";
        public static DataTable OfficeInfo { get; set; }
        public static string Server { get; set; }
        public static string EmployeeId { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; }
        public static string DateFormatShortView { get; } = "dd-MMM-yy";
        public static string DateFormatSave { get; } = "yyyy-MM-dd";

        //Method
        public static Image ByteToImage(object imageField, Bitmap defaultImage)
        {
            if (imageField == DBNull.Value) return defaultImage;
            var ms = new MemoryStream((byte[]) imageField);
            return Image.FromStream(ms);
        }
        
        public static byte[] ImageToByte(Image image)
        {
            var imgConv = new ImageConverter();
            var bytes = (byte[])imgConv.ConvertTo(image, typeof(byte[]));
            return bytes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newForm">New Form</param>
        /// <param name="currentForm">Currently Active Form</param>
        /// <param name="body">Load New Form Body</param>
        public static Form OpenChildForm(Form newForm, Form currentForm, Control body)
        {
            var wait = new frmWaiting {TopMost = true};
            wait.Show();
            Application.DoEvents();

            CloseChildForm(currentForm);
            var currentChildForm = newForm;

            currentChildForm.TopLevel = false;
            currentChildForm.ShowInTaskbar = false;
            currentChildForm.ShowIcon = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            currentChildForm.BackColor = body.BackColor;

            body.Controls.Add(currentChildForm);
            body.Tag = currentChildForm;

            currentChildForm.Show();
            wait.Close();
            return currentChildForm;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentForm">Currently Active Form</param>
        public static void CloseChildForm(Form currentForm)
        {
            //if (currentForm != null)
            //{
            //    currentForm.Close();
            //}
            currentForm?.Close();
        }

        /// <summary>
        /// This method is a Result Calculator System
        /// </summary>
        /// <param name="obtainedMark">Obtained marks</param>
        /// <param name="subjectMark">Subject marks</param>
        /// <returns></returns>
        public static (double MarksPercentage, double GradePoint, string LetterGrade) ResultCalculate(double obtainedMarks, double subjectMarks)
        {
            var markPct = ((obtainedMarks * 100) / subjectMarks);
            int schoolYear = 2023;

            var grade = Db.GetDataReader(
                "SELECT GRADE_POINT, LETTER_GRADE FROM S_GRADE WHERE SCHOOL_YEAR=" + schoolYear + " AND MIN_PCT<=" +
                markPct +
                " AND MAX_PCT>=" + markPct);

            var gradePoint = string.Empty;
            var letterGrade = string.Empty;

            if (grade.HasRows)
            {
                grade.Read();
                gradePoint = grade["GRADE_POINT"].ToString();
                letterGrade = grade["LETTER_GRADE"].ToString();
                grade.Close();
            }

            return (markPct, Convert.ToDouble(gradePoint), letterGrade);
        }
    }
}
