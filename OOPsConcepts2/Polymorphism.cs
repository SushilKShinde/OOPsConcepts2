using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts2
{
    internal class Polymorphism
    {
        public static void Addtion(int x, int y)
        {
            Console.WriteLine( x + y);
        }

        //way 1: changing data type of parameters
        public static void Addition(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        //way 2: changing number of parameters
        public static void Addition(int x, double y, int z)
        {
            Console.WriteLine(x + y+ z);
        }

        //way 3: changing order of parameters
        public static void Addition(double x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
