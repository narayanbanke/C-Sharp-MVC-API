using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjection
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
    public interface IOrderDataAccess
    {
        string GetOrderName(int id);
    }
    interface IDataAccessDependency
    {
        void SetDependency(ICustomerDataAccess customerDataAccess);
        void SetDependency(IOrderDataAccess orderDataAccess);
    }
    public class CustomerBusinessLogic : IDataAccessDependency
    {
        ICustomerDataAccess _dataAccess;
        IOrderDataAccess _dataorderAccess;
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }

        public void SetDependency(ICustomerDataAccess customerDataAccess)
        {
            _dataAccess = customerDataAccess;
        }

        public void SetDependency(IOrderDataAccess orderDataAccess)
        {
            _dataorderAccess = orderDataAccess;
        }

        public string GetOrdername(int id)
        {
            return _dataorderAccess.GetOrderName(id);
        }


    }
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }
        public string GetCustomerName(int id)
        {
            //get the customer name from the db in real application        
            return "Dummy Customer Name";
        }
    }
    public class  orderDataAccess : IOrderDataAccess
    {
        public orderDataAccess()
        {
        }
        public string GetOrderName(int id)
        {
            //get the customer name from the db in real application        
            return "Dummy Customer Name";
        }
    }


    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;
        
        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic();
            ((IDataAccessDependency)_customerBL).SetDependency(new CustomerDataAccess());


            _customerBL = new CustomerBusinessLogic();
            ((IDataAccessDependency)_customerBL).SetDependency(new orderDataAccess());


        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
        public string GetOrdername(int id)
        {
            return _customerBL.GetOrdername(id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService obj = new CustomerService();
            obj.GetCustomerName(1);
            obj.GetOrdername(1);
        }
    }
}
