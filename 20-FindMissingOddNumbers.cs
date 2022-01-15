using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class FindMissingOddNumbers_Result
    {
        public static void MissingOddNumber(int[] arr) 
        {
            Array.Sort(arr);
            List<int> lstNumbers = new List<int>();
            for(int i = 0; i < arr.Length; i++) 
            {
                if( i+1 < arr.Length && arr[i+1]!=arr[i]+2) 
                {
                    lstNumbers.Add(arr[i] + 2);
                }
            }
            if (lstNumbers.Count > 0) 
            {
                foreach(var digit in lstNumbers) 
                {
                    Console.WriteLine($"{digit}");
                }
            }
            else
            {
                Console.WriteLine("No Missing Number in element!");
            }
        }
    }

    public class FindMissingOddNumbers_Solution
    {
        public static void Input() 
        {
            int[] oddNumber = new int[] { 9, 7, 3, 13, 17};
            FindMissingOddNumbers_Result.MissingOddNumber(oddNumber);
        }
    }


}
