using System;

namespace LINQAssignment
{
    public class Manager
    {
        public string Name { get; set; }
        public int BranchId { get; set; }
        public int Age { get; set; }

        public void DisplayManager()
        {
            Console.WriteLine($"Name:{Name},Age:{Age}");
        }
    }
}
