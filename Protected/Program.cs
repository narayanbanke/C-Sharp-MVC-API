using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    // C# Program to show use of
    // internal access modifier
    // Inside the file Program.cs
    using System;

    namespace internalAccessModifier
    {

        // Declare class Complex as internal
        internal class Complex
        {

            int real;
            int img;

            public void setData(int r, int i)
            {
                real = r;
                img = i;
            }

            public void displayData()
            {
                Console.WriteLine("Real = {0}", real);
                Console.WriteLine("Imaginary = {0}", img);
            }
        }

        // Driver Class
        class Program
        {

            // Main Method
            static void Main(string[] args)
            {
                // Instantiate the class Complex
                // in separate class but within 
                // the same assembly
                Complex c = new Complex();

                // Accessible in class Program
                c.setData(2, 1);
                c.displayData();
            }
        }
    }
//    Output:
//Real = 2
//Imaginary = 1
}
