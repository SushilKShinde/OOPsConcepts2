using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts2
{
    public class Employee //base class 
    {
        public int empId;
        public string empName;
        public void EmployeeDetails()
        {
            Console.WriteLine("This is method of base class");   
        }
    }
}
