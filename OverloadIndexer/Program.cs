using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadIndexer
{
    class StringDataStore
    {
        private string[] strArr = new string[10]; // internal data storage

        // int type indexer
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                strArr[index] = value;
            }
        }

        // string type indexer
        public string this[string name]
        {
            get
            {
                foreach (string str in strArr)
                {
                    if (str.ToLower() == name.ToLower())
                        return str;
                }

                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            Console.WriteLine(strStore["one"]);
            Console.WriteLine(strStore["two"]);
            Console.WriteLine(strStore["Three"]);
            Console.WriteLine(strStore["Four"]);
        }
    }
}
