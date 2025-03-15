using Microsoft.AspNetCore.Mvc;
using MyAspProject.Models;
using System.Collections.Generic;

namespace MyAspProject.Controllers
{
    public class ComputerController : Controller
    {
        // ✅ Ensure the list is initialized
        private static List<Computer> computers = Computer.GetComputers() ?? new List<Computer>();

        public IActionResult Index()
        {
            return View(computers ?? new List<Computer>()); 
        }
    }
}
