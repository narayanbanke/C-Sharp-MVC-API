using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        class KeyValuePair<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }
        class DataStore<T>
        {
            public T Data { get; set; }
        }
        static void Main(string[] args)
        {
            DataStore<string> store = new DataStore<string>();
            store.Data = "Hello World!";
            //obj.Data = 123; //compile-time error
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello World!";
            //strStore.Data = 123; // compile-time error

            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100;
            //intStore.Data = "Hello World!"; // compile-time error

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";



        }
    }
}
