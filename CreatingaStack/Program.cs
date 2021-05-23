using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingaStack
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
            
            foreach (var item in myStack)
                Console.Write(item + ","); //prints 4,3,2,1, 
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack1 = new Stack<int>(arr);

            foreach (var item in myStack1)
                Console.Write(item + ","); //prints 4,3,2,1, 


        }
    }
}
