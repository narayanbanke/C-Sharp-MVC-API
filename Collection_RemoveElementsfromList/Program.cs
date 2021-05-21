using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_RemoveElementsfromList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes the first 10 from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            foreach (var el in numbers)
                Console.Write(el); //prints 20 30


            Console.Write(numbers.Contains(10)); // returns true
            Console.Write(numbers.Contains(11)); // returns false
            Console.Write(numbers.Contains(20)); // returns true

        }
    }
}
