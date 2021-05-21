using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsfromSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"},
                                        {5, "Five"},
                                        {4, "Four"}
                                    };

            numberNames.Remove(1);//removes key 1 pair
            numberNames.Remove(10);//removes key 1 pair, no error if not exists

            numberNames.RemoveAt(0);//removes key-value pair from index 0 
                                    //numberNames.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
}
