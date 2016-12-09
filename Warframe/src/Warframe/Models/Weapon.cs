using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warframe.Models
{
    public class Weapon
    {
        public String weponslot;
        public String wepontype;
        public String triggertype;
        public int firerate;
        public int magazinesize;
        public int reloadtime;
        public int physicaldamage;
        public int critchance;
        public int critmultiplier;
        public int statuschance;
        public String elementaltype;
        public int elementaldmg;

        public Weapon(String weponslot, String wepontype, String triggertype, int firerate, int magazinesize, int reloadtime, int physicaldamage, int critchance, int critmultiplier, int statuschance, String elementaltype, int elementaldmg)
        {
            this.weponslot = weponslot;
            this.wepontype = wepontype;
            this.triggertype = triggertype;
            this.firerate = firerate;
            this.magazinesize = magazinesize;
            this.reloadtime = reloadtime;
            this.physicaldamage = physicaldamage;
            this.critchance = critchance;
            this.critmultiplier = critmultiplier;
            this.statuschance = statuschance;
            this.elementaltype = elementaltype;
            this.elementaldmg = elementaldmg;
        }

        public String GetWeponslot()
        {
            return this.weponslot;
        }
    }
}
