using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    class MakingAnagrams_Solution
    {
        //1- Using Dictionary
        public static int makingAnagrams(string a, string b)
        {
            char[] CharArray1 = a.ToCharArray();
            char[] CharArray2 = b.ToCharArray();
            char[] intersectArray = CharArray1.Intersect(CharArray2).ToArray();


            Dictionary<char, int> A_Data = new Dictionary<char, int>();
            Dictionary<char, int> B_Data = new Dictionary<char, int>();


            //Fill A_Data 
            for (int i = 0; i < a.Length; i++)
            {
                A_Data[a[i]] = A_Data.ContainsKey(a[i]) ? A_Data[a[i]] += 1 : A_Data[a[i]] = 1;
            }
            //Fill B_Data
            for (int i = 0; i < b.Length; i++)
            {
                B_Data[b[i]] = B_Data.ContainsKey(b[i]) ? B_Data[b[i]] += 1 : B_Data[b[i]] = 1;
            }

            foreach (char ch in intersectArray)
            {
                int count = Math.Min(A_Data[ch], B_Data[ch]);
                A_Data[ch] = A_Data[ch] - count;
                B_Data[ch] = B_Data[ch] - count;
            }

            int A_Characters = A_Data.Sum(x => x.Value);
            int B_Characters = B_Data.Sum(x => x.Value);
            int totalCharacters = A_Characters + B_Characters;

            return totalCharacters;
        }

        //1- Using int Array [26] as total characters are 26
        public static int makingAnagrams_2(string a, string b)
        {
            int[] a_frequencies = new int[26];
            int[] b_frequencies = new int[26];


            for (int i = 0; i < a.Length; i++) 
            {
                char current_char = a[i];
                int char_to_int = (int)current_char;
                int position = char_to_int - (int)'a';
                a_frequencies[position]++;
            }

            for (int i = 0; i < b.Length; i++)
            {
                char current_char = b[i];
                int char_to_int = (int)current_char;
                int position = char_to_int - (int)'a';
                b_frequencies[position]++;
            }

            int min_deletions = 0;
            for(int i = 0; i < 26; i++) 
            {
                int difference = Math.Abs(a_frequencies[i] - b_frequencies[i]);
                min_deletions += difference;
            }

            return min_deletions;
        }
    }

    class MakingAnagrams_Result
    {
        public static void Input() 
        {
            //string a = "cde";
            //string b = "dcf";
            //output = 2
            
            string a = "cdde";  //cdde      e
            string b = "dcfdc"; //ccddf     cf      
            //output 3

            //int count = MakingAnagrams_Solution.makingAnagrams(a, b);
            int count = MakingAnagrams_Solution.makingAnagrams_2(a, b);
            Console.WriteLine($"Total characters to be deleted are: {count}");
        }
    }

}
