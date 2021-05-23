using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBusinessLogicIOC
{
    class Program
    {
        public class CustomerBusinessLogic
        {
            DataAccess _dataAccess;

            public CustomerBusinessLogic()
            {
                _dataAccess = new DataAccess();
            }

            public string GetCustomerName(int id)
            {
                return _dataAccess.GetCustomerName(id);
            }
        }

        public class DataAccess
        {
            public DataAccess()
            {
            }

            public string GetCustomerName(int id)
            {
                return "Dummy Customer Name"; // get it from DB in real app
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
