using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class Shoe
    {
        const int CutCardLengthFromBottom = 16;

        int _decksCount = 0;
        List<Card> _cards = new List<Card>( 8 * 52 );

        /// <summary>
        /// Shoe constructor
        /// </summary>
        /// <param name="numDecks">Count of decks to be included in the shoe</param>
        public Shoe( int numDecks )
        {
            _decksCount = numDecks;

            _cards = new List<Card>( _decksCount * 52 ); 
        }

        public List<Card> Cards
        {
            get { return _cards; }

            set 
            { 
                _cards = value; 
            }
        }

        public bool cutCardReached
        {
            get
            {
                return cardsBeforeCutCard <= 0;
            }
        }

        public int cardsLeft
        {
            get
            {
                return _cards.Count;
            }
        }

        public int cardsBeforeCutCard
        {
            get
            {
                return Math.Max( 0, this.cardsLeft - CutCardLengthFromBottom );
            }
        }

        /// <summary>
        /// Creates the cards array
        /// </summary>
        public void createDecks()
        {
            for (var i = 0; i < this._decksCount; i++)
            {
                for (var j = 0; j < 52; j++)
                {
                    this._cards.Add( this.createCard( j ) );
                }
            }
        }
        public Card createCard( int j )
        {
            var suit = Math.Floor( (decimal)j / 13 );
            var cardValue = j % 13;

            var suitEnum = (Card.CardSuit)suit;
            var valueEnum = (Card.CardValue)cardValue;

            return new Card( suitEnum, valueEnum );
        }


        /// <summary>
        /// Shuffles the cards array
        /// </summary>
        public void shuffle()
        {
            var rand = new Random();
            _cards = _cards.OrderBy( _ => rand.Next() ).ToList();            
        }

        public Card draw()
        {
            if (this._cards.Count == 0)
            {
                this.createDecks();
                this.shuffle();
            }
            var card = this._cards.Last();

            _cards.RemoveAt( _cards.Count - 1 );

            return card;
        }

        public void RemoveCards( int count )
        {
            if ( count < this._cards.Count )
            {
                for( var i = 0; i < count; i++ )
                {
                    draw();
                }
            }
        }
    }
}
