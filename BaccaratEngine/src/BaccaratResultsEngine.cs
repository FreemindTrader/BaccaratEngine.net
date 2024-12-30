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

            this.ProcessExtraInfo( hand, game );            

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
        public GResult calculateOutcome( Hand hand )
        {
            var playerValue = calculateHandValue( hand.Playercards );
            var bankerValue = calculateHandValue( hand.Bankercards );

            var difference = bankerValue - playerValue;

            if (difference == 0) return GResult.T;
            else if (difference > 0) return GResult.B;
            else return GResult.P;
        }

        public void ProcessExtraInfo( Hand hand, GameResult game )
        {
            CheckIfNatural( hand, game );
            CheckForPairs( hand, game );
            CheckForMonsters( hand, game );
        }

        /// <summary>
        /// Calculates the winning natural bets for this game.
        /// </summary>
        /// <param name="outcome">The outcome for the game played</param>
        /// <param name="hand">The hand for the baccarat game played</param>
        /// <returns></returns>
        public void CheckIfNatural( Hand hand, GameResult game )
        {
            switch (game.Outcome)
            {
                case GResult.P:
                {
                    var handValue = this.calculateHandValue( hand.Playercards );
                    if (handValue == 8)
                    {
                        game.NaturalInfo = GNatural.P8;
                    }
                    else if (handValue == 9)
                        game.NaturalInfo = GNatural.P9;
                }
                break;

                case GResult.B:
                {
                    var handValue = this.calculateHandValue( hand.Bankercards );
                    if (handValue == 8)
                    {
                        game.NaturalInfo = GNatural.B8;
                    }
                    else if (handValue == 9)
                        game.NaturalInfo = GNatural.B9;
                }
                break;

                default:
                game.NaturalInfo = GNatural.None;
                break;
            }
        }


        /// <summary>
        /// Calculates the winning pair bets for the game.
        /// </summary>
        /// <param name="hand">The hand for the baccarat game played.</param>
        /// <returns></returns>
        public void CheckForPairs( Hand hand, GameResult game )
        {
            var isPlayerPair = hand.PlayerHasPairs();
            var isBankerPair = hand.BankerHasPairs();

            if (isPlayerPair && isBankerPair)
            {
                game.PairInfo = GPair.BBPP;
            }                
            else if (isPlayerPair)
            {
                switch(hand.Playercards[0].valueForCard())
                {
                    case 3:
                    game.PairInfo = GPair.P33;
                    break;

                    case 4:
                    game.PairInfo = GPair.P44;
                    break;
                    case 9:
                    game.PairInfo = GPair.P99;
                    break;

                    default:
                    game.PairInfo = GPair.PP;
                    break;
                }
                
            }                
            else if (isBankerPair)
            {
                switch (hand.Playercards[0].valueForCard())
                {
                    case 3:
                    game.PairInfo = GPair.B33;
                    break;

                    case 4:
                    game.PairInfo = GPair.B44;
                    break;
                    case 9:
                    game.PairInfo = GPair.B99;
                    break;

                    default:
                    game.PairInfo = GPair.BB;
                    break;
                }                
            }                
            else
                game.PairInfo = GPair.None;
        }

        public void CheckForMonsters( Hand hand, GameResult game )
        {
            var playerValue = this.calculateHandValue( hand.Playercards );
            var bankerValue = this.calculateHandValue( hand.Bankercards );

            game.MonsterInfo = GMonster.None;

            switch (game.Outcome)
            {
                case GResult.P:
                {
                    if (playerValue == 7 && bankerValue == 6)
                        game.MonsterInfo = GMonster.P76;
                    else if (playerValue == 7)
                        game.MonsterInfo = GMonster.P7;                    

                    if ( playerValue == 8 && hand.Playercards.Count == 3)
                    {
                        game.MonsterInfo = GMonster.P83;
                    }
                }
                break;

                case GResult.B:
                {
                    if ( bankerValue == 6 )
                    {
                        if (hand.Bankercards.Count == 3)
                        {
                            game.MonsterInfo = GMonster.B63;
                        }
                        else
                        {
                            game.MonsterInfo = GMonster.B6;
                        }                            
                    }                                            
                }
                break;

                case GResult.T:
                {
                    var handValue = this.calculateHandValue( hand.Bankercards );
                    if (handValue == 6)
                    {
                        game.MonsterInfo = GMonster.T6;                        
                    }
                    else if (handValue == 0)
                    {
                        game.MonsterInfo = GMonster.T0 ;
                    }

                    game.MonsterInfo = GMonster.T;
                }
                break;
            }            
        }

    }
}
