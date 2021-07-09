// I have a large text, but have to display only 20 characters of the text and display but ensure you won't break the word appearing in the end. So It can go a little beyond 20 characters ensuring we won't break the word. 
// example:  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard
// Output :   Lorem Ipsum is simply dummy
using System;
using System.Text;
using System.Collections.Generic;

namespace TextManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Lorem Ipsum is simple dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard";
            StringBuilder shortText = new StringBuilder();
            var characterCoutRef = 0;

            var wordList = new List<string>();

            wordList.AddRange(text.Split(" "));

            foreach (var i in wordList)
            {
                shortText.Append(i).Append(" ");
                characterCoutRef = characterCoutRef + i.Length + 1; // the addition of 1 is for the white space after the words
                if (characterCoutRef > 20)
                {
                    break;
                }
            }

            Console.WriteLine($"The trimmed text :{shortText}");


        }
    }
}
