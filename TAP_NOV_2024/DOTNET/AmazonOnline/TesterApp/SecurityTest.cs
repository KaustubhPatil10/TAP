using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Membership;

namespace TesterApp
{
    class SecurityTest
    {

        static void Main(string [] args)
        {
            Console.WriteLine("Login Demo");
            Console.WriteLine("Enter User Id: ");
            string userId = Console.ReadLine();

            Console.WriteLine("Enter your Password: ");
            string password = Console.ReadLine();

            bool status = AccountManager.Login(userId, password);
            if(status)
            {
                Console.WriteLine("Welcome....");
            }
            else
            {
                Console.WriteLine("Invalid User....");
            }


            Console.WriteLine("Customers Registration");
            Console.WriteLine("Full Name : ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter your Email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your ContactNumber : ");
            string contactNumber = Console.ReadLine();

            Console.WriteLine("Enter your Location : ");
            string location = Console.ReadLine();

            status = AccountManager.Register(userId, password, fullName, email, contactNumber, location);
            if (status)
            {
                Console.WriteLine("Test passed....");
            }
            else
            {
                Console.WriteLine("Test Failed....");
            }
                
                
                
                Console.ReadLine();

        }
    }
}
