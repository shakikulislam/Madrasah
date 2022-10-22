using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WindowsDesktop.Models
{
    public class Student
    {
        public double Id { get; set; }
        public string FORM_NUMBER { get; set; }
        public int Roll { get; set; }
        public int Reg { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime Dob { get; set; }
        public string Birth_Certificate { get; set; }
        public string Nid { get; set; }
        public string Father_Name { get; set; }
        public string Father_Phone { get; set; }
        public string Father_Nid { get; set; }
        public string Mother_Name { get; set; }
        public string Mother_Phone { get; set; }
        public string Mother_Nid { get; set; }
        public string Guardian_Name { get; set; }
        public string Guardian_Phone { get; set; }
        public double Class_Id { get; set; }
        public string Remark { get; set; }
        public Image Picture { get; set; }
        public string Status { get; set; }
        public string Create_By { get; set; }
        public DateTime Create_Date { get; set; }
        public string Update_By { get; set; }
        public DateTime Update_Date { get; set; }

        public Address Address { get; set; }
    }
}
