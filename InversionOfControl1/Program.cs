using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl1
{

    public class A
    {
        B b;

        public A()
        {
            b = new B();
        }

        public void Task1()
        {
            // do something here..
            b.SomeMethod();
            // do something here..
        }

    }
    public class B
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
            //save firstName and lastName to the database here..
        }
    }

}
