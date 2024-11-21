using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    //delegate definition.
    public delegate void AccountHandler();

    public class Account
    {
        private float balance;  //state


        //this way we declare event as a data member to a class.
        public event AccountHandler underbalance; //event
        public event AccountHandler overbalance; //event


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

        public void Monitor()  // Observing balance
        {
            
            //check balance against threshold.
            if(balance < 5000)
            {
                //raise an event underbalance
                //trigger
                underbalance(); //calling event like a function or invoking event. 

            }
            else if(balance >= 250000)
            {
                //raise an event overbalance
                //trigger
                overbalance();   //invoking event
            }
        }

        //behaviour
        //Method 1 
        public void Deposit(float amount)
        {
            balance = balance + amount;
            Monitor();
        }

        //Method 2
        public void Withdraw(float amount)
        {
            balance = balance - amount;
            Monitor();
        }



        //dynamic behaviour
        //underbalance, overbalance as events

        // is always overrided to convert object state into string
        public override string ToString()
        {
            return balance.ToString();
        }
    }
}
