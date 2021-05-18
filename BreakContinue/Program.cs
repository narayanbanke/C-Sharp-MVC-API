using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AttributeAccess4;

namespace Hello

{

    class Program
    {
        static void Main(string[] args)
        {
            FirstClass f = new FirstClass();
            int i;
            for (i = 0; i <= 10; i++)
            {
                if (i == 5)
                    continue;
                if (i == 8)
                    break;
                Console.WriteLine("value is" + i);
            }
            Console.ReadLine();
        }

    }
}