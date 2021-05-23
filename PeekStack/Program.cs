using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeekStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.Write("Number of elements in Stack: {0}", myStack.Count);// prints 4

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek()); // prints 4
                Console.WriteLine(myStack.Peek()); // prints 4
            }

            Console.Write("Number of elements in Stack: {0}", myStack.Count);// prints 4

            Stack<int> myStack1 = new Stack<int>();
            myStack1.Push(50);
            myStack1.Push(60);
            myStack1.Push(5);
            myStack1.Push(1);
            while (myStack1.Count > 0)
            {
                Console.Write(myStack.Pop() + ",");//4,3,2,1
            }
            myStack1.Contains(50); // returns false
            myStack1.Contains(10); // returns false


        }
    }
}
