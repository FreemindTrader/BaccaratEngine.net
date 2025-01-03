using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static BaccaratEngine.Card;

namespace BaccaratEngine
{
    public class xCards : INotifyPropertyChanged
    {
        CardSuit _cardSuit1;
        CardValue _cardValue1;

        CardSuit _cardSuit2;
        CardValue _cardValue2;

        CardSuit _cardSuit3;
        CardValue _cardValue3;
        public xCards(  ) 
        {            
        }

        public void SetCard1( CardSuit cardSuit, CardValue cardValue )
        {
            _cardSuit1 = cardSuit;
            _cardValue1 = cardValue;
        }

        public void SetCard2( CardSuit cardSuit, CardValue cardValue )
        {
            _cardSuit2 = cardSuit;
            _cardValue2 = cardValue;
        }

        public void SetCard3( CardSuit cardSuit, CardValue cardValue )
        {
            _cardSuit3 = cardSuit;
            _cardValue3 = cardValue;
        }

        int card3;
        int card2;
        int card1;

        protected void OnPropertyChanged( [CallerMemberName] string propertyName = "" )
        {
            if (PropertyChanged != null)
                PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        
        public int Card1
        {
            get
            {
                var cardValue = Math.Max( 0, ((int)_cardSuit1 - 1) * 13 ) + (int)_cardValue1;
                return cardValue;
            }

            set
            {
                if (card1 != value)
                {
                    card1 = value;
                    OnPropertyChanged();
                }
            }
        }


        public int Card2
        {
            get
            {
                var cardValue = Math.Max( 0, ((int)_cardSuit2 - 1) * 13 ) + (int)_cardValue2;
                return cardValue;
            }

            set
            {
                if (card2 != value)
                {
                    card2 = value;
                    OnPropertyChanged();
                }
            }
        }


        public int Card3
        {
            get
            {
                var cardValue = Math.Max( 0, ((int)_cardSuit3 - 1) * 13 ) + (int)_cardValue3;
                return cardValue;
            }

            set
            {
                if (card3 != value)
                {
                    card3 = value;
                    OnPropertyChanged();
                }
            }
        }


        
    }
}
