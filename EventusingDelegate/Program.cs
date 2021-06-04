using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventusingDelegate
{

     
    class Program
    {
        public delegate int transformer(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int i = int.Parse(Console.ReadLine());
            transformer t = square;
            t += Cuber;
            int j = t.Invoke(i);
            Console.WriteLine("result "+j.ToString());
            Console.ReadLine();
        }
        public static int square(int x)
        {
            return x * x;
        }
        public static int Cuber(int x)
        {
            return x * x * x;
        }
    }
}
