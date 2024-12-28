using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class Hand
    {     
        private List<Card> _playercards = new List<Card>();
        private List<Card> _bankercards = new List<Card>();
        public Hand(  ) 
        {            
        }

        public List<Card> Playercards 
        {
            get
            {
                return _playercards;
            }
            set
            {
                _playercards = value;
            }
        }

        public List<Card> Bankercards
        {
            get
            {
                return _bankercards;
            }
            set
            {
                _bankercards = value;
            }
        }        

        public bool PlayerHasPairs()
        {
            if (Playercards.Count != 2 )
                return false;

            return Playercards[0].valueForCard() == Playercards[1].valueForCard();
        }

        public bool BankerHasPairs()
        {
            if (Bankercards.Count != 2)
                return false;

            return Bankercards[0].valueForCard() == Bankercards[1].valueForCard();
        }
    }
}
