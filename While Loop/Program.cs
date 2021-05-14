using System;
public class Exercise4
{
	public static void Main()
	{
		employee objemployee = new employee();
		 

		int i = 0; // initialization

		//while (i < 10) // condition
		//{
		//	Console.WriteLine("i = {0}", i);

		//	++i; // increment
		//}
		//int x = 6; int y = 5;
		//        Exercise4.add(x, y);
		//Console.WriteLine("Addition is" + result);

		//MyMethod("India");
		//MyMethod();
		//MyMethod("USA");
		double p1 = 20;
		int x = 10; int y = 20;
		float x1 = 20; double y1 = 20;
		int b=  MyMethodoverload( x);
		float c= MyMethodoverload( x1);
	 	double z = MyMethodoverload(y1, p1);
		Console.ReadLine();
	}
	static double MyMethodoverload(double x, double y)
    {
		return x * y;

    }	
	
	static int  MyMethodoverload(int a)
	{
		int b = a;
		return b;
	}
	static float MyMethodoverload(float a)
	{	 
		return a;
	}
	public static void add(int a, int b)
	{
		int c = a + b;
		Console.WriteLine("Addition is" + c);
	}
	static void MyMethod(string country = "Norway")
	{
		Console.WriteLine(country);
	}
}

public class employee
{



}