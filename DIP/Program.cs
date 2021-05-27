using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();

            return _dataAccess.GetCustomerName(id);
        }
        public bool DeleteCustomer(int id)
        {
            DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();

            return _dataAccess.DeleteCustomer(id);
        }

    }

    public class DataAccessFactory
    {
        public static DataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }

    public class DataAccess
    {
        public DataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            //will have sql statement
            return "Dummy Customer Name"; // get it from DB in real app
        }
        public bool DeleteCustomer(int id)
        {
            //will have sql statement
            return true; // get it from DB in real app
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomerBusinessLogic objCustomerBusinessLogic = new CustomerBusinessLogic();
    Console.WriteLine("Customer Name"  +      objCustomerBusinessLogic.GetCustomerName(1));

            objCustomerBusinessLogic.DeleteCustomer(1);
        
        
        }
    }
}
