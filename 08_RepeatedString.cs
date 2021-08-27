using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class RepeatedString_Result
    {
        //public static long RepeatedString(string s, long n) 
        //{
        //    //-----***create Extended string

        //    int count = 0;
        //    int letterCount = 0;



        //    string ExtendedString = string.Empty;
        //    for (int i = 0; i < n;) 
        //    {   if(count < s.Length) 
        //        {
        //            ExtendedString += s[count];
        //            count++;
        //            i++;
        //        }
        //        else
        //        {
        //            count = 0;
        //        }      
        //    }

        //    //-----*** Count total number of a's from Extended string

        //    for (int j = 0; j < ExtendedString.Length; j++) 
        //    {
        //        if (ExtendedString[0] == ExtendedString[j]) 
        //        {
        //            letterCount++;
        //        }
        //    }



        //    return letterCount;
        //}
        public static long RepeatedString(string s, long n)
        {
            int strLength = s.Length;
            long q = n / strLength;    //qoutient
            long r = n % strLength;   //remainder
            long partialStrLen = (r == 0) ? 0 : r;
            
            //formula = qoutient *(freq of 'a' in S) + (freq of 'a' in Substring of length r) 
            
            long aCount = q * getLetterCount(s, strLength) + getLetterCount(s, partialStrLen);          
            return aCount;
        }

        public static long getLetterCount(string s, long strLength)
        {
            long count = 0;
            for(int i=0; i<strLength; i++) 
            {
                if (s[i] == 'a')
                    count++;
            } 
            return count;
        }
    }

    public class RepeatedString_Problem 
    {
        public static void Input() 
        {
            //Test Case-1

            string s = "aba";
            long n = 10;
            //s= "abaabaabaa"
            //output => total no. of a = 7

            //Test Case-2

            //string s = "a";
            //long n = 10000000000;

            //output => total no. of a = 10000000000


            long Result = RepeatedString_Result.RepeatedString(s, n);            
            Console.WriteLine(Result);

        }
    }
}
