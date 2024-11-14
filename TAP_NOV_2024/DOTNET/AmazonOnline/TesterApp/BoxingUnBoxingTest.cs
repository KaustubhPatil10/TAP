using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class BoxingUnBoxingTest
    {
        static void Main(string [] args)
        {
            // value type
            int count = 45;

            //reference type - type of o is a class
            //Boxing is a technique where value type are transformed into reference type
            // Value type is wrapped in Reference Type

            Object o = count;
            //Console.Write(o);

            //unboxing is a technique where reference is unwrapped and value type is received.
            int result = (int) o;
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
