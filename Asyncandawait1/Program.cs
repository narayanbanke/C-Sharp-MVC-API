using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asyncandawait1
{
    class Program
    {
        static void Main(string[] args)
        {
            somemethod();

            Console.WriteLine("Main method code");
            Console.Read();
        }
       async static void somemethod()
        {
           await Task.Delay(10000);
            Console.WriteLine("Asyncandawait");
        }
    }
}
