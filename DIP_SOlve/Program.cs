﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_SOlve
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hardcoded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeBusinessLogic EmployeeBusinessLogic = new EmployeeBusinessLogic();
            Employee Employee = EmployeeBusinessLogic.GetEmployeeDetails(1);

            System.Console.WriteLine("ID" + Employee.ID);
            System.Console.WriteLine("Name" + Employee.Name);
            System.Console.WriteLine("Department" + Employee.Department);
            System.Console.WriteLine("Salary" + Employee.Salary);
            System.Console.ReadLine();
        }
    }
}
