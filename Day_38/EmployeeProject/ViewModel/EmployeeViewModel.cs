using EmployeeProject.Models.Implementation;
using System.Collections.Generic;

namespace EmployeeProject.ViewModel
{
    public class EmployeeViewModel
    {
        public IEnumerable<Department> DepartmentList { get; set; }
        
        public Employee Employee { get; set; }
        
        
    }
}