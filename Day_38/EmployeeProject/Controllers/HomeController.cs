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

        public IActionResult Index()
        {
            IEnumerable<Employee> employeeList = _db.Employee;
            return View(employeeList);
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
        public async Task<IActionResult> NewEmployee([FromForm] Employee empObj)
        {
            if (ModelState.IsValid)
            {
                var json =
                    Newtonsoft.Json.JsonConvert.SerializeObject(empObj);
                Console.WriteLine($"{json}");
                _db.Employee.Add(empObj);
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
