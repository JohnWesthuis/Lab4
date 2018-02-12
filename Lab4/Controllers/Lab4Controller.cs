using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            DateTime time = DateTime.Now;
            return View(time);
        }

        public IActionResult Page2(int id)
        {
            return View(id);
        }

        public IActionResult Page3()
        {
            ViewData["Message"] = "beverages";
            List<string> drinks = new List<string> () { "Coke", "Sprite", "Dr. Pepper", "RootBeer", "Mountain Dew", "Orange Soda", "Water" };
            return View(drinks);
        }
    }
}