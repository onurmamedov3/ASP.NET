using Microsoft.AspNetCore.Mvc;
using MyAspProject.Models;
using System.Collections.Generic;

namespace MyAspProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Get the list of computers and pass it to the view
            List<Computer> computers = Computer.GetComputers() ?? new List<Computer>();
            return View(computers);
        }

        // Add an action for the About page
        public IActionResult About()
        {
            return View();
        }

        // Add an action for the Contact page
        public IActionResult Contact()
        {
            return View();
        }
    }
}