using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class SelectionSort_KhanAcademy_Result
    {
        //Swap 2 values of array with each other.
        private static void Swap(int[] arr, int firstIndex, int secondIndex)
        {
            int temp = arr[firstIndex];
            
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }

        //Find index of minimum value of array
        private static int indexOfMinimum(int[] arr, int startIndex)
        {
            int minIndex = startIndex;
            int minValue = arr[startIndex];
            for (int i = minIndex + 1; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minIndex = i;
                    minValue = arr[i];
                }
            }

            return minIndex;
        }
        public static int[] selectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int index = indexOfMinimum(arr, i);
                Swap(arr, i, index);
            }
            return arr;
        }
    }

    public class SelectionSort_KhanAcademy_Solution
    {
        public static void Input() 
        {
             int[] array = new int[] { 22, 11, 99, 88, 9, 7, 42 };
             int[] ResultArray = SelectionSort_KhanAcademy_Result.selectionSort(array);
             Console.WriteLine("Array after sorting:");
             foreach(var i in ResultArray) 
             {
                Console.WriteLine(i);
             }
             //output= [7, 9, 11, 22, 42, 88, 99];
            //selectionSort(array);
            //println("Array after sorting:  " + array);
        }
    }
}
