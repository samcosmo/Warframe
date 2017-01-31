using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        private String connString = "Data Source=LAP7OP\\SQLEXPRESS;Initial Catalog=Warframe;Integrated Security=True";

        /*
         * Index
         */

        public IActionResult Index()
        {
            List<Models.Link> names = new List<Models.Link>();
            names.Add(new Models.Link("Fleeting Expertise", "WarframeDatabase/Mod/Fleeting%20Expertise"));
            names.Add(new Models.Link("Sound Quake", "WarframeDatabase/Ability/Sound%20Quake"));
            names.Add(new Models.Link("Arcane Energize", "WarframeDatabase/Arcane/Arcane%20Energize"));
            names.Add(new Models.Link("Arcane Reverb Helmet", "WarframeDatabase/ArcaneHelmet/Arcane%20Reverb%20Helmet"));
            names.Add(new Models.Link("Banshee", "WarframeDatabase/Warframe/Banshee"));
            names.Add(new Models.Link("Tonkor", "WarframeDatabase/Weapon/Tonkor"));
            names.Add(new Models.Link("Blind Rage", "WarframeDatabase/Mod/Blind%20Rage"));

            ViewData["names"] = names;

            return View();
        }

        /*
         * Ability
         */

        public IActionResult Ability()
        {
            ViewData["Ability Name"] = Database.Database.FillNumbers("hello eeh === thre", 1);
            return View();
        }

        /*
         * Mod
         */

        public IActionResult Mod(String name)
        {

            int id = Database.Database.GetModId(name)[0];
            ViewData["Mod Name"] = Database.Database.GetModName(id);

            List<Models.Mod> ranks = new List<Models.Mod>();
            int drain = Database.Database.GetModDrain(id);
            int maxRank = Database.Database.GetModMaxRank(id);

            for(int i = 0; i <= maxRank; i++)
            {
                ranks.Add(new Models.Mod(i, i + drain, "+10% POWER EFFICIENCY -10% POWER DURATION"));
            }

            ViewData["Ranks"] = ranks;

            return View();
        }

        /*
         * Arcane
         */

        public IActionResult Arcane(String name)
        {
            ViewData["Arcane Name"] = "Arcane Energize";
            return View();
        }

        /*
         * ArcaneHelmet
         */

        public IActionResult ArcaneHelmet(String name)
        {
            ViewData["ArcaneHelmet Name"] = "Arcane Reverb Helmet";
            return View();
        }

        /*
         * Warframe
         */

        public IActionResult Warframe(String name)
        {
            ViewData["Warframe Name"] = "Banshee";

            List<Models.Warframe> frame = new List<Models.Warframe>();
            frame.Add(new Models.Warframe(0, 0, 100, 100, 150.0));
            frame.Add(new Models.Warframe(1, 1, 120, 100, 150.0));
            frame.Add(new Models.Warframe(2, 2, 120, 120, 150.0));
            frame.Add(new Models.Warframe(3, 3, 120, 120, 157.5));
            frame.Add(new Models.Warframe(4, 4, 140, 120, 157.5));
            frame.Add(new Models.Warframe(5, 5, 140, 140, 157.5));
            frame.Add(new Models.Warframe(6, 6, 140, 140, 165.0));
            frame.Add(new Models.Warframe(7, 7, 160, 140, 165.0));
            frame.Add(new Models.Warframe(8, 8, 160, 160, 165.0));
            frame.Add(new Models.Warframe(9, 9, 160, 160, 172.5));
            frame.Add(new Models.Warframe(10, 10, 180, 160, 172.5));
            frame.Add(new Models.Warframe(11, 11, 180, 180, 172.5));
            frame.Add(new Models.Warframe(12, 12, 180, 180, 180.0));
            frame.Add(new Models.Warframe(13, 13, 200, 180, 180.0));
            frame.Add(new Models.Warframe(14, 14, 200, 200, 180.0));
            frame.Add(new Models.Warframe(15, 15, 200, 200, 187.5));
            frame.Add(new Models.Warframe(16, 16, 220, 200, 187.5));
            frame.Add(new Models.Warframe(17, 17, 220, 220, 187.5));
            frame.Add(new Models.Warframe(18, 18, 220, 220, 195.0));
            frame.Add(new Models.Warframe(19, 19, 240, 220, 195.0));
            frame.Add(new Models.Warframe(20, 20, 240, 240, 195.0));
            frame.Add(new Models.Warframe(21, 21, 240, 240, 202.5));
            frame.Add(new Models.Warframe(22, 22, 260, 240, 202.5));
            frame.Add(new Models.Warframe(23, 23, 260, 260, 202.5));
            frame.Add(new Models.Warframe(24, 24, 260, 260, 210.0));
            frame.Add(new Models.Warframe(25, 25, 280, 260, 210.0));
            frame.Add(new Models.Warframe(26, 26, 280, 280, 210.0));
            frame.Add(new Models.Warframe(27, 27, 280, 280, 217.5));
            frame.Add(new Models.Warframe(28, 28, 300, 280, 217.5));
            frame.Add(new Models.Warframe(29, 29, 300, 300, 217.5));
            frame.Add(new Models.Warframe(30, 30, 300, 300, 225));
            ViewData["Frame"] = frame;
            return View();
        }

        /*
         * Weapon
         */

        public IActionResult Weapon(String name)
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