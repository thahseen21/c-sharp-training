using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Employee.Data;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _customerObj;

        public EmployeeController(ApplicationDbContext db)
        {
            _customerObj = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromForm] EmployeeModel customerObj)
        {
            if (ModelState.IsValid)
            {
                _customerObj.Customers.Add(customerObj);
                await _customerObj.SaveChangesAsync();
                return Redirect("/");
            }

            return View(customerObj);
        }
    }
}
