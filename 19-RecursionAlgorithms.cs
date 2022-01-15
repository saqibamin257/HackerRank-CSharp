using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class RecursionAlgorithms_Result
    {
        public static int Factorial(int n) 
        {
            #region By-Loop-Iteration
            //int result=1;
            //for(int i=n; i > 0; i--) 
            //{
            //    result = result * i;
            //}
            //return result;
            #endregion

            #region By-Recursion
            //base criteria
            
            if (n == 0) 
            { return 1; }

            //progressive criteria

            return n * Factorial(n - 1);
            #endregion
        }

        public static void PrintNaturalNumber_AscendingOrder(int number, int start) 
        {
            #region Ascending Order
            
            if (number > 0)
            {
                Console.WriteLine(start);
                start++;
                PrintNaturalNumber_AscendingOrder(number-1, start);
            }
            #endregion
        }


        public static void PrintNaturalNumber_DescendingOrder(int number) 
        {
            #region Iteration
            //for(int i = 1; i <= number; i++) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region ReverseOrder

            if (number > 0)
            {
                Console.WriteLine(number);
                PrintNaturalNumber_DescendingOrder(number - 1);
            }

            #endregion
        }
        public static int SumOfNaturalNumbers(int num) 
        {
            if (num == 0)
            { return 1; }
            
            return num + SumOfNaturalNumbers(num - 1);            
        }

        public static void SeparateDigits(int n) 
        {
            if (n < 10)
            {
                Console.Write("{0}  ", n);
                return;
            }
            SeparateDigits(n / 10);
            Console.Write(" {0} ", n % 10);
        }

        public static int MultiplyByExponent(int exp, int number) 
        {
            if (exp == 0) 
            {
                return 1;
            }
            return number * MultiplyByExponent(exp - 1, number);
            
        }       

       
    }

    public class RecursionAlgorithms_Solution
    {
        public static void Input() 
        {
            #region Program-1 Factorial
            //int number = 5;
            //int result = RecursionAlgorithms_Result.Factorial(number);
            //Console.WriteLine($"Factorial of {number} is: {result}");
            #endregion

            #region Program-2(a) NaturalNumbers_AscendingOrder
            int num = 10;
            int start = 1;
            RecursionAlgorithms_Result.PrintNaturalNumber_AscendingOrder(num,start);
            #endregion

            #region Program-2(b) NaturalNumbers_DescendingOrder
            //int num = 10;            
            //RecursionAlgorithms_Result.PrintNaturalNumber_DescendingOrder(num);
            #endregion


            #region Program-3 SumOfNaturalNumbers
            //int num = 10;
            //int result = RecursionAlgorithms_Result.SumOfNaturalNumbers(num);
            //Console.WriteLine($"Sum of first {num} natural numbers: {result}");
            #endregion

            #region Program-4 Convert Number to individual digits
            //int number = 123;
            //RecursionAlgorithms_Result.SeparateDigits(number);
            #endregion


            #region Program-5 Multiply number by its Exponent
            //int exponent = 3;
            //int number = 4;            
            //int Result= RecursionAlgorithms_Result.MultiplyByExponent(exponent, number);
            //Console.WriteLine($"Result of {number} exp {3} is:{Result}");
            #endregion

        }



    }
}
