using System.Globalization;

namespace api_inoutboard.models
{
    public class Week
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int WeekNumber { get; set; }
        public string MondayStatus { get; set; }
        public TimeOnly MondayStart { get; set; }
        public TimeOnly MondayEnd { get; set; }
        public string MondayNote { get; set; }
        public string TuesdayStatus { get; set; }
        public TimeOnly TuesdayStart { get; set; }
        public TimeOnly TuesdayEnd { get; set; }
        public string TuesdayNote { get; set; }
        public string WednesdayStatus { get; set; }
        public TimeOnly WednesdayStart { get; set; }
        public TimeOnly WednesdayEnd { get; set; }
        public string WednesdayNote { get; set; }
        public string ThursdayStatus { get; set; }
        public TimeOnly ThursdayStart { get; set; }
        public TimeOnly ThursdayEnd { get; set; }
        public string ThursdayNote { get; set; }
        public string FridayStatus { get; set; }
        public TimeOnly FridayStart { get; set; }
        public TimeOnly FridayEnd { get; set; }
        public string FridayNote { get; set; }
        public string WeekNote { get; set; }
        public DateTime Updated { get; set; }


        public Week ()
        {
            Random rnd = new Random();

            Id = rnd.Next(999999);
            Updated = DateTime.Now;
            Year = DateTime.Now.Year;
            WeekNumber = ISOWeek.GetWeekOfYear(DateTime.Now);

            MondayStatus = "WFH";
            MondayStart = new TimeOnly(08, 00);
            MondayEnd = new TimeOnly(16, 00);
            MondayNote = "";

            TuesdayStatus = "WFH";
            TuesdayStart = new TimeOnly(08, 00);
            TuesdayEnd = new TimeOnly(16, 00);
            TuesdayNote = "";

            WednesdayStatus = "Office";
            WednesdayStart = new TimeOnly(07, 30);
            WednesdayEnd = new TimeOnly(15, 30);
            WednesdayNote = "";

            ThursdayStatus = "WFH";
            ThursdayStart = new TimeOnly(08, 00);
            ThursdayEnd = new TimeOnly(16, 00);
            ThursdayNote = "";

            FridayStatus = "WFH";
            FridayStart = new TimeOnly(08, 00);
            FridayEnd = new TimeOnly(16, 00);
            FridayNote = "";

            WeekNote = "";
        }

    }
}
