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
            //Animal animal = new Animal();  >>>it is not possible to create an object of the Animal class
            Dog dog = new Dog();
            dog.AnimalSound();
            dog.Run(); // run method of Animal can be called from dog class object
        }
    }
}
