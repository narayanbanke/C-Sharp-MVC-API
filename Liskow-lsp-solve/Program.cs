using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskowlspsolve
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Permanent = new PartTimeEmployee(1, "john");
            decimal bonus = Permanent.CalculateBonus(10000);
            Console.WriteLine("Employee name:" + Permanent.Name);
            Console.WriteLine("Employee bonus:" + bonus);
            Employee tempo = new TempTimeEmployee(1, "vikky");
            decimal tempobonus = tempo.CalculateBonus(10000);
            Console.WriteLine("Employee name:" + tempo.Name);
            Console.WriteLine("Employee bonus:" + tempobonus);
            //  Employee contractemp = new ContractEmployee(1, "dffg");
            //   decimal contractempbonus = contractemp.CalculateBonus(10000);
            //    Console.WriteLine("Employee name:" + contractemp.Name);
            //   Console.WriteLine("Employee bonus:" + contractempbonus);

            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(new PartTimeEmployee (1, "john"));
            employees.Add(new TempTimeEmployee(3, "mohan"));
            employees.Add(new ContractEmployee(3, "myyyohan"));
            foreach (var Employee in employees)
            {
                
            }
            Console.ReadLine();
        }
    }
}
