//Finding unique values
using System;
using System.Collections.Generic;

namespace DupeFind
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>();
            var uniqueList = new List<int>();
            var allowInput = true;


            //to read input from the user till the user inputs 'quit'
            do
            {
                Console.WriteLine($"To quit enter \"quit\" else enter a integer value: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    allowInput = false;
                }
                else
                {
                    // this block is to handle the exception made when the input is other than integer and 'quit'
                    try
                    {
                        myList.Add(Convert.ToInt32(input));
                    }
                    catch
                    {
                        Console.WriteLine($"did you mean quit? please enter \"quit\" or an integer value");
                    }
                }
            } while (allowInput);

            Console.WriteLine($"Finding unique values......");

            //to find the unique value and here i have use isContains like a flag variable.
            for (int i = 0; i < myList.Count; i++)
            {
                var isContains = false;
                for (int j = 0; j < myList.Count; j++)
                {
                    if (i != j)
                    {
                        if (myList[i].Equals(myList[j]))
                        {
                            isContains = true;
                        }
                    }
                }
                if (!isContains)
                {
                    uniqueList.Add(myList[i]);
                }
            }

            foreach (var i in uniqueList)
            {
                Console.Write($"{i},");
            }

        }
    }
}
