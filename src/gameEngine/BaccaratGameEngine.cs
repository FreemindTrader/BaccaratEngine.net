using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class BaccaratGameEngine
    {
        BaccaratResultsEngine _resultEngine = null;
        Shoe _shoe = null;
        public BaccaratGameEngine()
        {
            _resultEngine = new BaccaratResultsEngine();
            _shoe = new Shoe( 8 );
        }

        public bool isBurnNeed
        {
            get
            {
                if (_shoe != null)
                    return _shoe.cutCardReached;

                return false;
            }
        }

        /// <summary>
        /// Performs a burn operation
        /// </summary>
        /// <returns>Burn indicator card</returns>
        /// <returns>Burn cards</returns>
        public (Card, List<Card>) burnCards()
        {
            var burnCard = _shoe.draw();
            var burnCards = new List<Card>();

            var burnCardValue = burnCard.valueForCard();

            // Face cards & T count for 10 during burn
            if (burnCardValue == 0) burnCardValue = 10;

            for (var i = 0; i < burnCardValue; i++)
            {
                burnCards.Add( _shoe.draw() );
            }

            return (burnCard, burnCards);
        }

        public Hand dealGame()
        {
            var pCard1 = _shoe.draw();
            var bCard1 = _shoe.draw();
            var pCard2 = _shoe.draw();
            var bCard2 = _shoe.draw();

            var hand = new Hand();

            hand.Playercards.Add( pCard1 );
            hand.Playercards.Add( pCard2 );

            hand.Bankercards.Add( bCard1 );
            hand.Bankercards.Add( bCard2 );

            var bankerCardsValue = _resultEngine.calculateHandValue( hand.Bankercards );
            var playerCardsValue = _resultEngine.calculateHandValue( hand.Playercards );

            var bankerDraw = false;

            // Natural (Dealer or Player drew an 8 or 9) - neither side draws, game over.
            if (bankerCardsValue > 7 || playerCardsValue > 7)
            {
                return hand;
                // Player has 6 or 7 - stands
            }
            else if (playerCardsValue > 5)
            {
                // Player stood so dealer draws with [0-5] and stands with 6 or 7
                if (bankerCardsValue <= 5)
                {
                    bankerDraw = true;
                }
                // Player has 0 - 5, draws 3rd card
            }
            else
            {
                var player3rdCard = _shoe.draw();
                hand.Playercards.Add( player3rdCard );
                var player3rdCardValue = player3rdCard.valueForCard();

                switch (player3rdCardValue)
                {
                    case 2:
                    case 3:
                    // Player has 2, 3 - banker draws 0-4, stands 5-7
                    if (bankerCardsValue < 5) bankerDraw = true;
                    break;

                    case 4:
                    case 5:
                    // Player has 4, 5 - banker draws 0-5, stands 6-7
                    if (bankerCardsValue < 6) bankerDraw = true;
                    break;

                    case 6:
                    case 7:
                    // Player has 6, 7 - banker draws 0-6, stands 7
                    if (bankerCardsValue < 7) bankerDraw = true;
                    break;

                    case 8:
                    // Player has 8 - banker draws 0-2, stands 3-7
                    if (bankerCardsValue < 3) bankerDraw = true;
                    break;

                    case 9:
                    case 0:
                    case 1:
                    // Player has 9, T/K/Q/J, A - banker draws 0-3, stands 4-7
                    if (bankerCardsValue < 4) bankerDraw = true;
                    break;
                }
            }

            if (bankerDraw)
            {
                var banker3rdCard = _shoe.draw();
                hand.Bankercards.Add( banker3rdCard );
                bankerCardsValue = _resultEngine.calculateHandValue( hand.Bankercards );
            }

            return hand;
        }
    }
}
