using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal static class CountSaturday_Solution
    {
        public static int TotalSaturdayOfMonth(int year, int month) 
        {
            int totalDay = DateTime.DaysInMonth(year, month);
            int count = 0;

            for (int i = 1; i <= totalDay; i++)
            {
                DateTime checkDate = new DateTime(year, month, i);
                string day = checkDate.DayOfWeek.ToString();
                if (day.ToLower() == "saturday")
                    count++;
            }

            return count;
        }
    }
    internal class CountSaturday_Result 
    {
        public static void Input() 
        {
            int year = 2022;
            int month = 4;            
            string monthName= new DateTime(year,month,1).ToString("MMMM");
            int result = CountSaturday_Solution.TotalSaturdayOfMonth(year,month);
            Console.WriteLine($"Total no of saturdays in {monthName } are: {result}");
        }

    }
}
