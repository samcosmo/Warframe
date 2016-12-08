using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warframe.Models
{
    public class Warframe
    {
        public int rank;
        public int capacity;
        public int health;
        public int shield;
        public int power;

        public Warframe(int rank, int capacity, int health, int shield, int power)
        {
            this.rank = rank;
            this.capacity = capacity;
            this.health = health;
            this.shield = shield;
            this.power = power;
        }
        
        public int GetRank()
        {
            return this.rank;
        }

        public int GetCapacity()
        {
            return this.capacity;
        }

        public int GetHealth()
        {
            return this.health;
        }

        public int GetShield()
        {
            return this.shield;
        }

        public int GetPower()
        {
            return this.power;
        }

    }
}
