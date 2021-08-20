using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BookStore.Models;
using System;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        public List<Book> BookList = new List<Book>(){
            new Book(){Id=1,Name="programming in C"},
            new Book(){Id=2,Name="Potato Recipe"}
        };

        [HttpGet("book")]
        public IActionResult GetBook()
        {
            Console.WriteLine($"potata");
            foreach (var item in BookList)
            {
                Console.WriteLine($"book name:{item.Name}");
            }
            return Ok(BookList);
        }

        [HttpPost("addnewbook")]
        public IActionResult AddNewBook(Book book)
        {
                BookList.Add(book);
                return Ok(BookList);
        }
    }
}