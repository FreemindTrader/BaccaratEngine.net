using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        public BindingList<beadPlatePos> beadPlate( List<GameResult> results, int columns = 6, int rows = 6 )
        {
            var beamPlateGrid = new BindingList<beadPlatePos>();
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


        public IList<bigRoadPos> bigRoad( List<GameResult> results, int columns = 6, int rows = 6, bool scroll = true )
        {
            IList<bigRoadPos> returnList = new BindingList<bigRoadPos>();

            var placementMap = new Dictionary<string, bigRoadPos>();

            var tieStack = new List<GameResult>();
            GameResult lastTieItem = null;
            int logicalColumnNumber = 0;
            int maximumColumnReached = 0;
            GameResult lastItem = null;

            // Build the logical column definitions that doesn't represent
            // the actual "drawn" roadmap.
            foreach (var result in results)
            {
                if (result.Outcome == Baccarat.T)
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

                        if (lastItem.Outcome == Baccarat.T)
                        {
                            if (lastItemInResults != null )
                            {
                                lastItemInResults.Ties = tieStack;          // Assign the old TieStack to it
                                tieStack = new List<GameResult>();          // here we create a new list
                                lastTieItem = null;

                                if (lastItemInResults.Result.Outcome != result.Outcome)
                                {
                                    logicalColumnNumber++;
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
                        }
                        else
                        {
                            // If this item is the same as the outcome of current game and not a tie, then we must clear the tie stack
                            tieStack = new List<GameResult>();
                            lastTieItem = null;
                        }                        
                    }

                    var probeColumn = logicalColumnNumber;
                    int probeRow = 0;
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

                            done = true;
                        }
                        else if (probeRow + 1 >= rows)
                        {
                            // The spot below would go beyond the table bounds.
                            probeColumn++;
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
                        }
                    }

                    maximumColumnReached = Math.Max( maximumColumnReached, probeColumn );
                }

                lastItem = result;
            }

            // There were no outcomes added to the placement map.
            // We only have ties.

            if (returnList.Count == 0 && tieStack.Count > 0 )
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

            return returnList;
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
    } 
}
