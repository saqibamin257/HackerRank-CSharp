using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class DiagonalDifference_Solution
    {
        //Left And Right Diagonal Separately
        public static int Diagonal_AbsoluteDifference1(int[,] arr) 
        {
            int Row = arr.GetLength(0);
            int Col = arr.GetLength(1);
            int Maxlength = Row;
            int LeftSum = 0, rightSum = 0;
            if (Row == Col)
            {
                //Left Diagonal Sum
                int counter = Row;
                for (int i = 0; i < Row; i++) 
                {                    
                    counter--;
                    for (int j = 0 ,k = Col-1; j < Col; j++) 
                    {                        
                        if (i == j) 
                        {
                            LeftSum = LeftSum + arr[i, j];
                        }
                        if (counter == k) 
                        {
                            rightSum = rightSum + arr[i, k];
                        }
                        k--;
                    }
                }
                //Right Diagonal Sum
                int count = Row;
                for (int i = 0; i < Row; i++)
                {
                    count--;
                    for (int j = Col - 1; j >= 0; j--)
                    {
                        if (count == j)
                        {
                            rightSum = rightSum + arr[i, j];
                        }
                    }
                }
                return Math.Abs(LeftSum - rightSum);
            }
            return 0;
        }

        //Both Diagonals together. no need for separate loops for left and right diagonals.
        public static int Diagonal_AbsoluteDifference2(int[,] arr)
        {
            int Row = arr.GetLength(0);
            int Col = arr.GetLength(1);            
            int LeftSum = 0, rightSum = 0;
            if (Row == Col)
            {
                //Left Diagonal Sum
                int counter = Row;
                for (int i = 0; i < Row; i++)
                {
                    counter--;
                    for (int j = 0, k = Col - 1; j < Col; j++)
                    {
                        if (i == j)
                        {
                            LeftSum = LeftSum + arr[i, j];
                        }
                        if (counter == k)
                        {
                            rightSum = rightSum + arr[i, k];
                        }
                        k--;
                    }
                }                
                return Math.Abs(LeftSum - rightSum);
            }

            return 0;
        }
    }

    public class DiagonalDifference_Result
    {
        public static void Input() 
        {
            int[,] a = new int[3, 3] {
                                       {0, 1, 2} ,   /*  initializers for row indexed by 0 */
                                       {4, 5, 6} ,   /*  initializers for row indexed by 1 */
                                       {10, 9, 10}   /*  initializers for row indexed by 2 */
                                    };
           //output |15-17| = 2;
           //int result= DiagonalDifference_Solution.Diagonal_AbsoluteDifference1(a);
            int result = DiagonalDifference_Solution.Diagonal_AbsoluteDifference2(a);
            Console.WriteLine(result);
        }
    }
}
