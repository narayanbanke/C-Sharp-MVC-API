using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeanEvent
{
    public delegate void Notify();  // delegate

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Subcribe clicked!");
            // some code here..
            // OnProcessCompleted();
            ProcessCompleted?.Invoke();
        }

        //void OnProcessCompleted() //protected virtual method
        //{
        //    //if ProcessCompleted is not null then call delegate
        //    ProcessCompleted?.Invoke();
             
        //}
    }
    class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();//next step1
            bl.ProcessCompleted += delegatemethod; // register with an event and provide the action  next step2
            bl.StartProcess();
            Console.ReadLine();
        }

        // event handler
        public static void delegatemethod()
        {// client code/ db insertion , updation
            Console.WriteLine("Data Updated!");
            Console.WriteLine("Email sent");
            Console.WriteLine("Subscribed!");
        }

    }
}
