using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Creating_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {//SortedList of int keys, string values 
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            //The following will throw exceptions
            //numberNames.Add("Three", 3); //Compile-time error: key must be int type
            //numberNames.Add(1, "One"); //Run-time exception: duplicate key
            //numberNames.Add(null, "Five");//Run-time exception: key cannot be null

            //Creating a SortedList of string keys, string values 
            //using collection-initializer syntax
            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };



        }
    }
}
