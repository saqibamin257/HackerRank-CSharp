using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Employee
    {
        private string[] arr = new string[2];
        public string this[int i] // this is indexer
        {
            get { return arr[i];}
            set { arr[i] = value;}
        }
    }
    internal class Indexer_Result
    {
        public static void Input() 
        {
            Employee objEmp = new Employee();
            objEmp[0] = "NMOPI12345";
            objEmp[1] = "NMOPI333355";
            for(int i = 0; i < 2; i++) 
            {
                Console.WriteLine(objEmp[i]);
            }
        }
    }
}
