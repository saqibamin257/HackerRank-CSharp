using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace HackerRank
{
    public class BracketMatcher_CoderByte_Solution
    {
        //---- Bracket Matcher
        //----Have the function BracketMatcher(str) take the str parameter being passed and return 1 if the brackets are correctly matched and each one is accounted for.
        // Otherwise return 0.
        // For example: if str is "(hello (world))", then the output should be 1,
        // but if str is "((hello (world))" the the output should be 0 because the brackets do not correctly match up.
        // Only "(" and ")" will be used as brackets.If str contains no brackets return 1.
        // Examples
        // Input: "(coder)(byte))"
        // Output: 0
        // Input: "(c(oder)) b(yte)"
        // Output: 1 
        public int checkBracketMatched() 
        {
            //example-1
            //string str = "(hello (world))"; //return 1
            
            //example-2
            //string str = "((hello (world))"; //return 0
            
            //example-3
            string str ="(()()(())"; //return 0

            if (!str.Contains("(") && !str.Contains(")"))
                return 0;
            
            
            Dictionary<char, int> MyDict = new Dictionary<char, int>();
           
            //extract only brackets from string and insertion in dictionary
                for (int i = 0; i < str.Length; i++) 
                {
                    if (str[i] == '(' || str[i] == ')')
                    {
                        if (MyDict.ContainsKey(str[i])) 
                        {
                            MyDict[str[i]]++;
                        }
                        else 
                        {
                            MyDict.Add(str[i], 1);
                        }
                    }
                }
                if (MyDict.ElementAt(0).Value != MyDict.ElementAt(1).Value)
                    return 0;
                
            return 1;
        }
    }    
}
