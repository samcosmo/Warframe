using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warframe.Models
{
    public class Mod
    {
        private int rank;
        private int drain;
        private String effect;

        public Mod(int rank, int drain, String effect)
        {
            this.rank = rank;
            this.drain = drain;
            this.effect = effect;
        }

        public int GetRank()
        {
            return this.rank;
        }

        public int GetDrain()
        {
            return this.drain;
        }

        public String GetEffect()
        {
            return this.effect;
        }
    }
}
