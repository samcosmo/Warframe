using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Warframe.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Index
         */

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

        /*
         * Ability
         */

        public IActionResult Ability()
        {
            ViewData["Ability Name"] = "Sound Quake";
            return View();
        }

        /*
         * Mod
         */

        public IActionResult Mod()
        {
            ViewData["Mod Name"] = "Fleeting Expertise";

            List <Models.ModRank> ranks = new List<Models.ModRank>();
            ranks.Add(new Models.ModRank(0, 6, "+10% POWER EFFICIENCY -10% POWER DURATION"));
            ranks.Add(new Models.ModRank(1, 7, "+20% POWER EFFICIENCY -20% POWER DURATION"));
            ranks.Add(new Models.ModRank(2, 8, "+30% POWER EFFICIENCY -30% POWER DURATION"));
            ranks.Add(new Models.ModRank(3, 9, "+40% POWER EFFICIENCY -40% POWER DURATION"));
            ranks.Add(new Models.ModRank(4, 10, "+50% POWER EFFICIENCY -50% POWER DURATION"));
            ranks.Add(new Models.ModRank(5, 11, "+60% POWER EFFICIENCY -60% POWER DURATION"));
            ViewData["Ranks"] = ranks;

            return View();
        }

        /*
         * Arcane
         */

        public IActionResult Arcane()
        {
            ViewData["Arcane Name"] = "Arcane Fuck";
            return View();
        }

        /*
         * ArcaneHelmet
         */

        public IActionResult ArcaneHelmet()
        {
            ViewData["ArcaneHelmet Name"] = "Arcane Aura Helmet";
            return View();
        }

        /*
         * Warframe
         */

        public IActionResult Warframe()
        {
            ViewData["Warframe Name"] = "Atlas";
            return View();
        }

        /*
         * Weapon
         */

        public IActionResult Weapon()
        {
            ViewData["Weapon Name"] = "Tonkor";
            return View();
        }

        /*
         * Error
         */

        public IActionResult Error()
        {
            return View();
        }

    }
}
