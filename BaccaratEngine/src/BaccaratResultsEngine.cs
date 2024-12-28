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
            game.Outcomes = this.calculateOutcome( hand );
            game.IsNatural = this.calculateNatural( game.Outcomes, hand );
            game.HasPair = this.calculatePairs( hand );
            game.IsMonster = this.checkforMonster( game.Outcomes, hand );

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
        public GameResultOutcomes calculateOutcome( Hand hand )
        {
            var playerValue = calculateHandValue( hand.Playercards );
            var bankerValue = calculateHandValue( hand.Bankercards );

            var difference = bankerValue - playerValue;

            if (difference == 0) return GameResultOutcomes.Tie;
            else if (difference > 0) return GameResultOutcomes.Banker;
            else return GameResultOutcomes.Player;
        }

        /// <summary>
        /// Calculates the winning natural bets for this game.
        /// </summary>
        /// <param name="outcome">The outcome for the game played</param>
        /// <param name="hand">The hand for the baccarat game played</param>
        /// <returns></returns>
        public GameResultNatural calculateNatural( GameResultOutcomes outcome, Hand hand )
        {
            switch (outcome)
            {
                case GameResultOutcomes.Player:
                {
                    var handValue = this.calculateHandValue( hand.Playercards );
                    if (handValue == 8)
                    {
                        return GameResultNatural.PlayerNatural8;
                    }
                    else if (handValue == 9)
                        return GameResultNatural.PlayerNatural9;
                }
                break;

                case GameResultOutcomes.Banker:
                {
                    var handValue = this.calculateHandValue( hand.Bankercards );
                    if (handValue == 8)
                    {
                        return GameResultNatural.BankerNatural8;
                    }
                    else if (handValue == 9)
                        return GameResultNatural.BankerNatural9;
                }
                break;

                default:
                return GameResultNatural.NoNatural;
            }

            return GameResultNatural.NoNatural;
        }


        /// <summary>
        /// Calculates the winning pair bets for the game.
        /// </summary>
        /// <param name="hand">The hand for the baccarat game played.</param>
        /// <returns></returns>
        public GameResultPair calculatePairs( Hand hand )
        {
            var isPlayerPair = hand.PlayerHasPairs();
            var isBankerPair = hand.BankerHasPairs();

            if (isPlayerPair && isBankerPair)
                return GameResultPair.BothPair;
            else if (isPlayerPair)
                return GameResultPair.PlayerPair;
            else if (isBankerPair)
                return GameResultPair.BankerPair;
            else
                return GameResultPair.NoPair;
        }

        public GameResultMonster checkforMonster( GameResultOutcomes outcome, Hand hand )
        {
            var playerValue = this.calculateHandValue( hand.Playercards );
            var bankerValue = this.calculateHandValue( hand.Bankercards );

            switch (outcome)
            {
                case GameResultOutcomes.Player:
                {
                    if (playerValue == 7 && bankerValue == 6)
                        return GameResultMonster.Lucky73;
                    else if (playerValue == 7)
                        return GameResultMonster.Lucky7;

                    if ( playerValue == 8 && hand.Playercards.Count == 3)
                    {
                        return GameResultMonster.Panda;
                    }
                }
                break;

                case GameResultOutcomes.Banker:
                {
                    if ( bankerValue == 6 )
                    {
                        if (hand.Bankercards.Count == 3) return GameResultMonster.Lucky63;

                        return GameResultMonster.Lucky6;
                    }                                            
                }
                break;

                case GameResultOutcomes.Tie:
                {
                    var handValue = this.calculateHandValue( hand.Bankercards );
                    if (handValue == 6)
                    {
                        return GameResultMonster.TigerTie;
                    }

                    return GameResultMonster.Tie;
                }
                break;
            }

            return GameResultMonster.NoMonster;
        }

    }
}
