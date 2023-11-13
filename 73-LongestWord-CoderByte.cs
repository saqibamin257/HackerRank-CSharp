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
    public class LongestWord_CoderByte
    {
        // Longest Word
        //Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. If there are two or more words that are the same length, return the first word from the string with that length.Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"
        //Examples
        // Input: "fun&!! time"
        //Output: time
        //Input: "I love dogs"
        //Output: love
        public string LongestWord()
        {
            //string str = "fun&!! time";// time
            string str = "I love& books# and !balls"; //output = books
            //string str = "Hello world123 567"; //world123

            Dictionary<string, int> Dict = new Dictionary<string, int>();
            str = Regex.Replace(str, @"\p{P}", "");

            string[] strArray = str.Split(" ").ToArray();
            for (int i = 0; i < strArray.Length; i++) 
            {
                Dict.Add(strArray[i], strArray[i].Length);
            }

            string result = string.Empty;
            int MaxWordLength = Dict.Max(x => x.Value);
            var word = Dict.FirstOrDefault(x=>x.Value == MaxWordLength);
            return word.Key.ToString();
        }



    }
}
