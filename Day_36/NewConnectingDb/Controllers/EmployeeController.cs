using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewConnectingDb.Data;
using NewConnectingDb.Models;
using System;

namespace NewConnectingDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
            return Ok(_db.Employees.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeModel empObj)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("Error while creating new employeee");
            }
            Console.WriteLine($"{empObj}");
            _db.Employees.Add(empObj);
            await _db.SaveChangesAsync();

            return new JsonResult("Employee created successfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] int id, [FromBody] EmployeeModel empObj)
        {
            Console.WriteLine($"{id}");
            
            if (empObj == null || id != empObj.Id)
            {
                return new JsonResult("Employee was not found");
            }
            else
            {
                _db.Employees.Update(empObj);
                await _db.SaveChangesAsync();
                return new JsonResult("Employee created successfully");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute]int id){
            var findEmployee = await _db.Employees.FindAsync(id);
            if(findEmployee == null){
                return NotFound();
            }else{
                _db.Employees.Remove(findEmployee);
                await _db.SaveChangesAsync();
                return new JsonResult("Employee deleted successfully");
            }
        }
    }
}
