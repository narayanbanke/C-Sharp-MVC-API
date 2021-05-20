using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class Employee
    {
        public abstract string GetProjectDetails(int employeeId);

        public abstract string GetEmployeeDetails(int employeeId);
        
    }
    public class CasualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
    public class ContractualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
       // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new ContractualEmployee());
            employeeList.Add(new CasualEmployee());
            foreach (Employee e in employeeList)
            {
                e.GetEmployeeDetails(1245);
            }
        }
    }
}