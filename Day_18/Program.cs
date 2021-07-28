using System;
using System.Text;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            // int[] arr = new int[] { 4, 3, 5, 1, 2 };
            Console.WriteLine($"Enter the length of the array :");
            var size = int.Parse(Console.ReadLine());
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
            Sort(ref arr, size);
            Display(arr, size);

            Console.WriteLine($"Find the element to search:");
            var value = int.Parse(Console.ReadLine());
            Search(arr, size, value);

            CheckPalindrome("potato");

        }
        public static void Display(int[] arr, int size)
        {
            foreach (var i in arr)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine($"");
        }
        public static void Search(int[] arr, int size, int value)
        {
            int mid = size / 2;
            for (int i = 0; i < size; i++)
            {
                if (arr[mid] == value)
                {
                    Console.WriteLine($"found {value}");
                    break;
                }
                else if (arr[mid] < value)
                {
                    mid = (mid + 1) / 2;
                }
                else if (arr[mid] > value)
                {
                    mid = (mid - 1) / 2;
                }
            }
            // return -1;
        }
        public static void Sort(ref int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                var min = arr[i];
                int indexRef = i;
                for (int j = i; j < size; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        indexRef = j;
                    }
                }
                var temp = arr[i];
                arr[i] = arr[indexRef];
                arr[indexRef] = temp;
            }
        }
        public static void CheckPalindrome(string text)
        {

            char[] reverseString = new char[text.Length];
            for (int i = 0, j = text.Length - 1; i < text.Length; i++, j--)
            {
                reverseString[i] = text[j];
            }
            var result = reverseString.ToString() == text ? "Palindrome" : "Not Palindrome";

            Console.WriteLine($"{result}");
        }
    }
}
