using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    //Local system Code
   public class HourGlass_Result
    {
        public static int HourGlassSum(int[,] arr) 
        {
            int Row = arr.GetLength(0);
            int Col = arr.GetLength(1);
            int MaxSum = -63;
            
            for(int i = 0; i < Row - 2; i++) 
            {
                for(int j = 0; j < Col - 2; j++) 
                {
                 int Sum =  arr[i,j] + arr[i, j+1] + arr[i , j+2] +
                                     arr[i+1, j+1]+
                        arr[i+2 , j] + arr[i+2, j+1] + arr[i+2,j+2];

                    MaxSum = Math.Max(Sum, MaxSum);
                }                
            }

            return MaxSum;
        }
    }
    public class HourGlass_Solution
    {
        public static void Input() 
        {
           
            int[,] input = new int[6, 6] { 
                                       { 1, 1, 1, 0, 0, 0},
                                       { 0, 1, 0, 0, 0, 0},
                                       { 1, 1, 1, 0, 0, 0 },
                                       { 0, 0, 2, 4, 4, 4 },
                                       { 0, 0, 0, 2, 0, 0 },
                                       { 0, 0, 1, 2, 4, 0}
                                     };

            int result = HourGlass_Result.HourGlassSum(input);

            Console.WriteLine(result);
        }
    }

    //submitted Code to Hacker Rank
    //class Result
    //{

    //    /*
    //     * Complete the 'hourglassSum' function below.
    //     *
    //     * The function is expected to return an INTEGER.
    //     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
    //     */

    //    public static int hourglassSum(List<List<int>> arr)
    //    {
    //        int Row = arr.Count;
    //        int Col = arr.Count;
    //        int MaxSum = -63;

    //        for (int i = 0; i < Row - 2; i++)
    //        {
    //            for (int j = 0; j < Col - 2; j++)
    //            {
    //                int Sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
    //                                    arr[i + 1][j + 1] +
    //                       arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

    //                MaxSum = Math.Max(Sum, MaxSum);
    //            }

    //        }

    //        return MaxSum;
    //    }

    //}

    //class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //        List<List<int>> arr = new List<List<int>>();

    //        for (int i = 0; i < 6; i++)
    //        {
    //            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
    //        }

    //        int result = Result.hourglassSum(arr);

    //        textWriter.WriteLine(result);

    //        textWriter.Flush();
    //        textWriter.Close();
    //    }
    //}
}
