using System;
using Banking;
using System.Collections.Generic;


namespace TesterApp
{
    //define delegate
    
    // public delegate void Handler();

    //delegate in nothing but a wrapper for function pointers
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
            AccountHandler operation1 = null;
            operation1 = new AccountHandler(PayIncomeTax);  //registering name of function to be invoked.
            //operation1();

            AccountHandler operation2 = null;
            operation2 = new AccountHandler(PayServiceTax);
            //operation2();

            AccountHandler operation3 = null;
            operation3 = new AccountHandler(PayProfessionalTax); //unicast delegate
            //operation3();


            AccountHandler masterOperationManager = null;

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
