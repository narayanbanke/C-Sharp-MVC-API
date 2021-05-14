using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
             Employee Permanent = new Employee(1, "john",10000,"Permanent");
          //  Employee Permanent = new Employee(1, "john");
             decimal bonus = Permanent.CalculateBonus();
            Console.WriteLine("Employee name:" + Permanent.Name);
            Console.WriteLine("Employee bonus:" + bonus);
             Employee tempo = new Employee(1, "vikky",10000, "tempo");
           // Employee tempo = new Employee(1, "vikky");
            decimal tempobonus = tempo.CalculateBonus();
            Console.WriteLine("Employee name:" + tempo.Name);
             Console.WriteLine("Employee bonus:" + tempobonus);
            Console.ReadLine();

        }
    }
}
