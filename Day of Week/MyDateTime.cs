using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class MyDateTime
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public MyDateTime()
        {

        }
        public MyDateTime(string day, string month, string year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public void calAndPrintTheDayOfWeek()
        {
            Console.WriteLine("Enter day (d-M-yyyy): ");
            string dateAsText = Console.ReadLine();

            DateTime currentDayTime = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(currentDayTime.DayOfWeek);
        }
    }
}
