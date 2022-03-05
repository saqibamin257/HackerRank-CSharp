using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class GreedyFlorist_Solution
    {       
        public static int getMinCost(int k, int[] arr) 
        {
            //Buy most expensive flowers first(prevPurchase = 0) in cheapest rate.
            //then increase previousPurchase by 1 for other flowers for group of friend
            //Sort Array and start buying in reverse order.
            Array.Sort(arr);
            int prevPurchase = 0;
            int count = 0;
            int minSum = 0;
            for (int i = arr.Length - 1; i >= 0; i--) 
            {
                if(count < k) 
                {
                    minSum += arr[i] * (prevPurchase + 1);
                    count++;
                }
                else 
                {
                    count = 0;
                    prevPurchase++;
                    i++;
                }
            }
            return minSum;
        }
    }
    internal class GreedyFlorist_Result
    {
        public static void Input() 
        {

            //int k = 3;
            //int[] C = new int[] { 1, 2, 3, 4 }; //output 11

            //int k = 3;
            //int[] C = new int[] { 2,5,6 }; //output 13

            //int k = 2;
            //int[] C = new int[] { 2, 5, 6 }; //output 15

            //int k = 3;
            //int[] C = new int[] { 1, 3, 5, 7, 9 }; //output 29

            int k = 2;
            int[] C = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; //output 125

            int result = GreedyFlorist_Solution.getMinCost(k, C);
            Console.WriteLine(result);
        }        
    }
}
