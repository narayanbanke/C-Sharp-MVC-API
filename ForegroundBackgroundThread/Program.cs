﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForegroundBackgroundThread
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    namespace ForegroundBackgroundThread
    {
        class Program
        {
            static void Print1()
            {
                Console.WriteLine("Print1() running on {0} Thread", Thread.CurrentThread.Name);
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("Executing Print1.... ");
                  Thread.Sleep(1000);
                }
            }
            static void Print2()
            {
                Console.WriteLine("Print2() running on {0} Thread", Thread.CurrentThread.Name);
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("Executing Print2....");
                   Thread.Sleep(1000);
                }
            }
            static void Main(string[] args)
            {
                Console.Title = "ForegroundBackgroundThread";
                Thread t1 = new Thread(Print1);
                Thread t2 = new Thread(Print2);

                t1.Name = "Primary";
                t2.Name = "Secondary";
            
                Console.WriteLine("Select your desired option: \n");
                Console.WriteLine("1. To Run 2 Threads Parrelly");
                Console.WriteLine("2. Foreground Vs Background");

                Console.Write("\nPlease enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choice == 1)
                {
                    t1.Start();
                    t2.Start();
                }

                if (choice == 2)
                {
                    Console.WriteLine("*********** Foreground Vs Background**********");
                    Console.WriteLine();
                    Console.WriteLine("Enter 1 to Start Foreground Thread and 2  Start Background Thread: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (number)
                    {
                        case 1:
                            RunningForegroundThread();
                            break;
                        case 2:
                            RunningBackgroundThread();
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine("Main() method completed...");

               // Console.ReadLine();
                 
            }

            static void foregroundtask()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Running......");
                    Thread.Sleep(1000);
                }
            }

            static void RunningForegroundThread()
            {
                Thread foreground = new Thread(foregroundtask);
                Console.WriteLine("Is background "+ foreground.IsBackground );
                foreground.Start();
            }

            static void RunningBackgroundThread()
            {
                Thread background = new Thread(foregroundtask);
                background.IsBackground = true;
                Console.WriteLine("Is background " + background.IsBackground);
                background.Start();
            }
        }
    }
}
