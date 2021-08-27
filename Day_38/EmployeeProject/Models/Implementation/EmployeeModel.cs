using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeProject.Models.Implementation
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Designation { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    
        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; } = true;
        
    }
}
