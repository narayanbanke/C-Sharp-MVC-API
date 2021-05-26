using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl2
{

    public class First
    {
        Second objsecond;

        public First()
        {
            objsecond = Factory.GetObjectOfSecond();
        }

        public void Task1()
        {
            // do something here..
            objsecond.SomeMethod();
            // do something here..
        }
    }
    public class Second
    {
        public void SomeMethod()
        {
            //doing something..
        }
    }
    public class Factory
    {
        public static Second GetObjectOfSecond()
        {
            return new Second();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Factory Factory = new Factory();
            Factory.GetObjectOfSecond();
            First objFirst = new First();
            objFirst.Task1();


        }
    }
}
