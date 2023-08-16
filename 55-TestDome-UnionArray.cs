using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerRank
{
    internal class TestDOME_UnionArray_Solution
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {

            
            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < names1.Length; i++)
            {
                hs.Add(names1[i]);
            }

            for (int i = 0; i < names2.Length; i++)
            {
                hs.Add(names2[i]);
            }
            hs.ToArray();

            throw new NotImplementedException();
        }
    }
    internal class TestDOME_UnionArray_Result 
    {

    }
}
