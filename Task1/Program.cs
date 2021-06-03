using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
  

    namespace TaskBasedAsynchronousProgramming
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Statred");
               // Thread thread = new Thread(PrintCounter);
                Task task1 = new Task(PrintCounter);
                 task1.Start();
                Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
                Console.ReadKey();
            }

            static void PrintCounter()
            {
                Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
                for (int count = 1; count <= 10000000000; count++)
                {
                    Console.WriteLine($"count value: {count}");
                }
                Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            }
        }
    }
}
