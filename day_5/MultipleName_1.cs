// Write a program which asks the user to enter multiple names until you press the enter button  (a blank name). Store them in a List.
// If the number of names are more than 2 then display a formatted string like name[0] , name[1] and others<name.count-2>  people like your post! ,
// If the number of names are two then display like name[0] and name[1] likes your post! , if there is only one name display name[0] likes your post  else  display blank line.

using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleName
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameList = new List<string>();

            Console.WriteLine($"Enter multiple names");
            var names = Console.ReadLine();

            // trim() is used to avoid "input : "ram     " ; output: ram, and others 4 likes your post!" this scenario.
            nameList.AddRange(names.Trim().Split(" ")); // this is a possible another way is using ToList() from Linq like this "nameList = names.Split(" ").ToList();" 

            if (nameList.Count() > 2)
            {
                Console.WriteLine($"{nameList[0]},{nameList[1]} and others {nameList.Count - 2} likes your post!");
            }
            else if (nameList.Count == 2)
            {
                Console.WriteLine($"{nameList[0]},{nameList[1]} likes your post!");
            }
            else if (nameList.Count == 1)
            {
                Console.WriteLine($"{nameList[0]} likes your post!");
            }
            else
            {
                Console.WriteLine($"No likes...");
            }

        }
    }
}
