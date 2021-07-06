using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;

            Console.WriteLine("Enter a string to reverse : ");

            myString = Console.ReadLine();

            Console.Write("Reverse String : ");
            for (int i = myString.Length - 1; i >= 0; i--)
            {
                Console.Write(myString[i]);
            }

        }
    }
}
