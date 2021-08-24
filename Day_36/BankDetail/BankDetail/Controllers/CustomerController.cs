using System;
using Microsoft.AspNetCore.Mvc;
using BankDetail.Models;

namespace BankDetail.Controllers
{
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet("DisplayCustomer")]
        public IActionResult Customer()
        {
            return View();
        }

        [HttpGet("AddCustomer")]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost("AddCustomer")]
        public void AddCustomer(CustomerDetail customer){
            Console.WriteLine($"{customer.Name}");
            Console.WriteLine($"{Request.Form["Name"]}");
        }
    }
}
