using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class BalancedBracket2_Solution
    {
        public static string isBalanced(string s)
        {
            if(!string.IsNullOrEmpty(s))
            {
                while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
                {
                    s=s.Replace("()", "");
                    s=s.Replace("[]", "");
                    s=s.Replace("{}", "");
                }
            }
            if (s.Length == 0)
                return "YES";
            else return "NO";
        }
    }

    internal class BalancedBracket2_Result
    {
        public static void Input()
        {
            //string str = "{[()]}"; //output YES
            //string str = "{[(])}"; //output NO
            //string str = "{{[[(())]]}}"; //output YES
            string str = "{[(])}"; //output NO
            //string str = "{(([])[])[]}"; //YES

            string result = BalancedBracket2_Solution.isBalanced(str);
            Console.WriteLine(result);

        }
    }
}
