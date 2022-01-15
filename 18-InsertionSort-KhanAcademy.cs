using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class InsertionSort_KhanAcademy_Result
    {
        public static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while ( j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            Console.WriteLine($"Sorted Array {arr}");
        }

        public static void insertionSort2(int[] inputArray) 
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            Console.WriteLine($"Sorted Array {inputArray}");
        }

        

        public static void Swap(int[] arr, int firstIndex, int secondIndex) 
        {
            int temp = arr[firstIndex];
            arr[secondIndex] = arr[firstIndex];
            arr[firstIndex] = temp;
        }
    }
    public class InsertionSort_KhanAcademy_Solution
    {
        public static void Input() 
        {
            //int[] arr = new int[] { 9, 5, 1, 4, 3 };
            
            int[] arr2 = new int[] { 3, 5, 7, 11, 13, 2, 9, 6 };
            //int[] SortedArray = InsertionSort_KhanAcademy_Result.Insert(arr2, 4, 2);
            //insert(array, 4, 2);
            //println("Array after inserting 2:  " + array);
            //Program.assertEqual(array, [2, 3, 5, 7, 11, 13, 9, 6]);



            //iteration-0
            //1-[9,5] => [5,9,1,4,3]
            //subarray [9,5]


            //iteration-1
            //2-[9,1] => [5,1,9,4,3]
            //subarray [5,1,9] => also sort subarray [1,5,9]
            //final [1,5,9,4,3]


            //iteration-2
            //[9,4] = [1,5,4,9,3]
            //subArray [1,5,4,9] => also sort subarray [1,4,5,9]
            //final [1,4,5,9,3]

            //iteration-3
            //[9,3] =[1,4,5,3,9] 
            //subArray [1,4,5,3,9] = also sort subarray [1,3,4,5,9]

            //output [1,3,4,5,9]
        }


    }
}
