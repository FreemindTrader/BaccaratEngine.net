using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public abstract class RoadMapCore
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

        /// <summary>
        /// Big road column definitions
        /// </summary>
        /// <param name="initBigRoad">The big road data</param>
        /// <returns>Dictionary< int, ColumnDefinitions > Map of columns</returns>
        protected Dictionary<int, ColumnDefinitions> bigRoadColumnDefinitions( IList<bigRoadPos> initBigRoad )
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
    }
}
