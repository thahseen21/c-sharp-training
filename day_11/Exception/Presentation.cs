
// Create two programs in your solution.
// One is a console application name it as presentation
// Another is a class library name it as Domain
// Ensure you use .NET 5.0 framework for both 
// In the library project, build the functionality to   search for a text occurrence in a string builder  Text program, 
// If the text is found, return the information or throw an exception
// example:  Text: "This is my sample text occurance",   subtext: "Sample text"
// In the main program , collect the message  or the exception  and display it to the user.  
// The main program should send both the Big  text  and substring  to the domain / library.  

using System;
using System.Text;

namespace ExceptionHandling
{
    class Presentation
    {
        static void Main(string[] args)
        {
            StringBuilder inputText = new StringBuilder();
            Console.WriteLine("Enter some text sentence:");
            inputText.Append(Console.ReadLine());
            Console.WriteLine($"Enter the text you want to search");
            var searchText = Console.ReadLine();
            FindText(inputText, searchText);
        }
        public static void FindText(StringBuilder inputData, string searchText)
        {
            string[] inputWord = inputData.ToString().Split(" ");
            var isFound = false;
            for (var i = 0; i < inputWord.Length; i++)
            {
                if (inputWord[i] == searchText)
                {
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"is found");
                throw new Domain("Not Found", "cannot found the text");
            }
            else
                Console.WriteLine($"Found the text \"{searchText}\"");
        }
    }
}
