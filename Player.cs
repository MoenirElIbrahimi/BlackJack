using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{


    internal class Player
    {
 
   
        bool IsPlaying= true;
        public List <Hand> hands= new List<Hand>();
        
    public Player ( )
        {

        }
        public bool Bet (int amount)
        {
            return true;
        }
        public bool hit(Cards cards)
        { return true;
        }
        public void stand()
        {
            
        }
 


           
    }
}
