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
            // Polymorphism
            //Polymorphism polymorphism = new Polymorphism(); 
            Console.WriteLine("Enter double value");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter double value");
            double b = Convert.ToDouble(Console.ReadLine());
            Polymorphism.Addition(a, b);
            Console.ReadLine();
        }
    }
}
