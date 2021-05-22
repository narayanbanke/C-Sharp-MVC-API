using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, string>(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
            string result;
            if (cities.TryGetValue("UK", out result))
            {
                Console.WriteLine(result);
            }                                    //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException
            cities.Remove("UK");
            string result1;

            if (cities.TryGetValue("UK", out result1))
            {
                Console.WriteLine(result1);
            }



            if (cities.ContainsKey("UK"))
            {
                cities["UK"] = "UK";
            }
        }
    }
}
