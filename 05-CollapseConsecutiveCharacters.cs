using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
   public class CollapseConsecutiveCharacters_Result
    {
        public static string CollapseCharacters(string str)         
        {            
            string result = "";
            int range = str.Length;
            
            for (int i = 0; i < range; i++)
            {
                int count = 1;
                //comparision
                while(i < range-1 && str[i] == str[i + 1]) 
                {
                    count++;
                    i++;
                }

                result = count > 1 ? $"{result}{str[i]}{count}" : $"{result}{str[i]}";
            }
            return result;            
        }
    }

    public class CollapseConsecutiveCharacters_Solution 
    {
        public static void CharactersCount() 
        {
            //Test Case-1 
            //string Input = "aaabccccdde";
            //Output : a3bc4d2e

            //Test Case-2 
            //string Input = "yyyyyzzzzzzzzzz";
            //Output: y5z10

            //Test Case-3 
            //string Input = "abcd";
            //Output: abcd(note: not a1b1c1d1)

            //Test Case-4 
            string Input ="hhhccchhhccc";            
            //Output: h3c3h3c3

            string OutPut = CollapseConsecutiveCharacters_Result.CollapseCharacters(Input);
           Console.WriteLine(OutPut);

        }

        
    }
}
