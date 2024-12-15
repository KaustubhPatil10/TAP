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

        // Deterministic Finalization --------- explicitly disposing resources by main thread
        // InDeterministic  Finalization ......... calling destructor for releasing resources
        static void Main(string[] args)
        {
            //Person thePerson = null;
            using (Person thePerson = new Person("Kaustubh", "Patil", new DateTime(1996, 06, 10)))
            {
                for (int i = 0; i < 5000; i++)
                {
                    //Person thePerson = new Person("Kaustubh"+i, "Patil", new DateTime(1996, 06, 10));
                    //Console.WriteLine(thePerson);
                    thePerson.show();
                }
            }

            //GC.SuppressFinalize(thePerson);
            //GC.WaitForPendingFinalizers();
            //GC.Collect();

            Console.ReadLine();
        }
    }
}
