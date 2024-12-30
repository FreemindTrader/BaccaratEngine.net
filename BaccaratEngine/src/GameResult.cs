using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class GameResult
    {
        private Hand? _lastHand;

        public GameResult( Hand hand )
        {
            _lastHand = hand;
        }  
        
        public GameResult( Baccarat outcome )
        {
            Outcome = outcome;
            
            NaturalInfo = BaccaratEx.None;
            PairInfo = BaccaratEx.None;
            MonsterInfo = BaccaratEx.None;
            _lastHand = null;
        }        

        public bool isNatural
        {
            get
            {
                return this.PlayerIsNatural || this.BankerIsNatural;
            }
                        
        }

        public bool BankerIsNatural
        {
            get
            {
                return (NaturalInfo == BaccaratEx.B8 || NaturalInfo == BaccaratEx.B9);
            }
        }

        public bool PlayerIsNatural
        {
            get
            {
                return (NaturalInfo == BaccaratEx.P8 || NaturalInfo == BaccaratEx.P9);
            }
        }

        public bool HasPairs
        {
            get
            {
                return this.BankerHasPair || this.PlayerHasPair;
            }
        }

        public bool BankerHasPair
        {
            get
            {
                return (PairInfo == BaccaratEx.BB || PairInfo == BaccaratEx.BBPP);
            }
        }

        public bool PlayerHasPair
        {
            get
            {
                return (PairInfo == BaccaratEx.PP || PairInfo == BaccaratEx.BBPP);
            }
        }

        public bool HasMonster
        {
            get
            {
                return this.BankerHasMonster || this.PlayerHasMonster;
            }
        }

        public bool BankerHasMonster
        {
            get
            {
                return (MonsterInfo == BaccaratEx.B6 || MonsterInfo == BaccaratEx.B63);
            }
        }

        public bool PlayerHasMonster
        {
            get
            {
                return (MonsterInfo == BaccaratEx.P7 || MonsterInfo == BaccaratEx.P76);
            }
        }


        public Baccarat Outcome { get; set; }

        public BaccaratEx NaturalInfo { get; set; }

        public BaccaratEx PairInfo { get; set; }

        public BaccaratEx MonsterInfo { get; set; }
        

        public override string ToString() 
        {
            string output = "[" + Outcome.ToString() + "]";

            if (NaturalInfo != BaccaratEx.None ) output += " " + NaturalInfo.ToString() + " ";

            if (PairInfo != BaccaratEx.None) output += " [" + PairInfo.ToString() + "] ";

            if ( MonsterInfo != BaccaratEx.None ) output += " [" + MonsterInfo.ToString() + "] ";

            return output;
        }

    }
}
