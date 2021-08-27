using System.Collections.Generic;
using EmployeeProject.Models.Implementation;
using EmployeeProject.Utils;

namespace EmployeeProject.ViewModel
{
    public class IndexPagination
    {
        public IEnumerable<Employee> EmpList;
        public Pagination Pagination;
    }
}