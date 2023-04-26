using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the oops concepts");
            //Polymorphism- Method Overriding
           //create object of base class 
            Animal animal = new Animal();
            animal.Run();
            //create object of child class
            Dog dog = new Dog();    
            dog.Run();

        }
    }
}
