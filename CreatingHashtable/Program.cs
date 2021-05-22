using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            student objstudent = new student();
            objstudent.id = 1;
            objstudent.name = "np";
            Marks Marks = new Marks();
            Marks.subject = "math";
            Marks.grade = "A";
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, 100); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            numberNames.Add("rr", "Three");
            numberNames.Add(objstudent, Marks);
            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 
          var a=  numberNames["rr"];
            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};
            int citiesOfUK = (int)numberNames[1]; //cast to string
            string citiesOfUSA = (string)numberNames["rr"]; //cast to string
           var  citiesOfUSA1 =  numberNames[objstudent];

            Console.WriteLine("Sub: {0}  grade: {1} ", ((Marks)citiesOfUSA1).subject, ((Marks)citiesOfUSA1).grade);
            Console.ReadLine();


            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        }
    }

    class student
    {
        public int id { get; set; }
        public string  name { get; set; }
    }
    class Marks
    {
        public string  subject { get; set; }
        public string grade { get; set; }
    }
}
