using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class MarkAndToys_Result
    {
        public static int maximumToys (int[] arr, int budget) 
        {
            int count = 0;
            int sum = 0;
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++) 
            {
                sum = sum + arr[i];
                if(sum <= budget) 
                { count++; }
                else { break; }
            }
            return count;
        }
    }

    public class MarkAndToys_Solution
    {
        public static void Input() 
        {
            int[] numArray = new int[] { 1, 12, 5, 111, 200, 1000, 10 };
            int budget = 50;
            int totalToys =  MarkAndToys_Result.maximumToys(numArray, budget);
            //output 4
            
            //int[] numArray = new int[] { 1, 2, 3, 4 };
            //int budget = 7;
            //output 3

            Console.WriteLine($"Maximum toys Mark can buy:{totalToys}");
        }
        

    }
}
