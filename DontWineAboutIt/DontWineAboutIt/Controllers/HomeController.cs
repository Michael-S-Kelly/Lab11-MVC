using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DontWineAboutIt.Models;

namespace DontWineAboutIt.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Brings in user input from the home page
        /// </summary>
        /// <returns>Returns value for input</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Posts results to Results page
        /// </summary>
        /// <param name="name">user inputed name</param>
        /// <param name="maxPrice">user inputed maximum price</param>
        /// <param name="minPoints">user inputed minimum pionts</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(string name, int maxPrice, int minPoints)
        {

            return RedirectToAction("Results", new { name, maxPrice, minPoints });
        }

        /// <summary>
        /// Posts user input to Wine class
        /// </summary>
        /// <param name="name">user inputed name</param>
        /// <param name="maxPrice">user inputed maximum price</param>
        /// <param name="minPoints">user inputed minimum pionts</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Results(string name, int maxPrice, int minPoints)
        {
            return View(Wine.GetWineList(name, maxPrice, minPoints));
        }
    }
}