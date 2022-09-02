using System;

namespace Inheritance_assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new("Travolta", "John", 40000);

            Boss boss1 = new("Washington", "George", 60000, "Mustang");

            Trainee trainee1 = new("Sandler", "Adam", 20000, 20, 20);

            boss1.Lead();
            trainee1.Work();

            Console.ReadLine();
        }
    }
}
