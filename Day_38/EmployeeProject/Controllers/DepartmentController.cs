using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeProject.Data;
using EmployeeProject.Models.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProject.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DepartmentController(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Department> departmentList = _db.Department;
            return View(departmentList);
        }

        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment([FromForm] Department deptObj)
        {
            if (ModelState.IsValid)
            {
                _db.Department.Add (deptObj);
                await _db.SaveChangesAsync();
                return Redirect("/");
            }

            return View(deptObj);
        }
    }
}
