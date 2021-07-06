using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
   public class DrawingBook_Result
    {
        /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

        public static int pageCount(int n, int p)
        {
            if (n % 2 == 0)
                n = n + 1;

            List<int> PageList = new List<int>();
            int left = 0, right = 0, min = 0, count = -1;
            for (int a = 0; a <= n; a++)
            {
                PageList.Add(a);
            }

            //from left
            for (int i = 0; i <= n; i += 2)
            {
                count++;
                if (PageList[i] == p || PageList[i + 1] == p)
                {
                    left = count;
                    break;
                }
            }

            //from right
            count = -1;
            for (int j = n; j >= 0; j -= 2)
            {
                count++;
                if (PageList[j] == p || PageList[j - 1] == p)
                {
                    right = count;
                    break;
                }

            }
            //calculate minimum.
            if (left <= right)
                min = left;
            else
                min = right;

            return min;
        }

    }
    public class DrawingBook_Solution 
    {
        public static void DrawingBook() 
        {
            //TestCase -1
            //int n = 3, p = 3;
            //output(left=1,right=1) => min=1

            //TestCase -2
            //int n = 6, p = 2;
            //output(left=1,right=2) => min=

            //TestCase -3
            int n = 5, p = 4;
            //output(left=2,right=0) => min=0

            int result = DrawingBook_Result.pageCount(n, p);
            Console.WriteLine(result);
        }
        

    }
}
