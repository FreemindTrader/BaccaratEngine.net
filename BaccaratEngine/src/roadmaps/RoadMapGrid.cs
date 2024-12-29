using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public abstract class RoadMapPos
    {
        public int Column { get; set; }

        public int Row { get; set; }
    }

    public class MacauRoadPos : RoadMapPos
    {
        public MacauRoadPos() { }

        public MoRoad Road { get; set; }
    }

    public class beadPlatePos : RoadMapPos
    {
        public beadPlatePos() { }
        public beadPlatePos( GameResult result, int column, int row )
        {
            Result = result;
            Column = column;
            Row = row;
        }

        public GameResult Result { get; set; }
    }

    public class bigRoadPos : beadPlatePos
    {
        public bigRoadPos() { }

        public int LogicalColumn { get; set; }

        public List<GameResult> Ties { get; set; }

        public override string ToString()
        {
            var output = String.Format( "{0} Col:{1}", Result.Outcome.ToString(), LogicalColumn );
            return output;
        }
    }

    public class ColumnDefinitions
    {
        public ColumnDefinitions() { }

        public ColumnDefinitions( int logicalColumn, int depth, Baccarat outcome ) 
        {
            LogicalColumn = logicalColumn;
            LogicalColumnDepth = depth;
            Outcome = outcome;
        }


        Baccarat outcome;
        int logicalColumnDepth;
        int logicalColumn;

        public int LogicalColumn
        {
            get => logicalColumn;
            set => logicalColumn = value;
        }


        public int LogicalColumnDepth
        {
            get => logicalColumnDepth;
            set => logicalColumnDepth = value;
        }


        public Baccarat Outcome
        {
            get => outcome;
            set => outcome = value;
        }

        public override string ToString()
        {
            var output = String.Format( "[{0}] Col={1}, Depth={2}", Outcome.ToString(), LogicalColumn, LogicalColumnDepth );
            return output;
        }
    }
}
