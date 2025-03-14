using Microsoft.AspNetCore.Mvc;
using MyAspProject.Models;
using System.Collections.Generic;

namespace MyAspProject.Controllers
{
    public class ComputerController : Controller
    {
        // Simulating a database with a list
        private static List<Computer> computers = new List<Computer>
        {
            new Computer { Id = 1, Brand = "Dell", Description = "High performance laptop" },
            new Computer { Id = 2, Brand = "HP", Description = "Business-class laptop" },
            new Computer { Id = 3, Brand = "Apple", Description = "MacBook Pro" }
        };

        // GET: /Computer/
        public IActionResult Index()
        {
            return View(computers);
        }

        
    }
}
