namespace BaccaratEngine.Tests;

[TestClass]
public class BaccaratGameEngine_Test
{
    private BaccaratGameEngine _gameEngine;
    private BaccaratResultsEngine _gameResult;

    public BaccaratGameEngine_Test()
    {
        _gameEngine = new BaccaratGameEngine();
        _gameResult = new BaccaratResultsEngine();
        _gameEngine.Shoe.createDecks();
        _gameEngine.Shoe.shuffle();
    }

    [TestMethod]
    public void BurnOperations_Test()
    {
        while (_gameEngine.Shoe.cardsLeft >= 16)
        {
            _gameEngine.dealGame();
        }

        Assert.AreEqual( _gameEngine.isBurnNeed, true );

        // Should not require burn before dealing
        _gameEngine = new BaccaratGameEngine();
        _gameResult = new BaccaratResultsEngine();
        _gameEngine.Shoe.createDecks();
        _gameEngine.Shoe.shuffle();

        Assert.AreEqual( _gameEngine.isBurnNeed, false );
    }

    /// <summary>
    /// "Should return the same amount of burn cards as the burn card."
    /// </summary>
    [TestMethod]
    public void WhenCardsBurned_Test()
    {
        var burn = _gameEngine.burnCards();
        var burnCardValue = burn.Item1.valueForCard( );

        var expectedCards = burnCardValue == 0 ? 10 : burnCardValue;

        Assert.AreEqual( expectedCards, burn.Item2.Count );
    }

    /// <summary>
    /// When 100,000 games simulated
    /// Should have probabilities of Banker: 45% Player: 44% Tie 9% With 2% margin of error
    /// </summary>
    [TestMethod]
    public void DealGame_Test()
    {
        var bankerWins = 0;
        var playerWins = 0;
        var ties = 0;

        for (var i = 0; i < 100000; i++)
        {
            if ( _gameEngine.Shoe.cutCardReached )
            {
                _gameResult = new BaccaratResultsEngine();
                _gameEngine.Shoe.createDecks();
                _gameEngine.Shoe.shuffle();

            }

            var hand = _gameEngine.dealGame();
            var result = _gameResult.calculateGameResult( hand );

            switch (result.Outcomes)
            {
                case GameResultOutcomes.Tie:
                ties++;
                break;
                case GameResultOutcomes.Banker:
                bankerWins++;
                break;
                case GameResultOutcomes.Player:
                playerWins++;
                break;
            }
        }

        Assert.AreEqual( bankerWins > (45859 - 1000), true );
        Assert.AreEqual( bankerWins <= (45859 + 1000), true );
        Assert.AreEqual( playerWins > (44624 - 1000), true );
        Assert.AreEqual( playerWins <= (44624 + 1000), true );
        Assert.AreEqual( ties > (9515 - 1000), true );
        Assert.AreEqual( ties <= (9515 + 1000), true );
    }
}
