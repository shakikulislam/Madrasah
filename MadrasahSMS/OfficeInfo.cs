using System.Drawing;

namespace MadrasahSMS
{
    public class OfficeInfo
    {
        public string Id { get; set; }
        public string NameEnglish { get; set; }
        public string NameBangla { get; set; }
        public string NameArabic { get; set; }
        public string SchoolYear { get; set; }
        public string InstallDate { get; set; }
        public string CurrentVersion { get; set; }
        public string Status { get; set; }
        public Image Logo { get; set; }
        public bool PreExamEffFinal { get; set; }
    }
}
