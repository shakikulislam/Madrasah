﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MadrasahSMS.DbContext;

namespace MadrasahSMS.Common
{
    public class GlobalSettings
    {
        #region Property/Variable
        
        public static string Server { get; set; }
        public static EmployeeInfo LoggedEmployee { get; set; }
        public static string DateFormatShortView { get; } = "dd-MMM-yy";
        public static string DateFormatSave { get; } = "yyyy-MM-dd";
        public static OfficeInfo OfficeInfo { get; set; }
        public static string MarkCalculateYear { get; set; } = "2023";
        public static frmWaiting Waiting;

        #endregion Property/Variable

        #region Enum (enumeration) Constant

        public enum Status
        {
            A,  //Active
            DA, //DeActive
            ME, //MarkEntry
            I   //In-Active/Absent
        }

        #endregion Enum

        #region Method

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
        public static (string MarksPercentage, string GradePoint, string LetterGrade) ResultCalculate(double obtainedMarks, double subjectMarks, string year)
        {
            var obtainedFinalMark = obtainedMarks > subjectMarks ? subjectMarks : obtainedMarks;

            var markPct = ((obtainedFinalMark * 100) / subjectMarks);

            var query = "SELECT GRADE_POINT, LETTER_GRADE FROM S_GRADE WHERE SCHOOL_YEAR = " + year + 
                        " AND " + markPct + " >= MIN_PCT AND " + markPct;

            query += markPct == 100 ? " <= MAX_PCT" : " < MAX_PCT";

            var grade = Db.GetReader(query);

            var gradePoint = string.Empty;
            var letterGrade = string.Empty;

            if (grade.HasRows)
            {
                grade.Read();
                gradePoint = grade["GRADE_POINT"].ToString();
                letterGrade = grade["LETTER_GRADE"].ToString();
                grade.Close();
            }

            return (markPct.ToString("N"), gradePoint, letterGrade);
        }


        #endregion Method
    }
}
