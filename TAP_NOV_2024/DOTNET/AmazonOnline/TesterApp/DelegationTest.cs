using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    //define delegate
    //
    public delegate void Handler();

    class DelegationTest
    {
        public static void PayIncomeTax()
        {
            Console.WriteLine(" 15% income tax is deducted from your account.");
        }

        public static void PayServiceTax()
        {
            Console.WriteLine(" 25% service tax is deducted from your account.");
        }

        public static void PayProfessionalTax()
        {
            Console.WriteLine(" 10% professional tax is deducted from your account.");
        }
        static void Main(string[] args)
        {
            //early binding
            //PayIncomeTax();

            //for late binding - we used delegate--> is a type that references methods with a particular parameter list and return type.
            Handler operation1 = null;
            operation1 = new Handler(PayIncomeTax);
            //operation1();

            Handler operation2 = null;
            operation2 = new Handler(PayServiceTax);
            //operation2();

            Handler operation3 = null;
            operation3 = new Handler(PayProfessionalTax); //unicast delegate
            //operation3();


            Handler masterOperationManager = null;

            masterOperationManager += operation1;  //multicast
            masterOperationManager += operation2;
            masterOperationManager += operation3;
            masterOperationManager(); // one invokation. ///multicast delegate.

            Console.WriteLine("after unregistration");
            masterOperationManager -= operation3;
            masterOperationManager();

            Console.ReadLine();
        }
    }
}
