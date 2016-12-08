using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Warframe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Models.Link> names = new List<Models.Link>();

            names.Add(new Models.Link("Fleeting Expertise", "Home/Mod"));

            names.Add(new Models.Link("Sound Quake", "Home/Ability"));

            names.Add(new Models.Link("Arcane Fuck", "Home/Arcane"));

            names.Add(new Models.Link("Arcane Aura Helmet", "Home/ArcaneHelmet"));

            names.Add(new Models.Link("Atlas", "Home/Warframe"));

            names.Add(new Models.Link("Tonkor", "Home/Weapon"));

            ViewData["names"] = names;

            return View();
        }














        public IActionResult Ability()
        {
            return View();
        }

        public IActionResult Mod()
        {
            return View();
        }

        public IActionResult Arcane()
        {
            return View();
        }

        public IActionResult ArcaneHelmet()
        {
            return View();
        }

        public IActionResult Warframe()
        {
            return View();
        }

        public IActionResult Weapon()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
