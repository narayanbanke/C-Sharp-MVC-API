using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaexpressionwithFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, Boolean> fun = (x, y) => x > y;
            Console.WriteLine(fun(10, 10));
            Console.ReadLine();
        }
    }
}
