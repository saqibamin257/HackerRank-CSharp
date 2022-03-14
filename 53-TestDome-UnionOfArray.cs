using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class UnionOfArray_Solution
    {
        // return array of names without repeating names from 2 arrays.
        public static string[] ArrayofName_HashSet(string[] name1, string[] name2) 
        {
            HashSet<string> hs = new HashSet<string>();
            for(int i=0;i< name1.Length; i++) 
            {
                hs.Add(name1[i]);
            }
            for(int i=0; i < name2.Length; i++) 
            {
                hs.Add(name2[i]);
            }
            return hs.ToArray();
        }
        public static string[] ArrayOfName_Union(string[] name1, string[] name2) 
        {
            string[] result = name1.Union(name2).ToArray();
            return result; 
        }
    }

    internal class UnionOfArray_Result
    {
        public static void Input_Hashset() 
        {
            string[] name1 = new string[] {"Ali","Akram","Wasim","Akhtar","Amjad" };
            string[] name2 = new string[] { "Ali", "Akram", "Ravi", "Imran" };

            Console.WriteLine("******* Using Hashset ********");
            string[] Result= UnionOfArray_Solution.ArrayofName_HashSet(name1, name2);
            
            foreach (var name in Result) 
            {
                Console.WriteLine(name);
            }
        }
        public static void Input_Union()
        {
            string[] name1 = new string[] { "Sameen", "Mughal", "Angilina", "Martin"};
            string[] name2 = new string[] { "Mughal", "Angilina", "Martin","Tim","Scott" };

            Console.WriteLine("******* Using Union ********");
            var Result = UnionOfArray_Solution.ArrayOfName_Union(name1, name2);
            Array.ForEach(Result, res => Console.WriteLine(res));
        }
    }
}
