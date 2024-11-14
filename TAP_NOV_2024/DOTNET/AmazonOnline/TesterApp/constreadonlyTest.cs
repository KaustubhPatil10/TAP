using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HR;

namespace TesterApp
{
    enum Weekdays { Mon, Tue, Wed, Thur, Fri, Sat, Sun};

    enum Months { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};

    enum FavouriteColor { Violet, Indigo, Blue, Green, Yellow, Orange, Red};
    class MathEngine
    {
        public const int count = 56; // at the time of declaration you have to initialize.
        public readonly double PI; //you can declare but no need to initialize here.

        public MathEngine(int num1, int num2)
        {
            PI = 7.14;
        }

        public MathEngine()       
        {
            PI = 3.14; // initialized only once.
        }

        public int Add(int op1, int op2)
        {
            //PI = 45;
            return op1 + op2;
        }

    }
    class constreadonlyTest
    {


        static float area;
        static float circum;

        //params is used only for similar type or  for method overloading. 
        static void ViewNames(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            
        }

        static void Swap(ref int n1, ref int n2)
        {
            int temp = n1; 
            n1 = n2; 
            n2 = temp;
        }
        static void  Calculate(float radius, out float area, out float circum)
        {
            area = 3.14f * radius * radius;
            circum = 2 * 3.14f * radius;
        }

        static void Main(string [] args)
        {
            #region Enum Examples
            Weekdays day = Weekdays.Mon;
            Months month = Months.May;
            FavouriteColor myColor = FavouriteColor.Red;
            #endregion

            #region Collection Examples
            int[] schoolMarks;
            int[] marks = new int[9];
            int[] enggMarks = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // we can declare arrays either in enggMarks format OR dacMarks Format. 
            int[] dacMarks = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string [] names = new string[] { "Kaustubh", "Pallavi", "Soham", "Smit", "Harsh" };
            
            //creating a list.
            List<string> students = new List<string>();
            students.Add("Amitabh");
            students.Add("Rajesh");
            students.Add("Ramesh");
            students.Add("Ganesh");

            List<Person> people = new List<Person>();
            people.Add(new Person("Kaustubh", "Patil", new DateTime(1996, 06, 10)));
            people.Add(new Person("Pallavi", "Patil", new DateTime(1994, 05, 09)));
            people.Add(new Person("Sairaj", "Patil", new DateTime(2002, 11, 09)));
            
            //foreach(string name in students)
            //{
            //    Console.WriteLine(name);
            //}

            foreach (Person prn in people)
            {
                Console.WriteLine(prn);
            }
            #endregion

            Console.WriteLine("{0}", day);
            Console.WriteLine("{0}", month);
            Console.WriteLine("{0}", myColor);

            #region MultipleViewNames
            ViewNames("Rahul sir", "Bakul madam", "shrinivas sir");
            ViewNames("Jeevan", "Sangita");
            ViewNames("Rahul sir", "Bakul madam", "shrinivas sir", "Rajesh", "Jay");
            #endregion


            int mumbaiPopulation = 45000;
            int punePopulation = 3400;

            Swap(ref mumbaiPopulation, ref punePopulation);
            Console.WriteLine("mumbaiPopulation = {0}", mumbaiPopulation);
            Console.WriteLine("punePopulation = {0}", punePopulation);



            float area; 
            float circum;

            float radius = 4;
            Calculate(radius, out area, out circum);

            Console.WriteLine("Area = {0} ", area);
            Console.WriteLine("Circumference = {0} ", circum);


            Console.ReadLine();
        }
    }
}
