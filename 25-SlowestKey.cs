using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class SlowestKey_Solution
    {
        public static char slowestKey() 
        {
            //Sample test case

            //2 - 0  = 2 => a
            //5 - 2  = 3 => b
            //9 - 5  = 4 => a
            //15 - 9 = 6 => c
            //output C it tooks Longest time

            int[,] KeyTime = new int[4,2]{
                                          {0,2},
                                          {1,5},
                                          {0,9},
                                          {2,15}
                                         };
            char ch= '\0'; //empty char
            int slowestValue = 0;
            int rowLength = KeyTime.GetLength(0);
            int colLength= KeyTime.GetLength(1);
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int row = 0; row < rowLength; row++) 
            {
                for(int col=0; col < colLength; col++) 
                {
                    if (col == 1 && row > 0) 
                    {
                        Console.WriteLine("a[{0},{1}] = {2}", row, col, KeyTime[row, col]);
                        int newValue = KeyTime[row, col] - KeyTime[row-1, col];
                        if (newValue > slowestValue) 
                        {
                            slowestValue = newValue;
                            ch =alpha[KeyTime[row, 0]];
                        }
                    }                                 
                }
            }
            return ch;
        }
    }
}
