using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloection_CreateList
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Insert(4,8);

            Console.WriteLine(primeNumbers.Contains(10));
            Console.WriteLine(primeNumbers.Count());
            
            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };
            bigCities.Add("Hyderabad");
            for (int i = 0; i < bigCities.Count; i++)
                Console.WriteLine(bigCities[i]);

            foreach (var city in bigCities)
                Console.WriteLine(city);

            Console.WriteLine("Access prime number 1" + primeNumbers[0]);
            Console.WriteLine("Access cities 1 " + cities[0]);
            Console.WriteLine("Access bigCities 1 " + bigCities[0]);
            Console.WriteLine("Access bigCities 1 " + bigCities[4]);
            Console.ReadLine();

        }
    }
}
