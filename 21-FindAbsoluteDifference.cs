using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class FindAbsoluteDifference_Result
    {
        public static void AbsoulteDifference(string strArray) 
        {
            char[] str = strArray.ToCharArray();
            Array.Sort(str);
            decimal firstLetter_TotalLength = 0;
            decimal secondLetter_TotalLength = 0;
            for(int i = 0; i < str.Length; i++) 
            {
                if(str[i]!= str[i + 1]) 
                {
                    firstLetter_TotalLength = i + 1;
                    secondLetter_TotalLength = str.Length - firstLetter_TotalLength;
                    break;
                }
            }

            decimal absolute_Diff = Math.Abs(firstLetter_TotalLength - secondLetter_TotalLength);
            Console.WriteLine($"Absoulte difference is : {absolute_Diff}");
        }
    }

    public class FindAbsoluteDifference_Solution
    {
        public static void Input() 
        {
            //string str = "AAABBAB";            
            //FindAbsoluteDifference_Result.AbsoulteDifference(str);
            //output 1

            string str = "AAAAABBAB";            
            FindAbsoluteDifference_Result.AbsoulteDifference(str);
            //output 3

        }
    }
}
