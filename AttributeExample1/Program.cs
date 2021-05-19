using System;

public class MyClass
{

    [Obsolete("Don't use OldMethod, it is depricated ,use NewMethod instead", false)]
    static void OldMethod()
    {
        Console.WriteLine("It is the old method");
    }
   
    static void NewMethod()
    {
        Console.WriteLine("It is the new method");
    }
    public static void Main()
    {
         OldMethod();
        NewMethod();
        Console.ReadLine();
    }
}