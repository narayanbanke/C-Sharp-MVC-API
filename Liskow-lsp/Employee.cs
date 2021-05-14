using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskowlsp
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;            
        }
        public abstract decimal CalculateBonus(decimal salary);   
    }

    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id, string name):base (id ,name )
        {
            this.Id = id;
            this.Name = name;
        }
        public override decimal CalculateBonus(decimal salary)
        {
            return    salary * .1M;
        }
    }
    public class TempTimeEmployee : Employee
    {
        public TempTimeEmployee(int id, string name) : base(id, name)
        {
            this.Id = id;
            this.Name = name;
        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .5M;
        }
    }
    public class ContractEmployee : Employee
    {
        public ContractEmployee(int id, string name) : base(id, name)
        {
            this.Id = id;
            this.Name = name;
        }
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }

}