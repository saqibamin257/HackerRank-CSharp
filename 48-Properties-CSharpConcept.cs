using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Properties_Solution
    {
        private string EmpName = "None";
        public string name 
        {
            get { return EmpName; }
            set { EmpName = value; }
        }
    }
    internal class Properties_Result
    {
        public static void Input() 
        {
            Properties_Solution p = new Properties_Solution();
            p.name = "John Smith";
            Console.WriteLine($"Employee name: {p.name}");
        }
    }
}
