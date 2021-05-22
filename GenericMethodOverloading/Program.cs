using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodOverloading
{
    class Program
    {
        class Printer
        {
            public void Print<T>(T data)
            {
                Console.WriteLine(data);
            }
        }

         // type infer from the specified value
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!");
        }
    }
}
