using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdaexpressionfitnicewithcollection
{
    class person
    {
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 4, 5, 6, 10 };
            //find all even number from array  
            int[] even = data.Where(fn => fn % 2 == 0).ToArray();

            //find all odd number from array  
            int[] odd = data.Where(fn => fn % 2 != 0).ToArray();

            List<person> persons = new List<person> {
            new person {name = "Sourav"},
            new person {name = "Sudip"},
            new person {name = "Ram"}
        };

            //List of person whose name starts with "S"  
            List<person> nameWithS = persons.Where(fn => fn.name.StartsWith("S")).ToList();
            Console.ReadLine();
        }
    }
}
