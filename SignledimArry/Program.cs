using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignledimArry
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9,10 };
             
            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };
            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write( array1[i]
                                                        );
            }
            Console.ReadLine();

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write( array2[i] );
            }
            Console.ReadLine();
             
        }
    }
}