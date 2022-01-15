using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class TwoSums_Result
    {
        public static int[] TwoSums(int[] arr, int target) 
        {
            //List<int> lst = new List<int>();
            int[] result = new int[2];
            for(int i = 0; i < arr.Length; i++) 
            {
                for(int j = i + 1; j < arr.Length; j++) 
                {
                    if(target == arr[i] + arr[j]) 
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
    }
    public class TwoSums_Solution 
    {
        public static void Input() 
        {
            //int[] nums = new int[] { 2, 7, 11, 15 };
            //int target = 9;
            //Output:[0,1]
            
            int[] nums = new int[] { 3, 2, 4}; 
            int target = 6;
            //Output:[1,2]


            int[] ResultArray = TwoSums_Result.TwoSums(nums, target);
            if (ResultArray.Length > 0) 
            {                
                foreach (var number in ResultArray)
                {
                    Console.WriteLine(number);
                }
            }
        }
        
    }
}
