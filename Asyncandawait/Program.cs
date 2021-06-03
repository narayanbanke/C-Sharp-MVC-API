using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asyncandawait
{
    class Program
    {
        static void Main(string[] args)
        {
            somemethod();

            Console.WriteLine("Main method code");
             Console.Read(); 
        }
        static  void  somemethod()
        {
            Task.Delay(5000);
            Console.WriteLine("Asyncandawait");
        }
    }
}
