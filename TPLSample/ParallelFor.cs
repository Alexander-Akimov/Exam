using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLSample
{
    class ParallelFor
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine($"Started working on: {item} on thread:" +
                $" {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }

        public static void Execute()
        {
            var items = Enumerable.Range(0, 500).ToArray();

            ParallelLoopResult result = Parallel.For(0, items.Length, (i, loopState) =>
            {
                if (i == 200)
                    loopState.Stop();

                WorkOnItem(items[i]);
            });

            Console.WriteLine("Completed: " + result.IsCompleted);
            Console.WriteLine("Items: " + result.LowestBreakIteration);

            //for (var i = 0; i < items.Length; i++)
            //{
            //    WorkOnItem(items[i]);
            //}
        }
    }
}
