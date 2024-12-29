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
            IsNatural = Baccarat89.None;
            HasPair = BaccaratPairs.None;
            IsMonster = BaccaratXXX.None;
            _lastHand = null;
        }

        public Baccarat Outcome { get; set; }

        public Baccarat89 IsNatural { get; set; }

        public BaccaratPairs HasPair { get; set; }

        public BaccaratXXX IsMonster { get; set; }

        public override string ToString() 
        {
            string output = "[" + Outcome.ToString() + "]";

            if (IsNatural != Baccarat89.None ) output += " " + IsNatural.ToString() + " ";

            if (HasPair != BaccaratPairs.None) output += " [" + HasPair.ToString() + "] ";

            if ( IsMonster != BaccaratXXX.None ) output += " [" + IsMonster.ToString() + "] ";

            return output;
        }

    }
}
