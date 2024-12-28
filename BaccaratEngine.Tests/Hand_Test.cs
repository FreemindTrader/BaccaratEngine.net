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
}
