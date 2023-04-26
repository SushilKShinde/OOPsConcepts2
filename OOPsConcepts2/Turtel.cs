using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts2
{
    public class Turtel:Animal
    {
        public override void Run()  //overrides the base class method
        {
            Console.WriteLine("Turtel runs slowly");
        }
    }
}
