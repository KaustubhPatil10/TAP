using System;
using Banking;

namespace TesterApp
{
    // Subscriber 1
    public static class Government
    {
        //Event Handler
        public static void PayIncomeTax()
        {
            Console.WriteLine(" 15% Income tax will be deducted from your account");
        }

        public static void SetIncomeTaxInquiry()
        {
            Console.WriteLine("Income Tax officials have been informed to enquire about payee as well as registered arrest warrant");
        }
    }

    // Subscriber 2
    public static class SBIBank
    {

        //Event Handler
        public static void BlockAccount()
        {
            Console.WriteLine("Your account has been blocked due to insufficient fund.");
        }

        public static void SendEmail()
        {
            Console.WriteLine("Banking operation details are sent to your registered email");
        }
    }



    class EventDemoTest
    {
        static void Main(string [] args)
        {
            // Observer pattern

            // Event Driven Mechanism apply
            // Define delegate AccountHandler
            // Define your class with events based on delegate
            // Write a logic to raise events based on condition
            // Defined Event handler logic for events
             
            // Register Eventhandlers with event before method invokation
            // Programs behaviour gets decided based on events defined,
            //                                          event handler logic implemented
            //                                          condition set for event triggering logic


            Account acct = new Account(45000);


            //events are getting registered with event handlers.
            
            // Subscribe to account
            acct.underbalance += new AccountHandler(SBIBank.BlockAccount);  //register
            acct.underbalance += new AccountHandler(SBIBank.SendEmail);    //register
            
            acct.overbalance += new AccountHandler(Government.PayIncomeTax);   //register
            acct.overbalance += new AccountHandler(Government.SetIncomeTaxInquiry);  //register


            Console.WriteLine("Initial Balance = {0}", acct.Balance);
            //Console.WriteLine("Enter amount to Deposit : ");
            Console.WriteLine("Enter amount to Withdraw : ");
            float amount = float.Parse(Console.ReadLine());


            //acct.Deposit(amount);
            acct.Withdraw(amount);
            Console.WriteLine("Net Balance after operation : ");
            Console.WriteLine(acct.Balance);

            Console.ReadLine();
        }
    }
}
