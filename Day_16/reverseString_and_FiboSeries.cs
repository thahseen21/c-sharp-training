using System;

namespace Assignment1
{
    class Program
    {

        static int ComputeFiboSeries(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            if (number == 0)
            {
                return 0;
            }

            return ComputeFiboSeries(number - 1) + ComputeFiboSeries(number - 2);
        }

        static string ReverseString(string text, int mid, int size)
        {
            var reverseString = text;
            if (text.Length == 1)
            {
                return reverseString;
            }

            char[] s1 = new char[mid + 1];
            char[] s2 = new char[size - mid];

            text.CopyTo(0, s1, 0, mid + 1);
            text.CopyTo(mid + 1, s2, 0, size - mid);

            return ReverseString(new string(s2), (s2.Length - 1) / 2, s2.Length - 1) + ReverseString(new string(s1), (s1.Length - 1) / 2, s1.Length - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result1 = ComputeFiboSeries(4);
            Console.WriteLine($"{result1}");

            string s1 = "potatooo";
            var mid = (s1.Length - 1) / 2;
            var size = s1.Length - 1;


            var result2 = ReverseString(s1, mid, size);

            Console.WriteLine($"{result2}");

        }
    }
}
