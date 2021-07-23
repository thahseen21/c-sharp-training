using System;
using System.Collections.Generic;

namespace DelegateProject
{
    public delegate bool IsPromotable(Employee emp);
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee() { Name = "Peter", Experience = 5, Salary = 10000 });
            employeeList.Add(new Employee() { Name = "Potato", Experience = 6, Salary = 20000 });
            employeeList.Add(new Employee() { Name = "Mike", Experience = 2, Salary = 2000 });
            employeeList.Add(new Employee() { Name = "John", Experience = 3, Salary = 5000 });

            // Employee.Promotion(employeeList);
            IsPromotable isPromotable = Promote;
            isPromotable += PromoteBySalary;
            isPromotable += PromoteByName; // here the last invoked method is PromoteByName so the return value is based on the last invoked value.'

            var emp = new Employee();

            var value = emp.Promotion(employeeList, isPromotable, CountEmployee, CountEmployee2, PromoteBySalary);
        }

        static public bool Promote(Employee emp)
        {
            // Console.WriteLine($"Promote {emp.Name},{emp.Salary}");

            return emp.Experience >= 5 ? true : false;
        }
        static public bool PromoteByName(Employee emp)
        {
            // Console.WriteLine($"PromoteByName {emp.Name},{emp.Salary}");

            return emp.Name == "Mike" ? true : false;
        }
        // static public bool PromoteBySalary(Employee emp)
        // {
        //     // Console.WriteLine($"PromoteBySalary {emp.Name},{emp.Salary}");

        //     return emp.Salary <= 6000 ? true : false;
        // }
        static public decimal CountEmployee(List<Employee> emp)
        {
            Console.WriteLine($"Employee count {emp.Count}");
            return emp.Count;
        }
        static public void CountEmployee2(List<Employee> emp)
        {
            Console.WriteLine($"Another employee count {emp.Count}");
        }
        static public bool PromoteBySalary(Employee emp)
        {
            return emp.Salary <= 6000 ? true : false;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public delegate bool DelegateFunction(Employee emp);

        public decimal Promotion(List<Employee> Employees, IsPromotable isPromotable, Func<List<Employee>, decimal> EmployeeCounter, Action<List<Employee>> EmployeeCounter2, Predicate<Employee> promoteBySalary)
        {
            foreach (var employee in Employees)
            {
                if (isPromotable(employee))
                {
                    Console.WriteLine($"{employee.Name}");
                }
            }

            // var count = EmployeeCounter(Employees);
            decimal count = EmployeeCounter(Employees);

            EmployeeCounter2(Employees);

            // Console.WriteLine($"Total employee count {EmployeeCounter(Employees)}");
            foreach (var employee in Employees)
            {
                if (promoteBySalary(employee))
                {
                    Console.WriteLine($"{employee.Name}");
                }
            }
            return count;
        }

    }

}
