using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class GCTest
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5000; i++)
            {
                Person thePerson = new Person("Kaustubh"+i, "Patil", new DateTime(1996, 06, 10));
                Console.WriteLine(thePerson);
            }
            Console.ReadLine();
        }
    }
}
