using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_AccessingSortList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

            Console.WriteLine(numberNames[1]); //output: One
            Console.WriteLine(numberNames[2]); //output: Two
            Console.WriteLine(numberNames[3]); //output: Three
                                               //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

            numberNames[2] = "TWO"; //updates value
            numberNames[4] = "Four"; //adds a new key-value if a key does not exists

            SortedList<int, string> numberNames1 = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };
            if (numberNames1.ContainsKey(4))
            {
                numberNames1[4] = "four";
            }

            int result;
            //if (numberNames1.TryGetValue(4, out result))
            //    Console.WriteLine("Key: {0}, Value: {1}", 4, result);

            SortedList<int, string> numberNames2 = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };
            for (int i = 0; i < numberNames2.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", numberNames2.Keys[i], numberNames2.Values[i]);
            }
            SortedList<int, string> numberNames5 = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"},
                                        {5, "Five"},
                                        {4, "Four"}
                                    };

            numberNames5.Remove(1);//removes key 1 pair
            numberNames5.Remove(10);//removes key 1 pair, no error if not exists

            numberNames5.RemoveAt(0);//removes key-value pair from index 0 
                                    //numberNames.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException

            foreach (var kvp in numberNames5)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
}
