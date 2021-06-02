using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    public delegate void myTestDel(string Name);
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

            Console.ReadLine();
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
