using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve_lementsFromQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); //prints Hello

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0
            Queue<string> strQ1 = new Queue<string>();
            strQ1.Enqueue("H");
            strQ1.Enqueue("e");
            strQ1.Enqueue("l");
            strQ1.Enqueue("l");
            strQ1.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ1.Count); //prints 5

            if (strQ1.Count > 0)
            {
                Console.WriteLine(strQ1.Peek()); //prints H
                Console.WriteLine(strQ1.Peek()); //prints H
            }

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0


            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            callerIds.Contains(2); //true
            callerIds.Contains(10); //false


        }
    }
}
