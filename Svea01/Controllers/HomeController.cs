using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Svea01.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Svea01.Models;
using System.Text;

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

        public string RandomString(int length)
        {
            StringBuilder sbuilder = new StringBuilder();
            for (int x = 0; x < length; ++x)
            {
                sbuilder.Append((char)_random.Next(97, 122));
            }
            return sbuilder.ToString();
        }

        public string[] dieu(int value)
        {
            string[] tblNom = new string[value];
            int longeur;
            for (int i = 0; i < value; i++)
            {
                longeur = _random.Next(3, 8);
                tblNom[i] = RandomString(longeur);
            }
            return tblNom;
        }

        public int[] yeet(int value)
        {

            int[] rndData = new int[value];

            for (int i = 0; i < value; i++)
            {
                rndData[i] = _random.Next(0, 1000);
            }
            rndData.ToString();
            return rndData;
        }

        public int[] dateAnnee(int value)
        {

            int[] rndData = new int[value];

            for (int i = 0; i < value; i++)
            {
                rndData[i] = _random.Next(0, 2022);
            }
            rndData.ToString();
            return rndData;
        }

        public int[] dateMois(int value)
        {

            int[] rndData = new int[value];

            for (int i = 0; i < value; i++)
            {
                rndData[i] = _random.Next(0, 12);
            }
            rndData.ToString();
            return rndData;
        }

        public int[] dateJour(int value)
        {

            int[] rndData = new int[value];

            for (int i = 0; i < value; i++)
            {
                rndData[i] = _random.Next(0, 31);
            }
            rndData.ToString();
            return rndData;
        }

        public IActionResult Index()
        {
            ViewBag.arrayData = yeet(101);
            ViewBag.arrayName = dieu(101);
            ViewBag.arrayDateAnnee = dateAnnee(101);
            ViewBag.arrayDateJour = dateJour(101);
            ViewBag.arrayDateMois = dateMois(101);

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
