//Demo of type casting

// Write a Program to
// •Add  an int with decimal 
//  •Divide a decimal with an int
//  •Multiply two floats

// •Console write them in a concatenated way// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double -> decimal

// Explicit Casting (manually) - converting a larger type to a smaller size type
// decimal -> double -> float -> long -> int -> char

using System;

namespace Add_Division
{
    class Program
    {

        public static decimal Add(int x, decimal y) // here the return type is decimal since the value returned is a decimal type value
        {
            decimal myDecimal = x; // Implicit casting int -> decimal 
            return (myDecimal + y);
        }

        public static float Multiply(float x, float y) // here the return type is int since the value returned is a int type value
        {
            return (x * y);
        }

        public static int Division(int x, decimal y) // non static function & void type
        {
            if (x == 0)
            {
                Console.WriteLine("Division is not possible");
                return 0;
            }
            else
            {
                int myInt = (int)y; // Explicit casting decimal -> int
                return (x / myInt);
            }
        }

        static void Main(string[] args)
        {
            char choice;

            int myInt = 10;

            decimal myDecimal = 20m;

            float myFloat1 = 21.31f, myFloat2 = 31.21f;

            Console.WriteLine("Select the given option");
            Console.WriteLine("1 for Addtion\n2 for Multiply \n3 for Division");
            Console.WriteLine("Please select your option:");
            choice = Console.ReadLine()[0];

            switch (choice)
            {
                case '1':
                    Console.WriteLine("Answer " + Program.Add(myInt, myDecimal)); // calling a static function
                    break;
                case '2':
                    Console.WriteLine("Answer " + Program.Multiply(myFloat1, myFloat2)); // calling a static function
                    break;
                case '3':
                    Console.WriteLine("Answer " + Program.Division(myInt, myDecimal)); // calling a static function
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;

            }

        }
    }
}
