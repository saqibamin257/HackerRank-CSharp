using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class TryCatchFinally_Result
    {
        int result;
       public TryCatchFinally_Result()
        {
            result = 0;
        }
        public void Division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                throw e;
                //Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine($"result :{result}");
            }
        }
    }
    internal class TryCatchFinally_Solution
    {
        public static void Input() 
        {
            TryCatchFinally_Result objTry = new TryCatchFinally_Result();
            objTry.Division(3, 0);
        }
        
    }
}
