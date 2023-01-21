using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class DigitalRecursiveSum_Solution
    {
        public static int RecursiveSum(string n, int k) 
        {
            string p = string.Empty;
            for(int i = 1; i <= k; i++) 
            {
                p = $"{p}{n}";
            }
            
            int result = new DigitalRecursiveSum_Solution().calculateSum(p);
            while (result.ToString().Length != 1) 
            {
                string digits = result.ToString();
                result = new DigitalRecursiveSum_Solution().calculateSum(digits);
            }
            return result;          
        }
        private int calculateSum(string number) 
        {
            int sum = 0;
            for(int i = 0; i < number.Length; i++) 
            {
                sum += Int32.Parse(number[i].ToString());
            }
            return sum;
        }
    }
    internal class DigitalRecursiveSum_Result
    {
        public static void Input() 
        {
            string n = "123";
            int k = 3;
            //output = 9
            int result = DigitalRecursiveSum_Solution.RecursiveSum(n, k);
            Console.WriteLine(result);
        }
    }
}
