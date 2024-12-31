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
                            colEntry.Row0 = (int)brCell.GetImageIndex();
                            break;
                            case 1:
                            colEntry.Row1 = (int)brCell.GetImageIndex();
                            break;
                            case 2:
                            colEntry.Row2 = (int)brCell.GetImageIndex();
                            break;
                            case 3:
                            colEntry.Row3 = (int)brCell.GetImageIndex();
                            break;
                            case 4:
                            colEntry.Row4 = (int)brCell.GetImageIndex();
                            break;
                            case 5:
                            colEntry.Row5 = (int)brCell.GetImageIndex();
                            break;
                        }
                    }                    
                }

            }
            return input;
        }
    }

}