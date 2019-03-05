using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLSample
{
    class ParallelForEach
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
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item =>
            {
                WorkOnItem(item);
            });
        }
    }
}
