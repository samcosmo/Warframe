using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warframe.Models
{
    public class Link
    {
        private String text;
        private String link;

        public Link(String text, String link)
        {
            this.text = text;
            this.link = link;
        }

        public String GetText()
        {
            return this.text;
        }

        public String GetLink()
        {
            return this.link;
        }
    }
}
