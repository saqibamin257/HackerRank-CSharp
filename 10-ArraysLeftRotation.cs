using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class ArraysLeftRotation_Result
    {
        // Terminated due to time limit execution
        //public static List<int> rotLeft(List<int> a, int d)
        //{            
        //    int HighestIndex = a.Count-1;            

        //    for(int rot=0; rot<d; rot++) 
        //    { 
        //        int lowestIndexValue = a[0];

        //        for(int i=0; i < a.Count; i++) 
        //        {
        //            a[i] = (i != HighestIndex) ? a[i + 1] : lowestIndexValue;
        //        }
        //    }
        //    return a.ToList();
        //}

        public static List<int> rotLeft(List<int> a, int d) 
        {
            int n = a.Count;
            int[] rotArray = new int[n];
            for (int oldIndex = 0; oldIndex < n; oldIndex++) 
            {
                int newIndex = (oldIndex + (n - d)) % n;
                rotArray[newIndex] = a[oldIndex];
            }
            return rotArray.ToList();
        }

    }

    public class ArraysLeftRotation_Solution 
    {

        public static void Input() 
        {
            string array = "1 2 3 4 5";

            int n = 5;

            int d = 4;

            List<int> a = array.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> result = ArraysLeftRotation_Result.rotLeft(a, d);

            Console.WriteLine(String.Join(" ", result));

            
        }
    }
}
