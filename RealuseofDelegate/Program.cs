using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealuseofDelegate
{
    
    class Utility
    {
        public delegate int transformer(int x);
        public static int callback(int x, transformer t)
        {
           int z = t(x);
            return z;
        }
        public delegate int transformer1(int a,int b);
        public static int callback1(int x,int y, transformer1 t1)
        {
            int z = t1(x,y);
            return z;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int i = int.Parse(Console.ReadLine());
            int square1 = Utility.callback(i, square);
            Console.WriteLine("the square is " + square1);
            int Cuber1 = Utility.callback(i, Cuber);
            Console.WriteLine("the Cuber is " + Cuber1);

            int squarroot1 = Utility.callback(i, squarroot);
            Console.WriteLine("the Cuber is " + squarroot1);

            int square2 = Utility.callback1(i,4, multiply);

            int division1 = Utility.callback1(i, 4, division);
            
            Console.ReadLine();

        }
        public static int square(int x)
        {
            return x * x;
        }
        public static int Cuber(int x)
        {
            return x * x*x;
        }
        public static int squarroot(int x)
        {
            return x * x * x;
        }
        public static int multiply(int x,int y)
        {
            return x *y;
        }
        public static int division(int x, int y)
        {
            return x / y;
        }
    }
}
