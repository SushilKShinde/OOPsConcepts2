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
            PartTimeEmp partTimeEmp = new PartTimeEmp();
            partTimeEmp.empName = "Sushil";
            FullTimeEmp fullTimeEmp = new FullTimeEmp();
            fullTimeEmp.empName = "Sachin";

            fullTimeEmp.EmployeeDetails();
 
            Console.WriteLine(fullTimeEmp.empName);
        }
    }
}
