using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hats.Models;

namespace Hats.Controllers
{
    public class HatsController : Controller
    {
        public IActionResult Index() {
            ViewBag.Play = "Wanna play, dad?"; 
            return View();
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Hat hat) { 
            // Later we want to save this to the database
            if (ModelState.IsValid) {
                // Save to db
                return View("Thanks", hat);   
            } else {
                return View(hat);
            }

            
        }




        public string WannaPlay() {
            return "No, I am coding!";
        }
    }
}