using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Cards
    {
        bool IsOpen = true;
        private string value;
        private string rank;

        public Cards(string rank, string value)
        {
            this.rank = rank;
            this.value = value;
        }
    }
}