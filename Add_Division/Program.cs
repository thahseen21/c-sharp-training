// hi Charan ,
// I have included both Addition and Division inside a same program

// the below code has two functions called Add() and Division() ,
//  i have declared the addtion has static function 
// and the division has non static funtion

using System;

namespace Add_Division
{
    class Program
    {

        public static int Add(int x, int y) // static function & int return type
        {
            return (x + y);
        }

        public void Division(int x, int y) // non static function & void type
        {
            if (x == 0)
                Console.WriteLine("Division is not possible");
            else
                Console.WriteLine(x / y);
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

            //I have created switch case for the operations to be performed
            Console.WriteLine("Select the given option");
            Console.WriteLine("1 for Addtion \n2 for Division");
            Console.WriteLine("Please select your option:");
            choice = Console.ReadLine()[0];

            switch (choice)
            {
                case '1':
                    Console.WriteLine("Answer " + Program.Add(x, y)); // calling a static function
                    break;
                case '2':
                    Program obj = new Program(); // to call a non-static function we have to create a object reference
                    Console.WriteLine("Answer ");
                    obj.Division(x, y); // calling the Divion() through obj object 
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;

            }

        }
    }
}
