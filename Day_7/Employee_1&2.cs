// Design an  Employee class with properties EmployeeId, Name, Designation. Have an encapsulated field called Salary. 
// Expose method called GetSalary() which displays or returns the current salary,
//     but setting of salary should be done at the time of hiring (object creation time).
// Have an encapsulated method called IncreasePay() , where the salary can be increased by 10%.
// The user / client  should be exposed only to a method called Promote() with a boolean value,
// which decides the Increase Pay of 10% or not.

using System;
using System.Collections;

namespace EmployeeProject
{
    class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public string Designation;
        private double Salary;
        private int[] phone = new int[2];
        public int this[int i]
        {
            get
            {
                return phone[i];
            }
            set
            {
                phone[i] = value;
            }
        }

        public Employee(double salary)
        {
            this.Salary = salary;
        }

        public Employee(int id, string name, string designation, double salary)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public void GetSalary()
        {
            Console.WriteLine($"{this.EmployeeName}\'s salary is {this.Salary}");
        }

        private void IncreasePay()
        {
            this.Salary += ((double)10 / 100) * this.Salary;
            GetSalary();
        }

        public void Promote(bool isPromoted)
        {
            if (isPromoted)
            {
                IncreasePay();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new Hashtable();

            var temp = new Employee(1, "Sam", "Manager", 20000);

            //indexer
            temp[0] = 123456;
            temp[1] = 654321;

            employeeList.Add(temp.EmployeeId, temp);

            Employee storedEmployee1 = (Employee)employeeList[temp.EmployeeId];


            foreach (DictionaryEntry employee in employeeList)
            {
                Employee temp1 = (Employee)employee.Value;
                Console.WriteLine($"Employee Name:{temp.EmployeeName}");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Contact Detail :{temp1[i]}");

                }

            }
        }
    }
}
