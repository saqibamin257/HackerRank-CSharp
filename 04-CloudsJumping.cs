using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class CloudsJumping_Result
    {
        //public static int jumpingOnClouds(List<int> c)
        //{
        //    int totalJumps = 0;
        //    int cycle = 0;
        //    for (int i = 0; i < c.Count - 1; i++)
        //    {
        //        if (c[i] == 0)
        //        {
        //            if (cycle + 2 <= c.Count - 1 && c[i + 2] == 0)
        //            {
        //                totalJumps++;
        //                i++;
        //                cycle = cycle + 2;
        //            }
        //            else if (c[i + 1] == 0)
        //            {
        //                totalJumps++;
        //                cycle++;
        //            }
        //        }
        //    }
        //    return totalJumps;
        //}
        public static int jumpingOnClouds(List<int> c)
        {
            int counter = -1;
            int length = c.Count;

            for (int i = 0; i < length; i++, counter++)
            {
                if (i + 2 < length && c[i + 2] == 0)
                {
                    i++;
                }
            }
            return counter;
        }
    }

    public class CloudsJumping_Solution
    {
        public static void CloudsJumping()
        {
            //Test-1            
            string numbers = "0 0 0 0 1 0";
            //output = 3

            //Test-2
            //string numbers = "0 0 1 0 0 1 0";
            //output = 4

            //Test-3
            //string numbers = "0 1 0 0 0 1 0";
            //output = 3

            //Test-4
            //string numbers = "0 1 0 0 0 1 1";
            //output = 2

            //Test-5
            //string numbers = "0 0 0 1 0 0";
            //output = 3
            

            List<int> c = numbers.TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();            
            int result = CloudsJumping_Result.jumpingOnClouds(c);
            Console.WriteLine(result);
        }
    }
}



