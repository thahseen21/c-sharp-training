//Read Input and it to the user
//hi Charan ,
// I have include the 5 exercise in this too 
//Console Writeline - explore different ways of printing a) concatenation b) paramerarized 
using System;

namespace ReadInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;

            Console.WriteLine("Enter your First Name :");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            lastName = Console.ReadLine();

            Console.WriteLine("Welcome to Gislen {0} {1}", firstName, lastName); // parameterised
            Console.WriteLine("Nice to meet you " + firstName + " " + lastName); // concatenation
        }
    }
}
