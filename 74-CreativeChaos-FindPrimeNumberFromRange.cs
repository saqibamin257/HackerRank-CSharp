using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class CreativeChaos_FindPrimeNumber
    {
        public List<int> PrimeNumbers(int start, int End) 
        {
            // start =10
            // End =100
            // 10/10 == 0;


            List<int> result = new List<int>();
            
            for (int i = start; i <= End; i++) 
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++) 
                {
                    if (i % j == 0)   
                    {
                        isPrime = false;                    
                        break;                        
                    }
                }
                if(isPrime)
                result.Add(i);
            }
            return result;
        }

    }
}
