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