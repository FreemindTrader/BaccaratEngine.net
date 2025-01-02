using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class Hand
    {     
        private List<Card> _playercards = new List<Card>();
        private List<Card> _bankercards = new List<Card>();
        public Hand(  ) 
        {            
        }

        /// <summary>
        /// For string formatting to work, I have to fix the format as follow
        /// Six Cards
        /// P1P2B1B2  P3B3
        /// 
        /// Five Card
        /// P1P2B1B2 P3
        /// P1P2B1B2 B3
        /// 
        /// </summary>
        /// <param name="hand"></param>
        public Hand( string hand )
        {

            ProcessHandString( hand );
        }

        private void ProcessHandString( string hand )
        {
            hand = hand.Trim();

            if (hand.Length == 4)
            {
                var player1 = hand[0] - '0';                
                var player2 = hand[1] - '0';
                _playercards.Add( new Card( player1 ) );
                _playercards.Add( new Card( player2 ) );

                var banker1 = hand[2] - '0';
                var banker2 = hand[3] - '0';
                _bankercards.Add( new Card( banker1 ) );                
                _bankercards.Add( new Card( banker2 ) );
            }
            else if (hand.Length == 5)
            {
                var card1 = hand[0] - '0';
                var card2 = hand[1] - '0';
                var card3 = hand[2] - '0';
                var card4 = hand[3] - '0';
                var card5 = hand[4] - '0';

                Process5Cards( card1, card2, card3, card4, card5 );               
            }
            else if (hand.Length == 6)
            {
                // "023033" means
                // player first card is 2, second card is 3. and then third card is 10, J Q, K
                
                var player1 = hand[0] - '0';
                var player2 = hand[1] - '0';
                var player3 = hand[4] - '0';
                _playercards.Add( new Card( player1 ) );                
                _playercards.Add( new Card( player2 ) );                
                _playercards.Add( new Card( player3 ) );

                var banker1 = hand[2] - '0';
                var banker2 = hand[3] - '0';
                var banker3 = hand[5] - '0';
                _bankercards.Add( new Card( banker1 ) );                
                _bankercards.Add( new Card( banker2 ) );                
                _bankercards.Add( new Card( banker3 ) );
            }
            else
            {
                throw new ArgumentException();

            }                       
        }

        private bool CheckAssignThirdCard( int player1, int player2, int banker1, int banker2, int whoscard )
        {
            // Where we have 5 cards scenarios.
            //
            // 1) either banker or player has a total of 7
            // 2) When banker is 6,
            //          player third card CANNOT be 6 or 7. If 6, or 7, banker will draw, and it is no longer 5 cards scenario
            // 3) When banker is 5
            //          player third card CANNOT be 4,5, 6 or 7. If not, it becomes 6 cards scenario
            // 4) when banker is 4
            //          player third card CANNOT be 2,3,4, 5, 6 or 7. If not, it becomes 6 cards scenario
            // 4) when banker is 3
            //          player third card CAN ONLY be 8. If not, it becomes 6 cards scenario
            int bankerCardsValue = banker1 + banker2;
            int playerCardsValue = player1 + player2;            

            if (playerCardsValue == 6 || playerCardsValue == 7 )
            {
                if (bankerCardsValue <= 5)
                {
                    _playercards.Add( new Card( player1 ) );
                    _playercards.Add( new Card( player2 ) );
                    _bankercards.Add( new Card( banker1 ) );
                    _bankercards.Add( new Card( banker2 ) );
                    _bankercards.Add( new Card( whoscard ) );

                    return true;
                }                
            }

            if (bankerCardsValue == 6 || bankerCardsValue == 7)
            {
                if (playerCardsValue <= 5)
                {
                    _playercards.Add( new Card( player1 ) );
                    _playercards.Add( new Card( player2 ) );
                    _playercards.Add( new Card( whoscard ) );
                    _bankercards.Add( new Card( banker1 ) );
                    _bankercards.Add( new Card( banker2 ) );

                    return true;
                }                
            }

            
            switch (bankerCardsValue)
            {
                case 6:
                {
                    // 2) When banker is 6,
                    //          player third card CANNOT be 6 or 7. If 6, or 7, banker will draw, and it is no longer 5 cards scenario
                    if (playerCardsValue <= 5)
                    {
                        if (whoscard != 6 && whoscard != 7)
                        {
                            _playercards.Add( new Card( player1 ) );
                            _playercards.Add( new Card( player2 ) );
                            _playercards.Add( new Card( whoscard ) );
                            _bankercards.Add( new Card( banker1 ) );
                            _bankercards.Add( new Card( banker2 ) );

                            return true;
                        }                        
                    }
                }
                break;

                case 5:
                {
                    // 3) When banker is 5
                    //          player third card CANNOT be 4,5, 6 or 7. If not, it becomes 6 cards scenario
                    if (whoscard != 4 && whoscard != 5 && whoscard != 6 && whoscard != 7)
                    {
                        _playercards.Add( new Card( player1 ) );
                        _playercards.Add( new Card( player2 ) );
                        _playercards.Add( new Card( whoscard ) );
                        _bankercards.Add( new Card( banker1 ) );
                        _bankercards.Add( new Card( banker2 ) );

                        return true;
                    }
                }
                break;

                case 4:
                {
                    // 4) when banker is 4
                    //          player third card CANNOT be 2,3,4, 5, 6 or 7. If not, it becomes 6 cards scenario
                    if (whoscard != 2 && whoscard != 3 && whoscard != 4 && whoscard != 5 && whoscard != 6 && whoscard != 7)
                    {
                        _playercards.Add( new Card( player1 ) );
                        _playercards.Add( new Card( player2 ) );
                        _playercards.Add( new Card( whoscard ) );
                        _bankercards.Add( new Card( banker1 ) );
                        _bankercards.Add( new Card( banker2 ) );

                        return true;
                    }
                }
                break;

                case 3:
                {
                    // 4) when banker is 3
                    //          player third card CAN ONLY be 8. If not, it becomes 6 cards scenario
                    if (whoscard == 8)
                    {
                        _playercards.Add( new Card( player1 ) );
                        _playercards.Add( new Card( player2 ) );
                        _playercards.Add( new Card( whoscard ) );
                        _bankercards.Add( new Card( banker1 ) );
                        _bankercards.Add( new Card( banker2 ) );

                        return true;
                    }
                }
                break;
            }


            return false;
        }

        private bool WhosThirdCard( int player1, int player2, int banker1, int banker2, int whoscard )
        {
            // Where we have 5 cards scenarios.
            //
            // 1) either banker or player has a total of 7
            // 2) When banker is 6,
            //          player third card CANNOT be 6 or 7. If 6, or 7, banker will draw, and it is no longer 5 cards scenario
            // 3) When banker is 5
            //          player third card CANNOT be 4,5, 6 or 7. If not, it becomes 6 cards scenario
            // 4) when banker is 4
            //          player third card CANNOT be 2,3,4, 5, 6 or 7. If not, it becomes 6 cards scenario
            // 4) when banker is 3
            //          player third card CAN ONLY be 8. If not, it becomes 6 cards scenario

            bool isValid = false;

            int bankerCardsValue = banker1 + banker2;
            int playerCardsValue = player1 + player2;

            if (playerCardsValue > 5) return false;

            if ( bankerCardsValue == 6 || bankerCardsValue == 7)
            {
                if (playerCardsValue <= 5) return true;
            }

            switch (bankerCardsValue)
            {
                case 6:
                {
                    // 2) When banker is 6,
                    //          player third card CANNOT be 6 or 7. If 6, or 7, banker will draw, and it is no longer 5 cards scenario
                    if (playerCardsValue <= 5)
                    {
                        if (whoscard != 6 && whoscard != 7) return true;
                    }
                }
                break;

                case 5:
                {
                    // 3) When banker is 5
                    //          player third card CANNOT be 4,5, 6 or 7. If not, it becomes 6 cards scenario
                    if (whoscard != 4 && whoscard != 5 && whoscard != 6 && whoscard != 7) return true;
                }
                break;

                case 4:
                {
                    // 4) when banker is 4
                    //          player third card CANNOT be 2,3,4, 5, 6 or 7. If not, it becomes 6 cards scenario
                    if (whoscard != 2 && whoscard != 3 && whoscard != 4 && whoscard != 5 && whoscard != 6 && whoscard != 7) return true;
                }
                break;

                case 3:
                {
                    // 4) when banker is 3
                    //          player third card CAN ONLY be 8. If not, it becomes 6 cards scenario
                    if ( whoscard == 8) return true;
                }
                break;
            }

            
            return false;
        }
        private bool VerifyIfBelongsToBanker( int player1, int player2, int banker1, int banker2, int banker3 )
        {
            // If the third card belongs to banker, it would mean player is either 6 or 7 and banker has a total of less than 6
            //
            // If not, there it is not valid

            int playerCardsValue = player1 + player2;
            int bankerCardsValue = banker1 + banker2;

            if (playerCardsValue == 6 || playerCardsValue == 7)
            {
                if (bankerCardsValue <= 5) return true;
            }

            return false;
        }
        private void Process5Cards( int card1, int card2, int card3, int card4, int card5 )
        {
            // Where we have 5 cards scenarios.
            //
            // 1) either banker or player has a total of 7
            // 2) When banker is 6,
            //          player third card CANNOT be 6 or 7. If 6, or 7, banker will draw, and it is no longer 5 cards scenario
            // 3) When banker is 5
            //          player third card CANNOT be 4,5, 6 or 7. If not, it becomes 6 cards scenario
            // 4) when banker is 4
            //          player third card CANNOT be 2,3,4, 5, 6 or 7. If not, it becomes 6 cards scenario
            // 4) when banker is 3
            //          player third card CAN ONLY be 8. If not, it becomes 6 cards scenario

            /// Five Card, we have to stick to this format.
            /// P1P2B1B2 P3
            /// P1P2B1B2 B3
            //
            // The first two have to be fixed as P1 and P2
            // Or else the following cannot be resolved.
            // This one is a very good example of not knowing whether Banker has 3 cards or Player has 3 cards.
            // var hand = new Hand( "60106" );

            bool isValid = CheckAssignThirdCard( card1, card2, card3, card4, card5 );
            
            if ( !isValid )
            {
                throw new ArgumentException( "Argrument is wrong" );
            }
        }

        public List<Card> Playercards 
        {
            get
            {
                return _playercards;
            }
            set
            {
                _playercards = value;
            }
        }

        public List<Card> Bankercards
        {
            get
            {
                return _bankercards;
            }
            set
            {
                _bankercards = value;
            }
        }        

        public bool PlayerHasPairs()
        {            
            return Playercards[0].valueForCard() == Playercards[1].valueForCard();
        }

        public bool BankerHasPairs()
        {         
            return Bankercards[0].valueForCard() == Bankercards[1].valueForCard();
        }
    }
}
