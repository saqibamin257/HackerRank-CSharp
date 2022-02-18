using HackerRank.Async_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    #region ConceptWithExample
    // The Task asynchronous programming model(TAP) provides an abstraction over asynchronous code.You write code as a sequence of statements,
    // just like always.You can read that code as though each statement completes before the next begins.
    // The compiler performs many transformations because some of those statements may start work and return a Task
    // that represents the ongoing work.

    //That's the goal of this syntax: enable code that reads like a sequence of statements, but executes in a much more complicated order
    //based on external resource allocation and when tasks complete. It's analogous to how people give instructions for processes that
    //include asynchronous tasks.Throughout this article, you'll use an example of instructions for making a breakfast to see how the
    //async and await keywords make it easier to reason about code, that includes a series of asynchronous instructions. You'd write the
    //instructions something like the following list to explain how to make a breakfast:


    //Pour a cup of coffee.
    //Heat up a pan, then fry two eggs.
    //Fry three slices of bacon.
    //Toast two pieces of bread.
    //Add butter and jam to the toast.
    //Pour a glass of orange juice.

    //If you have experience with cooking, you'd execute those instructions asynchronously. You'd start warming the pan for eggs,
    //then start the bacon. You'd put the bread in the toaster, then start the eggs. At each step of the process, you'd start a task,
    //then turn your attention to tasks that are ready for your attention.


    //Cooking breakfast is a good example of asynchronous work that isn't parallel. One person (or thread) can handle all these tasks.
    //Continuing the breakfast analogy, one person can make breakfast asynchronously by starting the next task before the first completes.
    //The cooking progresses whether or not someone is watching it. As soon as you start warming the pan for the eggs, you can begin frying
    //the bacon. Once the bacon starts, you can put the bread into the toaster.


    //For a parallel algorithm, you'd need multiple cooks (or threads). One would make the eggs, one the bacon, and so on. Each one would be
    //focused on just that one task. Each cook (or thread) would be blocked synchronously waiting for bacon to be ready to flip, or the toast
    //to pop.


    //Now, consider those same instructions written as C# statements:


    //Computers don't interpret those instructions the same way people do. The computer will block on each statement until the work is
    //complete before moving on to the next statement. That creates an unsatisfying breakfast. The later tasks wouldn't be started until
    //the earlier tasks had completed.It would take much longer to create the breakfast, and some items would have gotten cold before being
    //served.


    //If you want the computer to execute the above instructions asynchronously, you must write asynchronous code.

    //These concerns are important for the programs you write today.When you write client programs, you want the UI to be responsive to user
    //input. Your application shouldn't make a phone appear frozen while it's downloading data from the web. When you write server programs,
    //you don't want threads blocked. Those threads could be serving other requests. Using synchronous code when asynchronous alternatives
    //exist hurts your ability to scale out less expensively. You pay for those blocked threads.


    //Successful modern applications require asynchronous code. Without language support, writing asynchronous code required callbacks,
    //completion events, or other means that obscured the original intent of the code.The advantage of the synchronous code is that
    //its step-by-step actions make it easy to scan and understand.Traditional asynchronous models forced you to focus on the asynchronous
    //nature of the code, not on the fundamental actions of the code.
    #endregion

    internal class Synchoronous_Programming_Result
    {
        public static void BreakFast()
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Coffee cup = Synchoronous_Programming_Solution.PourCoffee();
            Console.WriteLine("Coffee is ready.");

            Egg egg = Synchoronous_Programming_Solution.FryEgg(2);
            Console.WriteLine("Eggs are ready");

            Kebab kebab = Synchoronous_Programming_Solution.FryKebab(2);
            Console.WriteLine("kebabs are ready");
                        
            Toast toast = Synchoronous_Programming_Solution.ToastBread(2);
            Synchoronous_Programming_Solution.ApplyButter(toast);
            Synchoronous_Programming_Solution.ApplyJam(toast);
            Console.WriteLine("Toasts are ready");

            Juice orangeJuice = Synchoronous_Programming_Solution.PourOJ();
            Console.WriteLine("Orange juice is ready");

            Console.WriteLine("Breakfast is ready");
            
            sw.Stop();
            Console.WriteLine($"Total time : {sw.ElapsedMilliseconds} milliseconds");
        }
    }

    internal class Synchoronous_Programming_Solution 
    {
        public static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        public static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        public static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        public static Toast ToastBread(int slices) 
        {
            for(int i = 0; i < slices; i++) 
            {
                Console.WriteLine($"Putting slice {i+1} of bread in the toaster");
            }
            Console.WriteLine("Start toasting.....");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        public static Kebab FryKebab(int Totalkebab) 
        {
            Console.WriteLine($"putting kebab slice {Totalkebab} in the pan");
            Console.WriteLine("cooking first side of kebab....");
            Task.Delay(3000).Wait();
            for(int i = 0; i < Totalkebab; i++) 
            {
                Console.WriteLine($"Flipping a slice {i+1} of kebab");
            }
            Console.WriteLine("cokking second side of Kebab.....");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put kebabs on plate");
            return new Kebab();
        }
        public static Egg FryEgg(int TotalEggs) 
        {
            Console.WriteLine("warming oil in the pan....");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {TotalEggs} eggs");
            Console.WriteLine("Cooking Egg...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }
        public static Coffee PourCoffee() 
        {
            Console.WriteLine("Pouring Coffee");
            return new Coffee();
        }
    }
}
