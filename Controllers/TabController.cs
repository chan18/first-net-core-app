using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tabscomponent.Models;

namespace tabscomponent.Controllers
{
    public class TabController : Controller
    {
        public String stringType() 
        {
            return "string-data";
            // return Json(Url);
        }

        public IActionResult Index()
        {
            var value = "Tab-Api";
            
            // return View();
            // To return other then IActionResult 
            return Content(value);
            // return Ok();
        }

        [HttpGet("tab/about-thing")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
