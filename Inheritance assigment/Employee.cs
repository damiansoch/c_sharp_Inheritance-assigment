using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_assigment
{
    public class Employee
    {

        public Employee(string lastName, string firstName, int salary)
        {
            LastName = lastName;
            FirstName = firstName;
            Salary = salary;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
        public void Pause()
        {
            Console.WriteLine("Employee is on his break");
        }
    }
}
