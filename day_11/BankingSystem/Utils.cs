using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace BankManagementSystem
{
    class RandomNumber
    {
        static private readonly Random _random = new Random();

        static public int GenerateRandomNumber(int from, int to)
        {
            return _random.Next(from, to);
        }
    }

    public static class Utils
    {
        public static string FindCustomer(string name, Hashtable customerList)
        {
            foreach (var key in customerList.Keys)
            {
                var listName = (string)key;
                if (listName.ToLower() == name.ToLower())
                {
                    return listName;
                }
            }
            return null;

        }
        public static Regex RegexPattern(string pattern)
        {
            Regex rx = new Regex(pattern, RegexOptions.IgnoreCase);// RegexOptions.IgnoreCase is for case insensitive
            return rx;
        }
        public static bool ValidatePanNumber(this string panNumber)
        {
            var pattern = @"[A-Z]{5}[0-9]{4}[A-Z]{1}";
            var matches = RegexPattern(pattern).IsMatch(panNumber);
            return matches;
        }
        public static double GetDueDays(this Insurance customer) //Inconsistent accessibility: parameter type 'Insurance' is less accessible than method 'Utils.GetDueDays(Insurance)' - have to use public for class
        {
            var dueDays = customer.DueDate - customer.isActiveFrom;
            if (dueDays.TotalDays > 0)
                Console.WriteLine($"Pay the next due in {dueDays.TotalDays} days");
            else
                Console.WriteLine($"Your pending {Math.Abs(dueDays.TotalDays)} days");

            return dueDays.TotalDays;
        }
    }
}
