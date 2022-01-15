using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
   public class SampleTest_Result
   {
        public static void BuzzFizz(int n) 
        {
            for(int i=1; i<=n; i++) 
            {
                switch (i) 
                {
                    case int a when ( i%3 == 0 && i%5 == 0):
                        Console.WriteLine("FizzBuzz");
                        break;

                    case int a when (i % 3 == 0):
                        Console.WriteLine("Fizz");
                        break;

                    case int a when (i % 5 == 0):
                        Console.WriteLine("Buzz");
                        break;
                    
                    default:
                        Console.WriteLine(i);
                        break;
                }
                    

                //if(i%3==0 && i % 5 == 0) 
                //{
                //    Console.WriteLine("FizzBuzz");
                //}
                //else if (i % 3 == 0) 
                //{
                //    Console.WriteLine("Fizz");
                //}
                //else if( i%5 == 0) 
                //{
                //    Console.WriteLine("Buzz");
                //}
                //else { Console.WriteLine(i); }
            }
        }
   }
   public class SampleTest_Solution
   {

        public static void Input() 
        {
            int n = 15;
            SampleTest_Result.BuzzFizz(n);
        }
   }
}
