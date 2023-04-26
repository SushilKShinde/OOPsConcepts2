using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts2
{
    abstract class Animal //Base class/Parent class
    {
        // Abstract method (does not have a body)
        public abstract void AnimalSound();
        public void Run()
        {
            Console.WriteLine("Every animal can run");
        }
    }
}
