using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class StairCase_HackerRank
    {
        /// <summary>
        ///        #
        ///      # #
        ///    # # #
        ///  # # # #
        /// </summary>
        public static void staircase()
        {
            int n = 4;
            for (int i = 1; i<=n ; i++)
            {
                for(int j=n; j>i; j--) 
                {                    
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++) 
                {
                    Console.Write("#");
                }
                Console.WriteLine();                
            }
           
        }
    }
    
}
