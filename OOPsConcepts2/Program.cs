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
            //Encapsulation
            Person person = new Person();
            //person.setName("sushil");
            //person.getName();
            //person.setAge(21);
            //person.getAge();

            //private variables are accessed by method or properties
            person.age = 23;
            person.getName = "Sushil";
            Console.WriteLine($"Person's age is {person.getAge}");
            Console.WriteLine($"Person's name is {person.getName}");
        }
    }
}
