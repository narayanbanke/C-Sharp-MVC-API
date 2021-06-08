using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaisinganEvent
{
    public delegate void Notify();  // delegate step1

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event step2

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }

         void OnProcessCompleted() //protected virtual method step3
        {
            //if ProcessCompleted is not null then call delegate
            if (ProcessCompleted != null)
                ProcessCompleted.Invoke();
           // ProcessCompleted?.Invoke(); //step4
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
}