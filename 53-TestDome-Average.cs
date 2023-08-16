using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class TestDome_Solution
    {
        public static double Average(int a, int b)
        {
            return (Convert.ToDouble(a + b) / 2);
        }
    }

    internal class TestDome_Result
    {
        public static void Input()
        {
            Console.WriteLine(TestDome_Solution.Average(2, 1));
        }
    }
}
