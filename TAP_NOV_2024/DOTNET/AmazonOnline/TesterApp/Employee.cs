using System;
using System.Collections.Generic;


namespace HR
{

    //Inheritance - inherited Prson class into Employee class.
    public class Employee : Person
    {
        public Employee(): base() 
        {

        }

        public Employee(string fname, string lname, DateTime bdate,
                        int id, string dept, float bsalary, int daysWorked):base(fname,lname,bdate)
        {
            this.ID = id;
            this.Department = dept;
            this.BasicSalary = bsalary;
        }
        public int ID { get; set; }
        public string Department { get; set; }
        public float BasicSalary { get; set; }
        public int WorkingDays { get; set; }

        //virtual is used so that this function can be overrided into Self Employee class 
        public virtual float CalculateSalary()
        {
            float salary = BasicSalary + (100 * WorkingDays);
            return salary;
        }

        public override string ToString()
        {
            // whenever + is used int ID will be converted to string.
            return base.ToString() + " " + this.ID + " " + this.Department + " " + 
                this.BasicSalary + " " + this.WorkingDays;
        }

    }
}
