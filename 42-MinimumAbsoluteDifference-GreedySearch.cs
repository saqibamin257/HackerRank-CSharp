using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class MinimumAbsoluteDifference_GreedySearch_Result
    {
        public static int MinAbsoluteDifference(int[] arr) 
        {
            int minDifference = int.MaxValue;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length-1; i++) 
            {
              minDifference = Math.Min(Math.Abs(arr[i] - arr[i+1]),minDifference);               
                if (minDifference == 0)                       
                return 0;                
            }
            return minDifference;
        }
    }

    internal class MinimumAbsoluteDifference_GreedySearch_Solution
    {
        public static void Input() 
        {
            int[] arr = new int[] { -59, - 36, - 13, 1, - 53, - 92, - 2, - 96, - 54, 75 };
            int result = MinimumAbsoluteDifference_GreedySearch_Result.MinAbsoluteDifference(arr);
            Console.WriteLine(result);
        }
    }

}
