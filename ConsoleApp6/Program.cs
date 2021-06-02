using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public delegate void myTestDel(string Name);
    public delegate void TestMutliCast();
    public delegate int TestMutliCastint();
    class Program
    {
        static void Main(string[] args)
        {
            // Normal Methos Call  
            getName("By Normal Method call - Abhishek Singh ");

            //Method Call using delegates  

            myTestDel del = new myTestDel(getName);
            del("By Delagete call-Abhishek singh");

            del.Invoke(" Using Invoke - Abhishek Singh ");

            del = new myTestDel(getLocation);
            del("Mumbai");

            //   Mutlticast implementation with void return type  

            TestMutliCast delmultiCast = new TestMutliCast(Method1);
            delmultiCast += Method2;
            delmultiCast();

            // Mutlticast implementation with void return type  

            myTestDel testMulti = new myTestDel(getName);
            testMulti += getLocation;
            testMulti("Abhi");

            // Mutlticast implementation with int return type  

            TestMutliCastint intMulti = new TestMutliCastint(Method3);
            intMulti += Method4;
            int i = intMulti();

            Console.WriteLine("Return Value is " + i);

            Console.ReadLine();
        }

        public static void Method1()
        {
            Console.WriteLine("Delegate 1st method called!!!!");
        }

        public static void Method2()
        {
            Console.WriteLine("Delegate 2nd method called!!!!");
        }

        public static int Method3()
        {
            Console.WriteLine("Delegate 3rd method called!!!!");
            return 3;
        }

        public static int Method4()
        {
            Console.WriteLine("Delegate 4th method called!!!!");
            return 4;
        }

        public static void getName(string name)
        {
            Console.WriteLine("My Name: " + name);
        }

        public static void getLocation(string location)
        {
            Console.WriteLine("My Loc: " + location);
        }
    }
}
