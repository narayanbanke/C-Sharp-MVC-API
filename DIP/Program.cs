﻿using System;
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
            return "Dummy Customer Name"; // get it from DB in real app
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
