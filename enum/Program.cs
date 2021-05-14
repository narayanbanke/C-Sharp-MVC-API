using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APr value " + MonthEnu.JAN);
            Console.WriteLine("Level " + Level.Low);

            if (MonthEnu.JAN.ToString() == "JAN")
            {
                Console.WriteLine("this is January");
            }
            Console.ReadLine();

        }
    }


    enum Level
    {
        Low,
        Medium,
        High
    }

    enum MonthEnu
    {
        JAN,
        FEB,
        MAR,
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC
    }

    enum gender
    {
        M,
        F

    }
}