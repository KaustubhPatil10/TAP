using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        static void Main(string [] args)
        {
            Weekdays day = Weekdays.Mon;
            Months month = Months.May;
            FavouriteColor myColor = FavouriteColor.Red;

            int[] schoolMarks;
            int[] marks = new int[9];
            int[] enggMarks = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] dacMarks = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            
            
            
            Console.WriteLine(" {0}", day);
            Console.WriteLine(" {0}", month);
            Console.WriteLine(" {0}", myColor);

            Console.ReadLine();
        }
    }
}
