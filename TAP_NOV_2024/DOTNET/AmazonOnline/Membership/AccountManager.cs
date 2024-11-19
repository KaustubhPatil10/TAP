using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;

namespace Membership
{
    public static class AccountManager
    {
        public static bool Login(string userName, string password)
        {
            bool status = false;
            if (userName == "kaustubh" && password == "seed")
            {
                status = true;
            }
            return status;
        }
         
        public static bool Register(string loginid, string password, string name, string email, string contactnumber, string location)
        {
            bool status = false;
            Customer theCustomer = new Customer();
            theCustomer.FullName = name;
            theCustomer.UserID = loginid;
            theCustomer.Password = password;
            theCustomer.Email = email;
            theCustomer.ContactNumber = contactnumber;
            theCustomer.Location = location;

            if(theCustomer != null)
                status = true ;
            return status;
        }

        public static bool ChangePassword(string loginId, string existingPassword, string newPassword)
        {
            bool status = false;
            //set new passwrod for userId


            return status;
        }

        public static bool ForgotPassword(string loginId)
        {
            bool status = false;

            return status;
        }
    }
}
