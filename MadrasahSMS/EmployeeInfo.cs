using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadrasahSMS
{
    public class EmployeeInfo
    {
        public string Id { get; set; }
        public string EmpId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Nid { get; set; }
        public string DesigId { get; set; }
        public DateTime Dob { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime LeavingDate { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public Image Picture { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
