using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Queue_DataStructure_Solution
    {
        public static void AddArray_Queue() 
        {
            string[] name = new string[] { "ali","ahmed","akram","wasim" };
            Queue<string> names_Queue = new Queue<string>(name);

            foreach(var n in names_Queue) 
            {
                Console.WriteLine(n);
            }
        }

        public static void AddValues_Queue()
        {
            
            Queue<string> names_Queue = new Queue<string>();
            names_Queue.Enqueue("Jibran");
            names_Queue.Enqueue("Jameel");
            names_Queue.Enqueue("John");
            names_Queue.Enqueue("Tim");

            foreach (var n in names_Queue)
            {
                Console.WriteLine(n);
            }
        }


        public static void RemoveValues_Queue()
        {

            Queue<string> names_Queue = new Queue<string>();
            names_Queue.Enqueue("Jibran");
            names_Queue.Enqueue("Jameel");
            names_Queue.Enqueue("John");
            names_Queue.Enqueue("Tim");

            Console.WriteLine("***** Orignal Data  ******");
            foreach (var n in names_Queue)
            {
                Console.WriteLine(n);
            }

            names_Queue.Dequeue();
            names_Queue.Dequeue();

            Console.WriteLine();
            Console.WriteLine("***** after removing first 2 members  ******");
            foreach (var n in names_Queue)
            {
                Console.WriteLine(n);
            }
        }

        public static void Clear_Queue()
        {

            Queue<string> names_Queue = new Queue<string>();
            names_Queue.Enqueue("abc");
            names_Queue.Enqueue("def");
            names_Queue.Enqueue("jkl");
            

            Console.WriteLine("***** Orignal Data  ******");
            foreach (var n in names_Queue)
            {
                Console.WriteLine(n);
            }

            names_Queue.Clear();
            

            Console.WriteLine();
            Console.WriteLine("***** after Clear  ******");
            foreach (var n in names_Queue)
            {
                Console.WriteLine(n);
            }
        }
    }

    internal class Queue_DataStructure_Result 
    {
        public static void Input() 
        {
            Console.WriteLine("****** add array values to Queue");
            Queue_DataStructure_Solution.AddArray_Queue();
            Console.WriteLine();

            Console.WriteLine("****** add values to Queue");
            Queue_DataStructure_Solution.AddValues_Queue();
            Console.WriteLine();

            Console.WriteLine("****** remove values from Queue");
            Queue_DataStructure_Solution.RemoveValues_Queue();
            Console.WriteLine();


            Console.WriteLine("****** Use Clear function");
            Queue_DataStructure_Solution.Clear_Queue();
            Console.WriteLine();



        }
    }
}
