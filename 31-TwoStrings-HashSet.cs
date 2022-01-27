using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class TwoStrings_HashSet_Solution
    {
        public static void twoStrings(string s1, string s2) 
        {
            //hashset always store only distinct values, no duplication.
            HashSet<char> string1_char = new HashSet<char>();
            HashSet<char> string2_char = new HashSet<char>();

            //Fill distinct charters of s1
            foreach(char ch in s1) 
            {
                string1_char.Add(ch);
            }

            //Fill distinct charters of s2
            foreach (char ch in s2) 
            {
                string2_char.Add(ch);
            }
            //intersects keep common values.
            string1_char.IntersectWith(string2_char);
            if(string1_char.Count > 0) 
            {
                Console.WriteLine("YES");
                return; 
            }
            Console.WriteLine("NO");
            return;

        }
    }
    class TwoStrings_HashSet_Result
    {
        public static void Input() 
        {
            //string s1 = "and";
            //string s2 = "art";
            
            string s1 = "be";
            string s2 = "cat";
            
            //string s1 = "hello";
            //string s2 = "world";

            TwoStrings_HashSet_Solution.twoStrings(s1, s2);
        }
     
    }
}
