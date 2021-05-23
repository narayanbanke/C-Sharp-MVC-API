using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static bool IsLessThan(this int i, int value)
        {
            return i <value;
        }

        public static bool Isequleto(this string  i, string value)
        {
            return i == value;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            string str = "np";
            bool result = i.IsGreaterThan(100);
            bool result1 = i.IsLessThan(100);
            bool result2 = str.Isequleto("fhf");
            Console.WriteLine(result);
        }
    }
}
