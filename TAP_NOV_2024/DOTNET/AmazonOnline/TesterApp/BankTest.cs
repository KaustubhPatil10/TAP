using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class BankTest
    {

        static void Main(string [] args)
        {
            Account acct1 = new Account(56000);
            Console.WriteLine("1. Withdraw: ");
            Console.WriteLine("2. Deposit: ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Amount: ");
            float amount = float.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        acct1.Withdraw(amount);
                    }
                    break;
                case 2:
                    {
                        acct1.Deposit(amount);
                    }
                    break;
            }

            float balance = acct1.Balance;
            Console.WriteLine("Your remaining Balance = {0}", balance);
            Console.WriteLine(acct1); 
            //to write this console.write and pass object to it we need to create a ToString function to show the output for the object.
            Console.ReadLine();
        }
    }
}
