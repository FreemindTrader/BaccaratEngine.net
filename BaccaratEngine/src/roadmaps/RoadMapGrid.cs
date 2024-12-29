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

        public List< GameResult > Ties { get; set; }
    }
}
