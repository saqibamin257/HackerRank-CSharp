using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
   public class IsPalindrome_Result
    {
        public static bool IsPalindrome(string str) 
        {
            if (str.Length <= 1) 
            {
                return true;   
            }
            else if (firstCharacter(str) != lastCharacter(str)) 
            {
                return false;
            }
            else 
            {
                return IsPalindrome(middleCharacter(str));
            }
        }
        private static char firstCharacter (string str) 
        {
             return Convert.ToChar(str.Substring(0, 1));
        }
        private static char lastCharacter(string str)
        {
            return Convert.ToChar(str.Substring(str.Length-1, 1));
        }

        private static string middleCharacter(string str)
        {
            return str.Substring(1, str.Length-2);
        }


    }
    public class IsPalindrome_Solution 
    {
        public static void Input() 
        {
            bool Result;
            string str = "rotor";
            //string str = "motor";
            //string str = "madam";
            //string str = "honest";
            Result =IsPalindrome_Result.IsPalindrome(str);
            
            if (Result)
                Console.WriteLine($"{str} is Palindrome!");
            else
            { Console.WriteLine($"{str} is not Palindrome!"); }
                    
        }
    }
}
