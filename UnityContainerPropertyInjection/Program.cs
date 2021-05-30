using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Unity;

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

            [Dependency]
            public ICar Car { get; set; }

            public void RunCar()
            {
                Console.WriteLine("Running {0} - {1} mile ", this.Car.GetType().Name, this.Car.Run());
            }
        }

        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}
