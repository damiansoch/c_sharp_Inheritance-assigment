using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_assigment
{
    public class Boss : Employee
    {

        public Boss(string lastName, string firstName, int salary, string companyCar) : base(lastName, firstName, salary)
        {
            CompanyCar = companyCar;
        }

        public string CompanyCar { get; set; }

        public void Lead()
        {
            Console.WriteLine("Boss is leading");
        }
    }
}
