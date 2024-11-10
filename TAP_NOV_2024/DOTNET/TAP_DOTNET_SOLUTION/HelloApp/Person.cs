using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    //Abstraction
    public class Person
    {
        //Encapsulation
        private string firstname;
        private string lastname;
        private int age;

        //Constructor Overloading
        //Default constructor
        public Person()
        {
            this.age = 28;
            this.firstname = "Kaustubh";
            this.lastname = "Patil";
        }

        // Parameterised Constructor
        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        // Function within a class
        public void show()
        {
            Console.WriteLine(this.firstname + " " + this.lastname + " " + this.age);    
        }
    }
}
