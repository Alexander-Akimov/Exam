using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParallelInvoke.Execute();
            ParallelForEach.Execute();

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
