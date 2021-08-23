using System;

namespace Test
{
    public class Employee : Salary
    {
        public string Name;

        public Salary SalaryDetails;

        public Employee(string name, double salary)
        {
            //   Console.WriteLine($"Employee Name:{name}\nEmployee Salary:{salary}");
            this.Name = name;
            var obj = new Salary(salary);
            this.SalaryDetails = obj;
        }

        public void ShowEmpDetail()
        {
            Console.WriteLine($"Employee Name:{this.Name}\nEmployee Salary:{SalaryDetails.ShowSalary()}");
        }
    }
}
