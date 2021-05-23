using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Indexer
{
    class Program
    {
      public  class StringDataStore
        {
            private string[] strArr = new string[10]; // internal data storage

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

            public int StoreId { get; set; }


        }
      static void Main(string[] args)
        {
            StringDataStore strStore = new StringDataStore();
            strStore.StoreId = 1000;
            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);

        }



    }
     
}
