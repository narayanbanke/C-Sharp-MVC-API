using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl1
{

    public class First
    {
        Second objSecond;
        public First()
        {
            objSecond = new Second();
        }
        public void Task1()
        {
            // do something here..
            objSecond.SomeMethod();
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
    class Program
    {
        static void Main(string[] args)
        {
            First objFirst = new First();
            objFirst.Task1();
            //save firstName and lastName to the database here..
        }
    }

}
