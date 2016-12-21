using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warframe.Models
{
    public class Damage
    {
        private Element type;
        private float number;

        public Damage(Element type, float number)
        {
            this.type = type;
            this.number = number;
        }

        public Element GetElement()
        {
            return this.type;
        }

        public float GetAmount()
        {
            return this.number;
        }
    }
}
