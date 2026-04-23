using DesignPatternsAsp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tools;

namespace DesignPatternsAsp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            Log.GetInstance("log.txt").Save("HomeController Index action called.");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance("log.txt").Save("HomeController Privacy action called.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
