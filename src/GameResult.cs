using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class GameResult
    {
        private Hand _lastHand;

        public GameResult( Hand hand )
        {
            _lastHand = hand;
        }                        

        public GameResultOutcomes Outcomes { get; set; }

        public GameResultNatural IsNatural { get; set; }

        public GameResultPair HasPair { get; set; }

        public GameResultMonster IsMonster { get; set; }

    }
}
