using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HackerRank
{
    public class PlusMinus_Solution
    {
        public static void plusMinus(int[] arr)
        {
            decimal n = arr.Length;            
            Dictionary<int, int> Positive = new Dictionary<int, int>();
            Dictionary<int, int> Negative = new Dictionary<int, int>();

            #region Postive
            //count total number of same and positive elements
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] > 0) 
                {
                    Positive[arr[i]] = Positive.ContainsKey(arr[i]) ? Positive[arr[i]] += 1 : Positive[arr[i]] = 1;                    
                }                
            }
            //calculate sum of all values
            int TotalPositive = Positive.Sum(x => x.Value);
            //calculate postive_ratio
            decimal Positive_Ratio = TotalPositive / n;
            #endregion

            #region Negative
            //count total number of same and negative elements
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Negative[arr[i]] = Negative.ContainsKey(arr[i]) ? Negative[arr[i]] += 1 : Negative[arr[i]] = 1;
                }
            }
            //calculate sum of all values
            int TotalNegative = Negative.Sum(x => x.Value);
            decimal Negative_Ratio = TotalNegative / n;
            #endregion

            #region Zero
            //count total number of 0 elements
            decimal TotalZero = n - (TotalPositive + TotalNegative);
            decimal Zero_Ratio= TotalZero / n;
            #endregion

            Console.WriteLine($"Positive_Ratio:{Positive_Ratio.ToString("N6")}");
            Console.WriteLine($"Negative_Ratio:{Negative_Ratio.ToString("N6")}");
            Console.WriteLine($"Zero_Ratio:{Zero_Ratio.ToString("N6")}");
        }
    }

    public class PlusMinus_Result
    {
        public static void Input()
        {
            //int[] array = new int[] {-4,3,-9,-4,0,4,1,3};
            int[] array = new int[] { 1, 2, 3, - 1, - 2, - 3, 0, 0 }; 
            PlusMinus_Solution.plusMinus(array);
        }
    }
}
