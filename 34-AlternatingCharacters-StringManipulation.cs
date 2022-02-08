using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class AlternatingCharacters_Solution
    {
        public static int AlternatingCharacters(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++) 
            {                
                if ( (i+1 < s.Length) && (s[i] == s[i + 1])) 
                {
                    //s = s.Remove(i+1,1);
                    //it is not required as we just need to count occurance if s[i]==s[i+1],
                    //when i performed Remove operation, it did not pass all test cases on hacker rank.
                    count++;
                }                
            }
            return count;
        }
    }

    class AlternatingCharacters_Result
    {
        public static void Input() 
        {
            //string s = "AABAAB";      //output: 2
            //string s = "AAAA";         //output: 3
            //string s = "BBBBB";     //output: 4
            //string s = "ABABABAB";  //output:0
            //string s = "BABABA";    //output:0
            string s = "AAABBB";    //output:4

            



            int result = AlternatingCharacters_Solution.AlternatingCharacters(s);
            Console.WriteLine($"Total character deletions are: {result}");
        }
    }
}
