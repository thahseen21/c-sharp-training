//demo method overloading and prams keyword.
using System;

namespace Calculator
{
    class Program
    {
        static private char choice;
        public static void Calculate(params int[] numbers)
        {
            Console.WriteLine($"for addition enter \'+\' and for multiplication enter \'*\'");
            choice = Console.ReadLine()[0];
            switch (choice)
            {
                case '+':
                    var result = 0;
                    foreach (var number in numbers)
                    {
                        result += number;
                    }
                    Console.WriteLine($"Result :{result}");
                    break;
                case '*':
                    result = 1;
                    foreach (var number in numbers)
                    {
                        result *= number;
                    }
                    Console.WriteLine($"Result :{result}");
                    break;
                default:
                    Console.WriteLine($"enter a valid input");
                    break;
            }

        }
        public static void Calculate(int x, int y)
        {
            Console.WriteLine($"for subtraction enter \'-\' and for division enter \'/\'");
            choice = Console.ReadLine()[0];
            switch (choice)
            {
                case '-':
                    Console.WriteLine($"Result :{x - y}");
                    break;
                case '/':
                    Console.WriteLine($"Result :{x / y}");
                    break;
                default:
                    Console.WriteLine($"enter a valid input");
                    break;
            }

        }
        static void Main(string[] args)
        {
            Program.Calculate(1, 2, 3, 4, 5, 6, 7);
            Program.Calculate(5, 2);
        }
    }
}
