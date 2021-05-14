using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.name = "ABC";
            objEmployee.age = 33;
            objEmployee.salary = 1000;
            objEmployee.employeeType = "A";
          double TotalSalary =  objEmployee.calculateTotalSalary();
            Console.WriteLine("Employee Name" + objEmployee.name +"\n");
            Console.WriteLine("Employee salary" + objEmployee.salary + "\n");
            Console.WriteLine("TotalSalary salary" + TotalSalary + "\n");
            Console.ReadLine();
        }
    }


    public class Employee
    {
        public string  name { get; set; }
        public string employeeType { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
        private  double bonusper { get; set; }
        public double calculateTotalSalary()
        {
            if (employeeType == "A")
                bonusper = 20;
            if (employeeType == "B")
                bonusper = 10;
                
            return salary + (salary * bonusper / 100);
        }
         
    }


}
