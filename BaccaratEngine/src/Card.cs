﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class Card
    {
        public string[ ] StandardSuitUnicodeStrings = new string[ ] { "♥", "♦", "♣", "♠" };
        public string[ ] _defaultValuesStrings = new string[ ] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        private CardSuit _suit;
        private CardValue _value;

        public Card()
        {
            _suit = CardSuit.Club;
            _value = CardValue.CA;
        }

        public Card( int cValue )
        {
            _suit = CardSuit.None;
            _value = (CardValue)(cValue);
        }

        public CardSuit Suit
        {
            get { return _suit; }
        }

        public CardValue Value
        {
            get { return _value; }
        }

        public Card( CardSuit suit, CardValue value ) 
        {
            _suit = suit;
            _value = value;
        }

        public enum CardSuit
        {          
            None = 0,
            Club = 1, 
            Diamond = 2,
            Heart = 3,
            Spade = 4
        }

        public int valueForCard( )
        {
            if (_value >= CardValue.C10 )
                return 0;

            return (int)_value;
        }

        public enum CardValue
        {
            CMonkey = 0,
            CA = 1,
            C2 = 2,
            C3,
            C4,
            C5,
            C6,
            C7,
            C8,
            C9,
            C10,
            CJ,
            CQ,
            CK
        }
        
        public override string ToString()
        {
            var suit = StandardSuitUnicodeStrings[(int)_suit];
            var pokerValue = _defaultValuesStrings[(int)_value];

            return suit + pokerValue;            
        }

    }
}
