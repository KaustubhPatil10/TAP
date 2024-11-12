using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        private float balance;
        
        //Property
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Parameterised Constructor
        public Account(float amount)
        {
            balance = amount;
        }

        //Method 1
        public void Deposit(float amount)
        {
            balance = balance + amount;
        }

        //Method 2
        public void Withdraw(float amount)
        {
            balance = balance - amount;
        }


        // is always overrided to convert object state into string
        public override string ToString()
        {
            return balance.ToString();
        }
    }
}
