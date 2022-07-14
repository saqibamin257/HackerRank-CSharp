using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class FibonnacciSeries_Solution
    {
        public static int Fibonnaci(int n) 
        {
            int previous = 0, current = 1;
            
            for (int i = 2; i <= n; i++) 
            {
                int newValue = previous + current;
                previous = current;
                current = newValue;
            }
            return current;
        }
        public static int FibonnaciRecursion(int n) 
        {
            if(n == 0 || n == 1) 
            {
                return n;
            }
            else 
            {
                return FibonnaciRecursion(n - 1) + FibonnaciRecursion(n - 2);
            }
        }
    }
    internal class FibonnacciSeries_Result 
    {
        public static void Input() 
        {   //Series = 0,1,1,2,3,5,8,13

            #region Fibbonacci By Loop
            //Test-1
            //int number = 3;
            //output = 2

            //Test-2
            int number = 6;
            //output = 8;            
            int result = FibonnacciSeries_Solution.Fibonnaci(number);
            Console.WriteLine($"Fibbonacci Series by Loop: {result}");
            #endregion

            #region Fibonacci By Recursion
            //int num = 6;
            ////output =8;
            int num = 7;
            //output =13;
            int res = FibonnacciSeries_Solution.FibonnaciRecursion(num);
            Console.WriteLine($"Fibbonacci Series by Rescursion: {res}");
            #endregion


        }
    }
}
