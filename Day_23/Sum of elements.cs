//Time complexity is O(n)
using System;
using System.Collections.Generic;

namespace SumOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> sumList = new List<int>();

            int total = 0;

            foreach (var num in list)
            {
                total += num;
            }

            for (int i = 0; i < list.Count; i++)
            {
                sumList.Add(total - list[i]);
            }

            foreach (var num in sumList)
            {
                Console.WriteLine($"{num}");
            }

        }
    }
}
