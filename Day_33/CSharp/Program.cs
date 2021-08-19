using System;
using System.Reflection;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=42;
            Type type = i.GetType();
            Console.WriteLine(type);

            Assembly info = typeof(int).Assembly;
            Console.WriteLine($"{info}"); 
        }
    }
}
