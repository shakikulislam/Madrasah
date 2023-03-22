namespace MadrasahSMS.Common
{
    public class ContentText
    {
        public static string AreYouSure { get; set; } = "Are you sure? ";
        public static string LastRecordMessage { get; set; } = "This is last record";
        public static string ExamScheduleNotFound { get; set; } = "Exam schedule not found";
        public static string CreateExamSchedule { get; set; } = "Please create exam schedule and try again";
        public static string StudentNotFound { get; set; } = "Student not found.";
        public static string DeleteSelectionItem { get; set; } = AreYouSure + "you want to delete this selected item?";
        public static string MarksMissing { get; set; } = "Marks missing";
        public static string MakeAbsentMessage { get; set; } = AreYouSure + "This student is absent?";
        public static string MakeAttendMessage { get; set; } = AreYouSure + "This student is attend?";
        public static string ProcessWithoutAbsentList { get; set; } = "Do you want to process results without this list?";
        public static string AbsentList { get; set; } = "Absent List";
        public static string MandatorySubjectList { get; set; } = "Mandatory Subject List";
        public static string ResultAlreadyProcessed { get; set; } = "Result Already Processed";
        public static string ReprocessResult { get; set; } = AreYouSure + "Reprocess this result";
        public static string FinalExamAlreadyExist { get; set; } = "Final exam already exist";

    }
}
