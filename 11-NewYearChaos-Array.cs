using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class NewYearChaos_Result
    {
        //Bubble Sort try
        //public static void minimumBribes(List<int> q)
        //{
        //    int length = q.Count;
        //    List<int> bribesList = new List<int>();
        //    for(int i = 0; i < length; i++) 
        //    {
        //        int count = 0;
        //        int temp = 0;

        //        for(int j = i; j < length; j++) 
        //        {
        //            if (q[j] > q[j + 1]) 
        //            {
        //                count++;
        //                temp = q[j];
        //                q[j] = q[j + 1];
        //                q[j + 1] = temp;                        
        //            }
        //        }
        //        bribesList.Add(count);
        //    }
        //    int maxValue = 0;
        //    foreach (var  item in bribesList)
        //    {
        //        maxValue = Math.Max(maxValue, item);
        //    }
        //    Console.WriteLine(maxValue);
        //}

        //Algorithm-2
        public static void minimumBribes(int[] arr)
        {
            int swapCount = 0;            
            
            for(int i = arr.Length - 1; i > 0; i--) 
            {
                if(arr[i]!= i + 1) 
                {
                    if( ((i-1) >= 0) && (arr[i - 1] == i + 1)) 
                    {
                        swapCount++;
                        swap(arr, i, i - 1);
                    }
                    else if (((i - 2) >= 0) && (arr[i - 2] == i + 1))
                    {
                          swapCount+=2;
                          swap(arr, i-2, i - 1);
                          swap(arr, i - 1, i);
                    }
                    else 
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }
            }
            Console.WriteLine(swapCount);            
        }
        private static void swap(int[] arr,int a, int b) 
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
    public class NewYearChaos_Solution
    {
        public static void Input() 
        {
            //int t = 1;
            //int[] inputString = new int[] { 2, 5, 1, 3, 4 }; //output = "too chaotic";
            int[] inputString = new int[] { 2, 1, 5, 3, 4 };  //output =3

            //List<int> q = inputString.Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            NewYearChaos_Result.minimumBribes(inputString);

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = inputString.Length;

            //    List<int> q = inputString.Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            //    NewYearChaos_Result.minimumBribes(q);
            //}
        }
    }
}
