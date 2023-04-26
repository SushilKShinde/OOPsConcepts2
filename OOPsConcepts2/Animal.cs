using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts2
{
    public class Animal //Base class/Parent class
    {
        public virtual void Run()
        {
            Console.WriteLine("Every animal can run");
        }
    }
}
