using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{ 
    public class BaccaratResultsEngine
    {
        public GameResult Result { get; set; }

        public BaccaratResultsEngine(  )
        {
            
        }
        /// <summary>
        /// Calculates game results and other related game information such as naturals and pairs.
        /// </summary>
        /// <param name="hand"></param>
        public BaccaratResultsEngine( Hand hand )
        {
            Result = calculateGameResult( hand );
        }        

        /// <summary>
        /// Calculates results for the baccarat game based on the hand that happened in the game.
        /// </summary>
        /// <param name="hand">The hand for the baccarat game played.</param>
        /// <returns>The game result calculated from the hand.</returns>
        public GameResult calculateGameResult( Hand hand )
        {
            var game = new GameResult( hand );
            game.Outcome = this.calculateOutcome( hand );
            game.IsNatural = this.calculateNatural( game.Outcome, hand );
            game.HasPair = this.calculatePairs( hand );
            game.IsMonster = this.checkforMonster( game.Outcome, hand );

            return game;
        }

        /// <summary>
        /// Calculates the hand value for the cards played in a baccarat game.
        /// </summary>
        /// <param name="cards">cards A collection of cards to calculate the baccarat hand value for.</param>
        /// <returns>The card value of the cards</returns>
        public int calculateHandValue( List<Card> cards )
        {
            int sum = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                sum += cards[i].valueForCard();
            }

            return sum % 10;
        }

        /// <summary>
        /// Calculates the winning main bet for this game.
        /// </summary>
        /// <param name="hand">The hand for the baccarat game played</param>
        /// <returns>The outcome</returns>
        public Baccarat calculateOutcome( Hand hand )
        {
            var playerValue = calculateHandValue( hand.Playercards );
            var bankerValue = calculateHandValue( hand.Bankercards );

            var difference = bankerValue - playerValue;

            if (difference == 0) return Baccarat.T;
            else if (difference > 0) return Baccarat.B;
            else return Baccarat.P;
        }

        /// <summary>
        /// Calculates the winning natural bets for this game.
        /// </summary>
        /// <param name="outcome">The outcome for the game played</param>
        /// <param name="hand">The hand for the baccarat game played</param>
        /// <returns></returns>
        public Baccarat89 calculateNatural( Baccarat outcome, Hand hand )
        {
            switch (outcome)
            {
                case Baccarat.P:
                {
                    var handValue = this.calculateHandValue( hand.Playercards );
                    if (handValue == 8)
                    {
                        return Baccarat89.P8;
                    }
                    else if (handValue == 9)
                        return Baccarat89.P9;
                }
                break;

                case Baccarat.B:
                {
                    var handValue = this.calculateHandValue( hand.Bankercards );
                    if (handValue == 8)
                    {
                        return Baccarat89.B8;
                    }
                    else if (handValue == 9)
                        return Baccarat89.B9;
                }
                break;

                default:
                return Baccarat89.None;
            }

            return Baccarat89.None;
        }


        /// <summary>
        /// Calculates the winning pair bets for the game.
        /// </summary>
        /// <param name="hand">The hand for the baccarat game played.</param>
        /// <returns></returns>
        public BaccaratPairs calculatePairs( Hand hand )
        {
            var isPlayerPair = hand.PlayerHasPairs();
            var isBankerPair = hand.BankerHasPairs();

            if (isPlayerPair && isBankerPair)
                return BaccaratPairs.BBPP;
            else if (isPlayerPair)
                return BaccaratPairs.PP;
            else if (isBankerPair)
                return BaccaratPairs.BB;
            else
                return BaccaratPairs.None;
        }

        public BaccaratXXX checkforMonster( Baccarat outcome, Hand hand )
        {
            var playerValue = this.calculateHandValue( hand.Playercards );
            var bankerValue = this.calculateHandValue( hand.Bankercards );

            switch (outcome)
            {
                case Baccarat.P:
                {
                    if (playerValue == 7 && bankerValue == 6)
                        return BaccaratXXX.Lucky73;
                    else if (playerValue == 7)
                        return BaccaratXXX.Lucky7;

                    if ( playerValue == 8 && hand.Playercards.Count == 3)
                    {
                        return BaccaratXXX.Panda;
                    }
                }
                break;

                case Baccarat.B:
                {
                    if ( bankerValue == 6 )
                    {
                        if (hand.Bankercards.Count == 3) return BaccaratXXX.Lucky63;

                        return BaccaratXXX.Lucky6;
                    }                                            
                }
                break;

                case Baccarat.T:
                {
                    var handValue = this.calculateHandValue( hand.Bankercards );
                    if (handValue == 6)
                    {
                        return BaccaratXXX.TigerTie;
                    }

                    return BaccaratXXX.Tie;
                }
                break;
            }

            return BaccaratXXX.None;
        }

    }
}
