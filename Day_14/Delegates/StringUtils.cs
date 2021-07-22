using System;
using System.Text;

namespace DelegateAssignment
{
    static class StringUtils
    {
        public static string ReplaceByUnderscore(string data)
        {
            Console.WriteLine($"\nReplaceByUnderscore\n{String.Join("_", data.Split(" "))}");
            return String.Join("_", data.Split(" "));
        }
        public static string ReverseString(string data)
        {
            StringBuilder reverseString = new StringBuilder();
            reverseString.Append(data);
            for (int i = data.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reverseString[j] = data[i];
            }
            Console.WriteLine($"\nReverseString\n{reverseString}");
            return reverseString.ToString();
        }
        public static string JoinString(string data1, string data2)
        {
            Console.WriteLine($"\nJoin string\n{data1 + data2}");
            return data1 + data2;
        }
        public static string FindAndCount(string data1, string data2)
        {
            var countRef = 0;
            if (data1.Contains(data2))
            {
                foreach (var item in data1.Split(" "))
                {
                    if (item.Equals(data2))
                    {
                        countRef++;
                    }
                }
                Console.WriteLine($"\n\n{data2} found {countRef} times");

            }
            else
            {
                Console.WriteLine($"\n Couldn't find {data2}");
            }

            return data1;
        }
    }
}
