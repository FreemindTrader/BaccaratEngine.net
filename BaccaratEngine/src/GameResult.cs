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
        
        public GameResult( BpOutcome outcome )
        {
            Outcome = outcome;
            IsNatural = BpNatural.None;
            HasPair = BpPair.None;
            IsMonster = BpMonster.None;
            _lastHand = null;
        }

        public BpOutcome Outcome { get; set; }

        public BpNatural IsNatural { get; set; }

        public BpPair HasPair { get; set; }

        public BpMonster IsMonster { get; set; }

        public override string ToString() 
        {
            string output = "[" + Outcome.ToString() + "]";

            if (IsNatural != BpNatural.None ) output += " " + IsNatural.ToString() + " ";

            if (HasPair != BpPair.None) output += " [" + HasPair.ToString() + "] ";

            if ( IsMonster != BpMonster.None ) output += " [" + IsMonster.ToString() + "] ";

            return output;
        }

    }
}
