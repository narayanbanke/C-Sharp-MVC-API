 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_solve
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee  Permanent = new PartTimeEmployee(1,1000, "john");
            decimal bonus = Permanent.CalculateBonus();
            Console.WriteLine("Employee name:" + Permanent.Name);
            Console.WriteLine("Employee bonus:" + bonus);
           
            Employee tempo = new TempTimeEmployee(1, 10000,"vikky" );
            decimal tempobonus = tempo.CalculateBonus();
            Console.WriteLine("Employee name:" + tempo.Name);
            Console.WriteLine("Employee bonus:" + tempobonus);

            Employee directoremp = new DirectorEmployee(1, 2000,"narr");
            decimal directorempbonus = directoremp.CalculateBonus();
            Console.WriteLine("Employee name:" + directoremp.Name);
            Console.WriteLine("Employee bonus:" + directorempbonus);



            Console.ReadLine();
        }
    }
}
