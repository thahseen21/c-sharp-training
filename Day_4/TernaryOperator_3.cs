using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter country name:");
            var country = Console.ReadLine();

            Console.WriteLine($"Enter state name:");
            var state = Console.ReadLine();

            var checkState = country.ToLower() == "india" ?
                state.ToLower() == "kerala" ? "It is India and Kerala"
                 : "It is India but not "
                    : "Not India";

            Console.WriteLine($"{checkState}");


        }
    }
}
