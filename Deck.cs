using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        public List<Cards> cards = new List<Cards>(); 
        private bool isShuffle;
        private readonly string[] rank = { "Clubs", "Diamonds", "Hearts", "Spades" }; 
        private readonly string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10" }; 
        public Deck() { foreach (string currentname in rank) { cards.Add(new Cards(currentname + " Ace", "1 / 10")); 
                foreach (string value in values) {
                cards.Add(new Cards(currentname + " " + value, value)); }
                cards.Add(new Cards(currentname + " Jack", "10")); 
                cards.Add(new Cards(currentname + " Queen", "10")); 
                cards.Add(new Cards(currentname + " King", "10")); } }
    
        public void shuffle()
    {

    }
        public void takeCard()
    {

    } 
    }
}
