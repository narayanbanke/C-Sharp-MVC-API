using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPintro
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string name, decimal Salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = Salary;
           
        }
        public Employee()
        {
             
        }
        public decimal CalculateBonus()
        {           
                return this.Salary * .1M;           
        }

    }
}
