using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class Employee: Person
    {
        private int id;
        private double da;
        private double hra;
        private double daysworking;

        public Employee()
        {
            this.id = 10;
            this.da = 20;
            this.hra = 30;
            this.daysworking = 50;
        }

        public Employee(int id, double da, double hra, double daysworking)
        {
             
        }

    }
}
