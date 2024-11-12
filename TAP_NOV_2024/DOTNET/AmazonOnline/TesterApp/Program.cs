using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class Program
    {
        private string ProgramName;

        //// Setter Function
        //public void SetProgramName(string name)
        //{
        //    this.ProgramName = name;
        //}

        ////Getter Function
        //public string GetProgrameName()
        //{
        //    return this.ProgramName;
        //}
        
          // OR in C# we use setter and getter function
          // Property 
        public string Name
        {
            get { return this.ProgramName; }
            set { this.ProgramName = value; }   
        }
         

        public Program()
        {
            this.ProgramName = "FirstProgram";
        }

        public Program (string name)
        {
            this.ProgramName = name;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Hello World ! " + args[i]);
            }

            //to give argument go to TestApp properties / under debug /write on command line 
            Console.WriteLine("Welcome to DotNet Programming");
            int count = 45;
            count = count++;


            if(count <= 300)
            {
                while(count < 299)
                {
                    Console.WriteLine("count = {0}", count);
                    count++;
                }
            }

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Good Morning {0}", name + " Patil");  //{}place holder

            int result = Addition(10, 9);
            int result2 = Multiplication(10, 9);

            Console.WriteLine("Addition = {0}", result);
            Console.WriteLine("Multiplication = {0}", result2);

            Program theProgram = new Program();
            theProgram.Name = "My Best Program";

            Console.WriteLine("Program title = " + theProgram.Name);

            theProgram.Display();


            Product theProduct1 = new Product(1, "Gerbera", "Wedding Flower", 4500, 10);
            Product theProduct2 = new Product(2, "Rose", "Valentine Flower", 4000, 20);

            Console.WriteLine(theProduct1);

            //to hold the program from shutting we keep readline at end so we can shut the program manually.
            Console.ReadLine();

        }


        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Multiplication(int a , int b)
        {
            return a * b;
        }

        public void Display()
        {
            Console.WriteLine("Processing Logic for Display");
            Console.WriteLine("Program instance Dashboard");
        }
    }
}
