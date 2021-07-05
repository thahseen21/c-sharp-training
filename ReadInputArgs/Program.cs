using System;

namespace ReadInputArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi" + args[0] + " " + args[1]);

            for (int i = 0; i < args.Length; i++) // for n number of arguments from cli
            {
                Console.WriteLine("hello " + args[i]);
            }
        }
    }
}
