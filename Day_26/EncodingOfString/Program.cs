using System;
using System.Text;
namespace EncodingOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "AAABCCCDE";
            StringEncoder(input);
        }
        public static void StringEncoder(string input)
        {
            StringBuilder encodedText = new StringBuilder();
            char currentChar = input[0];
            int j = 1, count = 1;
            do
            {
                if (currentChar != input[j])
                {
                    if (count > 1)
                    {
                        encodedText.Append(count.ToString() + currentChar);
                        count = 1;
                    }
                    // else if (input.Length == j)
                    // {
                    //     encodedText.Append(count.ToString() + currentChar);
                    // }
                    else
                    {
                        encodedText.Append(currentChar);
                    }
                    currentChar = input[j];
                }
                else
                {
                    count++;
                }
                Console.WriteLine($"{currentChar}");
                j++;
            } while (j < input.Length);
            if (count > 1)
            {
                encodedText.Append(count.ToString() + currentChar);
                count = 1;
            }
            else
            {
                encodedText.Append(currentChar);
            }

            Console.WriteLine($"{encodedText}");


        }
    }
}
