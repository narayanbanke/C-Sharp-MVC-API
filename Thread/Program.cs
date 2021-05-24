using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread
{// C# program to illustrate the
 // creation of thread using
 // non-static method
	using System;
	using System.Threading;

	public class Otherclass
	{

		// Non-static method
		public void myMethod()
		{
			for (int z = 0; z < 3; z++)
			{
				Console.WriteLine("First Thread");
			
			}
		}
	}

	// Driver Class
	public class GFG
	{

		// Main Method
		public static void Main()
		{
			// Creating object of ExThread class
			Otherclass obj = new Otherclass();
			//
			Console.WriteLine("some other operation");
			// Creating thread
			// Using thread class
			//ThreadStart objThreadStart = new ThreadStart(obj.myMethod);
			Thread thr = new Thread(new ThreadStart(obj.myMethod));

			thr.IsBackground = true;
			thr.Start();
			//obj.myMethod();

			Console.WriteLine("Thread type");
			Console.WriteLine("Thread type" + thr.IsBackground);
			Console.ReadLine();
		}
	}

 
}
