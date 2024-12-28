namespace BaccaratEngine.Tests;

[TestClass]
public class Shoe_Test
{
    private Shoe _testShoe;

    public Shoe_Test()
    {
        _testShoe = new Shoe( 1 );
        _testShoe.createDecks();
        _testShoe.shuffle();
    }

    [TestMethod]
    public void OneDeckConstructTest()
    {
        Assert.AreEqual( _testShoe.Cards.Count, 52 );
    }

    [TestMethod]
    public void WhenDrawDownTo17Cards()
    {
        // We only have 17 cards left
        _testShoe.RemoveCards( 52 - 17 );
        Assert.AreEqual( _testShoe.cutCardReached, false );
    }

    [TestMethod]
    public void WhenDrawDownTo16Cards()
    {
        // We only have 15 cards left
        _testShoe.RemoveCards( 52 - 16 );
        Assert.AreEqual( _testShoe.cutCardReached, true );
    }

    [TestMethod]
    public void WhenDrawDownTo15Cards()
    {
        // We only have 15 cards left
        _testShoe.RemoveCards( 52 - 15 );
        Assert.AreEqual( _testShoe.cutCardReached, true );
    }
}
