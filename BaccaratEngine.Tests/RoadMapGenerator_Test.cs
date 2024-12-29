using System.Collections.Generic;

namespace BaccaratEngine.Tests;

[TestClass]
public class RoadMapGenerator_Test
{
    private RoadmapGenerator _generator = new RoadmapGenerator();
    
    
    [TestMethod]
    public void beadPlate_Test()
    {
        // When called with game results of [B, B, P, T, P, B]
        // When configured with 3 rows and 1 column
        // Should return a scrolled bead plate of [T, P, B] showing the last 3 entries

        List<GameResult> input_result = new List<GameResult>();

        input_result.Add( new GameResult( BpOutcome.B ) );
        input_result.Add( new GameResult( BpOutcome.B ) );
        input_result.Add( new GameResult( BpOutcome.P ) );
        input_result.Add( new GameResult( BpOutcome.T ) );
        input_result.Add( new GameResult( BpOutcome.P ) );
        input_result.Add( new GameResult( BpOutcome.B ) );

        var result = _generator.beadPlate( input_result, 1, 3 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 3 );

        Assert.AreEqual( result[0].Result.Outcome, BpOutcome.T );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );

        Assert.AreEqual( result[1].Result.Outcome, BpOutcome.P );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1);

        Assert.AreEqual( result[2].Result.Outcome, BpOutcome.B );
        Assert.AreEqual( result[2].Column, 0 );
        Assert.AreEqual( result[2].Row, 2 );
    }
}
