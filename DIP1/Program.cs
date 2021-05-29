using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP1
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
        string DeleteCustomerName(int id);
        bool UpdateCustomer(int id);
    }
    public interface IOrderDataAccess
    {
        string GetorderName(int id);
        string DeleteorderName(int id);
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string DeleteCustomerName(int id)
        {
            return "Dummy Customer Name";
        }

        

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }

        public bool UpdateCustomer(int id)
        {//just pass the id and update in data
            return true;
        }
    }
    public class OrderrDataAccess : IOrderDataAccess
    {
        public string DeleteorderName(int id)
        {
            throw new NotImplementedException();
        }

        public string GetorderName(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
        public static IOrderDataAccess GetOrderDataAccessObj()
        {
            return new OrderrDataAccess();
        }
    }

    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;
        IOrderDataAccess _orDDataAccess;
        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
             _orDDataAccess = DataAccessFactory.GetOrderDataAccessObj();
        }     
        
        
        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
        public string GetorderrName(int id)
        {
            return _orDDataAccess.GetorderName(id);
        }

        public string DeleteOrdername(int id)
        {
            return _orDDataAccess.DeleteorderName(id);
        }
        public bool UpdateCustomerName(int id)
        {
            return _custDataAccess.UpdateCustomer(id);
        }



    }



    class Program
    {
        static void Main(string[] args)
        {
            CustomerBusinessLogic objCustomerBusinessLogic = new CustomerBusinessLogic();
            objCustomerBusinessLogic.DeleteOrdername(1);
            objCustomerBusinessLogic.GetCustomerName(1);
            objCustomerBusinessLogic.UpdateCustomerName(1);

        }
    }
}
