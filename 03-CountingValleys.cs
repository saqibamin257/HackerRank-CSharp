using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
   public class altitudeingvalleyCounts_Result
    {
        public static int altitudeingvalleyCounts(int steps, string path)
        {
            char[] ch = path.ToCharArray();
            int altitude = 0, valleyCount = 0;
            for (int i = 0; i < ch.Length; i++) 
            {
                if ( ch[i].ToString().ToUpper() == "U")
                {
                    altitude++;
                    if (altitude == 0)
                        valleyCount++;
                }
                else
                {
                    altitude--;
                }                
            }
            return valleyCount;             
        }
    }

    public class altitudeingvalleyCounts_Solution 
    {
        public static void altitudeingvalleyCounts() 
        {
            //TestCase-1
            //int steps = 8;
            //string path = "UDDDUDUU";

            //TestCase-2
            int steps = 12;
            string path = "DDUUDDUDUUUD";

            int result = altitudeingvalleyCounts_Result.altitudeingvalleyCounts(steps,path);

            Console.WriteLine(result);

        }

    }
}
