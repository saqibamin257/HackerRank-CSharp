using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
   public class EqualizeTheArray_Result
    {
        public static int equalizeArray(List<int> arr)
        {
            int prevCount = 0, TotalCount = 0, length = arr.Count;

            List<int> MatchList = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (!MatchList.Contains(arr[i]))
                {
                    MatchList.Add(arr[i]);
                    int nextCount = 1;
                    for (int j = i + 1; j < length; j++)
                    {
                        if (arr[i] == arr[j])
                            nextCount++;
                    }
                    if (nextCount > prevCount)
                    {
                        prevCount = nextCount;
                    }
                }
            }

            TotalCount = length - prevCount;

            return TotalCount;
        }
    }
    public class EqualizeTheArray_Solution
    {
        public static void Input() 
        {
            //Test-1
            //string numbers = "3 3 2 1 3";
            //output = 2

            //Test-2
            string numbers = "1 2 3 1 2 3 3 3";
            //output = 4
            
            //Test-3
            //string numbers = "1 2 3 4";
            //output = 3


            List<int> c = numbers.TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();
            int result = EqualizeTheArray_Result.equalizeArray(c);
            Console.WriteLine(result);
        }
        
    }
}
