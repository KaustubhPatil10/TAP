using System;
using HR;

namespace TesterApp
{
    class InheritanceTest
    {
        static void Main(string [] args)
        {
            DateTime birthdate = new DateTime(1996, 06, 10);
            Person thePerson = new Person("Kaustubh", "Patil", birthdate);
            Console.WriteLine(thePerson);

            DateTime birthdate2 = new DateTime(1996, 06, 10);
            Employee emp = new Employee("Soham", "Patil", birthdate2, 9, "Analyst", 22000, 27);
            float salary = emp.CalculateSalary();
            Console.WriteLine("Soham Salary = {0}", salary);


            DateTime birthdate3 = new DateTime(1992, 05, 13);
            SalesEmployee emp2 = new SalesEmployee("Vinay", "Tiwari", birthdate3, 12, "Business analyst", 40000, 32, 6000);
            float salary2 = emp2.CalculateSalary();
            Console.WriteLine("Vinay Salary = {0}", salary2);

            //Person prn = thePerson; // instance of person

            Person prn = emp;

            //Polymorphism for ToString will be worked....
            Console.WriteLine("Polymorphic Behaviour");
            Console.WriteLine(prn);


            Console.ReadLine();
        }
    }
}
