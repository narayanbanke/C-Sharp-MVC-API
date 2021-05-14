using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {//<class name> <userdefined name> = new <class name>();
            Employee objemployee = new Employee();
            objemployee.id = 1;
            objemployee.name = "narayan";
            objemployee.hourlypay = 10000;
            objemployee.hrs = 40;
     double salary=objemployee.CalculateSalary();
            Console.WriteLine("Employee\t" + objemployee.name + "\tsalary is " + salary);
           


            Employee objemployee2 = new Employee();
            objemployee2.id = 2;
            objemployee2.name = "Supriya";
            objemployee2.hourlypay = 100000;
            objemployee2.hrs = 40;
            double salary1 = objemployee2.CalculateSalary();
            Console.WriteLine("Employee\t" + objemployee2.name + "\tsalary is " + salary1);
            

            Employee objemployee3 = new Employee();
            objemployee3.id = 3;
            objemployee3.name = "Prakash";
            objemployee3.hourlypay = 100000;
            objemployee3.hrs = 40;
            double salary2 = objemployee2.CalculateSalary();
            Console.WriteLine("Employee\t" + objemployee3.name + "\tsalary is " + salary2);
            Console.ReadLine();




        }
    }
    class Employee
    {
        public int id { get; set; }//fields
        public string name { get; set; }
        public double  hourlypay { get; set; }
        public int  hrs { get; set; }
      public  double CalculateSalary()
        {
            return hrs * hourlypay;
        }
        public double CalculateSalary(int hourlypay)
        {
            return hrs * hourlypay;
        }
        
    }


}
