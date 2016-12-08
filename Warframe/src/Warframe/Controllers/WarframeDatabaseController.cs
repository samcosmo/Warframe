using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/*
 * WarframeDatabaseContact@gmail.com
 */

namespace Warframe.Controllers
{
    public class WarframeDatabaseController : Controller
    {
        /*
         * Index
         */

        public IActionResult Index()
        {
            List<Models.Link> names = new List<Models.Link>();
            names.Add(new Models.Link("Fleeting Expertise", "WarframeDatabase/Mod/Fleeting Expertise"));
            names.Add(new Models.Link("Sound Quake", "WarframeDatabase/Ability"));
            names.Add(new Models.Link("Arcane Energize", "WarframeDatabase/Arcane"));
            names.Add(new Models.Link("Arcane Aura Helmet", "WarframeDatabase/ArcaneHelmet"));
            names.Add(new Models.Link("Banshee", "WarframeDatabase/Warframe"));
            names.Add(new Models.Link("Tonkor", "WarframeDatabase/Weapon"));

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

        public IActionResult Mod(String name)
        {
            ViewData["Mod Name"] = name;

            List<Models.Mod> ranks = new List<Models.Mod>();
            ranks.Add(new Models.Mod(0, 6, "+10% POWER EFFICIENCY -10% POWER DURATION"));
            ranks.Add(new Models.Mod(1, 7, "+20% POWER EFFICIENCY -20% POWER DURATION"));
            ranks.Add(new Models.Mod(2, 8, "+30% POWER EFFICIENCY -30% POWER DURATION"));
            ranks.Add(new Models.Mod(3, 9, "+40% POWER EFFICIENCY -40% POWER DURATION"));
            ranks.Add(new Models.Mod(4, 10, "+50% POWER EFFICIENCY -50% POWER DURATION"));
            ranks.Add(new Models.Mod(5, 11, "+60% POWER EFFICIENCY -60% POWER DURATION"));
            ViewData["Ranks"] = ranks;

            return View();
        }

        /*
         * Arcane
         */

        public IActionResult Arcane()
        {
            ViewData["Arcane Name"] = "Arcane Energize";
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
            ViewData["Warframe Name"] = "Banshee";

            List<Models.Warframe> frame = new List<Models.Warframe>();
            frame.Add(new Models.Warframe(0, 0, 100, 100, 150));
            frame.Add(new Models.Warframe(30, 30, 300, 300, 225));
            ViewData["Frame"] = frame;
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