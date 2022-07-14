using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class TaleOfTwoStacks_Solution
    {
        public static int TwoStacks(List<Records> records) 
        {
            for(int i = 0; i < records.Count; i++) 
            {

            }
            return 1;
        }
    }
    internal class TaleOfTwoStacks_Result
    {
        public static void Input()
        {
            List<Records> records = new List<Records>
            {
                              new Records { key = 1, value = 12 },
                              new Records { key = 1, value = 13 },
                              new Records { key = 2, value = 0 },
                              new Records { key = 2, value = 0 },
                              new Records { key = 1, value = 15 },
                              new Records { key = 3, value = 0 }
            };

            int result = TaleOfTwoStacks_Solution.TwoStacks(records);
            Console.WriteLine(result);
        }
    }
    public class Records 
    {
        //----  1-Enqueue.
        //----  2-Dequeue.
        //----  3-Peek.
        public int key { get; set; }
        public int value { get; set; }
    }
}
