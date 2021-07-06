// Write a program to accept details like Id ,Name, Salary all using string variables.
//  When showing the results typecast Id and Salary to the suitable data types.

using System;

namespace typecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string id, name, salary;

            Console.WriteLine("Enter your Id : ");
            id = Console.ReadLine();

            Console.WriteLine("Enter your Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Salary : ");
            salary = Console.ReadLine();

            int convertedId = Convert.ToInt32(id); // using convert 
            float convertedSalary = float.Parse(salary); // using parse

            Console.WriteLine("Hi {0},", name);
            Console.WriteLine("Your id is {0} and salary is {1}", convertedId, salary);

        }
    }
}
