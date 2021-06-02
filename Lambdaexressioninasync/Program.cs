using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdaexressioninasync
{
    public class AsyncClass
    {
        public async Task<string> Hello()
        {
            return await Task<string>.Run(() => {
                return "Return From Hello";
            });
        }
        public async void fun()
        {
            Console.WriteLine(await Hello());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new AsyncClass().fun();
            Console.ReadLine();
        }
    }
}
