using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class HackerRankSampleTest_Solution
    {
        public static string findNumber(int[] array, int k) 
        {
            int[] arr = array.ToArray();
            Array.Sort(arr);
            int min = 0;            
            int max = arr.Length-1;
            while(min <= max) 
            {
                int target = Convert.ToInt32(Math.Floor(Convert.ToDecimal((min + max) / 2)));

                if (arr[target] == k)
                {                   
                    return "YES";
                }

                else if (arr[target] < k)
                {
                    min = target + 1;
                }
                else
                {
                    max = target - 1;
                }
            }
            return "NO";
        }
    }

    internal class HackerRankSampleTest_Result
    {
        public static void Input() 
        {
            int[] array = new int[] {1,2,3,4,5,6 };
            int k = 4;
            string result = HackerRankSampleTest_Solution.findNumber(array,k);
            Console.WriteLine(result);
        }
    }

}
