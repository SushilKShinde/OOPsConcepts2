using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts2
{
     class Dog:Animal // derived class
    {
        //Derived class (inherit from Animal)
        public override void AnimalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("Dog says Bhoo Bhoo");    
        }
    }
}
