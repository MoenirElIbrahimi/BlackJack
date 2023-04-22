using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class card
    {
        private string naam;
        private string value;

        public card(string naam, string value)
        {
            this.naam = naam;
            this.value = value;
        }

        public string getnaam()
        {
            return naam;
        }
        public string getvalue()
        {
            return value;
        }
    }
}
