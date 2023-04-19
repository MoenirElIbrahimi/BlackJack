using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Hand
    {
        public List<Cards> cards = new List<Cards>();
        private int checkScore;
        private bool isOpen;

        public Hand(int checkScore,bool isOpen) {
            this.checkScore = checkScore;
            this.isOpen = isOpen;
        }
        public int CheckScore { get {  return checkScore; } }
        public bool IsOpen { get { return isOpen; } }
        public bool Hit(Cards cards) {

            return true;
        } 
        public void stand()
        {

        }
        public int total() {
            return 0; 
        }

    }
}
