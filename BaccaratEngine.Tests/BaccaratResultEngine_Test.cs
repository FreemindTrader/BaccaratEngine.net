namespace BaccaratEngine.Tests;

[TestClass]
public class BaccaratResultEngine_Test
{
    private BaccaratResultsEngine _engine;

    public BaccaratResultEngine_Test()
    {
        _engine = new BaccaratResultsEngine(  );        
    }

    [TestMethod]
    public void BankWin_Test()
    {
        var player1 = new Card( Card.CardSuit.Diamond, Card.CardValue.C10 );
        var player2 = new Card( Card.CardSuit.Diamond, Card.CardValue.C8 );

        var banker1 = new Card( Card.CardSuit.Spade, Card.CardValue.CA );
        var banker2 = new Card( Card.CardSuit.Spade, Card.CardValue.C8 );

        var hand = new Hand();

        hand.Playercards.Add( player1 );
        hand.Playercards.Add( player2 );

        hand.Bankercards.Add( banker1 );
        hand.Bankercards.Add( banker2 );

        var result = _engine.calculateGameResult( hand );

        Assert.AreEqual( result.Outcomes, GameResultOutcomes.Banker );
        Assert.AreEqual( result.IsNatural, GameResultNatural.BankerNatural9 );
        Assert.AreEqual( result.HasPair, GameResultPair.NoPair );
    }

    [TestMethod]
    public void BankPlayer_Tie_Test()
    {
        var player1 = new Card( Card.CardSuit.Diamond, Card.CardValue.C10 );
        var player2 = new Card( Card.CardSuit.Diamond, Card.CardValue.C8 );

        var banker1 = new Card( Card.CardSuit.Spade, Card.CardValue.CA );
        var banker2 = new Card( Card.CardSuit.Spade, Card.CardValue.C7 );

        var hand = new Hand();

        hand.Playercards.Add( player1 );
        hand.Playercards.Add( player2 );

        hand.Bankercards.Add( banker1 );
        hand.Bankercards.Add( banker2 );

        var result = _engine.calculateGameResult( hand );

        Assert.AreEqual( result.Outcomes, GameResultOutcomes.Tie );
        Assert.AreEqual( result.IsNatural, GameResultNatural.NoNatural );
        Assert.AreEqual( result.HasPair, GameResultPair.NoPair );
    }

    [TestMethod]
    public void BankPlayer_HasPairs_Test()
    {
        var player1 = new Card( Card.CardSuit.Diamond, Card.CardValue.C4 );
        var player2 = new Card( Card.CardSuit.Diamond, Card.CardValue.C4 );

        var banker1 = new Card( Card.CardSuit.Spade, Card.CardValue.C5 );
        var banker2 = new Card( Card.CardSuit.Spade, Card.CardValue.C5 );

        var hand = new Hand();

        hand.Playercards.Add( player1 );
        hand.Playercards.Add( player2 );

        hand.Bankercards.Add( banker1 );
        hand.Bankercards.Add( banker2 );

        var result = _engine.calculateGameResult( hand );

        Assert.AreEqual( result.Outcomes, GameResultOutcomes.Player );
        Assert.AreEqual( result.IsNatural, GameResultNatural.PlayerNatural8 );
        Assert.AreEqual( result.HasPair, GameResultPair.BothPair );
    }

    [TestMethod]
    public void Banker_Lucky6_Test()
    {
        var player1 = new Card( Card.CardSuit.Diamond, Card.CardValue.C2 );
        var player2 = new Card( Card.CardSuit.Diamond, Card.CardValue.C2 );
        var player3 = new Card( Card.CardSuit.Diamond, Card.CardValue.CJ );

        var banker1 = new Card( Card.CardSuit.Spade, Card.CardValue.C5 );
        var banker2 = new Card( Card.CardSuit.Spade, Card.CardValue.CA );

        var hand = new Hand();

        hand.Playercards.Add( player1 );
        hand.Playercards.Add( player2 );
        hand.Playercards.Add( player3 );

        hand.Bankercards.Add( banker1 );
        hand.Bankercards.Add( banker2 );

        var result = _engine.calculateGameResult( hand );

        Assert.AreEqual( result.Outcomes, GameResultOutcomes.Banker );
        Assert.AreEqual( result.IsNatural, GameResultNatural.NoNatural );
        Assert.AreEqual( result.HasPair, GameResultPair.PlayerPair );
        Assert.AreEqual( result.IsMonster, GameResultMonster.Lucky6 );
    }

    [TestMethod]
    public void Banker_Lucky6_3Cards_Test()
    {
        var player1 = new Card( Card.CardSuit.Diamond, Card.CardValue.C2 );
        var player2 = new Card( Card.CardSuit.Diamond, Card.CardValue.C2 );
        var player3 = new Card( Card.CardSuit.Diamond, Card.CardValue.CJ );

        var banker1 = new Card( Card.CardSuit.Spade, Card.CardValue.C2 );
        var banker2 = new Card( Card.CardSuit.Spade, Card.CardValue.C2 );
        var banker3 = new Card( Card.CardSuit.Spade, Card.CardValue.C2 );

        var hand = new Hand();

        hand.Playercards.Add( player1 );
        hand.Playercards.Add( player2 );
        hand.Playercards.Add( player3 );

        hand.Bankercards.Add( banker1 );
        hand.Bankercards.Add( banker2 );
        hand.Bankercards.Add( banker3 );

        var result = _engine.calculateGameResult( hand );

        Assert.AreEqual( result.Outcomes, GameResultOutcomes.Banker );
        Assert.AreEqual( result.IsNatural, GameResultNatural.NoNatural );
        Assert.AreEqual( result.HasPair, GameResultPair.BothPair );
        Assert.AreEqual( result.IsMonster, GameResultMonster.Lucky63 );
    }

    [TestMethod]
    public void Player_Lucky7_Test()
    {
        var player1 = new Card( Card.CardSuit.Diamond, Card.CardValue.C2 );
        var player2 = new Card( Card.CardSuit.Diamond, Card.CardValue.C2 );
        var player3 = new Card( Card.CardSuit.Diamond, Card.CardValue.C3 );

        var banker1 = new Card( Card.CardSuit.Spade, Card.CardValue.C2 );
        var banker2 = new Card( Card.CardSuit.Spade, Card.CardValue.C2 );
        var banker3 = new Card( Card.CardSuit.Spade, Card.CardValue.CA );

        var hand = new Hand();

        hand.Playercards.Add( player1 );
        hand.Playercards.Add( player2 );
        hand.Playercards.Add( player3 );

        hand.Bankercards.Add( banker1 );
        hand.Bankercards.Add( banker2 );
        hand.Bankercards.Add( banker3 );

        var result = _engine.calculateGameResult( hand );

        Assert.AreEqual( result.Outcomes, GameResultOutcomes.Player );
        Assert.AreEqual( result.IsNatural, GameResultNatural.NoNatural );
        Assert.AreEqual( result.HasPair, GameResultPair.BothPair );
        Assert.AreEqual( result.IsMonster, GameResultMonster.Lucky7 );
    }

    [TestMethod]
    public void Player_Lucky7_Over6_Test()
    {
        var player1 = new Card( Card.CardSuit.Diamond, Card.CardValue.C2 );
        var player2 = new Card( Card.CardSuit.Diamond, Card.CardValue.C2 );
        var player3 = new Card( Card.CardSuit.Diamond, Card.CardValue.C3 );

        var banker1 = new Card( Card.CardSuit.Spade, Card.CardValue.C2 );
        var banker2 = new Card( Card.CardSuit.Spade, Card.CardValue.C2 );
        var banker3 = new Card( Card.CardSuit.Spade, Card.CardValue.C2 );

        var hand = new Hand();

        hand.Playercards.Add( player1 );
        hand.Playercards.Add( player2 );
        hand.Playercards.Add( player3 );

        hand.Bankercards.Add( banker1 );
        hand.Bankercards.Add( banker2 );
        hand.Bankercards.Add( banker3 );

        var result = _engine.calculateGameResult( hand );

        Assert.AreEqual( result.Outcomes, GameResultOutcomes.Player );
        Assert.AreEqual( result.IsNatural, GameResultNatural.NoNatural );
        Assert.AreEqual( result.HasPair, GameResultPair.BothPair );
        Assert.AreEqual( result.IsMonster, GameResultMonster.Lucky73 );
    }
}
