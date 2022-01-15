using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class BinarySearch_Solution
    {
        public static int doSearch(int[] arr, int TargetValue) 
        {
            int min = 0;
            int max = arr.Length - 1;
            int guess=0;
            while(min <= max) 
            {
                //find avg.
                guess = Convert.ToInt32(Math.Floor(Convert.ToDecimal((min+max)/2)));
                if (arr[guess] == TargetValue)
                {
                    return guess;
                }
                else if (arr[guess] < TargetValue) 
                {
                    min = guess + 1;
                }
                else 
                {
                    max = guess - 1;
                }                 
            }
            return -1;
        }
    }
    public class BinarySearch_Result
    {
        public static void Input() 
        {
            int[] primes = new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
                                      41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

            int result = BinarySearch_Solution.doSearch(primes, 73);
            Console.WriteLine("Found prime at index " + result);
        }
    }
}
