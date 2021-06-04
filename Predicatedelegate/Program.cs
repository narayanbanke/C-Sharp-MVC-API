using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicatedelegate
{
    class Program
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        static bool Isadult(int age)
        {
            bool adult = false;
            if (age > 18)
            {
                adult = true; 
            }
            return adult;
        }
        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("NPBANKE");
            Predicate<int> isadultdelegate = Isadult;
            bool Isadultresult = Isadult(19);
          
            
            Console.WriteLine(Isadultresult);
            Console.ReadLine();
        }
    }
}
