using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class LuckBalance_Result
    {
        public static int luckBalance(int k, int[][] contests)
        {
            int Row = contests.GetLength(0);            
            int sum = 0;
            for (int i = 0; i < Row; i++)
            {
                if ((contests[i][1] == 0))
                {
                    sum += contests[i][0];
                }

               else if ((k > 0 && contests[i][1] == 1))
                {
                    sum += contests[i][0];
                    k--;
                }
                
                else
                {
                    sum -= contests[i][0];
                } 
            }

            return sum;
        }
    }
    
    internal class LuckBalance_Solution
    {
        public static void Input() 
        {



            //int[,] array = new int[6, 2] {
            //                             {5, 1},
            //                             {2, 1},
            //                             {1, 1},
            //                             {8, 1},
            //                             {10, 0},
            //                             {5, 0}
            //                           };


            //var src = new List<int[]> { new[] {5, 1},
            //                            new[] {2, 1},
            //                            new[] {5, 0},
            //                            new[] {5, 0},

            //    };

            //var sortedByFirst = src.OrderBy(x => x[0]).ToList();

            ////Sorted Array on base of col 1
            //int[,] input = new int[6, 2] {
            //                           {10, 0},
            //                           {8, 1},
            //                           {5, 1},
            //                           {5, 0},
            //                           {2, 1},
            //                           {1, 1}                                                                           
            //                         };

            int[][] jagged_arr = new int[6][];
            jagged_arr[0] = new int[] { 5, 1 };
            jagged_arr[1] = new int[] { 2, 1 };
            jagged_arr[2] = new int[] { 1, 1 };
            jagged_arr[3] = new int[] { 8, 1 };
            jagged_arr[4] = new int[] { 10, 0 };
            jagged_arr[5] = new int[] { 5, 0 };

            

            int[][] sortedByFirst = jagged_arr.OrderByDescending(x => x[0]).ToArray();
            int k = 3;            
            int result = LuckBalance_Result.luckBalance(k, sortedByFirst);
            //output 29.
            Console.WriteLine(result);           

        }
    }
}
