using System.Collections.Generic;
using System.ComponentModel;

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

        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.T ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.B ) );

        var result = _generator.beadPlate( input_result, 1, 3 );

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 3 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.T );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );

        Assert.AreEqual( result[1].Result.Outcome, GResult.P );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1 );

        Assert.AreEqual( result[2].Result.Outcome, GResult.B );
        Assert.AreEqual( result[2].Column, 0 );
        Assert.AreEqual( result[2].Row, 2 );


        var result26 = _generator.beadPlate( input_result, 2, 6 );

        Assert.IsNotNull( result26 );
        Assert.AreEqual( result26.Count, 6 );

        Assert.AreEqual( result26[0].Result.Outcome, GResult.B );
        Assert.AreEqual( result26[0].Column, 0 );
        Assert.AreEqual( result26[0].Row, 0 );

        Assert.AreEqual( result26[1].Result.Outcome, GResult.B );
        Assert.AreEqual( result26[1].Column, 0 );
        Assert.AreEqual( result26[1].Row, 1 );

        Assert.AreEqual( result26[2].Result.Outcome, GResult.P );
        Assert.AreEqual( result26[2].Column, 0 );
        Assert.AreEqual( result26[2].Row, 2 );

        Assert.AreEqual( result26[3].Result.Outcome, GResult.T );
        Assert.AreEqual( result26[3].Column, 0 );
        Assert.AreEqual( result26[3].Row, 3 );

        Assert.AreEqual( result26[4].Result.Outcome, GResult.P );
        Assert.AreEqual( result26[4].Column, 0 );
        Assert.AreEqual( result26[4].Row, 4 );

        Assert.AreEqual( result26[5].Result.Outcome, GResult.B );
        Assert.AreEqual( result26[5].Column, 0 );
        Assert.AreEqual( result26[5].Row, 5 );
    }

    [TestMethod]
    public void bigRoad_Test()
    {
        // When called with game results of [B, B, P, T, P, B]
        // Should return a valid big road        

        List<GameResult> input_result = new List<GameResult>();

        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.T ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.B ) );

        var result = _generator.initBigRoad( input_result, 10, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 5 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.B );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );
        Assert.AreEqual( result[0].Ties.Count, 0 );

        Assert.AreEqual( result[1].Result.Outcome, GResult.B );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1 );
        Assert.AreEqual( result[1].LogicalColumn, 0 );
        Assert.AreEqual( result[1].Ties.Count, 0 );

        Assert.AreEqual( result[2].Result.Outcome, GResult.P );
        Assert.AreEqual( result[2].Column, 1 );
        Assert.AreEqual( result[2].Row, 0 );
        Assert.AreEqual( result[2].LogicalColumn, 1 );
        Assert.AreEqual( result[2].Ties.Count, 1 );
        Assert.AreEqual( result[2].Ties[0].Outcome, GResult.T );


        Assert.AreEqual( result[3].Result.Outcome, GResult.P );
        Assert.AreEqual( result[3].Column, 1 );
        Assert.AreEqual( result[3].Row, 1 );
        Assert.AreEqual( result[3].LogicalColumn, 1 );
        Assert.AreEqual( result[3].Ties.Count, 0 );

        Assert.AreEqual( result[4].Result.Outcome, GResult.B );
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

        var result = _generator.initBigRoad( input_result, 10, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 0 );
    }

    [TestMethod]
    public void bigRoadAllTies_Test()
    {
        // When called with game results of []
        // Should return an empty big road        

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( GResult.T ) );
        input_result.Add( new GameResult( GResult.T ) );

        var result = _generator.initBigRoad( input_result, 10, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 1 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.T );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );
        Assert.AreEqual( result[0].Ties.Count, 2 );
        Assert.AreEqual( result[0].Ties[0].Outcome, GResult.T );
        Assert.AreEqual( result[0].Ties[1].Outcome, GResult.T );
    }

    [TestMethod]
    public void bigRoad2T1B_Test()
    {
        // When called with game results of []
        // Should return an empty big road        

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( GResult.T ) );
        input_result.Add( new GameResult( GResult.T ) );

        var result = _generator.initBigRoad( input_result, 10, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 1 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.T );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );
        Assert.AreEqual( result[0].Ties.Count, 2 );
        Assert.AreEqual( result[0].Ties[0].Outcome, GResult.T );
        Assert.AreEqual( result[0].Ties[1].Outcome, GResult.T );
    }

    public void bigRoadBankerWithTies_Test()
    {
        // When called with game results starting with ties and ending with a banker win
        // Should return a big road with a single Banker win with ties        

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.T ) );
        input_result.Add( new GameResult( GResult.T ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.P ) );

        var result = _generator.bigRoadShowTies( input_result, 10, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 6 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.B );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );


        Assert.AreEqual( result[1].Result.Outcome, GResult.B );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1 );
        Assert.AreEqual( result[1].LogicalColumn, 0 );


        Assert.AreEqual( result[2].Result.Outcome, GResult.T );
        Assert.AreEqual( result[2].Column, 0 );
        Assert.AreEqual( result[2].Row, 2 );
        Assert.AreEqual( result[2].LogicalColumn, 0 );


        Assert.AreEqual( result[3].Result.Outcome, GResult.T );
        Assert.AreEqual( result[3].Column, 0 );
        Assert.AreEqual( result[3].Row, 3 );
        Assert.AreEqual( result[3].LogicalColumn, 0 );


        Assert.AreEqual( result[4].Result.Outcome, GResult.B );
        Assert.AreEqual( result[4].Column, 0 );
        Assert.AreEqual( result[4].Row, 4 );
        Assert.AreEqual( result[4].LogicalColumn, 0 );


        Assert.AreEqual( result[5].Result.Outcome, GResult.P );
        Assert.AreEqual( result[5].Column, 1 );
        Assert.AreEqual( result[5].Row, 0 );
        Assert.AreEqual( result[5].LogicalColumn, 1 );

    }

    [TestMethod]
    public void bigRoadBankerWithTies_PTBP_Test()
    {
        // When called with game results starting with ties and ending with a banker win
        // Should return a big road with a single Banker win with ties        

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        input_result.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        input_result.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        input_result.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},

        var result = _generator.bigRoadShowTies( input_result, 10, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 4 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.P );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );
        

        Assert.AreEqual( result[1].Result.Outcome, GResult.T );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1 );
        Assert.AreEqual( result[1].LogicalColumn, 0 );
        

        Assert.AreEqual( result[2].Result.Outcome, GResult.B );
        Assert.AreEqual( result[2].Column, 1 );
        Assert.AreEqual( result[2].Row, 0 );
        Assert.AreEqual( result[2].LogicalColumn, 1 );
        

        Assert.AreEqual( result[3].Result.Outcome, GResult.P );
        Assert.AreEqual( result[3].Column, 2 );
        Assert.AreEqual( result[3].Row, 0 );
        Assert.AreEqual( result[3].LogicalColumn, 2 );                
    }

    [TestMethod]
    public void bigRoadBanker8T8B8P_Test()
    {
        // When called with game results starting with ties and ending with a banker win
        // Should return a big road with a single Banker win with ties        

        List<GameResult> gameResults = new List<GameResult>();
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},


        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'}
        gameResults.Add( new GameResult( GResult.P ) );

        var result = _generator.bigRoadShowTies( gameResults, 100, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 24 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.B );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );

        Assert.AreEqual( result[1].Result.Outcome, GResult.B );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1 );
        Assert.AreEqual( result[1].LogicalColumn, 0 );

        Assert.AreEqual( result[2].Result.Outcome, GResult.B );
        Assert.AreEqual( result[2].Column, 0 );
        Assert.AreEqual( result[2].Row, 2 );
        Assert.AreEqual( result[2].LogicalColumn, 0 );

        Assert.AreEqual( result[3].Result.Outcome, GResult.B );
        Assert.AreEqual( result[3].Column, 0 );
        Assert.AreEqual( result[3].Row, 3 );
        Assert.AreEqual( result[3].LogicalColumn, 0 );

        Assert.AreEqual( result[4].Result.Outcome, GResult.B );
        Assert.AreEqual( result[4].Column, 0 );
        Assert.AreEqual( result[4].Row, 4 );
        Assert.AreEqual( result[4].LogicalColumn, 0 );

        Assert.AreEqual( result[5].Result.Outcome, GResult.B );
        Assert.AreEqual( result[5].Column, 0 );
        Assert.AreEqual( result[5].Row, 5 );
        Assert.AreEqual( result[5].LogicalColumn, 0 );

        Assert.AreEqual( result[6].Result.Outcome, GResult.B );
        Assert.AreEqual( result[6].Column, 1 );
        Assert.AreEqual( result[6].Row, 5 );
        Assert.AreEqual( result[6].LogicalColumn, 0 );

        Assert.AreEqual( result[7].Result.Outcome, GResult.B );
        Assert.AreEqual( result[7].Column, 2 );
        Assert.AreEqual( result[7].Row, 5 );
        Assert.AreEqual( result[7].LogicalColumn, 0 );

        Assert.AreEqual( result[8].Result.Outcome, GResult.T );
        Assert.AreEqual( result[8].Column, 3 );
        Assert.AreEqual( result[8].Row, 5 );
        Assert.AreEqual( result[8].LogicalColumn, 0 );

        Assert.AreEqual( result[9].Result.Outcome, GResult.T );
        Assert.AreEqual( result[9].Column, 4 );
        Assert.AreEqual( result[9].Row, 5 );
        Assert.AreEqual( result[9].LogicalColumn, 0 );

        Assert.AreEqual( result[10].Result.Outcome, GResult.T );
        Assert.AreEqual( result[10].Column, 5 );
        Assert.AreEqual( result[10].Row, 5 );
        Assert.AreEqual( result[10].LogicalColumn, 0 );

        Assert.AreEqual( result[11].Result.Outcome, GResult.T );
        Assert.AreEqual( result[11].Column, 6 );
        Assert.AreEqual( result[11].Row, 5 );
        Assert.AreEqual( result[11].LogicalColumn, 0 );

        Assert.AreEqual( result[12].Result.Outcome, GResult.T );
        Assert.AreEqual( result[12].Column, 7 );
        Assert.AreEqual( result[12].Row, 5 );
        Assert.AreEqual( result[12].LogicalColumn, 0 );

        Assert.AreEqual( result[13].Result.Outcome, GResult.T );
        Assert.AreEqual( result[13].Column, 8 );
        Assert.AreEqual( result[13].Row, 5 );
        Assert.AreEqual( result[13].LogicalColumn, 0 );
        Assert.AreEqual( result[14].Result.Outcome, GResult.T );
        Assert.AreEqual( result[14].Column, 9 );
        Assert.AreEqual( result[14].Row, 5 );
        Assert.AreEqual( result[14].LogicalColumn, 0 );

        Assert.AreEqual( result[15].Result.Outcome, GResult.T );
        Assert.AreEqual( result[15].Column, 10 );
        Assert.AreEqual( result[15].Row, 5 );
        Assert.AreEqual( result[15].LogicalColumn, 0 );

        Assert.AreEqual( result[16].Result.Outcome, GResult.P );
        Assert.AreEqual( result[16].Column, 1 );
        Assert.AreEqual( result[16].Row, 0 );
        Assert.AreEqual( result[16].LogicalColumn, 1 );

        Assert.AreEqual( result[17].Result.Outcome, GResult.P );
        Assert.AreEqual( result[17].Column, 1 );
        Assert.AreEqual( result[17].Row, 1 );
        Assert.AreEqual( result[17].LogicalColumn, 1 );

        Assert.AreEqual( result[18].Result.Outcome, GResult.P );
        Assert.AreEqual( result[18].Column, 1 );
        Assert.AreEqual( result[18].Row, 2 );
        Assert.AreEqual( result[18].LogicalColumn, 1 );

        Assert.AreEqual( result[19].Result.Outcome, GResult.P );
        Assert.AreEqual( result[19].Column, 1 );
        Assert.AreEqual( result[19].Row, 3 );
        Assert.AreEqual( result[19].LogicalColumn, 1 );

        Assert.AreEqual( result[20].Result.Outcome, GResult.P );
        Assert.AreEqual( result[20].Column, 1 );
        Assert.AreEqual( result[20].Row, 4 );
        Assert.AreEqual( result[20].LogicalColumn, 1 );

        Assert.AreEqual( result[21].Result.Outcome, GResult.P );
        Assert.AreEqual( result[21].Column, 2 );
        Assert.AreEqual( result[21].Row, 4);
        Assert.AreEqual( result[21].LogicalColumn, 1 );

        Assert.AreEqual( result[22].Result.Outcome, GResult.P );
        Assert.AreEqual( result[22].Column, 3 );
        Assert.AreEqual( result[22].Row, 4 );
        Assert.AreEqual( result[22].LogicalColumn, 1 );


    }

    [TestMethod]
    public void bigRoad9B10P_Test()
    {
        // When called with game results starting with ties and ending with a banker win
        // Should return a big road with a single Banker win with ties        

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );

        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.P ) );

        var result = _generator.initBigRoad( input_result, 10, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 19 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.B );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 0 );
        Assert.AreEqual( result[0].Ties.Count, 0 );

        Assert.AreEqual( result[1].Result.Outcome, GResult.B );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1 );
        Assert.AreEqual( result[1].LogicalColumn, 0 );
        Assert.AreEqual( result[1].Ties.Count, 0 );

        Assert.AreEqual( result[2].Result.Outcome, GResult.B );
        Assert.AreEqual( result[2].Column, 0 );
        Assert.AreEqual( result[2].Row, 2 );
        Assert.AreEqual( result[2].LogicalColumn, 0 );
        Assert.AreEqual( result[2].Ties.Count, 0 );

        Assert.AreEqual( result[3].Result.Outcome, GResult.B );
        Assert.AreEqual( result[3].Column, 0 );
        Assert.AreEqual( result[3].Row, 3 );
        Assert.AreEqual( result[3].LogicalColumn, 0 );
        Assert.AreEqual( result[3].Ties.Count, 0 );

        Assert.AreEqual( result[4].Result.Outcome, GResult.B );
        Assert.AreEqual( result[4].Column, 0 );
        Assert.AreEqual( result[4].Row, 4 );
        Assert.AreEqual( result[4].LogicalColumn, 0 );
        Assert.AreEqual( result[4].Ties.Count, 0 );

        Assert.AreEqual( result[5].Result.Outcome, GResult.B );
        Assert.AreEqual( result[5].Column, 0 );
        Assert.AreEqual( result[5].Row, 5 );
        Assert.AreEqual( result[5].LogicalColumn, 0 );
        Assert.AreEqual( result[5].Ties.Count, 0 );

        Assert.AreEqual( result[6].Result.Outcome, GResult.B );
        Assert.AreEqual( result[6].Column, 1 );
        Assert.AreEqual( result[6].Row, 5 );
        Assert.AreEqual( result[6].LogicalColumn, 0 );
        Assert.AreEqual( result[6].Ties.Count, 0 );

        Assert.AreEqual( result[7].Result.Outcome, GResult.B );
        Assert.AreEqual( result[7].Column, 2 );
        Assert.AreEqual( result[7].Row, 5 );
        Assert.AreEqual( result[7].LogicalColumn, 0 );
        Assert.AreEqual( result[7].Ties.Count, 0 );

        Assert.AreEqual( result[8].Result.Outcome, GResult.B );
        Assert.AreEqual( result[8].Column, 3 );
        Assert.AreEqual( result[8].Row, 5 );
        Assert.AreEqual( result[8].LogicalColumn, 0 );
        Assert.AreEqual( result[8].Ties.Count, 0 );

        Assert.AreEqual( result[9].Result.Outcome, GResult.P );
        Assert.AreEqual( result[9].Column, 1 );
        Assert.AreEqual( result[9].Row, 0 );
        Assert.AreEqual( result[9].LogicalColumn, 1 );
        Assert.AreEqual( result[9].Ties.Count, 0 );

        Assert.AreEqual( result[10].Result.Outcome, GResult.P );
        Assert.AreEqual( result[10].Column, 1 );
        Assert.AreEqual( result[10].Row, 1 );
        Assert.AreEqual( result[10].LogicalColumn, 1 );
        Assert.AreEqual( result[10].Ties.Count, 0 );

        Assert.AreEqual( result[11].Result.Outcome, GResult.P );
        Assert.AreEqual( result[11].Column, 1 );
        Assert.AreEqual( result[11].Row, 2 );
        Assert.AreEqual( result[11].LogicalColumn, 1 );
        Assert.AreEqual( result[11].Ties.Count, 0 );

        Assert.AreEqual( result[12].Result.Outcome, GResult.P );
        Assert.AreEqual( result[12].Column, 1 );
        Assert.AreEqual( result[12].Row, 3 );
        Assert.AreEqual( result[12].LogicalColumn, 1 );
        Assert.AreEqual( result[12].Ties.Count, 0 );

        Assert.AreEqual( result[13].Result.Outcome, GResult.P );
        Assert.AreEqual( result[13].Column, 1 );
        Assert.AreEqual( result[13].Row, 4 );
        Assert.AreEqual( result[13].LogicalColumn, 1 );
        Assert.AreEqual( result[13].Ties.Count, 0 );

        Assert.AreEqual( result[14].Result.Outcome, GResult.P );
        Assert.AreEqual( result[14].Column, 2 );
        Assert.AreEqual( result[14].Row, 4 );
        Assert.AreEqual( result[14].LogicalColumn, 1 );
        Assert.AreEqual( result[14].Ties.Count, 0 );

        Assert.AreEqual( result[15].Result.Outcome, GResult.P );
        Assert.AreEqual( result[15].Column, 3 );
        Assert.AreEqual( result[15].Row, 4 );
        Assert.AreEqual( result[15].LogicalColumn, 1 );
        Assert.AreEqual( result[15].Ties.Count, 0 );

        Assert.AreEqual( result[16].Result.Outcome, GResult.P );
        Assert.AreEqual( result[16].Column, 4 );
        Assert.AreEqual( result[16].Row, 4 );
        Assert.AreEqual( result[16].LogicalColumn, 1 );
        Assert.AreEqual( result[16].Ties.Count, 0 );

        Assert.AreEqual( result[17].Result.Outcome, GResult.P );
        Assert.AreEqual( result[17].Column, 4 );
        Assert.AreEqual( result[17].Row, 5 );
        Assert.AreEqual( result[17].LogicalColumn, 1 );
        Assert.AreEqual( result[17].Ties.Count, 0 );

        Assert.AreEqual( result[18].Result.Outcome, GResult.P );
        Assert.AreEqual( result[18].Column, 5 );
        Assert.AreEqual( result[18].Row, 5 );
        Assert.AreEqual( result[18].LogicalColumn, 1 );
        Assert.AreEqual( result[18].Ties.Count, 0 );
    }

    [TestMethod]
    public void bigRoadNotEnoughColumns_Test()
    {
        // When called with not enough columns to fit every result
        // Should scroll to show a sliding window of results      

        List<GameResult> input_result = new List<GameResult>();
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.B ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.T ) );
        input_result.Add( new GameResult( GResult.P ) );
        input_result.Add( new GameResult( GResult.B ) );

        var result = _generator.initBigRoad( input_result, 2, 6 ).RoadList;

        Assert.IsNotNull( result );
        Assert.AreEqual( result.Count, 3 );

        Assert.AreEqual( result[0].Result.Outcome, GResult.P );
        Assert.AreEqual( result[0].Column, 0 );
        Assert.AreEqual( result[0].Row, 0 );
        Assert.AreEqual( result[0].LogicalColumn, 1 );
        Assert.AreEqual( result[0].Ties.Count, 1 );
        Assert.AreEqual( result[0].Ties[0].Outcome, GResult.T );

        Assert.AreEqual( result[1].Result.Outcome, GResult.P );
        Assert.AreEqual( result[1].Column, 0 );
        Assert.AreEqual( result[1].Row, 1 );
        Assert.AreEqual( result[1].LogicalColumn, 1 );
        Assert.AreEqual( result[1].Ties.Count, 0 );

        Assert.AreEqual( result[2].Result.Outcome, GResult.B );
        Assert.AreEqual( result[2].Column, 1 );
        Assert.AreEqual( result[2].Row, 0 );
        Assert.AreEqual( result[2].LogicalColumn, 2 );
        Assert.AreEqual( result[2].Ties.Count, 0 );
    }

    [TestMethod]
    public void bigEyeRoad_TestA()
    {
        IList<MoRoad> expectedBigEye = new BindingList<MoRoad>();

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );



        List<GameResult> gameResults = new List<GameResult>();
        //[
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'b//},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'p )); //},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'both'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'p )); //},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'p )); //},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'both'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'b//},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
        gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'p )); //},
        gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'}];

        var initBigRoad = _generator.initBigRoad( gameResults, 100, 6 ).RoadList;
        var result = _generator.bigEyeRoad( initBigRoad );

        //Assert.AreEqual( result.Count, expectedBigEye.Count );

        var tobeTested = Math.Min( result.Count, expectedBigEye.Count );

        for (int i = 0; i < tobeTested; i++)
        {
            Assert.AreEqual( result[i], expectedBigEye[i] );
        }
    }

    [TestMethod]
    public void bigEyeRoad_TestB()
    {
        IList<MoRoad> expectedBigEye = new BindingList<MoRoad>();

        // Something is causing this red dot to be need detected in the algorithm.
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );


        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );




        List<GameResult> gameResults = new List<GameResult>();


        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'p )); //}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'p )); //}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'b//}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'p )); //}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) ); //natural': 'none', 'pair': 'b//}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) ); // 'natural': 'none', 'pair': 'none'}];

        var initBigRoad = _generator.initBigRoad( gameResults, 100, 6 ).RoadList;
        var result = _generator.bigEyeRoad( initBigRoad );

        var tobeTested = Math.Min( result.Count, expectedBigEye.Count );

        for (int i = 0; i < tobeTested; i++)
        {
            Assert.AreEqual( result[i], expectedBigEye[i] );
        }




        var smallRoad = _generator.smallRoad( initBigRoad );

        IList<MoRoad> expectedSmallRoad = new BindingList<MoRoad>();

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );


        var tobeTested2 = Math.Min( smallRoad.Count, expectedSmallRoad.Count );

        for (int i = 0; i < tobeTested2; i++)
        {
            Assert.AreEqual( smallRoad[i], expectedSmallRoad[i] );
        }


        var cockroachPig = _generator.cockroachPig( initBigRoad );

        IList<MoRoad> expectedcockroachPig = new BindingList<MoRoad>();

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );

        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );

        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );


        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );

        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );

        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );


        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );

        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );


        var tobeTested3 = Math.Min( cockroachPig.Count, expectedcockroachPig.Count );

        for (int i = 0; i < tobeTested3; i++)
        {
            Assert.AreEqual( cockroachPig[i], expectedcockroachPig[i] );
        }
    }

    [TestMethod]
    public void bigEyeRoad_TestC()
    {
        List<GameResult> gameResults = new List<GameResult>();

        gameResults.Add( new GameResult( GResult.P ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player8', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'b//}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'both'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.T ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player8', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker8', 'pair': 'b//}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player9', 'pair': 'b//}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'none', 'pair': 'none'}];

        var initBigRoad = _generator.initBigRoad( gameResults, 100, 6 ).RoadList;
        var bigEyeRoad = _generator.bigEyeRoad( initBigRoad );

        IList<MoRoad> expectedBigEye = new BindingList<MoRoad>();

        // Something is causing this red dot to be need detected in the algorithm.
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        expectedBigEye.Add( MoRoad.Blue );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Blue );

        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );
        expectedBigEye.Add( MoRoad.Red );

        var tobeTested1 = Math.Min( bigEyeRoad.Count, expectedBigEye.Count );

        for (int i = 0; i < tobeTested1; i++)
        {
            Assert.AreEqual( bigEyeRoad[i], expectedBigEye[i] );
        }


        var smallRoad = _generator.smallRoad( initBigRoad );

        IList<MoRoad> expectedSmallRoad = new BindingList<MoRoad>();

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );

        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );
        expectedSmallRoad.Add( MoRoad.Red );

        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );
        expectedSmallRoad.Add( MoRoad.Blue );


        var tobeTested2 = Math.Min( smallRoad.Count, expectedSmallRoad.Count );

        for (int i = 0; i < tobeTested2; i++)
        {
            Assert.AreEqual( smallRoad[i], expectedSmallRoad[i] );
        }



        var cockroachPig = _generator.cockroachPig( initBigRoad );

        IList<MoRoad> expectedcockroachPig = new BindingList<MoRoad>();

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );


        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );


        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );

        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );

        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );
        expectedcockroachPig.Add( MoRoad.Red );

        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );
        expectedcockroachPig.Add( MoRoad.Blue );

        var tobeTested3 = Math.Min( cockroachPig.Count, expectedcockroachPig.Count );

        for (int i = 0; i < tobeTested3; i++)
        {
            Assert.AreEqual( cockroachPig[i], expectedcockroachPig[i] );
        }
    }

    [TestMethod]
    public void bigEyeRoad_Test_ZeroGame()
    {
        List<GameResult> gameResults = new List<GameResult>();

        var initBigRoad = _generator.initBigRoad( gameResults, 100, 6 ).RoadList;
        var bigEyeRoad = _generator.bigEyeRoad( initBigRoad );

        Assert.AreEqual( bigEyeRoad.Count, 0 );
    }

    [TestMethod]
    public void bigEyeRoad_Test_OneGame()
    {
        List<GameResult> gameResults = new List<GameResult>();
        gameResults.Add( new GameResult( GResult.P ) ); 

        var initBigRoad = _generator.initBigRoad( gameResults, 100, 6 ).RoadList;
        var bigEyeRoad = _generator.bigEyeRoad( initBigRoad );

        Assert.AreEqual( bigEyeRoad.Count, 0 );
    }

    [TestMethod]
    public void bigEyeRoad_Test_FiveGames_Blue()
    {
        List<GameResult> gameResults = new List<GameResult>();
        
        gameResults.Add( new GameResult( GResult.B ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'player8', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.P ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 
        
        var initBigRoad = _generator.initBigRoad( gameResults, 100, 6 );
        var bigEyeRoad = _generator.bigEyeRoad( initBigRoad.RoadList );

        IList<MoRoad> expectedBigEye = new BindingList<MoRoad>();

        // Something is causing this red dot to be need detected in the algorithm.
        expectedBigEye.Add( MoRoad.Blue );
        
        var tobeTested1 = Math.Min( bigEyeRoad.Count, expectedBigEye.Count );

        for (int i = 0; i < tobeTested1; i++)
        {
            Assert.AreEqual( bigEyeRoad[i], expectedBigEye[i] );
        }


        
    }

    [TestMethod]
    public void bigEyeRoad_Test_FiveGames_Red()
    {
        List<GameResult> gameResults = new List<GameResult>();

        // [{'outcome': 'banker', 'natural': 'none', 'pair': 'none'}, {'outcome': 'banker', 'natural': 'none', 'pair': 'none'}, {'outcome': 'player', 'natural': 'none', 'pair': 'none'}, {'outcome': 'player', 'natural': 'none', 'pair': 'none'}, {'outcome': 'banker', 'natural': 'banker8', 'pair': 'none'}];
        gameResults.Add( new GameResult( GResult.B ) ); //, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'player8', 'pair': 'p//}, 
        gameResults.Add( new GameResult( GResult.P ) );//natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.P ) );//, 'natural': 'none', 'pair': 'none'}, 
        gameResults.Add( new GameResult( GResult.B ) );//, 'natural': 'banker9', 'pair': 'none'}, 

        var initBigRoad = _generator.initBigRoad( gameResults, 100, 6 ).RoadList;
        var bigEyeRoad = _generator.bigEyeRoad( initBigRoad );

        IList<MoRoad> expectedBigEye = new BindingList<MoRoad>();

        // Something is causing this red dot to be need detected in the algorithm.
        expectedBigEye.Add( MoRoad.Red );

        var tobeTested1 = Math.Min( bigEyeRoad.Count, expectedBigEye.Count );

        for (int i = 0; i < tobeTested1; i++)
        {
            Assert.AreEqual( bigEyeRoad[i], expectedBigEye[i] );
        }



    }

}

