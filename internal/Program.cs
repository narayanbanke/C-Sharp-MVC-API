using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo

{
    class Program
    {
        static void Main(string[] args)
        {
            demointernal objdemointernal = new demointernal();
            objdemointernal.id = 1;
            
            Console.WriteLine(objdemointernal.id);
        }
    }

    public class demointernal
    {
        internal int id { get; set; }
        private int id1 { get; set; }
        public int id2 { get; set; }
    }
    public class demointernal1
    {
        internal int id { get; set; }
        private int id1 { get; set; }
        public int id2 { get; set; }
    }
}
