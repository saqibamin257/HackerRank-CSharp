using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class QuestionsMarks_Coderbyte
    {
        //Have the function QuestionsMarks(str) take the str string parameter, which will contain single digit numbers, letters, and question marks,
        //and check if there are exactly 3 question marks between every pair of two numbers that add up to 10. If so, then your program should return the string true,
        //otherwise it should return the string false. If there aren't any two numbers that add up to 10 in the string, then your program should return false as well.
        //For example: if str is "arrb6???4xxbl5???eee5" then your program should return true because there are exactly 3 question marks between 6 and 4,
        //and 3 question marks between 5 and 5 at the end of the string.

        //Examples
        //Input: "aa6?9"
        //Output: false
        //Input: "acc?7??sss?3rr1??????5"
        //Output: true.

        public string QuestionMarks() 
        {
            //string str = "acc?7??sss?3rrl"; //true;
            //string str = "acc?7??sss?3rr1??????5"; //true
            string str = "aa6?9"; //false
            int count = 0;
            int? firstNo = null;
            int? secondNo = null;
            List<bool> Pair = new List<bool>();
            string result = "false";
            for (int i = 0; i < str.Length; i++) 
            {
                if (char.IsNumber(str[i]))
                {
                    if (!firstNo.HasValue)
                        firstNo = Convert.ToInt32(str[i].ToString());
                    else if (!secondNo.HasValue)
                        secondNo = Convert.ToInt32(str[i].ToString());
                }
                if (firstNo.HasValue && str[i] == '?') 
                {
                    count++;
                }
                
                if (firstNo.HasValue && secondNo.HasValue) 
                {
                    if (count != 3 && firstNo + secondNo != 10) 
                    {
                        Pair.Add(false);
                    }
                    else 
                    { 
                        Pair.Add(true);
                    }
                    count = 0;
                    firstNo = null; secondNo = null;
                }
            }
            //check if any pair value is true then return true.
            var checkResult = Pair.Any(p => p == true);
            if (checkResult) {result="true";}
            return result;

        }
    }
}
