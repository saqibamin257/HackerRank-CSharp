using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class BasicProblemSolvingTest_Solution 
    {
        //this algorithm will have performance issues as it works on nested loops O(n pow 2). n square.
        public  List<int> countAnagrams(List<string> dictionary, List<string> query)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < query.Count; i++)
            {
                int total = 0;
                for (int j = 0; j < dictionary.Count; j++)
                {
                    if (query[i].Length == dictionary[j].Length)
                    {
                        if (sortString(query[i]) == sortString(dictionary[j]))
                            total++;
                    }
                }
                result.Add(total);
            }
            return result;
        }


        public List<int> countAnagrams_Optimize(List<string> Originaldictionary, List<string> Originalquery)
        {
            //Step-1: Sort dictionary and query in ascending order
            //Step-2: Create dictionary<string,int> with no. of repitations
            //Step-3: iterate through query and check if element is present in sortedDictionary, add sortedDictionary value in list.
            //Order of N O(N).single loop execution.


            List<int> result = new List<int>();
            List<string> dictionary = new List<string>();
            List<string> query = new List<string>();

            //step-1:
            foreach (string str in Originaldictionary) 
            {
                dictionary.Add(sortString(str));
            }

            foreach (string str in Originalquery)
            {
                query.Add(sortString(str));
            }

            //step-2:

            Dictionary<string, int> sortedDictionary = new Dictionary<string, int>();
            for(int i = 0; i < dictionary.Count; i++) 
            {
                sortedDictionary[dictionary[i]] = sortedDictionary.ContainsKey(dictionary[i]) ? sortedDictionary[dictionary[i]] + 1 : 1;                
            }
            

            //step-3:

            for(int i = 0; i < query.Count; i++) 
            {
                if (sortedDictionary.ContainsKey(query[i])) 
                {
                    result.Add(sortedDictionary[query[i]]);
                }
            }
            return result;
        }

        // Method: Sort String word in ascending Order.
        private string sortString(string input)
        {
            char[] characters = input.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }


    internal class BasicProblemSolvingTest_Result: BasicProblemSolvingTest_Solution
    {
        public static void Input() 
        {
            List<string> query = new List<string>() { "two", "bca", "no", "listen" };
            List<string> dictionary = new List<string>() { "listen", "tow", "silent", "lisent", "two", "abc", "no", "on" };
            
            //output
            //2
            //1
            //2
            //3
            //List<int> result = new BasicProblemSolvingTest_Solution().countAnagrams(dictionary, query);
            List<int> result1 = new BasicProblemSolvingTest_Solution().countAnagrams_Optimize(dictionary, query);


            //Method-1: Nested Loops
            //foreach (var r in result) 
            //{
            //    Console.WriteLine(r);
            //}
            //Method-2: Optimize solution
            foreach (var r in result1)
            {
                Console.WriteLine(r);
            }
        }       
    }
}
