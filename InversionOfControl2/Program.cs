using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl2
{

    public class A
    {
        B b;

        public A()
        {
            b = Factory.GetObjectOfB();
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
    public class Factory
    {
        public static B GetObjectOfB()
        {
            return new B();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Factory Factory = new Factory();
            Factory.GetObjectOfB();
        }
    }
}
