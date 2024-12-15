using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Person: IDisposable
    {

        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.BirthDate = DateTime.Now;
        }
        public Person(string fname, string lname, DateTime bdate)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = bdate;
        }

        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime BirthDate { get; set; }

        //Here in override you can write either LastName or this.LastName both are same.
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate + " ";
        }

        public void show()
        {

        }

        public void Dispose()
        {
            // Deinitializing system resources before object get Destroyed

            // Releasing system resources which were used

            // database connections,
            // multiple threads,
            // files

            GC.SuppressFinalize(this);
        }

        ~Person()
        {
            // Deinitializing system resources before object get Destroyed

            // Releasing system resources which were used

            // database connections,
            // multiple threads,
            // files
        }

    }
}
