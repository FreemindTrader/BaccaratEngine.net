using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class BigRoad : RoadMapCore
    {
        private List<GameResult> _gameResults;
        private int _maxRows = 0;
        private int _maxCols = 0;
        private bool _scrool = false;
        private IList<bigRoadPos> _bigRoadPos;
        private Dictionary<string, bigRoadPos> _placementMap = null;
        private int _logicalColumnNumber = 0;

        public BigRoad( List<GameResult> results, int columns = 6, int rows = 6, bool scroll = true )
        {
            _gameResults = results;
            _maxCols = columns;
            _maxRows = rows;
            _scrool = scroll;
            _logicalColumnNumber = 0;
        }

        public (IList<bigRoadPos> RoadList, int MaxColumn) initBigRoad( )
        {
            _bigRoadPos = new List<bigRoadPos>();

            _placementMap = new Dictionary<string, bigRoadPos>();

            var tieStack = new List<GameResult>();
            GameResult lastTieItem = null;
            _logicalColumnNumber = 0;
            int maximumColumnReached = 0;
            GameResult lastItem = null;
            int takenRowIndex = 0;

            // Build the logical column definitions that doesn't represent
            // the actual "drawn" roadmap.
            foreach (var result in _gameResults)
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
                        var lastItemInResults = _bigRoadPos.LastOrDefault();

                        if (lastItem.Outcome == GResult.T)
                        {
                            if (lastItemInResults != null)
                            {
                                lastItemInResults.Ties = tieStack;          // Assign the old TieStack to it
                                tieStack = new List<GameResult>();          // here we create a new list
                                lastTieItem = null;

                                if (lastItemInResults.Result.Outcome != result.Outcome)
                                {
                                    _logicalColumnNumber++;
                                    takenRowIndex = 0;
                                }
                            }
                        }
                        else if (lastItem.Outcome != result.Outcome)
                        {
                            // If this item is different from the outcome of
                            // the last game then we must place it in another column
                            // lastItem is not tie so we can clear the tieStack
                            _logicalColumnNumber++;
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

                    var probeColumn = _logicalColumnNumber;
                    int probeRow = takenRowIndex;
                    bool done = false;

                    while (!done)
                    {
                        var keySearch = String.Format( "{0}{1}", probeColumn, probeRow );
                        var keySearchBelow = String.Format( "{0}{1}", probeColumn, probeRow + 1 );

                        // Position available at current probe location
                        if (!_placementMap.ContainsKey( keySearch ))
                        {
                            var newEntry = new bigRoadPos();
                            newEntry.Row = probeRow;
                            newEntry.Column = probeColumn;
                            newEntry.LogicalColumn = _logicalColumnNumber;
                            newEntry.Ties = new List<GameResult>( tieStack );       // Here we deepClone the tie stack
                            newEntry.Result = result;

                            _placementMap.Add( keySearch, newEntry );

                            _bigRoadPos.Add( newEntry );

                            takenRowIndex = probeRow;

                            done = true;
                        }
                        else if (probeRow + 1 >= _maxRows)
                        {
                            // The spot below would go beyond the table bounds.
                            probeColumn++;
                            takenRowIndex = 0;
                        }
                        else if (!_placementMap.ContainsKey( keySearchBelow ))
                        {
                            // The spot below is empty.
                            probeRow++;
                        }
                        else if (_placementMap[keySearchBelow].Result.Outcome == result.Outcome)
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

            if (_bigRoadPos.Count == 0 && tieStack.Count > 0)
            {
                var newEntry = new bigRoadPos();
                newEntry.Row = 0;
                newEntry.Column = 0;
                newEntry.LogicalColumn = 0;
                newEntry.Ties = new List<GameResult>( tieStack );       // Here we deepClone the tie stack
                newEntry.Result = lastTieItem;
                lastTieItem = null;

                _bigRoadPos.Add( newEntry );
            }
            else if (_bigRoadPos.Count > 0)
            {
                var lastElement = _bigRoadPos.Last();
                lastElement.Ties = new List<GameResult>( tieStack );
                lastTieItem = null;
            }

            if (_scrool)
            {
                _bigRoadPos = this.scrollBigRoad( _bigRoadPos, maximumColumnReached, _maxCols );
            }

            return (_bigRoadPos, maximumColumnReached);
        }

        private IList<bigRoadPos> scrollBigRoad( IList<bigRoadPos> results, int highestDrawingColumn, int drawingColumns )
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
