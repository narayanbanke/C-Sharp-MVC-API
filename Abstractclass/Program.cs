using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass
{
    // Abstract class
    abstract class Animal
    {
        public string color { get; set; }
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    interface IAnimal
    {
         int color { get; set; }
        //string color=string.Empty ;
        // Abstract method (does not have a body)
        void animalSound();
        // Regular method
        //public void sleep()
        //{
        //    Console.WriteLine("Zzz");
        //}
    }
    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : IAnimal
    {
        public int color
        {
            get => throw new NotImplementedException();
            set
               => color = 1;
        }   

        public void animalSound()
        {
            Console.WriteLine("The pig says: bow bow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.color = "Black";
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method

            Dog myDog = new Dog();
            myDog.animalSound();
            myDog.color = 2;
            int color = myDog.color;
            Console.WriteLine(myDog.color);
            Console.ReadLine();
        }
    }
}
