// Multiuse attribute.  

namespace AttributeAccess4
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                          System.AttributeTargets.Struct,
                          AllowMultiple = true)  // Multiuse attribute.  
   ]
    public class Author : System.Attribute
    {
        string name;
        public double version;

        public Author(string name)
        {
            this.name = name;

            // Default value.  
            version = 1.0;
        }

        public string GetName()
        {
            return name;
        }
    }

    
    [Author("Shobha")]
    public class SecondClass
    {
        // ...  
    }

    // Class with multiple Author attributes.  
    [Author("P. Ackerman"), Author("R. Koch", version = 2.0), Author("npbanke", version = 3.0)]
    public class ThirdClass
    {
        // ...  
    }

    class program
    {

        public static void Main()
        {
            Test();
            System.Console.ReadLine();
        }
        static void Test()
        {
            PrintAuthorInfo(typeof(FirstClass));
            PrintAuthorInfo(typeof(SecondClass));
            PrintAuthorInfo(typeof(ThirdClass));

            SecondClass f = new SecondClass();


        }
        private static void PrintAuthorInfo(System.Type t)
        {
            System.Console.WriteLine("Author information for {0}", t);

            // Using reflection.  
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is Author)
                {
                    Author a = (Author)attr;
                    System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
                }
            }
        }
    }
    /* Output:  
        Author information for FirstClass  
           P. Ackerman, version 1.00  
        Author information for SecondClass  
        Author information for ThirdClass  
           R. Koch, version 2.00  
           P. Ackerman, version 1.00  
    */
}