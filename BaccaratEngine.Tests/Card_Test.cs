namespace BaccaratEngine.Tests
{
    [TestClass]
    public class Card_Test
    {
        private readonly Card _card;
        private readonly Card _spade3card;

        public Card_Test()
        {
            _card = new Card();
            _spade3card = new Card( Card.CardSuit.Spade, Card.CardValue.C3 );
        }

        [TestMethod]
        public void DefaultConstructTest()
        {
            Assert.AreEqual( _card.Suit, Card.CardSuit.Club );
            Assert.AreEqual( _card.Value, Card.CardValue.CA );
        }

        [TestMethod]
        public void ConstructWithParametersTest()
        {
            Assert.AreEqual( _spade3card.Suit, Card.CardSuit.Spade );
            Assert.AreEqual( _spade3card.Value, Card.CardValue.C3 );
        }
    }
}
