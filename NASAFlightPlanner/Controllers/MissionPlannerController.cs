using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NASAFlightPlanner.Models;

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Contracts;

namespace NASAFlightPlanner.Controllers
{
    public class MissionPlannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public IActionResult Results()
        {
            int numberOfDays = int.Parse(Request.Form["NumOfDays"]);
            int numberOfTasks = int.Parse(Request.Form["NumOfTasks"]);
            var newMissionPlan = new MissionPlanner();
            int astronautsNeeded = newMissionPlan.GetAstronautsNeeded(numberOfDays, numberOfTasks);
            return View(astronautsNeeded);
        }
    }
}
