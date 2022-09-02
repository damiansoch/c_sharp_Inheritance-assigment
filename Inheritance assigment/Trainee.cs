using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_assigment
{
    internal class Trainee : Employee
    {

        public Trainee(string lastName, string firstName, int salary, int workingHours, int schoolHours) : base(lastName, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public void Learn()
        {

        }

        public override void Work()
        {
            Console.WriteLine("Trainee is working but only {0} hours", WorkingHours);
        }
    }
}
