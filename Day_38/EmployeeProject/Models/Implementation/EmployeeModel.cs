using System;
 
namespace EmployeeProject.Models.Implementation
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }

        public Department DepartmentIdFk { get; set; }

        public DateTime HireDate { get; set; }

    }
}