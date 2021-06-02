using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousfunctionandasync
{
    public class AsyncClass
    {
        public string Hello(string name)
        {
            return name;
        }

        public async Task<string> Hello()
        {
            return await Task<string>.Run(() => {
                //lambda expression to execute function using Func anonymous delegate  
                Func<string, string> del = x => x;
                return del.Invoke("sourav");
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
