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
        public BpOutcome calculateOutcome( Hand hand )
        {
            var playerValue = calculateHandValue( hand.Playercards );
            var bankerValue = calculateHandValue( hand.Bankercards );

            var difference = bankerValue - playerValue;

            if (difference == 0) return BpOutcome.T;
            else if (difference > 0) return BpOutcome.B;
            else return BpOutcome.P;
        }

        /// <summary>
        /// Calculates the winning natural bets for this game.
        /// </summary>
        /// <param name="outcome">The outcome for the game played</param>
        /// <param name="hand">The hand for the baccarat game played</param>
        /// <returns></returns>
        public BpNatural calculateNatural( BpOutcome outcome, Hand hand )
        {
            switch (outcome)
            {
                case BpOutcome.P:
                {
                    var handValue = this.calculateHandValue( hand.Playercards );
                    if (handValue == 8)
                    {
                        return BpNatural.P8;
                    }
                    else if (handValue == 9)
                        return BpNatural.P9;
                }
                break;

                case BpOutcome.B:
                {
                    var handValue = this.calculateHandValue( hand.Bankercards );
                    if (handValue == 8)
                    {
                        return BpNatural.B8;
                    }
                    else if (handValue == 9)
                        return BpNatural.B9;
                }
                break;

                default:
                return BpNatural.None;
            }

            return BpNatural.None;
        }


        /// <summary>
        /// Calculates the winning pair bets for the game.
        /// </summary>
        /// <param name="hand">The hand for the baccarat game played.</param>
        /// <returns></returns>
        public BpPair calculatePairs( Hand hand )
        {
            var isPlayerPair = hand.PlayerHasPairs();
            var isBankerPair = hand.BankerHasPairs();

            if (isPlayerPair && isBankerPair)
                return BpPair.BBPP;
            else if (isPlayerPair)
                return BpPair.PP;
            else if (isBankerPair)
                return BpPair.BB;
            else
                return BpPair.None;
        }

        public BpMonster checkforMonster( BpOutcome outcome, Hand hand )
        {
            var playerValue = this.calculateHandValue( hand.Playercards );
            var bankerValue = this.calculateHandValue( hand.Bankercards );

            switch (outcome)
            {
                case BpOutcome.P:
                {
                    if (playerValue == 7 && bankerValue == 6)
                        return BpMonster.Lucky73;
                    else if (playerValue == 7)
                        return BpMonster.Lucky7;

                    if ( playerValue == 8 && hand.Playercards.Count == 3)
                    {
                        return BpMonster.Panda;
                    }
                }
                break;

                case BpOutcome.B:
                {
                    if ( bankerValue == 6 )
                    {
                        if (hand.Bankercards.Count == 3) return BpMonster.Lucky63;

                        return BpMonster.Lucky6;
                    }                                            
                }
                break;

                case BpOutcome.T:
                {
                    var handValue = this.calculateHandValue( hand.Bankercards );
                    if (handValue == 6)
                    {
                        return BpMonster.TigerTie;
                    }

                    return BpMonster.Tie;
                }
                break;
            }

            return BpMonster.None;
        }

    }
}
