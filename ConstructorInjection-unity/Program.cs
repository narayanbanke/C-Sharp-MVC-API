using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConstructorInjection
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
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
    public class CustomerBusinessLogic
        {
         ICustomerDataAccess _dataAccess;
        public CustomerBusinessLogic(ICustomerDataAccess custDataAccess)
        {
            _dataAccess = custDataAccess;
        }

        //public CustomerBusinessLogic()
        //    {
        //        _dataAccess = new CustomerDataAccess();
        //    }

        public string ProcessCustomerData(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }


    //public class CustomerService
    //{
    //    CustomerBusinessLogic _customerBL;
    //    private ICustomerDataAccess _ICustomerDataAccess = null;

    //    public CustomerService()
    //    {
    //        _customerBL = _CustomerDataAccess;
    //    }

    //    // CustomerBusinessLogic _customerBL;
    //    //public CustomerService()
    //    //{
    //    //    CustomerDataAccess objCustomerDataAccess = new CustomerDataAccess();
    //    //    _customerBL = new CustomerBusinessLogic(objCustomerDataAccess);
    //    //    CustomerDataAccess objCustomerDataAccess1 = new CustomerDataAccess();
    //    //    _customerBL = new CustomerBusinessLogic();


    //    //}
    //    public string GetCustomerName(int id)
    //    {
    //        return _customerBL.ProcessCustomerData(id);
    //    }

    //}
    class program
    {
        static void Main(string[] args)
        {
            //CustomerService obj = new CustomerService();
            //obj.GetCustomerName(1);
            var container = new UnityContainer();
            container.RegisterType<ICustomerDataAccess, CustomerDataAccess>();
           
            var driver = container.Resolve<CustomerBusinessLogic>();
            driver.ProcessCustomerData(1);

            
        }

    }

}
