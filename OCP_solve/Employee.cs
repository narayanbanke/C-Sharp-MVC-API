using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_solve
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, decimal Salary, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = Salary;
        }
        public abstract decimal CalculateBonus();

    }

    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id, decimal salary, string name) : base(id, salary, name)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;

        }
        public override decimal CalculateBonus()
        {
            return this.Salary * .1M;
        }
    }
    public class TempTimeEmployee : Employee
    {
        public TempTimeEmployee(int id, decimal salary, string name) : base(id, salary, name)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        public override decimal CalculateBonus()
        {
            return this.Salary * .20M;
        }
    }

    public class DirectorEmployee : Employee
    {
        public DirectorEmployee(int id, decimal salary, string name) : base(id, salary, name)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        public override decimal CalculateBonus()
        {
            return this.Salary * .20M;
        }
    }

    public class GuestEmployee : Employee
    {
        public GuestEmployee(int id, decimal salary, string name) : base(id, salary, name)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        public override decimal CalculateBonus()
        {
            return this.Salary * .20M;
        }
    }
}