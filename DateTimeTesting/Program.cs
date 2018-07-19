using System;
using System.Collections.Generic;

namespace testing
{
    class HolidayChecker
    {

        public static List <DateTime> holidays = new List <DateTime>{new DateTime (2018,12,31), new DateTime(2018, 11, 25)};

        public static void AddHoliday(DateTime date)
        {
            holidays.Add(date);
        }
        public static bool CheckTodayHoliday(DateTime date)
        {
            var checkHolidays = holidays.Contains(date);
            if (checkHolidays)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public 
        static void Main(string[] args)
        {
            AddHoliday(DateTime.Today);
            Console.WriteLine(CheckTodayHoliday(DateTime.Today));            
        }
    }
}
