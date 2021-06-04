using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actiondelegate
{
    class Program
    {
        static void Print(int i)
        {
            Console.WriteLine(i);
            //return i;
        }

        static void Main(string[] args)
        {
            Action<int> printActionDel = Print;
            printActionDel(10);
        }
    }
}
