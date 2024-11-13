using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    //interface is used to define contract
    // interface is used to define specification
    // interface is used to define guidelines
    //interface is used to enforce rules while building concrete classes
    // interface in C++ is called Abstract Based Class.
    // we can write public void print() OR void IPrintable.Print() //for any function in interface.

    interface IPrintable
    {
        void Print();
        void Start();
        void Stop();
    }

    interface IScannable
    {
        void Scan();
    }
    class Printer : IPrintable, IScannable //Multiple interface inheritance
    {

        public void Scan()
        {
            Console.WriteLine("Started Scanning");
        }

        public void Start()
        {
            Console.WriteLine("Printing is started");
        }

        public void Stop()
        {
        Console.WriteLine("Printing has stopped working");
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Printing data");
        }
    }

    class ThreeDPrinter : IPrintable, IScannable
    {

        public void Scan()
        {
            Console.WriteLine("Started scanning 3D object using UV camera");
        }

        public void Start()
        {
            Console.WriteLine("3D Printer has started Initializing material needed to Job creation");
        }

        public void Stop()
        {
            Console.WriteLine("3D Printer has stop building Model");
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Building 3-D model");
        }

    }
    class LanguageFeaturesTest
    {
        
        static void Main(string [] args)
        {
            //primitive
            //value types
            int result = 12;
            float price = 45;
            bool status = false;
            double score = 5600;

            //reference type
            //class, interface, delegate, event
            //values pointed by reference type are always store on Heap

            //Heap is managed by Garbage Collector;
            //interface IPrintable is used for Polymorphism purpose.

            IPrintable outputDevice = null;
            
            Printer laserPrinter = new Printer();
            outputDevice = laserPrinter;
            outputDevice.Print(); //Printer method will be called.

            ThreeDPrinter jobPrinter = new ThreeDPrinter();
            outputDevice = jobPrinter;
            outputDevice.Print(); // ThreeDPrinter method will be called.
            
            LanguageFeaturesTest test = new LanguageFeaturesTest();

            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
