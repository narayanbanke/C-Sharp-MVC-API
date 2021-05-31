using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace UnityContainerPropertyInjection
{
    class Program
    {
        public interface ICar
        {
            int Run();
        }

        public class BMW : ICar
        {
            private int _miles = 0;

            public int Run()
            {
                return ++_miles;
            }
        }

        public class Ford : ICar
        {
            private int _miles = 0;

            public int Run()
            {
                return ++_miles;
            }
        }

        public class Audi : ICar
        {
            private int _miles = 0;

            public int Run()
            {
                return ++_miles;
            }

        }
        public class Driver
        {
            public Driver()
            {
            }

            [Dependency("LuxuryCar")]
            public ICar Car { get; set; }

            public void RunCar()
            {
                Console.WriteLine("Running {0} - {1} mile ", this.Car.GetType().Name, this.Car.Run());
            }
        }

        static void Main(string[] args)
        {
            //var container = new UnityContainer();

            ////run-time configuration
            //container.RegisterType<Driver>(new InjectionProperty("Car", new BMW()));

            //var driver = container.Resolve<Driver>();
            //driver.RunCar();
            var container1 = new UnityContainer();
             container1.RegisterType<ICar, BMW>("LuxuryCar");
           container1.RegisterType<ICar, Audi>("Car");

            var driver1 = container1.Resolve<Driver>();
            driver1.RunCar();
            Console.ReadLine();



        }
    }
}
