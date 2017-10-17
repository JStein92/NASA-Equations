using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NASAFlightPlanner.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NASAFlightPlanner.Controllers
{
    public class DogWalkerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public IActionResult Results(DogWalker dogWalker)
        {
            int days = int.Parse(Request.Form["days"]);
            int profit = dogWalker.profitOverDays(days);
            return View(dogWalker);
        }
    }
}
