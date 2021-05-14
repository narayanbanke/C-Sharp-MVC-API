using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Car

    {
        private string model = "Mustang";
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
            Car1 myObj1= new Car1();
            myObj1.ModifyModel("modelname");
            myObj1.firstname = "narayan";
            myObj1.lastname = "banke";
            Console.WriteLine(myObj1.firstname);//get property
            Car2 myObj2 = new Car2();
            Console.WriteLine(myObj2.model);
            Base ob1 = new Base();
            Derived ob2 = new Derived();  
            ob2.num1 = 20;
            ob2.num2 = 40;
           
            // Access to protected member as it is inherited by the Derived class  
            ob2.num2 = 90;
            Console.WriteLine("Number2 value {0}", ob2.num2);
            Console.WriteLine("Number1 value which is protected {0}", ob2.num1);
            Console.ReadLine();
        }
    }
    class Car1

    {
        private string fullname { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

        private string model { get; set; }
        public void ModifyModel(string varmodle)
            {
            //i can do.
            model = varmodle;

             }
        public string readmodel()
        {
            return model;
            
        }

    }

    class Car2
    {
        public string model = "Mustang";
    }
    class Base
    {
        protected int num3;
        public int num1;
    }
    class Derived : Base
    {
        public int num2;
         
    }
}  
 
