using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class BalancedBrackets_Solution
    {
        public static string isBalanced(string s) 
        {
            // Logic
            // create dictionary with open brakcets as key and close brackets as values.
            // if it is an open bracket (,{,[ then push into stack
            // else if it is a close bracket then check lastvalue of stack by pop,
            // if it is not the open bracket of the closed one like '{' for ')' then return false

            //Step-1 create dictionary with open brackets as key and close brackets as value
            // Key = (,{,[   value = ),},]

            //Step-2 create stack<char>.
            //Step-3 loop through s.length, if it is open bracket then add to stack
            // if close bracket then match it with stack last value, if both are not paired brackets then return false.


            int n = s.Length;
            if (n % 2 != 0)
                return "NO";
            if (n == 0)
                return "YES";

            Dictionary<char, char> pairs = new Dictionary<char, char> 
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            Stack<char> stack = new Stack<char>();
            
            
            for (int i = 0; i < s.Length; i++) 
            {
                if (pairs.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);                     //push in to stack open brackets (,{,[
                }
                else if (pairs.ContainsValue(s[i]))       // pair does not contains close brackets ),},] as key
                {
                    if (stack.Count == 0)                 //check weather any open bracket had been added, if it is starting with close bracket then false.
                        return "NO";

                    char openingBracket = stack.Pop();                    
                                                          //value )  openingBracket = (
                    if (pairs[openingBracket] != s[i])    //if value of openingBracket and s[i] are not same like ) and ) because we created respectively openbracket as key and close bracket as value
                        return "NO";
                }
            }
            // Ensure all brackets are closed
            return stack.Count() == 0 ? "YES" : "NO";
        }
    }
    internal class BalancedBrackets_Result
    {
        public static void Input() 
        {
            //string str = "{[()]}"; //output YES
            //string str = "{[(])}"; //output NO
            //string str = "{{[[(())]]}}"; //output YES
            string str = "{[(])}"; //output NO
            //string str = "{(([])[])[]}"; //YES

            string result = BalancedBrackets_Solution.isBalanced(str);
            Console.WriteLine(result);

        }
    }
}
