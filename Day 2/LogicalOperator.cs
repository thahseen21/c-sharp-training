
/* A program to accept 2 strings and 2 real time numbers.
  use comparison operator to compare the strings and real time numbers. 
  And compare both these conditions using a logical && operator. */

using System;

namespace LogicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString1, myString2;
            int num1, num2;

            Console.WriteLine("Enter String :");
            myString1 = Console.ReadLine();

            Console.WriteLine("Enter another string to compare :");
            myString2 = Console.ReadLine();

            Console.WriteLine("Enter a number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number to compare :");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (myString1 == myString2 && num1 == num2)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
