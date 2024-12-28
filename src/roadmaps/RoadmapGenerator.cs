using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public int columnForGameNumber( int gameNumber, int columnSize)
        {
            return (int) Math.Floor( gameNumber / (decimal)columnSize );
        }

        /// <summary>
        /// Generates the row number for the game number of a game based on the column size of the table to be drawn.
        /// </summary>
        /// <param name="gameNumber">The game number of the item in the sequence</param>
        /// <param name="columnSize">The column size of the drawn table</param>
        /// <returns>The row number that this gameNumber is drawn to</returns>
        public int  rowForGameNumber( int gameNumber, int columnSize)
        {
            return gameNumber % columnSize;
        }

        public void beadPlate( List<GameResult> result, int columns =6 , int rows = 6 )
        {
            var DisplayEntries = columns * rows;
            var ColumnSize = rows;

            // Get the selected amount of display entries from the most
            // recent games.
            var gameResults = result.Skip( Math.Max( 0, result.Count - DisplayEntries ) );
        }
    }
}
