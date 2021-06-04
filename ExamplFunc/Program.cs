using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplFunc
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)
        {
            return x + y;
        }
        static string Sum(int x)
        {
            return x.ToString();
        }
        static void Main(string[] args)
        {
            Func<int , string> adddelegate = Sum;

            string result = adddelegate.Invoke(10);

            Console.WriteLine(result);
        }
    }
}
