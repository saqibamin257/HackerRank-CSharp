using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    class MinimumTimeRequired_Solution
    {
        //public static long MinimumTimeRequired(long[] machines, long goal)
        //{
        //    long day = 0;
        //    int count = 0;

        //    Dictionary<long, long> Map = new Dictionary<long, long>();

        //    while(count != goal) 
        //    {
        //        day++;
        //        for (int i = 0; i < machines.Length; i++) 
        //        {
        //            if (day % machines[i] == 0)
        //            {
        //                count++;
        //            }
        //        }              
        //        Map.Add(day, count); //this is not necessay, this is just to check the total records after everyday                              
        //    }

        //    return day;
        //}
        //public static long MinimumTimeRequired(long[] machines, long goal) 
        //{
        //    Array.Sort(machines);            
        //    long n = machines.Length;
        //    /// according to constraint 
        //    /// 1< machines[i]< 10^9
        //    long min = 1;
        //    long max = 1000000000; //10^9

        //    long guess = 0;
        //    while (min <= max) 
        //    {
        //        guess = (long)(Math.Floor(Convert.ToDecimal((min + max) / 2)));
        //        long count = 0;
        //        for (int i = 0; i < n; i++) 
        //        {
        //            count += guess / machines[i];
        //        }
        //        if(count == goal) 
        //        {
        //            return guess-1; //as initial min value is 1 not 0 that is why we are doing -1, In binary search usually we search from 0.
        //        }

        //        if (count < goal) 
        //        {
        //            min = guess + 1;
        //        }
        //        else 
        //        {
        //            max = guess - 1;
        //        }
        //    }

        //    return -1;
        //}
        public static long MinimumTimeRequired(long[] machines, long goal) 
        {
            Array.Sort(machines);
            long left = machines[0];
            long right = machines[0] * goal;
            while (left <= right) 
            {
                long mid = (left + right) / 2;
                long count = 0;
                for (int i = 0; i < machines.Length; i++) 
                {
                    count += mid / machines[i];
                }
                if (count >= goal) 
                {
                    right = mid - 1;
                }
                else 
                {
                    left = mid + 1;
                }
            }
            return left;
        }

    }
    class MinimumTimeRequired_Result
    {
        public static void Input() 
        {
            //long goal = 10; 
            //long[] machines = new long[] { 1, 3, 4 };
            //output = 7 
            
            long goal = 12;
            long[] machines = new long[] { 4, 5, 6 };
            //output= 20
            long minDays = MinimumTimeRequired_Solution.MinimumTimeRequired(machines, goal);
            Console.WriteLine($"Min days are required: {minDays}");
        }
    }
}
