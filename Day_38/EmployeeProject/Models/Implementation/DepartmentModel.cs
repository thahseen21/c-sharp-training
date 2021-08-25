using EmployeeProject.Models.Interface;

namespace EmployeeProject.Models.Implementation
{
    public class Department : IDepartment
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

    }
}