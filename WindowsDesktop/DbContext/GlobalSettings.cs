﻿
using System;
using System.Data;

namespace WindowsDesktop.DbContext
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

    }
}
