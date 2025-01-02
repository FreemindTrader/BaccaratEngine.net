using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class RoadmapGenerator
    {


        /// <summary>
        /// Generates the column number for the game number of a game based on the column size of the table to be drawn.
        /// </summary>
        /// <param name="gameNumber">The game number of the item in the sequence.</param>
        /// <param name="columnSize">The column size of the drawn table</param>
        /// <returns>The column number that this gameNumber is drawn to</returns>
        public int columnForGameNumber( int gameNumber, int columnSize )
        {
            return (int)Math.Floor( gameNumber / (decimal)columnSize );
        }

        /// <summary>
        /// Generates the row number for the game number of a game based on the column size of the table to be drawn.
        /// </summary>
        /// <param name="gameNumber">The game number of the item in the sequence</param>
        /// <param name="columnSize">The column size of the drawn table</param>
        /// <returns>The row number that this gameNumber is drawn to</returns>
        public int rowForGameNumber( int gameNumber, int columnSize )
        {
            return gameNumber % columnSize;
        }

        public List<beadPlatePos> beadPlate( List<GameResult> results, int columns = 6, int rows = 6 )
        {
            var beamPlateGrid = new List<beadPlatePos>();
            var DisplayEntries = columns * rows;
            var ColumnSize = rows;

            // Get the selected amount of display entries from the most
            // recent games.
            var selectedResults = results.TakeLast( DisplayEntries ).ToList();

            for (int i = 0; i < selectedResults.Count; i++)
            {
                beamPlateGrid.Add( new beadPlatePos( selectedResults[i], columnForGameNumber( i, ColumnSize ), rowForGameNumber( i, ColumnSize ) ) );
            }

            return beamPlateGrid;
        }


        public BindingList<xColumn> initBindingList( int maxColumn )
        {            
            var bindingList = new BindingList<xColumn>();

            for (int i = 0; i < maxColumn; i++)
            {
                var colEntry = new xColumn();

                colEntry.Row0 = 0;

                bindingList.Add( colEntry );
            }
            return bindingList;            
        }


        public ( IList<bigRoadPos> RoadList, int MaxColumn ) initBigRoad( List<GameResult> results, int columns = 6, int rows = 6, bool scroll = true )
        {
            IList<bigRoadPos> returnList = new List<bigRoadPos>();

            var placementMap = new Dictionary<string, bigRoadPos>();

            var tieStack = new List<GameResult>();
            GameResult lastTieItem = null;
            int logicalColumnNumber = 0;
            int maximumColumnReached = 0;
            GameResult lastItem = null;
            int takenRowIndex = 0;

            // Build the logical column definitions that doesn't represent
            // the actual "drawn" roadmap.
            foreach (var result in results)
            {
                if (result.Outcome == GResult.T)
                {
                    tieStack.Add( result );
                    lastTieItem = result;
                }
                else
                {
                    if (lastItem != null)
                    {
                        // Add the ties that happened in between the last placed
                        // big road item  and this new big road item to the
                        // last entered big road item.
                        var lastItemInResults = returnList.LastOrDefault();

                        if (lastItem.Outcome == GResult.T)
                        {
                            if (lastItemInResults != null)
                            {
                                lastItemInResults.Ties = tieStack;          // Assign the old TieStack to it
                                tieStack = new List<GameResult>();          // here we create a new list
                                lastTieItem = null;

                                if (lastItemInResults.Result.Outcome != result.Outcome)
                                {
                                    logicalColumnNumber++;
                                    takenRowIndex = 0;
                                }
                            }
                        }
                        else if (lastItem.Outcome != result.Outcome)
                        {
                            // If this item is different from the outcome of
                            // the last game then we must place it in another column
                            // lastItem is not tie so we can clear the tieStack
                            logicalColumnNumber++;
                            tieStack = new List<GameResult>();
                            lastTieItem = null;
                            takenRowIndex = 0;
                        }
                        else
                        {
                            // If this item is the same as the outcome of current game and not a tie, then we must clear the tie stack
                            tieStack = new List<GameResult>();
                            lastTieItem = null;
                        }
                    }

                    var probeColumn = logicalColumnNumber;
                    int probeRow = takenRowIndex;
                    bool done = false;

                    while (!done)
                    {
                        var keySearch = String.Format( "{0}{1}", probeColumn, probeRow );
                        var keySearchBelow = String.Format( "{0}{1}", probeColumn, probeRow + 1 );

                        // Position available at current probe location
                        if (!placementMap.ContainsKey( keySearch ))
                        {
                            var newEntry = new bigRoadPos();
                            newEntry.Row = probeRow;
                            newEntry.Column = probeColumn;
                            newEntry.LogicalColumn = logicalColumnNumber;
                            newEntry.Ties = new List<GameResult>( tieStack );       // Here we deepClone the tie stack
                            newEntry.Result = result;

                            placementMap.Add( keySearch, newEntry );

                            returnList.Add( newEntry );

                            takenRowIndex = probeRow;

                            done = true;
                        }
                        else if (probeRow + 1 >= rows)
                        {
                            // The spot below would go beyond the table bounds.
                            probeColumn++;
                            takenRowIndex = 0;
                        }
                        else if (!placementMap.ContainsKey( keySearchBelow ))
                        {
                            // The spot below is empty.
                            probeRow++;
                        }
                        else if (placementMap[keySearchBelow].Result.Outcome == result.Outcome)
                        {
                            // The result below is the same outcome.
                            probeRow++;
                        }
                        else
                        {
                            probeColumn++;
                            takenRowIndex = 0;
                        }
                    }

                    maximumColumnReached = Math.Max( maximumColumnReached, probeColumn );
                }

                lastItem = result;
            }

            // There were no outcomes added to the placement map.
            // We only have ties.

            if (returnList.Count == 0 && tieStack.Count > 0)
            {
                var newEntry = new bigRoadPos();
                newEntry.Row = 0;
                newEntry.Column = 0;
                newEntry.LogicalColumn = 0;
                newEntry.Ties = new List<GameResult>( tieStack );       // Here we deepClone the tie stack
                newEntry.Result = lastTieItem;
                lastTieItem = null;

                returnList.Add( newEntry );
            }
            else if (returnList.Count > 0)
            {
                var lastElement = returnList.Last();
                lastElement.Ties = new List<GameResult>( tieStack );
                lastTieItem = null;
            }

            if (scroll)
            {
                returnList = this.scrollBigRoad( returnList, maximumColumnReached, columns );
            }

            return ( returnList, maximumColumnReached) ;
        }

        public (IList<bigRoadPos> RoadList, int MaxColumn) bigRoadShowTies( List<GameResult> results, int columns = 6, int rows = 6, bool scroll = true )
        {
            IList<bigRoadPos> returnList = new List<bigRoadPos>();

            var placementMap = new Dictionary<string, bigRoadPos>();
                        
            int logicalColumnNumber = 0;
            int maximumColumnReached = 0;
            GameResult lastItem = null;
            int takenRowIndex = 0;

            // Build the logical column definitions that doesn't represent
            // the actual "drawn" roadmap.
            foreach (var result in results)
            {
                
                
                if (lastItem != null)
                {
                    // Add the ties that happened in between the last placed
                    // big road item  and this new big road item to the
                    // last entered big road item.
                    var lastItemInResults = returnList.LastOrDefault();

                    if ( result.Outcome == GResult.T )
                    {
                        // Since we append to the end of the previous Trend, we don't need to increment the logical Column
                    }
                    else
                    {                        
                        if (lastItemInResults.Result.Outcome != GResult.T)
                        {
                            if (lastItem.Outcome != result.Outcome)
                            {
                                // If this item is different from the outcome of
                                // the last game then we must place it in another column
                                // lastItem is not tie so we can clear the tieStack
                                logicalColumnNumber++;
                                takenRowIndex = 0;
                            }
                        }
                        else
                        {
                            // Here we need to scan backward to check what's the last entry before Tie

                            for (int i = returnList.Count - 2; i >= 0; i--)
                            {
                                if (returnList[i].Result.Outcome != GResult.T )
                                {
                                    if (returnList[i].Result.Outcome != result.Outcome)
                                    {
                                        // If this item is different from the outcome of
                                        // the last game then we must place it in another column
                                        // lastItem is not tie so we can clear the tieStack
                                        logicalColumnNumber++;
                                        takenRowIndex = 0;
                                        break;
                                    }
                                    else
                                    {
                                        // Since the new entry is the same whatever is before the tie.
                                        break;
                                    }
                                }
                            }
                        }
                        
                    }                                   
                }

                var probeColumn = logicalColumnNumber;
                int probeRow = takenRowIndex;
                bool done = false;

                while (!done)
                {
                    var keySearch = String.Format( "{0}{1}", probeColumn, probeRow );
                    var keySearchBelow = String.Format( "{0}{1}", probeColumn, probeRow + 1 );

                    // Position available at current probe location
                    if (!placementMap.ContainsKey( keySearch ))
                    {
                        var newEntry = new bigRoadPos();
                        newEntry.Row = probeRow;
                        newEntry.Column = probeColumn;
                        newEntry.LogicalColumn = logicalColumnNumber;                            
                        newEntry.Result = result;

                        placementMap.Add( keySearch, newEntry );

                        returnList.Add( newEntry );

                        takenRowIndex = probeRow;

                        done = true;
                    }
                    else if (probeRow + 1 >= rows)
                    {
                        // The spot below would go beyond the table bounds.
                        probeColumn++;
                        takenRowIndex = 0; 
                    }
                    else if (!placementMap.ContainsKey( keySearchBelow ))
                    {
                        // The spot below is empty.
                        probeRow++;
                    }
                    else if (result.Outcome == GResult.T || placementMap[keySearchBelow].Result.Outcome == GResult.T )
                    {
                        var belowSearch = placementMap[keySearchBelow];
                        var belowSearchLogicalColumn = belowSearch.LogicalColumn;
                        // The input is a Tie, we append to the previous trend

                        if (belowSearchLogicalColumn == logicalColumnNumber )
                        {
                            probeRow++;
                        }
                        else
                        {
                            probeColumn++;
                            takenRowIndex = 0;
                        }
                        
                    }
                    else if (placementMap[keySearchBelow].Result.Outcome == result.Outcome /*|| placementMap[keySearchBelow].Result.Outcome == GResult.T */)
                    {
                        // The result below is the same outcome.
                        probeRow++;
                    }
                    else
                    {                        
                        probeColumn++;
                        takenRowIndex = 0;
                    }
                }

                maximumColumnReached = Math.Max( maximumColumnReached, probeColumn );
                

                lastItem = result;
            }

            // There were no outcomes added to the placement map.
            // We only have ties.

            //if (returnList.Count == 0 && tieStack.Count > 0)
            //{
            //    var newEntry = new bigRoadPos();
            //    newEntry.Row = 0;
            //    newEntry.Column = 0;
            //    newEntry.LogicalColumn = 0;
            //    newEntry.Ties = new List<GameResult>( tieStack );       // Here we deepClone the tie stack
            //    newEntry.Result = lastTieItem;
            //    lastTieItem = null;

            //    returnList.Add( newEntry );
            //}
            //else if (returnList.Count > 0)
            //{
            //    var lastElement = returnList.Last();
            //    lastElement.Ties = new List<GameResult>( tieStack );
            //    lastTieItem = null;
            //}

            if (scroll)
            {
                returnList = this.scrollBigRoad( returnList, maximumColumnReached, columns );
            }

            return (returnList, maximumColumnReached);
        }

        public IList<bigRoadPos> scrollBigRoad( IList<bigRoadPos> results, int highestDrawingColumn, int drawingColumns )
        {
            var highestDrawableIndex = drawingColumns - 1;
            var offset = Math.Max( 0, highestDrawingColumn - highestDrawableIndex );

            IList<bigRoadPos> validItems = results.Where( ( value ) => (value.Column - offset) >= 0 ).ToList();

            foreach (var item in validItems)
            {
                item.Column -= offset;
            }

            return validItems;
        }

        


        /// <summary>
        /// Big road column definitions
        /// </summary>
        /// <param name="initBigRoad">The big road data</param>
        /// <returns>Dictionary< int, ColumnDefinitions > Map of columns</returns>
        private Dictionary<int, ColumnDefinitions> bigRoadColumnDefinitions( IList<bigRoadPos> initBigRoad )
        {
            var columnDictionary = new Dictionary<int, ColumnDefinitions>();

            foreach (bigRoadPos item in initBigRoad)
            {
                if (!columnDictionary.ContainsKey( item.LogicalColumn ))
                {
                    columnDictionary.Add( item.LogicalColumn, new ColumnDefinitions( item.LogicalColumn, 1, item.Result.Outcome ) );
                }
                else
                {
                    columnDictionary[item.LogicalColumn].LogicalColumnDepth++;
                }
            }

            return columnDictionary;
        }

        /// <summary>
        /// Derived Road using the given cycle
        /// </summary>
        /// <param name="initBigRoad">initBigRoad The big road data</param>
        /// <param name="cycleLength">Cycle used to calculate the derived road</param>
        /// <returns>A new list of derived road items (i.e., list of red/blue)</returns>
        public IList<MoRoad> derivedRoad( IList<bigRoadPos> initBigRoad, int cycleLength )
        {
            var columnDefinitionsDictionary = this.bigRoadColumnDefinitions( initBigRoad );
            /*
                1.    Let k be the Cycle of the roadmap.  k = 1 for big eye road.
                2.    Assume that the last icon added to the 大路 (Big Road) is on row m of column n.
                2.a.    If m >= 2, we compare with column (n-k).
                2.a.1.    If there is no such column (i.e. before the 1st column) …  No need to add any icon.
                2.a.2.    If there is such a column, and the column has p icons.
                2.a.2.1.    If m <= p  …  The answer is red.
                2.a.2.2.    If m = p + 1  …  The answer is blue.
                2.a.2.3.    If m > p + 1  … The answer is red.
                2.b.    If m = 1, reverse the result (Banker to Player, and vice versa), determine the result as in rule 2.a above, and reverse the answer (Red to blue, and vice versa) to get the real answer.
            */
            IList<MoRoad> outcomes = new List<MoRoad>();
            var k = cycleLength;

            var columnDefinitions = columnDefinitionsDictionary.Values;

            foreach (var bigRoadColumn in columnDefinitions)
            {
                var outcome = MoRoad.Blue;
                var n = bigRoadColumn.LogicalColumn;

                for (var m = 0; m < bigRoadColumn.LogicalColumnDepth; m++)
                {
                    var rowMDepth = m + 1;

                    if (rowMDepth >= 2)
                    {
                        var compareColumn = n - k;

                        // Step 2.a.1 - No column exists here.
                        // I seemed to have fixed a bug in the original Javascript code for BigEyeRoad. The second Column Second row was not calculated becuase the code was as followed
                        // if (compareColumn <= 0)
                        // I changed it to be as followed.
                        // Column 0 is there. Because in C#, we represent the first column as 0, instead of 1.
                        if (compareColumn < 0)
                            continue;

                        // Step 2.a.1
                        if ( ! columnDefinitionsDictionary.ContainsKey( compareColumn ) )
                            continue;

                        var p = columnDefinitionsDictionary[compareColumn].LogicalColumnDepth;

                        if (rowMDepth <= p)
                        {
                            outcome = MoRoad.Red;
                        }
                        else if (rowMDepth == (p + 1))
                        {
                            outcome = MoRoad.Blue;
                        }
                        else if (rowMDepth > (p + 1))
                        {
                            outcome = MoRoad.Red;
                        }

                        outcomes.Add( outcome );
                    }
                    else
                    {
                        var kDistanceColumn = n - (k + 1);
                        var leftColumn = n - 1;

                        if ( columnDefinitionsDictionary.ContainsKey( kDistanceColumn ) && columnDefinitionsDictionary.ContainsKey( leftColumn ) )
                        {
                            var kDistanceColumnDefinition = columnDefinitionsDictionary[kDistanceColumn];
                            var leftColumnDefinition = columnDefinitionsDictionary[leftColumn];

                            if (kDistanceColumnDefinition.LogicalColumnDepth == leftColumnDefinition.LogicalColumnDepth)
                                outcome = MoRoad.Red;
                            else
                                outcome = MoRoad.Blue;

                            outcomes.Add( outcome );
                        }
                    }
                }
            }

            return outcomes;
        }

        

        /// <summary>
        /// the big eye road - derived road with a cycle of 1
        /// </summary>
        /// <param name="initBigRoad">The big road data</param>
        /// <returns>A new list of derived road items</returns>
        public IList<MoRoad> bigEyeRoad( IList<bigRoadPos> initBigRoad )
        {
            return derivedRoad( initBigRoad, 1 );
        }

        /// <summary>
        /// the big eye road - derived road with a cycle of 2
        /// </summary>
        /// <param name="initBigRoad">The big road data</param>
        /// <returns>A new list of derived road items</returns>
        public IList<MoRoad> smallRoad( IList<bigRoadPos> initBigRoad )
        {
            return derivedRoad( initBigRoad, 2 );
        }

        /// <summary>
        /// the cockroach pig - derived road with a cycle of 3
        /// </summary>
        /// <param name="initBigRoad">The big road data</param>
        /// <returns>A new list of derived road items</returns>
        public IList<MoRoad> cockroachPig( IList<bigRoadPos> initBigRoad )
        {
            return derivedRoad( initBigRoad, 3 );
        }
    } 
}
