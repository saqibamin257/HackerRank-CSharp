using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Async_Classes;


namespace HackerRank
{
    #region Stage-1
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
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        public static async Task<Kebab> FryKebabAsync(int Totalkebab)
        {
            Console.WriteLine($"putting kebab slice {Totalkebab} in the pan");
            Console.WriteLine("cooking first side of kebab....");
            await Task.Delay(3000);
            for (int i = 0; i < Totalkebab; i++)
            {
                Console.WriteLine($"Flipping a slice {i + 1} of kebab");
            }
            Console.WriteLine("cokking second side of Kebab.....");
            await Task.Delay(3000);
            Console.WriteLine("Put kebabs on plate");
            return new Kebab();
        }
        public static async Task<Egg> FryEggAsync(int TotalEggs)
        {
            Console.WriteLine("warming oil in the pan....");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {TotalEggs} eggs");
            Console.WriteLine("Cooking Egg...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }
        public static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring Coffee");
            return new Coffee();
        }
    }

    //This code doesn't block while the eggs or the bacon are cooking. This code won't start any other tasks though.You'd still put
    //the toast in the toaster and stare at it until it pops. But at least, you'd respond to anyone that wanted your attention.
    //In a restaurant where multiple orders are placed, the cook could start another breakfast while the first is cooking.

    //Now, the thread working on the breakfast isn't blocked while awaiting any started task that hasn't yet finished.For some applications,
    //this change is all that's needed. A GUI application still responds to the user with just this change. However, for this scenario,
    //you want more. You don't want each of the component tasks to be executed sequentially.It's better to start each of the component tasks
    //before awaiting the previous task's completion.


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
            Task<Kebab> kebabTask = ASynchoronous_Programming_Solution_Stage2.FryKebabAsync(2);
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
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        

        public static async Task<Kebab> FryKebabAsync(int Totalkebab)
        {
            Console.WriteLine($"putting {Totalkebab} slice of kebab in the pan");
            Console.WriteLine("cooking first side of kebab....");
            await Task.Delay(3000);
            for (int i = 0; i < Totalkebab; i++)
            {
                Console.WriteLine($"Flipping a slice {i + 1} of kebab");
            }
            Console.WriteLine("cooking second side of Kebab.....");
            await Task.Delay(3000);
            Console.WriteLine("Put kebabs on plate");
            return new Kebab();
        }
        public static async Task<Egg> FryEggAsync(int TotalEggs)
        {
            Console.WriteLine("warming oil in the pan....");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {TotalEggs} eggs");
            Console.WriteLine("Cooking Egg...");
            await Task.Delay(3000);
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

    #region Stage-3
    internal class ASynchoronous_Programming_Result_Stage3
    {
        public static async void BreakFast()
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Coffee cup = ASynchoronous_Programming_Solution_Stage3.PourCoffee();
            Console.WriteLine("Coffee is ready.");

            var eggTask = ASynchoronous_Programming_Solution_Stage3.FryEggAsync(2);
            var KebabTask= ASynchoronous_Programming_Solution_Stage3.FryKebabAsync(2);
            var toastTask = ASynchoronous_Programming_Solution_Stage3.MakeToastWithBreadAndButterAsync(2);

            var breakfastTasks = new List<Task> { eggTask,KebabTask,toastTask };

            while (breakfastTasks.Count > 0) 
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggTask) 
                {
                    Console.WriteLine("eggs are ready");
                }
               else if (finishedTask == KebabTask)
                {
                    Console.WriteLine("kebabs are ready");
                }
              else if (finishedTask == toastTask)
                {
                    Console.WriteLine("toasts are ready");
                }
                breakfastTasks.Remove(finishedTask);
            }
            

            Juice OJ = ASynchoronous_Programming_Solution_Stage3.PourOJ();
            Console.WriteLine("Orange Juice is ready");
            
            Console.WriteLine("Breakfast Juice is ready");


            sw.Stop();
            Console.WriteLine($"Total time : {sw.ElapsedMilliseconds} milliseconds");
        }
    }

    internal class ASynchoronous_Programming_Solution_Stage3
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

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine($"Putting slice {i + 1} of bread in the toaster");
            }
            Console.WriteLine("Start toasting.....");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");
            return new Toast();           
        }

        //Composition with task
        public static async Task<Toast> MakeToastWithBreadAndButterAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyJam(toast);
            ApplyButter(toast);
            return toast;
        }

        public static async Task<Kebab> FryKebabAsync(int Totalkebab)
        {
            Console.WriteLine($"putting {Totalkebab} slice of kebab in the pan");
            Console.WriteLine("cooking first side of kebab....");
            await Task.Delay(3000);
            for (int i = 0; i < Totalkebab; i++)
            {
                Console.WriteLine($"Flipping a slice {i + 1} of kebab");
            }
            Console.WriteLine("cooking second side of Kebab.....");
            await Task.Delay(3000);
            Console.WriteLine("Put kebabs on plate");
            return new Kebab();
        }
        public static async Task<Egg> FryEggAsync(int TotalEggs)
        {
            Console.WriteLine("warming oil in the pan....");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {TotalEggs} eggs");
            Console.WriteLine("Cooking Egg...");
            await Task.Delay(3000);
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
