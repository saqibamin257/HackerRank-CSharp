using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class BubbleSort_Result
    {
        public static void countSwap(int[] arr) 
        {
            int count = 0;
            int firstElement = 0;
            int lastElement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        count++;
                    }
                }
            }
            firstElement = arr[0];
            lastElement = arr[arr.Length - 1];
            Console.WriteLine($"Array is sorted in {count} swaps.");
            Console.WriteLine($"First Element: {firstElement}");
            Console.WriteLine($"Last Element: {lastElement}");
        }
        private static void Swap(int[] arr, int firstIndex, int secondIndex)
        {
            int temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
    }
    public class BubbleSort_Solution
    {
        public static void Input() 
        {
            //int[] numArray = new int[] {6,4,1};

            //output
            //Array is sorted in 3 swaps.
            //First Element: 1
            //Last Element: 6

            int[] numArray = new int[] { 3, 2, 1 };
            //output
            //Array is sorted in 3 swaps.
            //First Element: 1
            //Last Element: 3
            //
            BubbleSort_Result.countSwap(numArray);
        }
    }
}
