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
    public static class UIExtensions
    {

        public static BindingList<xColumn> ToBindingList( this IList<bigRoadPos> bigRoadItems, int maxColumns )
        {
            var bindingList = new BindingList<xColumn>();

            for (int i = 0; i <= maxColumns; i++)
            {
                var perColumn = bigRoadItems.Where( x => x.Column == i ).OrderBy( x => x.Row );

                if ( perColumn.Count() > 0 )
                {
                    var colEntry = new xColumn();

                    foreach (bigRoadPos brCell in perColumn)
                    {
                        switch (brCell.Row)
                        {
                            case 0:
                            colEntry.Row0 = (int)brCell.Result.RawData.MyUint;
                            break;
                            case 1:
                            colEntry.Row1 = (int)brCell.Result.RawData.MyUint;
                            break;
                            case 2:
                            colEntry.Row2 = (int)brCell.Result.RawData.MyUint;
                            break;
                            case 3:
                            colEntry.Row3 = (int)brCell.Result.RawData.MyUint;
                            break;
                            case 4:
                            colEntry.Row4 = (int)brCell.Result.RawData.MyUint;
                            break;
                            case 5:
                            colEntry.Row5 = (int)brCell.Result.RawData.MyUint;
                            break;
                        }
                    }

                    bindingList.Add( colEntry );
                }

                
            }
            return bindingList;
        }

        public static BindingList<xColumn> UpdateBindingList( this IList<MoRoad> derivedRoad, BindingList<xColumn> input, int maxColumns, int rows )
        {
            IList<MacauRoadPos> returnList = new List<MacauRoadPos>();

            var placementMap = new Dictionary<string, MacauRoadPos>();

            int logicalColumnNumber = 0;
            int maximumColumnReached = 0;
            MoRoad lastItem = MoRoad.None;

            // Build the logical column definitions that doesn't represent
            // the actual "drawn" roadmap.
            foreach (var result in derivedRoad)
            {
                if (lastItem != MoRoad.None)
                {
                    // Add the ties that happened in between the last placed
                    // big road item  and this new big road item to the
                    // last entered big road item.
                    var lastItemInResults = returnList.LastOrDefault();

                    if (lastItem != result)
                    {
                        // If this item is different from the outcome of
                        // the last game then we must place it in another column
                        // lastItem is not tie so we can clear the tieStack
                        logicalColumnNumber++;
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
                        var newEntry = new MacauRoadPos();
                        newEntry.Row = probeRow;
                        newEntry.Column = probeColumn;
                        newEntry.LogicalColumn = logicalColumnNumber;
                        newEntry.Road = result;

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
                    else if (placementMap[keySearchBelow].Road == result)
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


                lastItem = result;
            }
            

            if (maximumColumnReached > maxColumns)
            {
                returnList = returnList.scrollDerivedRoad( maximumColumnReached, maxColumns );
            }

            for (int i = 0; i <= maxColumns; i++)
            {
                var perColumn = returnList.Where( x => x.Column == i ).OrderBy( x => x.Row );

                if (perColumn.Count() > 0)
                {
                    var colEntry = input[i];

                    foreach (var brCell in perColumn)
                    {
                        switch (brCell.Row)
                        {
                            case 0:
                            colEntry.Row0 = (int)brCell.Road;
                            break;
                            case 1:
                            colEntry.Row1 = (int)brCell.Road;
                            break;
                            case 2:
                            colEntry.Row2 = (int)brCell.Road;
                            break;
                            case 3:
                            colEntry.Row3 = (int)brCell.Road;
                            break;
                            case 4:
                            colEntry.Row4 = (int)brCell.Road;
                            break;
                            case 5:
                            colEntry.Row5 = (int)brCell.Road;
                            break;
                        }
                    }
                }

            }
            return input;
        }

        public static IList<MacauRoadPos> scrollDerivedRoad( this IList<MacauRoadPos> results, int highestDrawingColumn, int drawingColumns )
        {
            var highestDrawableIndex = drawingColumns - 1;
            var offset = Math.Max( 0, highestDrawingColumn - highestDrawableIndex );

            IList<MacauRoadPos> validItems = results.Where( ( value ) => (value.Column - offset) >= 0 ).ToList();

            foreach (var item in validItems)
            {
                item.Column -= offset;
            }

            return validItems;
        }

        public static GImageIndex GetImageIndex( this GameResult result )
        {
            if (result.isNatural)
            {
                var info = result.NaturalInfo;

                switch (info)
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

            if (result.HasMonster)
            {
                var info = result.MonsterInfo;

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

            switch (result.Outcome)
            {
                case GResult.B:
                return GImageIndex.B;

                case GResult.P: return GImageIndex.P;

                case GResult.T: return GImageIndex.T;
            }

            return 0;
        }

        public static BindingList<xColumn> UpdateBindingList( this IList<bigRoadPos> bigRoadItems, BindingList<xColumn> input, int maxColumns )
        {            
            for (int i = 0; i <= maxColumns; i++)
            {
                var perColumn = bigRoadItems.Where( x => x.Column == i ).OrderBy( x => x.Row );

                if (perColumn.Count() > 0)
                {
                    var colEntry = input[i];                    

                    foreach (bigRoadPos brCell in perColumn)
                    {
                        switch (brCell.Row)
                        {
                            case 0:
                            colEntry.Row0 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 1:
                            colEntry.Row1 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 2:
                            colEntry.Row2 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 3:
                            colEntry.Row3 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 4:
                            colEntry.Row4 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 5:
                            colEntry.Row5 = (int)brCell.Result.GetImageIndex();
                            break;
                        }
                    }                    
                }

            }
            return input;
        }

        public static BindingList<xColumn> UpdateBindingList( this IList<beadPlatePos> beadPlatePos, BindingList<xColumn> input, int maxColumns )
        {
            for (int i = 0; i <= maxColumns; i++)
            {
                var perColumn = beadPlatePos.Where( x => x.Column == i ).OrderBy( x => x.Row );

                if (perColumn.Count() > 0)
                {
                    var colEntry = input[i];

                    foreach (var brCell in perColumn)
                    {
                        switch (brCell.Row)
                        {
                            case 0:
                            colEntry.Row0 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 1:
                            colEntry.Row1 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 2:
                            colEntry.Row2 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 3:
                            colEntry.Row3 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 4:
                            colEntry.Row4 = (int)brCell.Result.GetImageIndex();
                            break;
                            case 5:
                            colEntry.Row5 = (int)brCell.Result.GetImageIndex();
                            break;
                        }
                    }
                }

            }
            return input;
        }

        
    }

}