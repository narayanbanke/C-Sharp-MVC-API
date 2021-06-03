using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncwithAnonymousMethod
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };

      int a=      getRandomNumber.Invoke();
        }
    }
}
