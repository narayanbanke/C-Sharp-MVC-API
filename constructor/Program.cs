using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    // Create a Car class
    class Car
    {
        public string model;  // Create a field
        // Create a class constructor for the Car class
        private  double discount;
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        discount=5.6;//this can come from databaswe


    }

    static void Main(string[] args)
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
             
            Console.WriteLine(Ford.model);  // Print the value of model
            person person1 = new person("narayan");
            Console.WriteLine(person1.name );
            Car1 Ford1 = new Car1("Mustang", "Red", 1969);
            Car1 Ford2 = new Car1();
            Ford2.model = "TIGIO";
            Ford2.color = "Yellow";
            Ford2.year = 1969;
            Console.WriteLine(Ford1.color + " " + Ford1.year + " " + Ford1.model);


        }
    }
    class person
    {
        public string name;

        // Create a class constructor with a parameter
        public person(string Name)
        {
            name = Name;
        }
        // Outputs "Mustang"
    }
    class Car1
    {
        public string model;
        public string color;
        public int year;
        public Car1()
        {

        }
        // Create a class constructor with multiple parameters
        public Car1(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

         
    }




}