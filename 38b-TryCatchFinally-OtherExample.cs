using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class checkException_Solution
    {
        public static void checkException() 
        {
            try
            {
                int num1 = 10;
                int num2 = 0;
                try
                {
                    int result = num1 / num2;
                    Console.WriteLine(result);
                }
                catch(DivideByZeroException e) 
                {
                    Console.WriteLine(e.Message);
                }

                int[] arr = new int[3] { 10, 20, 30 };
                Console.WriteLine(arr[10]);

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Exception caught : {ex.Message}");
            }
            finally 
            {
                Console.WriteLine("Finally block executed.");
            }
        }

    }
    internal class checkException_Result
    {
        public static void Input() 
        {
            checkException_Solution.checkException();
        }
    }
}
