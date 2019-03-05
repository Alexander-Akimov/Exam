using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLSample
{
    class ParallelInvoke
    {
        static void Task1()
        {
            Console.WriteLine($"Task 1 starting on thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending");
        }

        static void Task2()
        {
            Console.WriteLine($"Task 2 starting on thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 ending");
        }

        public static void Execute()
        {
            Parallel.Invoke(() => Task1(), () => Task2());
        }
    }
}
