using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Async_Classes;

namespace HackerRank
{
    #region-Stage-1
    //Don't block, await instead
    //The preceding code demonstrates a bad practice: constructing synchronous code to perform asynchronous operations.As written, this code blocks the thread executing it from doing any other work.It won't be interrupted while any of the tasks are in progress. It would be as though you stared at the toaster after putting the bread in. You'd ignore anyone talking to you until the toast popped.
    //Let's start by updating this code so that the thread doesn't block while tasks are running.The await keyword provides a non-blocking way to start a task, then continue execution when that task completes.A simple asynchronous version of the make a breakfast code would look like the following snippet:

    internal class ASynchoronous_Programming_Result_Stage1
    {
        public static async void BreakFast()
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Coffee cup = ASynchoronous_Programming_Solution_Stage1.PourCoffee();
            Console.WriteLine("Coffee is ready.");

            Egg egg = await ASynchoronous_Programming_Solution_Stage1.FryEggAsync(2);
            Console.WriteLine("Eggs are ready");

            Kebab kebab = await ASynchoronous_Programming_Solution_Stage1.FryKebabAsync(2);
            Console.WriteLine("kebabs are ready");

            Toast toast = await ASynchoronous_Programming_Solution_Stage1.ToastBreadAsync(2);
            ASynchoronous_Programming_Solution_Stage1.ApplyButter(toast);
            ASynchoronous_Programming_Solution_Stage1.ApplyJam(toast);
            Console.WriteLine("Toasts are ready");

            Juice orangeJuice = ASynchoronous_Programming_Solution_Stage1.PourOJ();
            Console.WriteLine("Orange juice is ready");

            Console.WriteLine("Breakfast is ready");

            sw.Stop();
            Console.WriteLine($"Total time : {sw.ElapsedMilliseconds} milliseconds");
        }
    }

    internal class ASynchoronous_Programming_Solution_Stage1
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

        public static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine($"Putting slice {i + 1} of bread in the toaster");
            }
            Console.WriteLine("Start toasting.....");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        public static async Task<Kebab> FryKebabAsync(int Totalkebab)
        {
            Console.WriteLine($"putting kebab slice {Totalkebab} in the pan");
            Console.WriteLine("cooking first side of kebab....");
            Task.Delay(3000).Wait();
            for (int i = 0; i < Totalkebab; i++)
            {
                Console.WriteLine($"Flipping a slice {i + 1} of kebab");
            }
            Console.WriteLine("cokking second side of Kebab.....");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put kebabs on plate");
            return new Kebab();
        }
        public static async Task<Egg> FryEggAsync(int TotalEggs)
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

    //This code doesn't block while the eggs or the bacon are cooking. This code won't start any other tasks though.You'd still put the toast in the toaster and stare at it until it pops. But at least, you'd respond to anyone that wanted your attention. In a restaurant where multiple orders are placed, the cook could start another breakfast while the first is cooking.

    //Now, the thread working on the breakfast isn't blocked while awaiting any started task that hasn't yet finished.For some applications, this change is all that's needed. A GUI application still responds to the user with just this change. However, for this scenario, you want more. You don't want each of the component tasks to be executed sequentially.It's better to start each of the component tasks before awaiting the previous task's completion.


    #endregion


    #region Stage-2
    internal class ASynchoronous_Programming_Result_Stage2
    {
        public static async void BreakFast()
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Coffee cup = ASynchoronous_Programming_Solution_Stage2.PourCoffee();
            Console.WriteLine("Coffee is ready.");

            Task<Egg> eggsTask = ASynchoronous_Programming_Solution_Stage2.FryEggAsync(2);
            Task<Kebab> kebabTask = ASynchoronous_Programming_Solution_Stage2.FryKebabAsync(3);
            Task<Toast> toastTask = ASynchoronous_Programming_Solution_Stage2.ToastBreadAsync(2);

            Toast toast = await toastTask;
            ASynchoronous_Programming_Solution_Stage1.ApplyButter(toast);
            ASynchoronous_Programming_Solution_Stage1.ApplyJam(toast);
            Console.WriteLine("Toasts are ready");


            Juice orangeJuice = ASynchoronous_Programming_Solution_Stage2.PourOJ();
            Console.WriteLine("Orange juice is ready");

            Egg eggs = await eggsTask;
            Console.WriteLine("Eggs are ready");

            Kebab kebab = await kebabTask;
            Console.WriteLine("kebabs are ready");

            Console.WriteLine("Breakfast is ready");

            sw.Stop();
            Console.WriteLine($"Total time : {sw.ElapsedMilliseconds} milliseconds");
        }
    }

    internal class ASynchoronous_Programming_Solution_Stage2
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

        public static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine($"Putting slice {i + 1} of bread in the toaster");
            }
            Console.WriteLine("Start toasting.....");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        public static async Task<Kebab> FryKebabAsync(int Totalkebab)
        {
            Console.WriteLine($"putting kebab slice {Totalkebab} in the pan");
            Console.WriteLine("cooking first side of kebab....");
            Task.Delay(3000).Wait();
            for (int i = 0; i < Totalkebab; i++)
            {
                Console.WriteLine($"Flipping a slice {i + 1} of kebab");
            }
            Console.WriteLine("cokking second side of Kebab.....");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put kebabs on plate");
            return new Kebab();
        }
        public static async Task<Egg> FryEggAsync(int TotalEggs)
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

    #endregion
}
