using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPintro
{
    class Program
    {
        static void Main(string[] args)
        {
             Employee Permanent = new Employee(1, "john",20000);
           
            decimal bonus = Permanent.CalculateBonus();
            Console.WriteLine("Employee name:" + Permanent.Name);
            Console.WriteLine("Employee bonus:" + bonus);
            Console.ReadLine();
        }

    }


}
