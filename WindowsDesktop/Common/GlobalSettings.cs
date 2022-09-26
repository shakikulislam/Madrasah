using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace WindowsDesktop.Common
{
    public class GlobalSettings
    {
        //Variable
        private static string _devUser = "DEVELOPER";
        private static string _devPass = "developer12345";
        private static string _viewDateFormatShort = "dd-MMM-yy";
        private static string _viewDateFormatShortWithDay = "dddd dd-MMM-yy";
        private static string _saveDateFormat = "yyyy-MM-dd";

        //Property
        public static string DevUser { get { return _devUser; } }
        public static string DevPass { get { return _devPass; } }
        public static DataTable OfficeInfo { get; set; }
        public static string Server { get; set; }
        public static string EmployeeId { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; }
        public static string DateFormatShortView { get { return _viewDateFormatShort; } }
        public static string DateFormatShortWithDateView { get { return _viewDateFormatShortWithDay; } }
        public static string DateFormatSave { get { return _saveDateFormat; } }

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
            var bytes = (byte[])imgConv.ConvertTo(image, Type.GetType("System.Byte[]"));
            return bytes;
        }
    }
}
