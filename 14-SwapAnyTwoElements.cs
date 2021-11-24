using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public static class SwapAnyTwoElements_Result
    {
        #region Program-1:
        //Program-1:Test cases fails due to Time Execution limit exceeds. 

        //public static int minimumSwaps(int[] arr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if ((i + 1 < arr.Length) && (arr[i] != i + 1))
        //        {
        //            int index = Array.IndexOf(arr, i + 1);
        //            swap(arr, index, i);
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion


        #region Program-2:
        //Program-2:Test cases fails due to Time Execution limit exceeds. 

        //public static int minimumSwaps(int[] arr)
        //{
        //    int count = 0;
        //    int i = 0;
        //    while (i < arr.Length)
        //    {
        //        if ((arr[i] != i + 1))
        //        {
        //            int index = Array.IndexOf(arr, i + 1);
        //            swap(arr, index, i);
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        #endregion

        #region SwapProgram
        //Swap Method; swap 2 elements of array with each other
        //private static void swap(int[] arr, int a, int b)
        //{
        //    int temp = arr[a];
        //    arr[a] = arr[b];
        //    arr[b] = temp;
        //}

        #endregion

        #region Program-3:Successfull
        //Program-3://Successfully passed all test cases
        public static int minimumSwaps(int[] arr)
        {
            int swapCount = 0;
            int index = 0;
            while (index < arr.Length)
            {
                if (arr[index] != index + 1)
                {
                    int temp = arr[index];
                    arr[index] = arr[arr[index] - 1];
                    arr[temp - 1] = temp;
                    swapCount++;
                }
                else
                {
                    index++;
                }
            }
            return swapCount;
        }

        #endregion

    }


    public static class SwapAnyTwoElements_Solution
    {
        public static void Input()
        {
            //Test Cases
            //int[] arr = new int[] { 1, 3, 5, 2, 4, 6, 7 }; //3
            int[] arr = new int[] { 7, 1, 3, 2, 4, 5, 6 }; //5
            //int[] arr = new int[] { 5,4,3,1,2 }; // 3
            //int[] arr = new int[] { 2, 3, 4, 1,5 };//3
            int totalSwap = SwapAnyTwoElements_Result.minimumSwaps(arr);
            Console.WriteLine(totalSwap);
        }        
    }
}
