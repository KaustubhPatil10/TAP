using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class Program
    {
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

            Program theprogram = new Program();
            theprogram.Display();
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
