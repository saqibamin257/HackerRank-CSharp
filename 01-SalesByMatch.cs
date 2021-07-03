using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
   public class Result
    {       
        public static int sockMerchant(int n, List<int> ar) 
        {
            int Total = 0;
            List<int> valuesExists = new List<int>();
            for (int i = 0; i <= ar.Count-1; i++) 
            {
                if (!valuesExists.Contains(ar[i])) 
                {
                    valuesExists.Add(ar[i]);
                    int Count = 0;
                    for (int j = i; j <= ar.Count - 1; j++)
                    {
                        if (ar[i] == ar[j])
                        {
                            Count++;
                        }
                    }
                    Total = Total + (Count / 2);
                }
            }
            return Total;
        }
    }

   public class Solution 
    {
        public static void SalesByMatch()
        {
            int n = 9;
            string numbers = "10 20 20 10 10 30 50 10 20";
            List<int> ar = numbers.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = Result.sockMerchant(n, ar);
            Console.WriteLine("Result:" + result);
            Console.ReadKey(true);
        }        
    }
}
