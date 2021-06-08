using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_inEventHandlerDelegate
{
    class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += delegateactionormethod; // register with an event
            bl.StartProcess();
        }

        // event handler
        public static void delegateactionormethod(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed!");
        }
    }

    public class ProcessBusinessLogic
    {
        // declaring an event using built-in EventHandler
        public event EventHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            //  OnProcessCompleted(EventArgs.Empty); //No event data
            
            ProcessCompleted?.Invoke(this, EventArgs.Empty);
            Console.ReadLine();
        }

        // void OnProcessCompleted(EventArgs e)
        //{
        //    ProcessCompleted?.Invoke(this, e);
        //}
    }
}
