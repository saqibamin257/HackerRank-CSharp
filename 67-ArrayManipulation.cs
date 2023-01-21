using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class ArrayManipulation_Solution
    {
        //Brut Force Algorithm
        public static long arrayManipulation_BrutForce(int n, List<List<int>> queries) 
        {
            List<List<int>> result = new List<List<int>>();
            List<int> first = new List<int>();
            long max = 0;

            for (int i = 0; i < n; i++) 
            {
                first.Add(0);
            }
            result.Add(first);
            for (int i = 0; i < queries.Count; i++) 
            {
                int start = queries[i][0];
                int end = queries[i][1];
                int value = queries[i][2];
                List<int> check = new List<int>(result[i]);
                for (int j = start-1; j <= end-1; j++) 
                {
                    check[j] += value;
                    if (check[j] > max) 
                    { max = check[j];}
                }
                result.Add(check);
            }

            return max;
        }
        public static long arrayManipulation(int n, List<List<int>> queries) 
        {
            uint m = (uint)queries[0].Count;
            long[] numList = new long[n + 1];
            for (int i = 0; i < queries.Count; i++) 
            {
                uint a =(uint)queries[i][0];
                uint b = (uint)queries[i][1];
                long k = (long)queries[i][2];
                numList[a] += k;
                if(b+1 <= n) 
                {
                    numList[b+1] -= k;
                }
            }
            long tempMax = 0;
            long max = 0;
            for(int j = 1; j <= n; j++) 
            {
                tempMax += numList[j];
                if(tempMax > max) 
                {
                    max = tempMax;
                }
            }
            return max;
        }
    }
}
