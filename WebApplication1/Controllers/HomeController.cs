using System.Diagnostics;
using HappyFarmer.Models;
using Microsoft.AspNetCore.Mvc;

namespace HappyFarmer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

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
        
        public IActionResult WeatherData()
        {
            return View();
        }
        
        public IActionResult SoilData()
        {
            return View();
        }
        
        public IActionResult DeviceData()
        {
            return View();
        }

        public new IActionResult Profile()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Tables()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}