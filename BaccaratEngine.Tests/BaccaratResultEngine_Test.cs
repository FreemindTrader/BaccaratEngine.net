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

        Assert.AreEqual( result.Outcome, Baccarat.B );
        Assert.AreEqual( result.NaturalInfo, BaccaratEx.B9 );
        Assert.AreEqual( result.PairInfo, BaccaratEx.None );
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

        Assert.AreEqual( result.Outcome, Baccarat.T );
        Assert.AreEqual( result.NaturalInfo, BaccaratEx.None );
        Assert.AreEqual( result.PairInfo, BaccaratEx.None );
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

        Assert.AreEqual( result.Outcome, Baccarat.P );
        Assert.AreEqual( result.NaturalInfo, BaccaratEx.P8 );
        Assert.AreEqual( result.PairInfo, BaccaratEx.BBPP );
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

        Assert.AreEqual( result.Outcome, Baccarat.B );
        Assert.AreEqual( result.NaturalInfo, BaccaratEx.None );
        Assert.AreEqual( result.PairInfo, BaccaratEx.PP );
        Assert.AreEqual( result.MonsterInfo, BaccaratEx.B6 );
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

        Assert.AreEqual( result.Outcome, Baccarat.B );
        Assert.AreEqual( result.NaturalInfo, BaccaratEx.None );
        Assert.AreEqual( result.PairInfo, BaccaratEx.BBPP );
        Assert.AreEqual( result.MonsterInfo, BaccaratEx.B63 );
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

        Assert.AreEqual( result.Outcome, Baccarat.P );
        Assert.AreEqual( result.NaturalInfo, BaccaratEx.None );
        Assert.AreEqual( result.PairInfo, BaccaratEx.BBPP );
        Assert.AreEqual( result.MonsterInfo, BaccaratEx.P7 );
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

        Assert.AreEqual( result.Outcome, Baccarat.P );
        Assert.AreEqual( result.NaturalInfo, BaccaratEx.None );
        Assert.AreEqual( result.PairInfo, BaccaratEx.BBPP );
        Assert.AreEqual( result.MonsterInfo, BaccaratEx.P76 );
    }
}
