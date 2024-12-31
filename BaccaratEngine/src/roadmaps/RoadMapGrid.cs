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

        public GImageIndex GetImageIndex()
        {
            if ( this.Result.isNatural )
            {
                var info =  Result.NaturalInfo;

                switch (info )
                {
                    case GNatural.B8:
                    return GImageIndex.B8;
                    break;

                    case GNatural.B9:
                        return GImageIndex.B9;

                    case GNatural.P8:
                        return GImageIndex.P8;
                    case GNatural.P9:
                        return GImageIndex.P9;

                    default:
                    break;
                }
            }

            if (this.Result.HasMonster)
            {
                var info = this.Result.MonsterInfo;

                switch (info)
                {
                    case GMonster.B6:
                    return GImageIndex.B6;
                    break;

                    case GMonster.B63:
                    return GImageIndex.B63;

                    case GMonster.P7:
                    return GImageIndex.P7;
                    case GMonster.P76:
                    return GImageIndex.P76;

                    case GMonster.B763:
                    return GImageIndex.B763;

                    case GMonster.P83:
                    return GImageIndex.P83;

                    case GMonster.T6:
                        return GImageIndex.T6;
                    default:
                    break;
                }
            }

            switch(this.Result.Outcome)
            {
                case GResult.B:
                return GImageIndex.B;

                case GResult.P: return GImageIndex.P;

                case GResult.T: return GImageIndex.T;
            }

            return 0;            
        }
    }

    public class ColumnDefinitions
    {
        public ColumnDefinitions() { }

        public ColumnDefinitions( int logicalColumn, int depth, GResult outcome ) 
        {
            LogicalColumn = logicalColumn;
            LogicalColumnDepth = depth;
            Outcome = outcome;
        }


        GResult outcome;
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


        public GResult Outcome
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
