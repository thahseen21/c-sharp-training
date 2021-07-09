// Ask the user to enter the time in 24 hours format (eg: 17:00), If the time is between 00:00  and 23:59  then display as valid time else display as invalid time. 
using System;

namespace TimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time in 24 hours format (hh:mm):");
            var time = Console.ReadLine();
            try
            {
                var inputTime = DateTime.Parse(time);
                Console.WriteLine($"Valid Time : {inputTime.TimeOfDay}");
            }
            catch
            {
                Console.WriteLine($"Invalid Time");
            }
        }
    }
}
