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

            names.Add(new Models.Link("Fleeting Expertise", "Home/Mods"));

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

        public IActionResult ModS()
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
