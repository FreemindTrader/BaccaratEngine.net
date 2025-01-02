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

        private GBits _gBits;

        public GameResult( Hand hand )
        {
            _lastHand = hand;
        }  

        
        public GameResult( GResult outcome )
        {
            Outcome = outcome;
            _gBits.ResultInfo = outcome;
            
            _lastHand = null;
        }

        public GameResult( GResult outcome, GNatural natural )
        {
            Outcome = outcome;
            _gBits.ResultInfo = outcome;
            _gBits.NaturalInfo = natural;

            _lastHand = null;
        }

        public GameResult( GResult outcome, GMonster monster )
        {
            Outcome = outcome;
            _gBits.ResultInfo = outcome;
            _gBits.MonsterInfo = monster;

            _lastHand = null;
        }

        public GBits RawData
        {
            get { return _gBits; }
        }
        

        public bool isNatural
        {
            get
            {
                var nInfo = _gBits.NaturalInfo;
                return _gBits.NaturalInfo != GNatural.None;
            }
                        
        }

        

        public bool HasPairs
        {
            get
            {
                var nInfo = _gBits.PairInfo;
                return _gBits.PairInfo != GPair.None;
            }
        }

        

        public bool HasMonster
        {
            get
            {
                var nInfo = _gBits.MonsterInfo;
                return _gBits.MonsterInfo != GMonster.None;
            }
        }        


        public GResult Outcome
        {
            get
            {
                return (_gBits.ResultInfo);
            }
            set
            {
                _gBits.ResultInfo = value;
            }
        }

        public GNatural NaturalInfo
        {
            get
            {
                return (_gBits.NaturalInfo);
            }
            set
            {
                _gBits.NaturalInfo = value;
            }
        }

        public GPair PairInfo
        {
            get
            {
                return (_gBits.PairInfo);
            }
            set
            {
                _gBits.PairInfo = value;
            }
        }

        public GMonster MonsterInfo
        {
            get
            {
                return (_gBits.MonsterInfo);
            }
            set
            {
                _gBits.MonsterInfo = value;
            }
        }
        
        

        public override string ToString() 
        {
            string output = "[" + Outcome.ToString() + "]";

            if (isNatural  ) output += " " + NaturalInfo.ToString() + " ";

            if (HasPairs) output += " [" + PairInfo.ToString() + "] ";

            if (HasMonster) output += " [" + MonsterInfo.ToString() + "] ";

            return output;
        }

    }
}
