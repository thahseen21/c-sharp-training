// Create two lists of Bank branches and Bank Managers with relevant properties and perform the following operations
// 1. display the branches and respective managers
// 2. Display list of managers who are aged above 30  along with the branch name  
// 3. Display the manager who has earned maximum points (create a property called maxpoint in branches)
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Branch> branchList = new List<Branch>();

            branchList.Add(new Branch() { BranchName = "Saligrammam", BranchId = 1, MaxPoint = 6 });
            branchList.Add(new Branch() { BranchName = "Vadapalani", BranchId = 2, MaxPoint = 9 });
            branchList.Add(new Branch() { BranchName = "K K Nagar", BranchId = 3, MaxPoint = 3 });

            List<Manager> managerList = new List<Manager>();

            managerList.Add(new Manager() { Name = "Peter", BranchId = 1, Age = 20 });
            managerList.Add(new Manager() { Name = "Mike", BranchId = 1, Age = 35 });
            managerList.Add(new Manager() { Name = "Philip", BranchId = 2, Age = 39 });
            managerList.Add(new Manager() { Name = "Sam", BranchId = 2, Age = 29 });
            managerList.Add(new Manager() { Name = "Rakesh", BranchId = 3, Age = 29 });

            foreach (var item in branchList)
            {
                item.DisplayBranch();
            }
            foreach (var item in managerList)
            {
                item.DisplayManager();
            }

            var myQuery1 = from branch in branchList
                           join manager in managerList
                           on branch.BranchId equals manager.BranchId
                           select new
                           {
                               branchName = branch.BranchName,
                               managerName = manager.Name
                           };

            foreach (var item in myQuery1)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Manager who is above 30 years old");

            var myQuery2 = from branch in branchList
                           join manager in managerList
                           on branch.BranchId equals manager.BranchId
                           where manager.Age >= 30
                           select new
                           {
                               branchName = branch.BranchName,
                               managerName = manager.Name
                           };

            foreach (var item in myQuery2)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"manager who has earned maximum points");

            var myQuery3 = from branch in branchList
                           join manager in managerList
                           on branch.BranchId equals manager.BranchId
                           orderby branch.MaxPoint descending
                           where branch.MaxPoint == branchList.Max(branch => branch.MaxPoint)
                           select manager.Name;

            foreach (var item in myQuery3)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
