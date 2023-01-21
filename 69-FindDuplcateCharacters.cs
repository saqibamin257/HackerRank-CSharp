using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class FindDuplcateCharacters_Result
    {
        public string DuplicateString(string str) 
        {
            string result = string.Empty;
            for(int i = 0; i < str.Length-1; i++) 
            {
                for(int j = i+1; j < str.Length; j++) 
                {
                    if (str[i] == str[j] && !result.Contains(str[i])) 
                    {
                        result=result+ str[j];
                    }
                }
            }
            return result;
        }
    }

    internal class FindDuplcateCharacters_Solution
    {
        public void Input() 
        {
            //string str = "improper";
            //output=pr
            string str = "ESTATEMENTS";
            //output=EST

            string duplicateCharacters = new FindDuplcateCharacters_Result().DuplicateString(str);
            Console.WriteLine($"duplicate characters in {str} are: {duplicateCharacters}");
        }
    }

}
