using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    class SherlockAndValidString_Soultion
    {

        #region Try-1
        //public static string SherlockValidString(string s)
        //{            
        //   this algorithm passed 18/20 test cases on hackerrank.
        //    HashSet<int> Distinct_Values = new HashSet<int>();
        //    Dictionary<char, int> Data = new Dictionary<char, int>();
        //    Dictionary<int, int> Freq_Dictionary = new Dictionary<int, int>();

        //    ///Success Case-1
        //    ///Distinct frequencies = 1;


        //    ///Success Case-2
        //    ///(a)Distinct frequencies = 2
        //    ///(b)&& Value of Any(1) frequency in freq_Dictionary = 1
        //    ///(c)&& Difference b/w min_freq and max_freq = 1.


        //    //fill dictionary
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        Data[s[i]] = Data.ContainsKey(s[i]) ? Data[s[i]] += 1 : Data[s[i]] = 1;
        //    }

        //    //Fill distinct values
        //    foreach (var d in Data)
        //    {
        //        Distinct_Values.Add(d.Value);
        //    }


        //    //Success Conditions
        //    if (Distinct_Values.Count == 1)
        //    {
        //        return "YES";
        //    }

        //    else if (Distinct_Values.Count() == 2)
        //    {
        //        //Frequency_Dictionary
        //        for (int i = 0; i < Distinct_Values.Count(); i++)
        //        {
        //            int total = (from d in Data
        //                         where d.Value == Distinct_Values.ToList()[i]
        //                         select d).Count();
        //            Freq_Dictionary.Add(Distinct_Values.ToList()[i], total);
        //        }

        //        int freq1_val = Freq_Dictionary.Values.ToList()[0];
        //        int freq2_val = Freq_Dictionary.Values.ToList()[1];
        //        int freq1_key = Freq_Dictionary.Keys.ToList()[0];
        //        int freq2_key = Freq_Dictionary.Keys.ToList()[1];

        //        int difference = Math.Abs(freq1_key - freq2_key);


        //        if ((freq1_val == 1 || freq2_val == 1) && difference == 1)
        //        {
        //            return "YES";
        //        }
        //    }
        //    return "NO";
        //}

        #endregion
        public static string SherlockValidString(string s)
        {
            ///Took help from Study Algorithms youtube channel
            /// this algorithm passed 20/20 test cases on hacker rank.
            ///Pass Cases
            ///(a) All frequencies are same
            ///(b) All frequencies are same and only one frequency is 1.
            ///(c) All frequencies are same and only one frequency is 1-Higher than others.



            Dictionary<char, int> Data = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                Data[s[i]] = Data.ContainsKey(s[i]) ? Data[s[i]] += 1 : Data[s[i]] = 1;
            }

            int[] arr = new int[Data.Count];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Data.Values.ToList()[i];
            }
            Array.Sort(arr);

            if (Data.Count == 1)
                return "YES";

            int first_freq = arr[0];
            int second_freq = arr[1];
            int secondlast_freq = arr[arr.Length - 2];
            int last_freq = arr[arr.Length - 1];

            ///(a) All frequencies are same, means first and last are same
            if (first_freq == last_freq)
                return "YES";

            ///(b) All frequencies are same and only one frequency is 1, means first freq is 1 and second and last frequencies are same.
            if (first_freq == 1 && second_freq == last_freq)
                return "YES";

            ///(c) All frequencies are same and only one frequency is 1-Higher than others.
            ///it means first_freq == second_freq && second_freq == secondlast_freq && secondlast_freq == last_freq-1
            if (first_freq == second_freq && second_freq == secondlast_freq && secondlast_freq == (last_freq - 1))
                return "YES";

            return "NO";

        }
    }
    class SherlockAndValidString_Result
    {
        public static void Input() 
        {
            //string s = "abcc"; //Yes
            //string s = "abc"; //Yes
            //string s = "abccc"; //No
            //string s = "aabbcd"; //No
            //string s = "aabbccddeefghi"; //No
            //string s = "abcdefghhgfedecba"; //Yes
            string s = "aabbccddeee"; //Yes
            //string s = "aabccdd"; //Yes


            string result = SherlockAndValidString_Soultion.SherlockValidString(s);
            Console.WriteLine($"{s} is a valid string: {result}");
        }
    }
}
