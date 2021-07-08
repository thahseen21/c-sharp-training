//Array Manipulation using array.

using System;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new int[10];
            var dupArray = new int[10];
            var index = 0;

            Console.WriteLine($"Enter 10 values:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}th :");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 && j != i; j++) // here the j!=i is used because not check with its same number which is obviously the same.
                {
                    if (myArray[i] == myArray[j])
                    {
                        dupArray[index] = myArray[i];
                        index++;
                    }
                }
            }

            Console.WriteLine($"The duplicate value are:");
            foreach (var number in dupArray)
            {
                Console.Write($"{number},");
            }

        }
    }
}
