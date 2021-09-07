using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Svea01.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Svea01.Models;

namespace Svea01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Random _random = new Random();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public int[] yeet(int value)
        {

            int[] rndData = new int[value];

            for (int i = 0; i < value; i++)
            {
                rndData[i] = _random.Next(0, 1000);
            }

            return rndData;
        }

        public IActionResult Index()
        {
            ViewBag.arrayData = yeet(100);
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
