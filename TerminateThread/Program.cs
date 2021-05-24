using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminateThread
{
	// C# program to illustrate the
	// concept of Abort() method
	// on a single thread
	using System;
	using System.Threading;

	class ExampleofThread
	{

		// Non-Static method
		public void thread()
		{
			for (int x = 0; x < 3; x++)
			{
				Console.WriteLine(x);
			}
		}
	}

	// Driver Class
	class ThreadExample
	{

		// Main method
		public static void Main()
		{

			// Creating instance for mythread() method
			ExampleofThread obj = new ExampleofThread();

			// Creating and initializing threads
			Thread thr = new Thread(new ThreadStart(obj.thread));
			thr.Start();

			Console.WriteLine("Thread is abort");

			// Abort thr thread
			// Using Abort() method
			thr.Abort();
		}
	}

}
