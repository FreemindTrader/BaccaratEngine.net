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

        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.T ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.B ) );

        var result = _generator.beadPlate( input_result, 1, 3 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 3 );

        Assert.AreEqual( result[0].Result.Outcome, Baccarat.T );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );

        Assert.AreEqual( result[1].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1);

        Assert.AreEqual( result[2].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[2].Column, 0 );
        Assert.AreEqual( result[2].Row, 2 );


        var result26 = _generator.beadPlate( input_result, 2, 6 );

        Assert.IsNotNull( result26 );
        Assert.AreEqual( result26.Count, 6 );

        Assert.AreEqual( result26[0].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result26[0].Column, 0 );
        Assert.AreEqual( result26[0].Row, 0 );

        Assert.AreEqual( result26[1].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result26[1].Column, 0 );
        Assert.AreEqual( result26[1].Row, 1 );

        Assert.AreEqual( result26[2].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result26[2].Column, 0 );
        Assert.AreEqual( result26[2].Row, 2 );

        Assert.AreEqual( result26[3].Result.Outcome, Baccarat.T );
        Assert.AreEqual( result26[3].Column, 0 );
        Assert.AreEqual( result26[3].Row, 3 );

        Assert.AreEqual( result26[4].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result26[4].Column, 0 );
        Assert.AreEqual( result26[4].Row, 4 );

        Assert.AreEqual( result26[5].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result26[5].Column, 0 );
        Assert.AreEqual( result26[5].Row, 5 );
    }

    [TestMethod]
    public void bigRoad_Test()
    {
        // When called with game results of [B, B, P, T, P, B]
        // Should return a valid big road        

        List<GameResult> input_result = new List<GameResult>();

        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.T ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.B ) );

        var result = _generator.bigRoad( input_result, 10, 6 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 5 );

        Assert.AreEqual( result[0].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );
        Assert.AreEqual( result[0].Ties.Count, 0 );

        Assert.AreEqual( result[1].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1 );
        Assert.AreEqual( result[1].LogicalColumn, 0 );
        Assert.AreEqual( result[1].Ties.Count, 0 );

        Assert.AreEqual( result[2].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[2].Column, 1 );
        Assert.AreEqual( result[2].Row, 0 );
        Assert.AreEqual( result[2].LogicalColumn, 1 );
        Assert.AreEqual( result[2].Ties.Count, 1 );
        Assert.AreEqual( result[2].Ties[0].Outcome, Baccarat.T );


        Assert.AreEqual( result[3].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[3].Column, 1 );
        Assert.AreEqual( result[3].Row, 1 );
        Assert.AreEqual( result[3].LogicalColumn, 1 );
        Assert.AreEqual( result[3].Ties.Count, 0 );

        Assert.AreEqual( result[4].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[4].Column, 2 );
        Assert.AreEqual( result[4].Row, 0 );
        Assert.AreEqual( result[4].LogicalColumn, 2 );
        Assert.AreEqual( result[4].Ties.Count, 0 );


    }

    [TestMethod]
    public void bigRoadEmptyInputEmptyOutput_Test()
    {
        // When called with game results of []
        // Should return an empty big road        

        List<GameResult> input_result = new List<GameResult>();
        
        var result = _generator.bigRoad( input_result, 10, 6 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 0 );        
    }

    [TestMethod]
    public void bigRoadAllTies_Test()
    {
        // When called with game results of []
        // Should return an empty big road        

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( Baccarat.T ) );
        input_result.Add( new GameResult( Baccarat.T ) );

        var result = _generator.bigRoad( input_result, 10, 6 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 1 );

        Assert.AreEqual( result[0].Result.Outcome, Baccarat.T );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );
        Assert.AreEqual( result[0].Ties.Count, 2 );
        Assert.AreEqual( result[0].Ties[0].Outcome, Baccarat.T );
        Assert.AreEqual( result[0].Ties[1].Outcome, Baccarat.T );
    }

    [TestMethod]
    public void bigRoad2T1B_Test()
    {
        // When called with game results starting with ties and ending with a banker win
        // Should return a big road with a single Banker win with ties        

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( Baccarat.T ) );
        input_result.Add( new GameResult( Baccarat.T ) );
        input_result.Add( new GameResult( Baccarat.B ) );

        var result = _generator.bigRoad( input_result, 10, 6 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 1 );

        Assert.AreEqual( result[0].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );
        Assert.AreEqual( result[0].Ties.Count, 2 );
        Assert.AreEqual( result[0].Ties[0].Outcome, Baccarat.T );
        Assert.AreEqual( result[0].Ties[1].Outcome, Baccarat.T );
    }

    [TestMethod]
    public void bigRoad9B10P_Test()
    {
        // When called with game results starting with ties and ending with a banker win
        // Should return a big road with a single Banker win with ties        

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );

        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.P ) );

        var result = _generator.bigRoad( input_result, 10, 6 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 19 );

        Assert.AreEqual( result[0].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[0].Column,          0 );
        Assert.AreEqual( result[0].Row,             0 );
        Assert.AreEqual( result[0].LogicalColumn,   0 );
        Assert.AreEqual( result[0].Ties.Count,      0 );

        Assert.AreEqual( result[1].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[1].Column,          0 );
        Assert.AreEqual( result[1].Row,             1 );
        Assert.AreEqual( result[1].LogicalColumn,   0 );
        Assert.AreEqual( result[1].Ties.Count,      0 );

        Assert.AreEqual( result[2].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[2].Column,          0 );
        Assert.AreEqual( result[2].Row,             2 );
        Assert.AreEqual( result[2].LogicalColumn,   0 );
        Assert.AreEqual( result[2].Ties.Count,      0 );

        Assert.AreEqual( result[3].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[3].Column,          0 );
        Assert.AreEqual( result[3].Row,             3 );
        Assert.AreEqual( result[3].LogicalColumn,   0 );
        Assert.AreEqual( result[3].Ties.Count,      0 );

        Assert.AreEqual( result[4].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[4].Column,          0 );
        Assert.AreEqual( result[4].Row,             4 );
        Assert.AreEqual( result[4].LogicalColumn,   0 );
        Assert.AreEqual( result[4].Ties.Count,      0 );

        Assert.AreEqual( result[5].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[5].Column,          0 );
        Assert.AreEqual( result[5].Row,             5 );
        Assert.AreEqual( result[5].LogicalColumn,   0 );
        Assert.AreEqual( result[5].Ties.Count,      0 );

        Assert.AreEqual( result[6].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[6].Column,          1 );
        Assert.AreEqual( result[6].Row,             5 );
        Assert.AreEqual( result[6].LogicalColumn,   0 );
        Assert.AreEqual( result[6].Ties.Count,      0 );

        Assert.AreEqual( result[7].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[7].Column,          2 );
        Assert.AreEqual( result[7].Row,             5 );
        Assert.AreEqual( result[7].LogicalColumn,   0 );
        Assert.AreEqual( result[7].Ties.Count,      0 );

        Assert.AreEqual( result[8].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[8].Column,          3 );
        Assert.AreEqual( result[8].Row,             5 );
        Assert.AreEqual( result[8].LogicalColumn,   0 );
        Assert.AreEqual( result[8].Ties.Count,      0 );

        Assert.AreEqual( result[9].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[9].Column,          1 );
        Assert.AreEqual( result[9].Row,             0 );
        Assert.AreEqual( result[9].LogicalColumn,   1 );
        Assert.AreEqual( result[9].Ties.Count,      0 );

        Assert.AreEqual( result[10].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[10].Column,          1 );
        Assert.AreEqual( result[10].Row,             1 );
        Assert.AreEqual( result[10].LogicalColumn,   1 );
        Assert.AreEqual( result[10].Ties.Count,      0 );

        Assert.AreEqual( result[11].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[11].Column,          1 );
        Assert.AreEqual( result[11].Row,             2 );
        Assert.AreEqual( result[11].LogicalColumn,   1 );
        Assert.AreEqual( result[11].Ties.Count,      0 );

        Assert.AreEqual( result[12].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[12].Column,          1 );
        Assert.AreEqual( result[12].Row,             3 );
        Assert.AreEqual( result[12].LogicalColumn,   1 );
        Assert.AreEqual( result[12].Ties.Count,      0 );

        Assert.AreEqual( result[13].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[13].Column,          1 );
        Assert.AreEqual( result[13].Row,             4 );
        Assert.AreEqual( result[13].LogicalColumn,   1 );
        Assert.AreEqual( result[13].Ties.Count,      0 );

        Assert.AreEqual( result[14].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[14].Column,          2 );
        Assert.AreEqual( result[14].Row,             4 );
        Assert.AreEqual( result[14].LogicalColumn,   1 );
        Assert.AreEqual( result[14].Ties.Count,      0 );

        Assert.AreEqual( result[15].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[15].Column,          3 );
        Assert.AreEqual( result[15].Row,             4 );
        Assert.AreEqual( result[15].LogicalColumn,   1 );
        Assert.AreEqual( result[15].Ties.Count,      0 );

        Assert.AreEqual( result[16].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[16].Column,          4 );
        Assert.AreEqual( result[16].Row,             4 );
        Assert.AreEqual( result[16].LogicalColumn,   1 );
        Assert.AreEqual( result[16].Ties.Count,      0 );

        Assert.AreEqual( result[17].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[17].Column,          4 );
        Assert.AreEqual( result[17].Row,             5 );
        Assert.AreEqual( result[17].LogicalColumn,   1 );
        Assert.AreEqual( result[17].Ties.Count,      0 );

        Assert.AreEqual( result[18].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[18].Column,          5 );
        Assert.AreEqual( result[18].Row,             5 );
        Assert.AreEqual( result[18].LogicalColumn,   1 );
        Assert.AreEqual( result[18].Ties.Count,      0 );
    }

    [TestMethod]
    public void bigRoadNotEnoughColumns_Test()
    {
        // When called with not enough columns to fit every result
        // Should scroll to show a sliding window of results      

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.B ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.T ) );
        input_result.Add( new GameResult( Baccarat.P ) );
        input_result.Add( new GameResult( Baccarat.B ) );

        var result = _generator.bigRoad( input_result, 2, 6 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 3 );

        Assert.AreEqual( result[0].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[0].Column,          0 );
        Assert.AreEqual( result[0].Row,             0 );
        Assert.AreEqual( result[0].LogicalColumn,   1 );
        Assert.AreEqual( result[0].Ties.Count,      1 );
        Assert.AreEqual( result[0].Ties[0].Outcome, Baccarat.T );

        Assert.AreEqual( result[1].Result.Outcome, Baccarat.P );
        Assert.AreEqual( result[1].Column,          0 );
        Assert.AreEqual( result[1].Row,             1 );
        Assert.AreEqual( result[1].LogicalColumn,   1 );
        Assert.AreEqual( result[1].Ties.Count,      0 );
        
        Assert.AreEqual( result[2].Result.Outcome, Baccarat.B );
        Assert.AreEqual( result[2].Column,          1 );
        Assert.AreEqual( result[2].Row,             0 );
        Assert.AreEqual( result[2].LogicalColumn,   2 );
        Assert.AreEqual( result[2].Ties.Count,      0 );
    }
}
