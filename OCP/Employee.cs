using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string EmployeeType { get; set; }
     

        public Employee(int id, string name, decimal Salary,string EmployeeType )
        {
            this.Id = id;
            this.Name = name;
            this.Salary = Salary;
            this.EmployeeType = EmployeeType;
        }

        public decimal CalculateBonus()
        { 
            if (this.EmployeeType=="Permanent")
                return this.Salary * .1M;

             else
                return this.Salary * .5M;
        }

    }
}