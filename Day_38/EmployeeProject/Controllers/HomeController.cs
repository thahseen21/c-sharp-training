using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmployeeProject.Data;
using EmployeeProject.Models;
using EmployeeProject.Models.Implementation;
using EmployeeProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;

        public HomeController(
            ILogger<HomeController> logger,
            ApplicationDbContext db
        )
        {
            _logger = logger;
            this._db = db;
        }

        // [HttpGet("{sortBy:string?}")]
        public IActionResult Index([FromQuery(Name = "sortBy")] string sortBy)
        {
            IEnumerable<Employee> empList;

            // empList = _db.Employee.Where(item => item.IsActive == true);
            switch (sortBy)
            {
                case "Id":
                    empList =
                        _db
                            .Employee
                            .Where(item => item.IsActive == true)
                            .OrderBy(item => item.Id);
                    break;
                case "Name":
                    empList = _db.Employee.Where(item => item.IsActive == true).OrderBy(item => item.Name);
                    break;
                case "Designation":
                    empList = _db.Employee.Where(item => item.IsActive == true).OrderBy(item => item.Designation);
                    break;
                case "HireDate":
                    empList = _db.Employee.Where(item => item.IsActive == true).OrderBy(item => item.HireDate);
                    break;
                default:
                    empList = _db.Employee.Where(item => item.IsActive == true);
                    break;
            }

            return View(empList);
        }

        [HttpPost]
        public IActionResult Index()
        {
            var searchInput = Request.Form["search"];
            IEnumerable<Employee> empList;

            Console.WriteLine($"{searchInput}");

            if (searchInput.Count > 0)
            {
                empList =
                    _db
                        .Employee
                        .Where(item =>
                            item.Name.Contains(searchInput) &&
                            item.IsActive == true);
            }
            else
            {
                empList = _db.Employee.Where(item => item.IsActive == true);
            }

            // empList = _db.Employee.Where(item => item.IsActive == true);
            return View(empList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NewEmployee()
        {
            var model = new EmployeeViewModel();
            model.Employee = new Employee();
            model.DepartmentList = _db.Department;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NewEmployee(EmployeeViewModel empObj)
        {
            if (ModelState.IsValid)
            {
                _db.Employee.Add(empObj.Employee);
                await _db.SaveChangesAsync();
                return Redirect("/");
            }

            return View(empObj);
        }

        public IActionResult Update(int? id)
        {
            Console.WriteLine($"{id}");

            var emp = _db.Employee.FirstOrDefault(x => x.Id == id);

            var model = new EmployeeViewModel();

            model.Employee = emp;
            model.DepartmentList = _db.Department;

            if (emp == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(EmployeeViewModel empObj)
        {
            if (ModelState.IsValid)
            {
                _db.Employee.Update(empObj.Employee);
                await _db.SaveChangesAsync();
                return Redirect("/");
            }

            return View(empObj);
        }

        [
            ResponseCache(
                Duration = 0,
                Location = ResponseCacheLocation.None,
                NoStore = true)
        ]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
