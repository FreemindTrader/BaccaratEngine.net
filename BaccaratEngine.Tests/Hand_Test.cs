namespace BaccaratEngine.Tests;

[TestClass]
public class Hand_Test
{
    private Hand _hand1;

    [TestMethod]
    public void DefaultConstructTest()
    {
        _hand1 = new Hand();

        Assert.AreEqual( _hand1.Playercards.Count, 0 );
        Assert.AreEqual( _hand1.Bankercards.Count, 0 );
    }

    [TestMethod]
    public void TestHandString()
    {
        _hand1 = new Hand( "3604" );

        Assert.AreEqual( _hand1.Playercards[0].valueForCard(), 3 );
        Assert.AreEqual( _hand1.Playercards[1].valueForCard(), 6 );

        Assert.AreEqual( _hand1.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( _hand1.Bankercards[1].valueForCard(), 4 );

        _hand1 = new Hand( "0654" );

        Assert.AreEqual( _hand1.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( _hand1.Playercards[1].valueForCard(), 6 );

        Assert.AreEqual( _hand1.Bankercards[0].valueForCard(), 5 );
        Assert.AreEqual( _hand1.Bankercards[1].valueForCard(), 4 );


        _hand1 = new Hand( "023066" );

        Assert.AreEqual( _hand1.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( _hand1.Playercards[1].valueForCard(), 2 );
        Assert.AreEqual( _hand1.Playercards[2].valueForCard(), 6 );

        Assert.AreEqual( _hand1.Bankercards[0].valueForCard(), 3 );
        Assert.AreEqual( _hand1.Bankercards[1].valueForCard(), 0 );
        Assert.AreEqual( _hand1.Bankercards[2].valueForCard(), 6 );

        _hand1 = new Hand( "24036" );

        Assert.AreEqual( _hand1.Playercards[0].valueForCard(), 2 );
        Assert.AreEqual( _hand1.Playercards[1].valueForCard(), 4 );


        Assert.AreEqual( _hand1.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( _hand1.Bankercards[1].valueForCard(), 3 );
        Assert.AreEqual( _hand1.Bankercards[2].valueForCard(), 6 );

        _hand1 = new Hand( "023033" );

        Assert.AreEqual( _hand1.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( _hand1.Playercards[1].valueForCard(), 2 );
        Assert.AreEqual( _hand1.Playercards[2].valueForCard(), 3 );

        Assert.AreEqual( _hand1.Bankercards[0].valueForCard(), 3 );
        Assert.AreEqual( _hand1.Bankercards[1].valueForCard(), 0 );
        Assert.AreEqual( _hand1.Bankercards[2].valueForCard(), 3 );
    }

    
    [TestMethod]
    public void ShouldThrowException_Test()
    {
        var thrown = false;
        // This doesn't make sense as neither hand has a total of 6, so they have 
        try
        {
            var hand = new Hand( "20204" );
        }
        catch (ArgumentException e)
        {
            thrown = true;
        }

        Assert.AreEqual( thrown, true );

        thrown = false;

        try
        {
            var hand = new Hand( "40047" );
        }
        catch (ArgumentException e)
        {
            thrown = true;
        }


        Assert.AreEqual( thrown, true );

        thrown = false;
        try
        {
            // This one is a very good example of not knowing whether Banker has 3 cards or Player has 3 cards.
            var hand = new Hand( "60106" );
        }
        catch (ArgumentException e)
        {
            thrown = true;
        }


        Assert.AreEqual( thrown, false );


    }

    [TestMethod]
    public void Test5CardsScenarios()
    {
        var hand = new Hand( "04038" );

        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 8 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 3 );

        hand = new Hand( "04040" );

        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 4 );

        hand = new Hand( "04041" );

        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 1 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 4 );

        hand = new Hand( "04048" );

        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 8 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 4 );

        hand = new Hand( "04049" );

        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 9 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 4 );

        hand = new Hand( "05050" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        hand = new Hand( "05051" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 1 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        hand = new Hand( "05052" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 2 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        hand = new Hand( "05053" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 3 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        hand = new Hand( "05058" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 8 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        hand = new Hand( "05060" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        hand = new Hand( "05061" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 1 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        hand = new Hand( "05062" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 2 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        hand = new Hand( "05063" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 3 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        hand = new Hand( "05064" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 4 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        hand = new Hand( "05065" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 5 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        hand = new Hand( "05068" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 8 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        hand = new Hand( "05069" );
        Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        Assert.AreEqual( hand.Playercards[2].valueForCard(), 9 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

    }

    [TestMethod]
    public void TestInvalid5CardsScenarios()
    {
        var hand = new Hand( "70403" );

        Assert.AreEqual( hand.Playercards[0].valueForCard(), 7 );
        Assert.AreEqual( hand.Playercards[1].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[0].valueForCard(), 4 );
        Assert.AreEqual( hand.Bankercards[1].valueForCard(), 0 );
        Assert.AreEqual( hand.Bankercards[2].valueForCard(), 3 );

        

        //hand = new Hand( "00404" );

        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 4 );

        //hand = new Hand( "10404" );

        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 1 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 4 );

        //hand = new Hand( "80404" );

        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 8 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 4 );

        //hand = new Hand( "90404" );

        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 4 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 9 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 4 );

        //hand = new Hand( "00505" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        //hand = new Hand( "10505" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 1 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        //hand = new Hand( "20505" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 2 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        //hand = new Hand( "30505" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 3 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        //hand = new Hand( "80505" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 8 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 5 );

        //hand = new Hand( "00506" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        //hand = new Hand( "10506" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 1 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        //hand = new Hand( "20506" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 2 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        //hand = new Hand( "30506" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 3 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        //hand = new Hand( "40506" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 4 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        //hand = new Hand( "50506" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 5 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        //hand = new Hand( "80506" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 8 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

        //hand = new Hand( "90506" );
        //Assert.AreEqual( hand.Playercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Playercards[1].valueForCard(), 5 );
        //Assert.AreEqual( hand.Playercards[2].valueForCard(), 9 );
        //Assert.AreEqual( hand.Bankercards[0].valueForCard(), 0 );
        //Assert.AreEqual( hand.Bankercards[1].valueForCard(), 6 );

    }
}
