using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HR.Person;

namespace TesterApp
{

    //User Defined Structure TYPE
    public struct Point
    {
        public int x;
        public int y;
    }
    //Abstract class enforce overriding
    public abstract class Shape
    {
        //Minimum one method has to be abstract method.
        abstract public void Draw();
        public string Color { get; set; } 
        public string Width { get; set; }
        public void Display()
        {
            Console.WriteLine("Shape is getting displayed...");
        }
    }

    public class Line : Shape
    {
        public Point StartPoint;
        public Point EndPoint;
        public override void Draw()
        {
            Console.WriteLine("Line is Drawn....");
            Console.WriteLine("First Point {0}, {1}", StartPoint.x, EndPoint.y);
            Console.WriteLine("Second Point {0}, {1}", StartPoint.x, EndPoint.y);
            Console.WriteLine("Color = {0} ", Color);
            Console.WriteLine("Width = {0} ", Width); 
        }
    }

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
            Console.WriteLine("Demo for Interface inheritance");
            IPrintable outputDevice = null;
            
            //Printer laserPrinter = new Printer();
            //outputDevice = laserPrinter;

            outputDevice = new Printer();
            //late binding 
            outputDevice.Start();
            outputDevice.Print(); //Printer method will be called.
            outputDevice.Stop();


            //ThreeDPrinter jobPrinter = new ThreeDPrinter();
            //outputDevice = jobPrinter;
            outputDevice = new ThreeDPrinter();

            //when interface is used always it is going to consider late binding.
            //late binding
            outputDevice.Start();
            outputDevice.Print(); // ThreeDPrinter method will be called.
            outputDevice.Stop();

            LanguageFeaturesTest test = new LanguageFeaturesTest();

            Console.Write("Demo Abstract Class");

            Shape theShape = new Line();

            theShape.Color = "Red";
            theShape.Width = "4";

            Line l = (Line) theShape; //typecast line //Line l = theShape as Line;
            l.StartPoint = new Point();
            l.StartPoint.x = 78;
            l.StartPoint.y = 12;

            l.EndPoint = new Point();
            l.EndPoint.x = 56;
            l.EndPoint.y = 12;

            theShape.Draw();

            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
