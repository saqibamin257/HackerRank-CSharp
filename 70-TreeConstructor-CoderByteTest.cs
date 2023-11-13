using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class TreeConstructor_Solution
    {

        public bool isBinaryTree(string[] str) 
        {
            Dictionary<int, string> ParentDict = new Dictionary<int, string>();
            Dictionary<int,string> ChildDict = new Dictionary<int, string>();
            
            for (int i = 0; i < str.Length; i++) 
            {
                string[] toupleArray= str[i].Replace("(",string.Empty).Replace(")",string.Empty).Split(",");
               //string[] toupleArray1= str[i].Replace("(", string.Empty).Replace(")", string.Empty).Split(",").ToArray();

                int child =Convert.ToInt32(toupleArray[0]);
                int parent = Convert.ToInt32(toupleArray[1]);

                //condition-1: Each Parent should have atmost 2 child
                if (ParentDict.ContainsKey(parent)) // if parent already have child then add current child 
                {
                    ParentDict[parent] = $"{ParentDict[parent]},{child}";   //let say parent 4 already have value 2 {(4:2)}, now add current value 3 so becomes {(4:2,3)} 
                }
                else 
                {
                    ParentDict.Add(parent,Convert.ToString(child)); // else add key,value in dictionary {1:2}
                }
                //if parent has more than 2 child return false;
                if (ParentDict[parent].Replace(",", string.Empty).Length > 2) 
                {
                    return false;
                }

                //condition-2: child should have atmost 1 parent.
                if (ChildDict.ContainsKey(child))
                { 
                    return false;
                }
                else 
                {
                    ChildDict.Add(child,Convert.ToString(parent));
                }
            }
            return true;
        }
    }
    public class TreeConstructor_Result     
    {
        public void Input() 
        {
            //string[] strArray = new string[] { "(1,2)", "(2,4)", "(7,2)" };          //true
            //["(5,6)", "(6,3)", "(2,3)", "(12,5)"]
            //string[] strArray = new string[] { "(5,6)", "(6,3)", "(2,3)", "(12,5)" };          //true
            //string[] strArray = new string[] { "(1,2)", "(2,4)", "(7,2)","(8,2)" };          //false when parent have more than 2 child.
            string[] strArray = new string[] { "(1,2)", "(2,4)", "(7,2)", "(1,12)" };          //false when child have more than 1 parent.
            bool result = new TreeConstructor_Solution().isBinaryTree(strArray);
            Console.WriteLine($"Given string Array is Binary Tree Constructor: {result}");
        }
    }
}
