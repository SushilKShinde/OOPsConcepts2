using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts2
{
    public class Person
    {
        private string name;
        private int age;

        to get and set the value of name

        public string getName
        {
            get { return name; }
            set { name = value; }
        }

        to get and set the value of age
        public int getAge
        {
            get { return age; }
            set { age = value; }
        }

        //public void setName(string name) //method to set a name 
        //{
        //    this.name = name;
        //}

        //public  void getName() // method to get a name as output
        //{
        //    Console.WriteLine($"Person name is {this.name}");
        //}

        ////method to set a age 
        //public void setAge(int age)
        //{
        //    this.age = age;
        //}

        //public void getAge() //method to get a age as output
        //{
        //    Console.WriteLine($"Person's age is {this.age}");
        //}

    }
}
