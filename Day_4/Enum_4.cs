//Write a program and ask the user to enter the width and height of an image. And determine if it is a landscape or portrait.
// Use enums to store landscape and portrait values.
// Use Ternary operator in conditional statement. 

using System;

namespace Enum
{
    class Program
    {

        public enum Picture
        {
            landscape, protrait
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the dimension of the image:");

            Console.WriteLine($"Length:");
            var length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Breadth:");
            var breadth = Convert.ToInt32(Console.ReadLine());

            var imageMode = length > breadth ? Picture.landscape : Picture.protrait;

            Console.WriteLine($"The image is {imageMode}");


        }
    }
}
