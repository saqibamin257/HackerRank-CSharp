using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    class IceCreameParlor_Solution
    {
        #region Using HashMap
        public static void whatFlavours(int money, int[] cost) 
        {
            try 
            {
                Dictionary<int, int> map = new Dictionary<int, int>();
                int[] result = new int[2];
                for (int i = 0; i < cost.Length; i++)
                {
                    int x = cost[i];
                    int y = money - x;
                    if (map.ContainsKey(y))
                    {
                        int j = map[y];
                        result[0] = j + 1;
                        result[1] = i + 1;
                        Console.WriteLine($"{result[0]} {result[1]}");
                        break;
                    }
                    else
                    {
                        map.Add(x, i);
                    }
                }
                
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }            
        }
        #endregion
    }
    class IceCreameParlor_Result
    {
        public static void Input() 
        {
            //case-1
            //int money = 4;
            //int[] cost = new int[] { 1, 4, 5, 3, 2 };
            //output = 1,4 index, 1-index based scenario.

            //case-2
            int money = 4;
            int[] cost = new int[] { 2, 2, 4, 3 };
            //output = 1,2 index, 1-index based scenario.

            //case-2
            //int money = 5;
            //int[] cost = new int[] { 2, 1, 3, 5, 6 };
            //output = 1,3 index, 1-index based scenario.

            IceCreameParlor_Solution.whatFlavours(money, cost);
        }
    }
}
