/*
Create a calculator program which accepts the first two inputs as intiables and
the third input as operator and perform the appropriate operation.
Try out all available arithmetic operators.
*/

using System;

namespace calculator
{
    class Program
    {

        public static int Addition(int x, int y)
        {
            return (x + y);
        }
        public static int Subtraction(int x, int y)
        {
            return (x + y);

        }
        public static int Multiplication(int x, int y)
        {
            return (x + y);
        }
        public static int Division(int x, int y)
        {

            try
            {
                return (x / y);
            }
            catch
            {
                Console.WriteLine("Divide by zero not possible");
                return 0;
            }

        }
        static void Main(string[] args)
        {
            int x, y;

            char choice;

            //Getting the ip from the user
            Console.WriteLine("Enter the Value of X");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of Y");
            y = Convert.ToInt32(Console.ReadLine());

            //witch case for the operations to be performed
            Console.WriteLine("Select the given option");
            Console.WriteLine("+ for Addtion \n- for Subtraction\n* for Multiplication \n/ for division");
            Console.WriteLine("Please select your option:");
            choice = Console.ReadLine()[0];

            switch (choice)
            {
                case '+':
                    Console.WriteLine("after addition = " + Program.Addition(x, y));
                    break;
                case '-':
                    Console.WriteLine("after Subtraction = " + Program.Subtraction(x, y));
                    break;
                case '*':
                    Console.WriteLine("after Multiplication = " + Program.Multiplication(x, y));
                    break;
                case '/':
                    Console.WriteLine("after Division = " + Program.Division(x, y));
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;

            }

        }
    }
}
