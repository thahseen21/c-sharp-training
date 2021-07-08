//Array Manipulation using arrayList.
// this program illustrates the ArrayList,while loop,for loop,foreach loop 

using System;
using System.Collections;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArrayList = new ArrayList() { 100, 200, 300, 400, 100 };
            // var choice;//not allowed  //Implicitly-typed variables must be initialized
            var dupArrayList = new ArrayList();
            var insert = true;

            while (insert)
            {
                Console.WriteLine($"\nSelect the given option below:\n 1)Insert \t 2)Display \t 3)Find Duplicate \t 0)Finish");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Enter a value :");
                        var num = Convert.ToInt32(Console.ReadLine());
                        myArrayList.Add(num);
                        break;
                    case "2":
                        if (myArrayList.Count > 0)
                            foreach (var value in myArrayList)
                            {
                                Console.Write($"{value},");
                            }
                        else
                            Console.WriteLine($"No Items to display");

                        Console.WriteLine($"\n");
                        break;
                    case "3":
                        for (int i = 0; i < myArrayList.Count; i++)
                        {
                            for (int j = 0; j < myArrayList.Count; j++)
                            {
                                if (j != i)
                                {
                                    if (myArrayList[i].Equals(myArrayList[j])) // had issue here when i used "myArrayList[i] == myArrayList[j]" it wasnt working. I read that the issue but clearly i could not understand
                                    {
                                        if (!dupArrayList.Contains(myArrayList[j]))// to avoid duplicate insertion of value
                                        {

                                            dupArrayList.Add(myArrayList[i]);
                                        }
                                    }
                                }
                            }
                        }

                        foreach (var value in dupArrayList)
                        {
                            Console.Write($"{value},");
                        }
                        break;
                    case "0":
                        insert = false;
                        break;
                    default:
                        Console.WriteLine($"Please give a valid input");
                        break;
                }
            }

            Console.WriteLine($"Bye bye....");


        }
    }
}
