using System;

namespace LINQAssignment
{
    public class Branch
    {
        public string BranchName { get; set; }
        public int BranchId { get; set; }
        public int MaxPoint { get; set; }
        public void DisplayBranch()
        {
            Console.WriteLine($"Branch Name:{BranchName},BranchId:{BranchId}");
        }
    }
}
