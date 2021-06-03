using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousmethodwithActiondelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printActionDel = delegate (int i)
            {
                Console.WriteLine(i);
            };

            printActionDel(10);
        }
    }
}
