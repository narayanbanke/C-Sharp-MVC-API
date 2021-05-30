﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainer
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
            private ICar _car = null;

            public Driver(ICar car)
            {
                _car = car;
            }

            public void RunCar()
            {
                Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
            }
        }
        static void Main(string[] args)
        {
            Driver driver = new Driver(new BMW());

            driver.RunCar();
        }
    }
}
