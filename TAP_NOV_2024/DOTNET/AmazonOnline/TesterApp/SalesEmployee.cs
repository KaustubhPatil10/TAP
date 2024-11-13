using System;
using System.Collections.Generic;

namespace HR
{

    //to block inheritance we use sealed keyword.
    public sealed class SalesEmployee : Employee
    {
        public float Incentive { get; set; }

        public SalesEmployee(string fname, string lname, DateTime bdate,
                        int id, string dept, float bsalary, int daysWorked, float incentive) :
            base(fname, lname, bdate, id, dept, bsalary, daysWorked)
        {
            this.Incentive = incentive;
        }

        public override float CalculateSalary()
        {
            return base.CalculateSalary() + this.Incentive;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Incentive;
        }
    }
}
